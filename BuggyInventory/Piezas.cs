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
    public partial class Piezas : Form
    {

        SqlConnection conne = new SqlConnection(dbConnection.getConnection());
        DataTable dt;
        SqlDataAdapter cmd;
        public Piezas()
        {
            InitializeComponent();
            filtro_cb.SelectedIndex=0;
            PiezasCargar();
        }

        private void Piezas_Load(object sender, EventArgs e)
        {
           // PiezasCargar();
        }

        private void PiezasCargar()
        {
            try
            {
                switch (filtro_cb.SelectedIndex)
                {
                    case 0:
                        cmd = new SqlDataAdapter("SELECT * FROM Piezas ", conne);
                        break;
                    case 1:
                        if (!string.IsNullOrEmpty(filtro_tb.Text))
                            cmd = new SqlDataAdapter($"SELECT * FROM Piezas where PieId = {filtro_tb.Text}", conne);
                        break;
                    case 2:
                        if (!string.IsNullOrEmpty(filtro_tb.Text))
                            cmd = new SqlDataAdapter($"SELECT * FROM Piezas where PieNombre like '%{filtro_tb.Text}%'", conne);
                        break;
                    default:
                        cmd = new SqlDataAdapter("SELECT * FROM Piezas ", conne);
                        break;
                }
                //dataGridView1.DataSource = null;
                dt = new DataTable();
                cmd.Fill(dt);
                Piezas_dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al Cargar los datos");
            }
        }

        private void atras_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            NuevaPieza bp = new NuevaPieza();
            this.Hide();
            bp.ShowDialog();
            this.Show();
            PiezasCargar();
        }

        private void filtro_btn_Click(object sender, EventArgs e)
        {
            PiezasCargar();
        }

        private void editar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection row = Piezas_dgv.SelectedRows;
                if (Piezas_dgv.CurrentRow == null)
                    throw new Exception("Seleccione una pieza");

                string id = row[0].Cells[0].Value.ToString();
                var pieza = new Entities.Piezas();
                pieza.PieId = Int32.Parse(id.ToString());
                pieza.PieNombre = row[0].Cells[1].Value.ToString();
                pieza.PieDescripcion = row[0].Cells[2].Value.ToString();
                pieza.PieCantidadInve = Int32.Parse(row[0].Cells[8].Value.ToString());

                NuevaPieza bp = new NuevaPieza(pieza);
                this.Hide();
                bp.ShowDialog();
                this.Show();
                PiezasCargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al Cargar los datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = Piezas_dgv.SelectedRows;
            if (Piezas_dgv.CurrentRow == null)
                throw new Exception("Seleccione una pieza");

            string id = row[0].Cells[0].Value.ToString();
            var pieza = new Entities.Piezas();
            pieza.PieId = Int32.Parse(id.ToString());
            pieza.PieNombre = row[0].Cells[1].Value.ToString();
            pieza.PieDescripcion = row[0].Cells[2].Value.ToString();
            pieza.PieCantidadInve = Int32.Parse(row[0].Cells[8].Value.ToString());

            NuevaPieza bp = new NuevaPieza(pieza, false);
            this.Hide();
            bp.ShowDialog();
            this.Show();
            PiezasCargar();
        }
    }
}
