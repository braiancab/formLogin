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
            //cargarDatos();
            _FormAnterior = formAnterior;
            _usuario = usuario;

            LUsuario.Text = _usuario.Nombre + " " + _usuario.Apellido;

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

       
        private void BGenerar_Click(object sender, EventArgs e)
        {
            if (_usuario.Rol == "Vendedor")
            {
                CargarGraficoVentas();
                CargarEvolucionSemanal();

            }
            else if (_usuario.Rol == "Administrador")
            {
                CargarGraficoVendedores();
                CargarTopProductos();

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

                chartTopProductos.Series.Clear();
                chartTopProductos.ChartAreas.Clear();
                chartTopProductos.ChartAreas.Add(new ChartArea());

                Series serie = new Series("Evolución Semanal");
                serie.ChartType = SeriesChartType.Line;
                serie.XValueMember = "Semana";
                serie.YValueMembers = "TotalSemanal";
                serie.BorderWidth = 3;
                serie.MarkerStyle = MarkerStyle.Circle;
                serie.IsValueShownAsLabel = false;

                chartTopProductos.DataSource = dt;
                chartTopProductos.Series.Add(serie);
            }
        }

        private void BHistorial_Click(object sender, EventArgs e)
        {
            using (formHistorial f = new formHistorial(this)    )
            {
                // Mostrar el formulario como diálogo modal
                var resultado = f.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    //cargarDatos(); // Recargar los datos en el DataGridView
                }
            }
        }
    }
}
