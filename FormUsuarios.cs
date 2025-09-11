using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;//
using Microsoft.Data.SqlClient;


namespace formLogin
{
    public partial class FormUsuarios : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROYECTO_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";

         int idSeleccionado = 0;
        public FormUsuarios()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            //   using (SqlConnection conn = new SqlConnection(connectionString))
            //  {
            //    string query = "SELECT * FROM Usuarios";
            //  SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //  DataTable dt = new DataTable();
            // da.Fill(dt);
            // dataGridView1.DataSource = dt;
            // }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();  //  abrir conexión
                string query = "SELECT * FROM Usuarios";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("La tabla Usuarios no tiene registros.");
                }
            }







        }
        //ARREGLAR PARA CARGAR TODOS LOS CAMPOS A LA BASE

        //MODIFICAR LA BASE DE DATOS 
        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (Nombre, Apellido, Correo, DNI, Sexo) VALUES (@Nombre, @Apellido, @Correo, @DNI, @Sexo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", TApellido.Text);
                
                cmd.Parameters.AddWithValue("@Correo", Tcorreo.Text);
                cmd.Parameters.AddWithValue("@DNI", TDni.Text);
     
                cmd.Parameters.AddWithValue("@Sexo", TUsuario.Text);
               

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TDni.Clear();
            Tcorreo.Clear();
            TUsuario.Clear();
            idSeleccionado = 0;
        }

    }


}
