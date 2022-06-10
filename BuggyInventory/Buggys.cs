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
    public partial class Buggys : Form
    {
        SqlConnection conne = new SqlConnection(dbConnection.getConnection());
        DataTable dt;
        SqlDataAdapter cmd;
        public Buggys()
        {
            InitializeComponent();
            filtro_cb.SelectedIndex = 0;
            BuggysCargar();
        }

        private void Buggys_Load(object sender, EventArgs e)
        {
            //BuggysCargar();
        }

        private void BuggysCargar()
        {
            try
            {
                switch (filtro_cb.SelectedIndex)
                {
                    case 0:
                        cmd = new SqlDataAdapter("SELECT * FROM Buggys ", conne);
                        break;
                    case 1:
                        if (!string.IsNullOrEmpty(filtro_tb.Text))
                            cmd = new SqlDataAdapter($"SELECT * FROM Buggys where BuggyId = {filtro_tb.Text}", conne);
                        break;
                    case 2:
                        if(!string.IsNullOrEmpty(filtro_tb.Text))
                            cmd = new SqlDataAdapter($"SELECT * FROM Buggys where BuggyNombre like '%{filtro_tb.Text}%'", conne);
                        break;
                    default:
                        cmd = new SqlDataAdapter("SELECT * FROM Buggys ", conne);
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
        private void ponerPiezas_btn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
            if (dataGridView1.CurrentRow == null)
                throw new Exception("Seleccione un buggy");


            String id = row[0].Cells[0].Value.ToString();
            int idconvertido = Convert.ToInt32(id);


            BuggyPiezas bp = new BuggyPiezas(idconvertido);
            this.Hide();
            bp.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void atrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verPiezas_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                if (dataGridView1.CurrentRow == null)
                    throw new Exception("Seleccione un buggy");


                string id = row[0].Cells[0].Value.ToString();


                cmd = new SqlDataAdapter($"SELECT * FROM vwBuggyPiezas Where BuggyId = {id}", conne);
                dt = new DataTable();
                cmd.Fill(dt);
                piezas_gd.DataSource = dt;

                nombreBuggy_lb.Text = $"Piezas agregadas en {row[0].Cells[1].Value}";
                piezas_panel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al Cargar los datos");
            }
        }

        private void atrasPanel_btn_Click(object sender, EventArgs e)
        {
            piezas_panel.Visible = false;
            //piezas_gd.DataSource = null;
        }

        private void filtro_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            //BuggysCargar();
            filtro_tb.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void filtro_btn_Click(object sender, EventArgs e)
        {
            BuggysCargar();
        }

        private void piezas_gd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoBuggy bp = new NuevoBuggy();
            this.Hide();
            bp.ShowDialog();
            this.Show();
            BuggysCargar();
        }

        private void piezas_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
