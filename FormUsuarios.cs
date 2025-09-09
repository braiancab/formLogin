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
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_EJTALLER;Trusted_Connection=True;TrustServerCertificate=True;";
   
       // int idSeleccionado = 0;
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

    }


}
