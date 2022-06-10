using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BuggyInventory
{
    public partial class NuevaPieza : Form
    {
        SqlConnection conne = new SqlConnection(dbConnection.getConnection());
        Entities.Piezas PiezaBP = new Entities.Piezas();
        public NuevaPieza()
        {
            InitializeComponent();
            PiezaBP = null;
            Titulo_lb.Text = "Nueva pieza";
        }

        public NuevaPieza(Entities.Piezas pieza, bool isEditing = true)
        {
            InitializeComponent();
            PiezaBP = pieza;
            nombre_tb.Text = pieza.PieNombre.ToString();
            descripcion_tb.Text = pieza.PieDescripcion.ToString();
            ano_tb.Text = pieza.PieCantidadInve.ToString();
            textBox1.Text = pieza.PieCantidadInve.ToString();
            ano_tb.ReadOnly = true;
            nuevacantidad_tb.Text = "0";
            if (isEditing)
            {
                Titulo_lb.Text = $"Editar #{pieza.PieId}";
            }
            else
            {
                Titulo_lb.Text = $"Inventario #{pieza.PieId}";
                panel1.Visible = true;
            }

        }

        private void atras_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(nombre_tb.Text))
                    throw new Exception("Nombre requerido");

                if (string.IsNullOrEmpty(descripcion_tb.Text))
                    throw new Exception("Descripcion requerida");

                if (string.IsNullOrEmpty(ano_tb.Text))
                    throw new Exception("cantidad requerida");


                conne.Open();

                if(PiezaBP == null)
                {
                    string Query = "INSERT INTO Piezas (PieNombre, PieDescripcion, PieCantidadInve, PieFechaCreacion) VALUES (@nombre, @descripcion,@cantidad, @fecha)";
                    using (SqlCommand cmd = new SqlCommand(Query, conne))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre_tb.Text);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion_tb.Text);
                        cmd.Parameters.AddWithValue("@cantidad", ano_tb.Text);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                }
                else
                {
                    if (string.IsNullOrEmpty(nuevacantidad_tb.Text))
                        throw new Exception("Nueva cantidad requerida");

                    const string sqlQuery = "UPDATE Piezas SET PieNombre = @nombre, PieDescripcion = @descripcion, PieFechaActualizacion = @fecha, PieCantidadInve = @cantidad WHERE PieId = @PieId";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conne))
                    {
                        cmd.Parameters.AddWithValue("@PieId", PiezaBP.PieId);
                        cmd.Parameters.AddWithValue("@nombre", nombre_tb.Text);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion_tb.Text);
                        cmd.Parameters.AddWithValue("@cantidad",Int32.Parse(ano_tb.Text) + Int32.Parse(nuevacantidad_tb.Text));
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                }


                MessageBox.Show("Pieza Guardada");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conne.Close();
            }
        }
    }
}
