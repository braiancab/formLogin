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
    public partial class FormAgregarProducto : Form
    {

        private Form _FormAnterior;

        public bool EsEdicion { get; set; } = false;
        public int idSelec { get; set; }
        //Conexión con la base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;     //Identifica el elemento de datagridview 
        private SqlConnection conn;


        public FormAgregarProducto(Form formAnterior)
        {
            InitializeComponent();
            EsEdicion = false; // modo agregar
            CargarDatos();
            this.Load += FormProducto_Load;
            _FormAnterior = formAnterior;

          

        }


        public FormAgregarProducto(DataGridViewRow fila)
        {
            InitializeComponent();
            CargarDatos();
            this.Load += FormProducto_Load;

            EsEdicion = true; // modo edición
            // Cargar los datos de la fila en los TextBox
            idSeleccionado = Convert.ToInt32(fila.Cells["id_producto"].Value);
            TNombre.Text = fila.Cells["nombre"].Value.ToString();
            TPrecio.Text = fila.Cells["precio"].Value.ToString();
            TStock.Text = fila.Cells["stock"].Value.ToString();
            TDescripcion.Text = fila.Cells["descripcion"].Value.ToString();
            TTalle.Text = fila.Cells["talle"].Value.ToString();
            
            // agrega los demás campos según tu tabla

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
               
            }


        }

        private void BAgregar_Click(object sender, EventArgs e)
       {
            if (!ValidarCampos()) return;


                using (SqlConnection conn = new SqlConnection(connectionString))
                {


                if (EsEdicion)
                {
                    string query = "UPDATE Productos SET  nombre=@nombre, descripcion=@descripcion, precio=@precio, stock=@stock, color=@color, talle=@talle, categoria=@categoria WHERE id_producto=@id_producto";
                    SqlCommand cmd = new SqlCommand(query, conn);

                     cmd.Parameters.AddWithValue("@nombre", TNombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", TDescripcion.Text);
                    cmd.Parameters.AddWithValue("@categoria", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@precio", TPrecio.Text);
                    cmd.Parameters.AddWithValue("@stock", TStock.Text);
                    cmd.Parameters.AddWithValue("@talle", TTalle.Text);
                    cmd.Parameters.AddWithValue("@color", comboBox2.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@id_producto", idSeleccionado);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    // Aquí guardas el producto en la base de datos o lista
                    CargarDatos();
                    // Indica que todo salió bien y cierra el formulario
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    LimpiarCampos();
                }
                else
                {

                    string query = "INSERT INTO Productos (nombre, descripcion, precio, stock, color, talle, categoria) VALUES (@nombre, @descripcion, @precio, @stock, @color, @talle, @categoria)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", TNombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", TDescripcion.Text);
                    cmd.Parameters.AddWithValue("@categoria", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@precio", TPrecio.Text);
                    cmd.Parameters.AddWithValue("@stock", TStock.Text);
                    cmd.Parameters.AddWithValue("@talle", TTalle.Text);
                    cmd.Parameters.AddWithValue("@color", comboBox2.SelectedItem.ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    // Aquí guardas el producto en la base de datos o lista
                    CargarDatos();
                    // Indica que todo salió bien y cierra el formulario
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    LimpiarCampos();
                }




                }
          
       }
        private bool ValidarCampos()
        {


            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TDescripcion.Text) ||
                string.IsNullOrWhiteSpace(TStock.Text) ||
                string.IsNullOrWhiteSpace(TPrecio.Text) ||
                string.IsNullOrWhiteSpace(TTalle.Text) 

                )
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoria en el ComboBox.");
                return false;
            }




            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoria en el ComboBox.");
                return false;
            }
            // ✅ Si pasa todas las validaciones
            return true;
        }
        private void LimpiarCampos()
        {
           TNombre.Clear();
           TDescripcion.Clear();
           TStock.Clear();
           TPrecio.Clear();
          comboBox1.SelectedIndex = -1;

           idSeleccionado = 0;
        }


        private void FormProducto_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_categoria, descripcion FROM Categoria", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                     comboBox1.DataSource = dt;
                     comboBox1.DisplayMember = "descripcion";   // Camisetas, Pantalones, Zapatillas
                     comboBox1.ValueMember = "id_categoria";     // 1, 2, 3
                     comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }


            comboBox2.Items.Insert(0, "Rojo");
            comboBox2.Items.Insert(1, "Azul");
            comboBox2.Items.Insert(2, "Amarillo");
            comboBox2.Items.Insert(3, "Blanco");
            comboBox2.Items.Insert(4, "Negro");
            comboBox2.Items.Insert(5, "Morado");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;


        }

    }
}
