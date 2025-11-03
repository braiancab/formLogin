using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static formLogin.Form1;
using Microsoft.Data.SqlClient;

namespace formLogin
{
    public partial class FormCarrito : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";

        private Usuario _usuario;
        private Form _FormAnterior;
        public FormCarrito(Usuario usuario, Form formAnterior)
        {
            InitializeComponent();
            cargarClientes();
            cargarProductos();
            _FormAnterior = formAnterior;
            _usuario = usuario;
          
        }
       public void cargarClientes()
        {
            string query = "SELECT id_cliente, nombre FROM Cliente WHERE activo = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "nombre"; // lo que se muestra
                comboBox2.ValueMember = "id_cliente";      // el valor interno
            }


        }

        private void cargarProductos()
        {
            string query = "SELECT id_producto, nombre FROM Productos WHERE stock > 0";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "nombre"; // lo que se muestra
                comboBox1.ValueMember = "id_producto";      // el valor interno
            }
        }


        private void BSalir_Click(object sender, EventArgs e)
        {

            _FormAnterior.Show();
            this.Close();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            cargarClientes();
            LNombreVendedor.Text = _usuario.Nombre + " " + _usuario.Apellido;
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            Clientes f = new Clientes(this);
            f.Show();
            this.Hide();


        }

       
    }
}
