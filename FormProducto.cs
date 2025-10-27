//using System.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace formLogin
{
    public partial class FormProducto : Form
    {
        int paginaActual = 1;
        int tamanioPagina = 10;
        int totalRegistros = 0;
        int totalPaginas = 0;

        private Form _FormAnterior;
        //variable del formulario anterior

        //Conexión con la base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;     //Identifica el elemento de datagridview 
        private SqlConnection conn;
        private object comboBox1;

        public FormProducto(Form formAnterior)
        {
            InitializeComponent();
            // Configurar ComboBox
            cmbTamanioPagina.Items.AddRange(new object[] { 5, 10, 20, 50 });
            cmbTamanioPagina.SelectedIndex = 1; // valor inicial = 10
            tamanioPagina = (int)cmbTamanioPagina.SelectedItem;
            CargarDatos();
            //      this.Load += FormProducto_Load;

            _FormAnterior = formAnterior;
        }

        private void CargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Primero contar los registros totales
                SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM Productos", conn);
                totalRegistros = (int)countCmd.ExecuteScalar();
                totalPaginas = (int)Math.Ceiling((double)totalRegistros / tamanioPagina);

                int offset = (paginaActual - 1) * tamanioPagina;

                string query = @"SELECT * FROM Productos
                         ORDER BY id_producto
                         OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@offset", offset);
                da.SelectCommand.Parameters.AddWithValue("@pageSize", tamanioPagina);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Agregar el botón Editar solo si no existe
                if (!dataGridView1.Columns.Contains("BEditar"))
                {
                    DataGridViewButtonColumn btnColumna = new DataGridViewButtonColumn();
                    btnColumna.HeaderText = "Acción";
                    btnColumna.Name = "BEditar";
                    btnColumna.Text = "Editar";
                    btnColumna.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnColumna);
                }

                // Actualizar etiqueta o mostrar la página actual
                labelPagina.Text = $"Página {paginaActual} de {totalPaginas}";
            }
        }


        //private void FormProducto_Load(object sender, EventArgs e)
        //     {
        //         using (SqlConnection con = new SqlConnection(connectionString))
        //         {
        //             con.Open();
        //             SqlCommand cmd = new SqlCommand("SELECT id_categoria, descripcion FROM Categoria", con);
        //             SqlDataAdapter da = new SqlDataAdapter(cmd);
        //             DataTable dt = new DataTable();
        //             da.Fill(dt);

        //             comboBox1.DataSource = dt;
        //             comboBox1.DisplayMember = "descripcion";   // Camisetas, Pantalones, Zapatillas
        //             comboBox1.ValueMember = "id_categoria";     // 1, 2, 3
        //             comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        //         }

        //     }

        private void BVolver_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        //private void BCargar_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Title = "Seleccionar imagen";
        //    openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        //        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta la imagen al tamaño del PictureBox
        //    }
        //}

        //private void BAgregar_Click(object sender, EventArgs e)
        //{
        //    if (!ValidarCampos())
        //        return;
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        string query = "INSERT INTO Productos (nombre, descripcion, precio, stock, id_categoria) VALUES (@nombre, @descripcion, @precio, @stock, @id_categoria)";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@nombre", TNombre.Text);
        //        cmd.Parameters.AddWithValue("@descripcion", TDescripcion.Text);
        //        cmd.Parameters.AddWithValue("@id_categoria", comboBox1.SelectedValue);
        //        cmd.Parameters.AddWithValue("@precio", TPrecio.Text);
        //        cmd.Parameters.AddWithValue("@stock", TStock.Text);

        //        conn.Open();
        //        cmd.ExecuteNonQuery();

        //    }
        //    CargarDatos();

        //    LimpiarCampos();
        //}
        //private bool ValidarCampos()
        //{


        //    if (string.IsNullOrWhiteSpace(TNombre.Text) ||
        //        string.IsNullOrWhiteSpace(TDescripcion.Text) ||
        //        string.IsNullOrWhiteSpace(TStock.Text) ||
        //        string.IsNullOrWhiteSpace(TPrecio.Text)

        //        )
        //    {
        //        MessageBox.Show("Todos los campos deben estar completos.");
        //        return false;
        //    }

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();


        //    }





        //    if (comboBox1.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una categoria en el ComboBox.");
        //        return false;
        //    }
        //    // ✅ Si pasa todas las validaciones
        //    return true;
        //}
        //private void LimpiarCampos()
        //{
        //    TNombre.Clear();
        //    TDescripcion.Clear();
        //    TStock.Clear();
        //    TPrecio.Clear();
        //    comboBox1.SelectedIndex = -1;

        //    idSeleccionado = 0;
        //}

        private void BAgregar_Click_1(object sender, EventArgs e)
        {
            using (FormAgregarProducto f = new FormAgregarProducto(this))
            {
                // Mostrar el formulario como diálogo modal
                var resultado = f.ShowDialog();

                // Si se guardó correctamente (el Form2 devuelve DialogResult.OK)
                if (resultado == DialogResult.OK)
                {
                    CargarDatos(); // Recargar los datos en el DataGridView
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la columna clickeada sea la del botón
            if (dataGridView1.Columns[e.ColumnIndex].Name == "BEditar" && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                using (FormAgregarProducto f = new FormAgregarProducto(filaSeleccionada))
                {
                    // Mostrar el formulario como diálogo modal
                    var resultado = f.ShowDialog();

                    // Si se guardó correctamente (el Form2 devuelve DialogResult.OK)
                    if (resultado == DialogResult.OK)
                    {
                        CargarDatos(); // Recargar los datos en el DataGridView
                    }
                }

            }
        }

        private void cmbTamanioPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            tamanioPagina = (int)cmbTamanioPagina.SelectedItem;
            paginaActual = 1;
            CargarDatos();

        }

        private void labelPagina_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarDatos();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                CargarDatos();
            }
        }
    }
}

