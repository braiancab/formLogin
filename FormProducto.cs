using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
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
            this.Load += FormProducto_Load;
            
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
            }
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_rol, nombre FROM Rol", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "nombre";   // ADMIN, GERENTE, VENDEDOR
                comboBox1.ValueMember = "id_rol";     // 1, 2, 3
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }

        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        private void BCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar imagen";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta la imagen al tamaño del PictureBox
            }
        }

    }
}
