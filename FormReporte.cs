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
            cargarDatos();
            _FormAnterior = formAnterior;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        private void cargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT v.id_venta, 
                        u.nombre as usuario,                      
                        c.nombre as cliente,    
                        v.fecha, 
                        v.total
                             
                        FROM Venta v
                        INNER JOIN Usuarios u ON v.id_usuario = u.id_usuario
                        INNER JOIN Cliente c ON v.id_cliente = c.id_cliente;
                            ";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt; // muestra los resultados en el DataGridView
                    dataGridView1.Columns["id_venta"].HeaderText = "Id de venta";
                    dataGridView1.Columns["usuario"].HeaderText = "Vendedor";
                    dataGridView1.Columns["cliente"].HeaderText = "Cliente";
                    dataGridView1.Columns["fecha"].HeaderText = "Fecha venta";
                    dataGridView1.Columns["total"].HeaderText = "Total";



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                dataGridView1.AllowUserToAddRows = false; // 👈 evita la fila vacía
                dataGridView1.ReadOnly = true; // opcional: evita edición manual

                // Evita agregar la columna varias veces
                if (!dataGridView1.Columns.Contains("Detalles"))
                {
                    DataGridViewButtonColumn BDetalles = new DataGridViewButtonColumn();
                    BDetalles.Name = "Detalles";
                    BDetalles.HeaderText = "Acción";
                    BDetalles.Text = "Ver Detalles";
                    BDetalles.UseColumnTextForButtonValue = true;
                    BDetalles.Width = 100;
                    // dataGridView1.Columns.Add(btnDetalles);
                    dataGridView1.Columns.Insert(0, BDetalles);

                }

            }
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
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detalles" && e.RowIndex >= 0)
            {
                int idVenta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_venta"].Value);
                // Abrir el nuevo formulario con los detalles
                FormDetallesVenta formDetalles = new FormDetallesVenta(idVenta);
                formDetalles.ShowDialog();
            }
        }
    }
}
