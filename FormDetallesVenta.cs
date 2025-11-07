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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


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
            try
            {
                // Seleccionar ruta donde guardar el PDF
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFile.FileName = $"Venta_{idVenta}.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // Crear documento PDF
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));
                    doc.Open();

                    // 🔹 Título
                    Paragraph titulo = new Paragraph($"Detalles de la Venta #{idVenta}\n\n",
                        new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f, iTextSharp.text.Font.BOLD));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    // 🔹 Fecha
                    Paragraph fecha = new Paragraph($"Fecha de generación: {DateTime.Now}\n\n",
                        new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.ITALIC));
                    fecha.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(fecha);

                    // 🔹 Tabla de productos
                    PdfPTable tabla = new PdfPTable(dataGridView1.Columns.Count);
                    tabla.WidthPercentage = 100;

                    // Encabezados
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        PdfPCell celda = new PdfPCell(new Phrase(col.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.BOLD)));
                        celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                        celda.HorizontalAlignment = Element.ALIGN_CENTER;
                        tabla.AddCell(celda);
                    }

                    // Filas
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                tabla.AddCell(celda.Value?.ToString() ?? "");
                            }
                        }
                    }

                    doc.Add(tabla);

                    // 🔹 Total
                    Paragraph total = new Paragraph($"\nTotal de la venta: {LTotalVenta.Text}",
                        new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD));
                    total.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(total);

                    doc.Close();

                    MessageBox.Show("PDF generado correctamente:\n" + saveFile.FileName,
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
