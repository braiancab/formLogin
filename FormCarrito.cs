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
        private DataTable carrito; // Tabla para almacenar los productos en el carrito
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

            carrito = new DataTable();
            carrito.Columns.Add("ID", typeof(int));
            carrito.Columns.Add("Producto", typeof(string));
            carrito.Columns.Add("Precio", typeof(decimal));
            carrito.Columns.Add("Cantidad", typeof(int));
            carrito.Columns.Add("Descuento", typeof(decimal));
            carrito.Columns.Add("Total", typeof(decimal));

            dataGridView1.DataSource = carrito; // 🔹 Asignás la grilla para ver los datos
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            Clientes f = new Clientes(this);
            f.Show();
            this.Hide();


        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TCantidad.Text) || string.IsNullOrWhiteSpace(TDescuento.Text))
            {
                MessageBox.Show("El campo cantidad es obligatorio");
                return false;   
            }
        

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Cliente en el ComboBox.");
                return false;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Producto en el ComboBox.");
                return false;
            }

            return true;
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

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if(!ValidarCampos())
                return;

            DataRowView fila = comboBox1.SelectedItem as DataRowView;

            int id = Convert.ToInt32(fila["id_producto"]);
            string nombre = fila["nombre"].ToString();
            decimal precio = Convert.ToDecimal(fila["precio"]);
            int cantidad = Convert.ToInt32(TCantidad.Text);
            decimal descuento = string.IsNullOrWhiteSpace(TDescuento.Text) ? 0 : Convert.ToDecimal(TDescuento.Text);

            // Calculamos el total del producto
            decimal total = (precio * cantidad) - descuento;


            TTotal.Text = total.ToString("F2");     //Ver como actualizar el total a medida que se agregan productos

            // Agregamos la fila al carrito
            carrito.Rows.Add(id, nombre, precio, cantidad, descuento, total);
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            comboBox1.SelectedIndex = -1;
          
            TCantidad.Clear();
            TDescuento.Clear();
            TPrecio.Clear();
            TStock.Clear();
            TTalle.Clear();
        }
    }

}
