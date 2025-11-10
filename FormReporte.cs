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
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
                CalcularEstadisticasVendedor();

            }
            else if (_usuario.Rol == "Administrador")
            {
                CargarGraficoVendedores();
                CargarTopProductos();
                CalcularEstadisticasAdmin();
                

            }
            else if (_usuario.Rol == "Gerente")
            {
                LPromedioDiario.Text = "Promedio diario de ventas: $" + CalcularPromedioDiario().ToString("N2");
                CalcularPorcentajeVentas();
                CargarProductosConMasStock();
                CargarDiasConMasVentas();
               

            }
        }

        private void CalcularPorcentajeVentas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT SUM(d.cantidad * d.precio) AS TotalVentas
            FROM Venta v
            INNER JOIN DetalleVenta d ON v.id_venta = d.id_venta
            WHERE v.fecha BETWEEN @desde AND @hasta;
        ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desde", DTDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", DTHasta.Value.Date);

                conn.Open();
                object resultado = cmd.ExecuteScalar();

                decimal totalVentas = 0;
                if (resultado != DBNull.Value && resultado != null)
                    totalVentas = Convert.ToDecimal(resultado);

                decimal porcentaje20 = totalVentas * 0.20m;
                //20% de las ventas totales
                LProcentaje.Text = $"Ganancia : ${porcentaje20:N2}";
                //Total de ventas
                LTotalVentas.Text = $"Total de ventas : ${totalVentas:N2}";
            }
        }

        private void CalcularEstadisticasAdmin()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                COUNT(DISTINCT v.id_venta) AS TotalVentas,
                SUM(dv.cantidad) AS TotalProductos,
                SUM(v.total) AS TotalDinero
            FROM Venta v
            INNER JOIN DetalleVenta dv ON v.id_venta = dv.id_venta
            WHERE v.fecha BETWEEN @desde AND @hasta;
        ";


                SqlCommand cmd = new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue("@desde", DTDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", DTHasta.Value.Date);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int totalVentas = reader["TotalVentas"] != DBNull.Value ? Convert.ToInt32(reader["TotalVentas"]) : 0;
                    int totalProductos = reader["TotalProductos"] != DBNull.Value ? Convert.ToInt32(reader["TotalProductos"]) : 0;
                    decimal totalDinero = reader["TotalDinero"] != DBNull.Value ? Convert.ToDecimal(reader["TotalDinero"]) : 0;

                    // Mostrar en labels
                    LTotalVentas.Text = $"Total de Ventas: {totalVentas}";
                    LPromedioDiario.Text = $"Productos Vendidos: {totalProductos}";
                    LProcentaje.Text = $"Total Recaudado: ${totalDinero:N2}";

                }
            }
        }





        private void CalcularEstadisticasVendedor()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                COUNT(DISTINCT v.id_venta) AS CantidadVentas,
                SUM(dv.cantidad) AS CantidadProductos,
                SUM(dv.cantidad * dv.precio) AS DineroTotal
            FROM Venta v
            INNER JOIN DetalleVenta dv ON v.id_venta = dv.id_venta
            WHERE v.id_usuario = @idVendedor
            AND v.fecha BETWEEN @desde AND @hasta;
        ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVendedor", _usuario.Id);
                cmd.Parameters.AddWithValue("@desde", DTDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", DTHasta.Value.Date);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int cantidadVentas = reader["CantidadVentas"] != DBNull.Value ? Convert.ToInt32(reader["CantidadVentas"]) : 0;
                    int cantidadProductos = reader["CantidadProductos"] != DBNull.Value ? Convert.ToInt32(reader["CantidadProductos"]) : 0;
                    decimal dineroTotal = reader["DineroTotal"] != DBNull.Value ? Convert.ToDecimal(reader["DineroTotal"]) : 0;

                    // Mostrar en labels
                    LTotalVentas.Text = $"Ventas realizadas: {cantidadVentas}";
                    LPromedioDiario.Text = $"Productos vendidos: {cantidadProductos}";
                    LProcentaje.Text = $"Total recaudado: ${dineroTotal:N2}";
                }
            }
        }


        private decimal CalcularPromedioDiario()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                AVG(TotalPorDia) AS PromedioDiario
            FROM (
                SELECT CAST(fecha AS DATE) AS Fecha, SUM(total) AS TotalPorDia
                FROM Venta
                WHERE fecha BETWEEN @desde AND @hasta
                GROUP BY CAST(fecha AS DATE)
            ) AS t;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desde", DTDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", DTHasta.Value.Date);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
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
                chartVentas.Titles.Clear();
                chartVentas.Titles.Add("Evolución Diaria de Ventas");

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
                chartTopProductos.Titles.Clear(); 
                chartTopProductos.Titles.Add("Top Productos Mas Vendidos");

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

        private void CargarProductosConMasStock()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT TOP 10 
            nombre,
            stock
        FROM Productos
        ORDER BY stock DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                chartVentas.Series.Clear();
                chartVentas.ChartAreas.Clear();
                chartVentas.Titles.Clear();
                chartVentas.Legends.Clear();
                chartVentas.Annotations.Clear();

                ChartArea area = new ChartArea("MainArea");
                area.AxisX.Interval = 1;
                area.AxisX.LabelStyle.Angle = -45;
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
                area.AxisX.IsMarginVisible = true;
                chartVentas.ChartAreas.Add(area);

                Series serie = new Series("Stock");
                serie.ChartType = SeriesChartType.Column;
                serie.XValueType = ChartValueType.Int32; // Usaremos índices
                serie.IsValueShownAsLabel = true;
                serie["PointWidth"] = "0.6";

                chartVentas.Series.Add(serie);

                int index = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string nombre = row["nombre"].ToString();
                    int stock = Convert.ToInt32(row["stock"]);

                    int pointIndex = serie.Points.AddXY(index, stock);
                    serie.Points[pointIndex].AxisLabel = nombre;

                    if (stock < 10)
                        serie.Points[pointIndex].Color = Color.Red;
                    else if (stock <= 30)
                        serie.Points[pointIndex].Color = Color.Goldenrod;
                    else
                        serie.Points[pointIndex].Color = Color.ForestGreen;

                    index++;
                }

                chartVentas.Titles.Add("Productos con Más Stock");
                chartVentas.Titles[0].Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }


        private void CargarDiasConMasVentas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                CONVERT(date, v.fecha) AS Fecha,
                SUM(d.cantidad) AS TotalVendidos
            FROM DetalleVenta d
            INNER JOIN Venta v ON v.id_venta = d.id_venta
            GROUP BY CONVERT(date, v.fecha)
            ORDER BY Fecha";

                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                chartTopProductos.Series.Clear();
                chartTopProductos.ChartAreas.Clear();
                chartTopProductos.Titles.Clear();

                chartTopProductos.ChartAreas.Add(new ChartArea());
                chartTopProductos.Titles.Add("Días con más productos vendidos");

                Series serie = new Series("Productos Vendidos");
                serie.ChartType = SeriesChartType.Line;
                serie.XValueMember = "Fecha";
                serie.YValueMembers = "TotalVendidos";
                serie.BorderWidth = 3;
                serie.Color = Color.Orange;
                serie.IsValueShownAsLabel = true;

                chartTopProductos.DataSource = dt;
                chartTopProductos.Series.Add(serie);



            }






        }


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

                chartTopProductos.Titles.Clear();
                chartTopProductos.Titles.Add("Evolución Semanal de Ventas");
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
