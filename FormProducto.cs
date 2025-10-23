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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace formLogin
{
    public partial class FormProducto : Form
    {

        private Form _FormAnterior;
        //variable del formulario anterior

        //Conexión con la base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;     //Identifica el elemento de datagridview 
        private SqlConnection conn;

        public FormProducto(Form formAnterior)
        {
            InitializeComponent();
            CargarDatos();
            //      this.Load += FormProducto_Load;

            _FormAnterior = formAnterior;
        }

        private void CargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                DataGridViewButtonColumn btnColumna = new DataGridViewButtonColumn();
                btnColumna.HeaderText = "Acción";
                btnColumna.Name = "BEditar";
                btnColumna.Text = "Editar";
                btnColumna.UseColumnTextForButtonValue = true;

                // Agregarla al DataGridView
                dataGridView1.Columns.Add(btnColumna);
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
                // Ejemplo: obtener el valor de una celda de esa fila (por ejemplo un ID)
                //  int idSeleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                // Abrir el nuevo formulario y pasarle el dato


            }
        }

       
    }
}

