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
            if (string.IsNullOrWhiteSpace(TCantidad.Text))
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
                CalcularTotal(); // calcula automáticamente el total
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
            if (!ValidarCampos())
                return;

            DataRowView fila = comboBox1.SelectedItem as DataRowView;

            int id = Convert.ToInt32(fila["id_producto"]);
            string nombre = fila["nombre"].ToString();
            int stock = Convert.ToInt32(fila["stock"]);
            decimal precio = Convert.ToDecimal(fila["precio"]);
            int cantidad = Convert.ToInt32(TCantidad.Text);
            decimal descuento = string.IsNullOrWhiteSpace(TDescuento.Text) ? 0 : Convert.ToDecimal(TDescuento.Text);

            // Calculamos el total del producto
            decimal total = (precio * cantidad) - descuento;


            TTotal.Text = total.ToString("F2");     //Ver como actualizar el total a medida que se agregan productos

            // 🔍 Verificar si el producto ya está en el carrito
            foreach (DataRow fila2 in carrito.Rows)
            {
                int idExistente = Convert.ToInt32(fila2["ID"]);
                if (idExistente == id)
                {
                    int cantidadActual = Convert.ToInt32(fila2["Cantidad"]);
                    int nuevaCantidad = cantidadActual + cantidad;

                    // 🧮 Verificar si la nueva cantidad supera el stock
                    if (nuevaCantidad > stock)
                    {
                        MessageBox.Show("No hay más productos disponibles en stock.", "Stock agotado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // ✅ Actualizar la fila existente
                    fila["Cantidad"] = nuevaCantidad;
                    fila["Total"] = nuevaCantidad * precio - descuento;
                    ActualizarTotalVenta();
                    return;
                }
            }


            // Agregamos la fila al carrito
            carrito.Rows.Add(id, nombre, precio, cantidad, descuento, total);
            ActualizarTotalVenta();
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

        private void CalcularTotal()
        {
            if (decimal.TryParse(TPrecio.Text, out decimal precio) &&
                int.TryParse(TCantidad.Text, out int cantidad))
            {
                decimal descuento = 0;
                if (!string.IsNullOrEmpty(TDescuento.Text))
                    decimal.TryParse(TDescuento.Text, out descuento);

                decimal total = (precio * cantidad) - descuento;
                TTotal.Text = total.ToString("0.00");
            }
            else
            {
                TTotal.Text = "0.00";
            }
        }

        private void TCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            if (int.TryParse(TCantidad.Text, out int cantidad) &&
       int.TryParse(TStock.Text, out int stock))
            {
                if (cantidad > stock)
                {
                    MessageBox.Show("La cantidad supera el stock disponible.",
                                    "Stock insuficiente",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    TCantidad.Text = stock.ToString();
                }
            }
        }

        private void TDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            if (string.IsNullOrEmpty(TDescuento.Text))
            {
                TDescuento.Text = "0.00";
            }
        }

        private void BFinalizar_Click(object sender, EventArgs e)
        {
            if (carrito.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto antes de finalizar.");
                return;
            }
            int idCliente = Convert.ToInt32(comboBox2.SelectedValue);
            int idUsuario = _usuario.Id;
            decimal totalVenta = carrito.AsEnumerable().Sum(r => r.Field<decimal>("Total"));
            DateTime fecha = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1️⃣ Insertar la cabecera de la venta
                    string queryVenta = @"INSERT INTO Venta (id_cliente, id_usuario, fecha, total)
                                  VALUES (@id_cliente, @id_usuario, @fecha, @total);
                                  SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdVenta = new SqlCommand(queryVenta, conn, transaction);
                    cmdVenta.Parameters.AddWithValue("@id_cliente", idCliente);
                    cmdVenta.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmdVenta.Parameters.AddWithValue("@fecha", fecha);
                    cmdVenta.Parameters.AddWithValue("@total", totalVenta);

                    int idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar()); // ← obtenemos el id_venta generado

                    // 2️⃣ Insertar cada producto del carrito
                    string queryDetalle = @"INSERT INTO DetalleVenta (id_venta, id_producto, cantidad, precio, descuento, total)
                                    VALUES (@id_venta, @id_producto, @cantidad, @precio, @descuento, @total)";

                    foreach (DataRow fila in carrito.Rows)
                    {
                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conn, transaction);
                        cmdDetalle.Parameters.AddWithValue("@id_venta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@id_producto", fila["ID"]);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", fila["Cantidad"]);

                        cmdDetalle.Parameters.AddWithValue("@precio", fila["Precio"]);
                        cmdDetalle.Parameters.AddWithValue("@descuento", fila["Descuento"]);
                        cmdDetalle.Parameters.AddWithValue("@total", fila["Total"]);
                        cmdDetalle.ExecuteNonQuery();

                        // 🔽 3️⃣ Descontar stock del producto
                        SqlCommand cmdStock = new SqlCommand(
                            "UPDATE Productos SET stock = stock - @cantidad WHERE id_producto = @id_producto",
                            conn, transaction);
                        
                        cmdStock.Parameters.AddWithValue("@cantidad", Convert.ToInt32(fila["Cantidad"]));
                        cmdStock.Parameters.AddWithValue("@id_producto", Convert.ToInt32(fila["ID"]));
                        cmdStock.ExecuteNonQuery();
                    }

                    // ✅ Confirmamos toda la transacción
                    transaction.Commit();
                    cargarProductos();
                    MessageBox.Show("Venta guardada correctamente.");

                    carrito.Clear(); // Limpiamos el carrito
                    comboBox2.SelectedIndex = -1;
                    comboBox2.Text = "Seleccione un Cliente...";

                    // 🔄 🔹 Volver a cargar los productos disponibles
                   
                    comboBox1.SelectedIndex = -1;
                    comboBox1.Text = "Seleccione un producto...";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar la venta: " + ex.Message);
                }
            }
        }



        private void ActualizarTotalVenta()
        {
            if (carrito.Rows.Count > 0)
            {
                decimal total = carrito.AsEnumerable().Sum(r => r.Field<decimal>("Total"));
                TTotalVenta.Text = total.ToString("0.00");
            }
            else
            {
                TTotalVenta.Text = "0.00";
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            // 🔹 1. Limpiar el DataGridView (carrito)
            //dgvCarrito.Rows.Clear();   // si lo llenás manualmente
            carrito.Clear();        // si usás un DataTable como DataSource

            limpiarCampos();
            // 🔹 4. Limpiar total general
            TTotalVenta.Text = "0.00";

        }
    }

}
