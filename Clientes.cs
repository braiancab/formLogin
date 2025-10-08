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
    public partial class Clientes : Form
    {

        private Form _FormAnterior;
        //Conectar con base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;     //Identifica el elemento de datagridview 
        private SqlConnection conn;



        public Clientes(Form formAnterior)
        {
            InitializeComponent();
            cargarDartos();
            _FormAnterior = formAnterior;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            TNYApellido.Clear();
            TDireccion.Clear();
            TDni.Clear();
            TTelefono.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarDartos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cliente";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }



    }
}
