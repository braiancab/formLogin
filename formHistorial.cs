using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formHistorial : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;
        private Form _FormAnterior;
        public formHistorial(Form formAnterior)
        {
            InitializeComponent();
            _FormAnterior = formAnterior;
            cargarDatos();
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

                dataGridView1.AllowUserToAddRows = false; //vita la fila vacía
                dataGridView1.ReadOnly = true; // evita edición manual

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

        private void BVolver_Click(object sender, EventArgs e)
        {

            _FormAnterior.Show();
            this.Close();
        }

        private void BFiltrar_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT v.id_venta, 
                        u.nombre as usuario,                      
                        c.nombre as cliente,    
                        v.fecha, 
                        v.total
                             
                        FROM Venta v
                        INNER JOIN Usuarios u ON v.id_usuario = u.id_usuario
                        INNER JOIN Cliente c ON v.id_cliente = c.id_cliente
                        WHERE 1=1"; 
                // Condición base para facilitar la adición de filtros

                // Filtros dinámicos
                if (!string.IsNullOrWhiteSpace(TNombreFiltro.Text))
                    query += " AND usuario LIKE @nombre";



                SqlCommand cmd = new SqlCommand(query, conn);
                // Agregar parámetros solo si los campos tienen valor
                if (!string.IsNullOrWhiteSpace(TNombreFiltro.Text))
                    cmd.Parameters.AddWithValue("@nombre", "%" + TNombreFiltro.Text + "%");

                if (RBTodos.Checked)  // si seleccionaste activo
                    query += " AND 1 = 1";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }
    }
}
