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
    public partial class NuevoBuggy : Form
    {
        SqlConnection conne = new SqlConnection(dbConnection.getConnection());
        public NuevoBuggy()
        {
            InitializeComponent();
        }

        private void NuevoBuggy_Load(object sender, EventArgs e)
        {

        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(nombre_tb.Text))
                    throw new Exception("Nombre requerido");

                if (string.IsNullOrEmpty(descripcion_tb.Text))
                    throw new Exception("Descripcion requerida"); 

                conne.Open();
                string Query = "INSERT INTO Buggys (BuggyNombre, BuggyDescripcion,BuggyAno, BuggyFechaCreacion) VALUES (@nombre, @descripcion,@ano, @fecha)";
                using (SqlCommand cmd = new SqlCommand(Query, conne))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre_tb.Text);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion_tb.Text);
                    cmd.Parameters.AddWithValue("@ano", ano_tb.Text);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Buggy Guardado");
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
    }
}
