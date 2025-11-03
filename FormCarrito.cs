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
        private bool cargandoProductos = false;
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
              
                comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

                comboBox2.SelectedIndex = -1;
                comboBox2.Text = "Seleccione un Cliente...";
            }


        }

        private void cargarProductos()
        {
            cargandoProductos = true; // 🔹 bloqueamos el evento mientras carga

            string query = "SELECT id_producto,nombre,descripcion,precio,stock,color,talle,categoria FROM Productos WHERE stock > 0";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;

                comboBox1.DisplayMember = "nombre"; // lo que se muestra
                comboBox1.ValueMember = "id_producto";      // el valor interno
              
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

                comboBox1.SelectedIndex = -1;
                comboBox1.Text = "Seleccione un producto...";
            }
            cargandoProductos = false; // 🔹 habilitamos el evento nuevamente
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
            LFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            Clientes f = new Clientes(this);
            f.Show();
            this.Hide();


        }

        private void validarCampos()
        {
            if (string.IsNullOrWhiteSpace(TCantidad.Text))
            {
                throw new Exception("El campo cantidad es obligatorio");
            }
            if (!int.TryParse(TCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                throw new Exception("El campo cantidad debe ser un mayor a cero.");
            }

            //      if (comboBox2.SelectedIndex == -1)
            //      {
            //        MessageBox.Show("Debe seleccionar un Cliente en el ComboBox.");
            //       return false;
            //  }
            //  if (comboBox1.SelectedIndex == -1)
            // {
            //     MessageBox.Show("Debe seleccionar un Producto en el ComboBox.");
            //   return false;
            // }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoProductos) return; // 🔹 evita ejecutar durante la carga
            if (comboBox1.SelectedItem == null)
                return;
            DataRowView filaSeleccionada = comboBox1.SelectedItem as DataRowView;

            if (filaSeleccionada != null)
            {
                TStock.Text = filaSeleccionada["stock"].ToString();
                TPrecio.Text = filaSeleccionada["precio"].ToString();
                TTalle.Text = filaSeleccionada["talle"].ToString();
            }
            else
            {
                TStock.Clear();
                TPrecio.Clear();
                TTalle.Clear();
            }
        }

    }

}
