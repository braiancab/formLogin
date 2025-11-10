using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static formLogin.Form1;

namespace formLogin
{


    public partial class FormReporte : Form
    {

        public static string RolUsuarioActual; // "admin" o "vendedor" o "Gerente"
        public static int IdUsuarioActual;

        private Usuario _usuario;
        //Conectar con base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";

        private Form _FormAnterior;

        public FormReporte(Usuario usuario, Form formAnterior)
        {
            InitializeComponent();
            cargarDatos();
            _FormAnterior = formAnterior;
            _usuario = usuario;

            LUsuario.Text = _usuario.Nombre + " " + _usuario.Apellido;

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

        private void BGenerar_Click(object sender, EventArgs e)
        {
            if (_usuario.Rol == "Vendedor")
            {
                CargarGraficoVentas();
                CargarTopProductos();
                CargarEvolucionSemanal();

            }
            else if (_usuario.Rol == "Administrador")
            {
                 CargarGraficoVendedores();
                // CargarTopProductos();
                // CargarEvolucionSemanal();
            }
            else if (_usuario.Rol == "Gerente")
            {
                //  CargarGraficoVentas();
                //  CargarTopProductos();
                //  CargarEvolucionSemanal();
                MessageBox.Show("No tiene permisos para generar reportes.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void CargarGraficoVendedores()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                u.nombre AS Vendedor,
                SUM(v.total) AS TotalVendido
            FROM Venta v
            INNER JOIN Usuarios u ON u.id_usuario = v.id_usuario
            WHERE v.fecha BETWEEN @desde AND @hasta
            GROUP BY u.nombre
            ORDER BY TotalVendido DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desde", DTDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", DTHasta.Value.Date);

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                chartVentas.Series.Clear();
                chartVentas.ChartAreas.Clear();
                chartVentas.ChartAreas.Add(new ChartArea());

                Series serie = new Series("Vendedores");
                serie.ChartType = SeriesChartType.Bar;
                serie.XValueMember = "Vendedor";
                serie.YValueMembers = "TotalVendido";
                serie.IsValueShownAsLabel = true;
                serie.Color = Color.SteelBlue;

                chartVentas.DataSource = dt;
                chartVentas.Series.Add(serie);
                chartVentas.Titles.Clear();
                chartVentas.Titles.Add("Ventas por Vendedor");
            }
        }
        // 📊 1. Evolución diaria de ventas
        private void CargarGraficoVentas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        CAST(v.fecha AS DATE) AS Fecha,
                        SUM(v.total) AS TotalVentas,
                        COUNT(v.id_venta) AS Ordenes
                    FROM Venta v
                    WHERE v.fecha BETWEEN @desde AND @hasta
                    GROUP BY CAST(v.fecha AS DATE)
                    ORDER BY Fecha";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desde", DTDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", DTHasta.Value.Date);

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                chartVentas.Series.Clear();
                chartVentas.ChartAreas.Clear();
                ChartArea area = new ChartArea();
                chartVentas.ChartAreas.Add(area);

                // Ventas ($)
                Series serieVentas = new Series("Ventas ($)");
                serieVentas.ChartType = SeriesChartType.Column;
                serieVentas.XValueMember = "Fecha";
                serieVentas.YValueMembers = "TotalVentas";
                serieVentas.Color = System.Drawing.Color.RoyalBlue;
                serieVentas.IsValueShownAsLabel = true;

                // Órdenes
                Series serieOrdenes = new Series("Órdenes");
                serieOrdenes.ChartType = SeriesChartType.Line;
                serieOrdenes.XValueMember = "Fecha";
                serieOrdenes.YValueMembers = "Ordenes";
                serieOrdenes.Color = System.Drawing.Color.MediumSeaGreen;
                serieOrdenes.BorderWidth = 3;
                serieOrdenes.YAxisType = AxisType.Secondary;

                chartVentas.DataSource = dt;
                chartVentas.Series.Add(serieVentas);
                chartVentas.Series.Add(serieOrdenes);

                chartVentas.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chartVentas.ChartAreas[0].AxisX.Interval = 1;
            }
        }

        // 🥇 2. Top productos del período
        private void CargarTopProductos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT TOP 5 
                        p.nombre AS Producto,
                        SUM(d.cantidad * d.precio) AS TotalVendido
                    FROM DetalleVenta d
                    INNER JOIN Venta v ON v.id_venta = d.id_venta
                    INNER JOIN Productos p ON p.id_producto = d.id_producto
                    WHERE v.fecha BETWEEN @desde AND @hasta
                    GROUP BY p.nombre
                    ORDER BY TotalVendido DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desde", DTDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", DTHasta.Value.Date);

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                chartTopProductos.Series.Clear();
                chartTopProductos.ChartAreas.Clear();
                chartTopProductos.ChartAreas.Add(new ChartArea());

                Series serie = new Series("Top Productos");
                serie.ChartType = SeriesChartType.Doughnut;
                serie.XValueMember = "Producto";
                serie.YValueMembers = "TotalVendido";
                serie.IsValueShownAsLabel = true;

                chartTopProductos.DataSource = dt;
                chartTopProductos.Series.Add(serie);
            }
        }
        // 📈 3. Evolución semanal
        private void CargarEvolucionSemanal()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        DATEPART(YEAR, v.fecha) AS Año,
                        DATEPART(WEEK, v.fecha) AS Semana,
                        SUM(v.total) AS TotalSemanal
                    FROM Venta v
                    WHERE v.fecha BETWEEN @desde AND @hasta
                    GROUP BY DATEPART(YEAR, v.fecha), DATEPART(WEEK, v.fecha)
                    ORDER BY Año, Semana";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desde", DTDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", DTHasta.Value.Date);

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                chartSemanal.Series.Clear();
                chartSemanal.ChartAreas.Clear();
                chartSemanal.ChartAreas.Add(new ChartArea());

                Series serie = new Series("Evolución Semanal");
                serie.ChartType = SeriesChartType.Line;
                serie.XValueMember = "Semana";
                serie.YValueMembers = "TotalSemanal";
                serie.BorderWidth = 3;
                serie.MarkerStyle = MarkerStyle.Circle;
                serie.IsValueShownAsLabel = false;

                chartSemanal.DataSource = dt;
                chartSemanal.Series.Add(serie);
            }
        }

       
    }
}
