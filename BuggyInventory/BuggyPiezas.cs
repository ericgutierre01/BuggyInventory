using BuggyInventory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuggyInventory
{
    public partial class BuggyPiezas : Form
    {
        SqlConnection conne = new SqlConnection(dbConnection.getConnection());
        DataTable dt;
        SqlDataAdapter cmd;
        List<PiezaBP> PiezasAgregadas = new List<PiezaBP>();

        public static int idBuggy;
        public BuggyPiezas(int id)
        {
            InitializeComponent();
            filtro_cb.SelectedIndex = 0;
            idBuggy = id;
        }

        private void BuggyPiezas_Load(object sender, EventArgs e)
        {

            try
            {
                PiezasCargar();

                conne.Open();

                string Querye = $"SELECT BuggyNombre FROM Buggys WHERE BuggyId = {idBuggy}";
                using (SqlCommand cmdc = new SqlCommand(Querye, conne))
                {
                    SqlDataReader dataReader = cmdc.ExecuteReader();
                    while (dataReader.Read())
                    {
                        label2.Text = $"Buggy :{Convert.ToString(dataReader["BuggyNombre"])}";
                    }
                }

                conne.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al Cargar los datos");
            }
        }
        private void PiezasCargar()
        {
            try
            {
                switch (filtro_cb.SelectedIndex)
                {
                    case 0:
                        cmd = new SqlDataAdapter("SELECT PieId, PieNombre, PieCantidadInve FROM Piezas ", conne);
                        break;
                    case 1:
                        if (!string.IsNullOrEmpty(filtro_tb.Text))
                            cmd = new SqlDataAdapter($"SELECT PieId, PieNombre, PieCantidadInve FROM Piezas where PieId = {filtro_tb.Text}", conne);
                        break;
                    case 2:
                        if (!string.IsNullOrEmpty(filtro_tb.Text))
                            cmd = new SqlDataAdapter($"SELECT PieId, PieNombre, PieCantidadInve FROM Piezas where PieNombre like '%{filtro_tb.Text}%'", conne);
                        break;
                    default:
                        cmd = new SqlDataAdapter("SELECT PieId, PieNombre, PieCantidadInve FROM Piezas ", conne);
                        break;
                }
                //dataGridView1.DataSource = null;
                dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al Cargar los datos");
            }
        }

        private void filtro_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            //BuggysCargar();
            filtro_tb.Text = "";
        }


        private void filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (filtro_cb.SelectedIndex)
            {

                case 1:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                        (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }

                    // only allow one decimal point
                    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                    {
                        e.Handled = true;
                    }
                    break;

                default:
                    break;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                if (dataGridView1.CurrentRow == null)
                {
                    throw new Exception("Seleccione una Pieza");
                }

                if(string.IsNullOrEmpty(cantidad_tb.Text))
                    throw new Exception("Cantidad debe ser mayor a 0");
                
                string Scantidad = row[0].Cells[2].Value.ToString();
                int cantidad = Convert.ToInt32(cantidad_tb.Text);
                int disponible = Convert.ToInt32(Scantidad);

                if (cantidad > disponible )
                    throw new Exception("Cantidad debe menos o igual a la disponible");

                var pieza = new PiezaBP 
                { 
                    PieId = Int32.Parse(row[0].Cells[0].Value.ToString()),
                    PieNombre = row[0].Cells[1].Value.ToString(),
                    PieCantidadInve = cantidad,
                    PieCantidadActual = Int32.Parse(row[0].Cells[2].Value.ToString())
                };
                if(PiezasAgregadas.Any(a=>a.PieId == pieza.PieId))
                {
                    var piezaActu = PiezasAgregadas.Find(f=>f.PieId == pieza.PieId);
                    PiezasAgregadas.Remove(piezaActu);
                }

                dataGridView2.DataSource = null;
                PiezasAgregadas.Add(pieza);
                dataGridView2.DataSource = PiezasAgregadas;
                cantidad_tb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(PiezasAgregadas.Count<=0)
                    throw new Exception("Agregue piezas primero");

                conne.Open();
                foreach (var item in PiezasAgregadas)
                {
                    string Query = "INSERT INTO BuggyPiezas (BuggyId, PieId, BPCantidad,BPFechaCreacion) VALUES (@buggyId, @piezaId, @cantidad,@fecha)";
                    using (SqlCommand cmd = new SqlCommand(Query, conne))
                    {
                        cmd.Parameters.AddWithValue("@buggyId", idBuggy);
                        cmd.Parameters.AddWithValue("@piezaId", item.PieId);
                        cmd.Parameters.AddWithValue("@cantidad", item.PieCantidadInve);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }

                    const string sqlQueryActualizar =
                        "UPDATE Piezas SET PieCantidadInve = @Cantidad WHERE PieId = @pieId";
                    using (SqlCommand cmd = new SqlCommand(sqlQueryActualizar, conne))
                    {
                        cmd.Parameters.AddWithValue("@pieId", item.PieId);
                        cmd.Parameters.AddWithValue("@Cantidad", (item.PieCantidadActual - item.PieCantidadInve));
                        cmd.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Datos actualizados");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void atras_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filtro_btn_Click(object sender, EventArgs e)
        {
            PiezasCargar();
        }
    }
}
