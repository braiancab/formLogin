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
    public partial class FormDetallesVenta : Form
    {

        private int idVenta;
        //Conectar con base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";

        public FormDetallesVenta(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
        }

        private void FormDetallesVenta_Load(object sender, EventArgs e)
        {
            CargarDetalles();
            CargarTotal();
        }

        private void CargarDetalles()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT p.nombre AS Producto,
                                        dv.cantidad AS Cantidad,
                                        dv.precio AS [Precio Unitario],
                                        dv.total AS Subtotal
                                 FROM DetalleVenta dv
                                 INNER JOIN Productos p ON dv.id_producto = p.id_producto
                                 WHERE dv.id_venta = @idVenta";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void CargarTotal()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT total FROM Venta WHERE id_venta = @idVenta";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    decimal total = Convert.ToDecimal(result);
                    LTotalVenta.Text = total.ToString("C2"); // Formato moneda
                }
                else
                {
                    LTotalVenta.Text = "No disponible";
                }
            }
        }

        private void FormDetallesVenta_Load_1(object sender, EventArgs e)
        {
            CargarDetalles();
            CargarTotal();
        }

        private void BDescargar_Click(object sender, EventArgs e)
        {

        }
    }
}
