using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace formLogin
{


    public partial class FormReporte : Form
    {

        //Conectar con base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";

        private Form _FormAnterior;
        public FormReporte(Form formAnterior)
        {
            InitializeComponent();

            _FormAnterior = formAnterior;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }



        private void BuscarUsuarioVendedor(string nombreBuscado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id_usuario, usuario " +
                                   "FROM Usuarios " +
                                   "WHERE nombre LIKE @nombre AND id_rol = 1"; // 3 = Vendedor

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombreBuscado + "%"); // búsqueda parcial

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt; // muestra los resultados en el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            string nombre = TNombre.Text.Trim(); // el TextBox donde ingresás el nombre
            BuscarUsuarioVendedor(nombre);
        }
    }
}
