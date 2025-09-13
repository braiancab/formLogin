using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;//
using Microsoft.Data.SqlClient;


namespace formLogin
{
    public partial class FormUsuarios : Form
    {
        private Form _FormAnterior; //variable del formulario anterior

        //Conectar con base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=EJEMPLO;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;     //Identifica el elemento de datagridview 


        public FormUsuarios(Form formAnterior)
        {
            InitializeComponent();
            CargarDatos();
            this.Load += FormUsuarios_Load;
            _FormAnterior = formAnterior;
        }




        private void CargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuarios";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }



        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (id_rol,Nombre, Apellido) VALUES (@id_rol,@Nombre, @Apellido)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", TApellido.Text);
                cmd.Parameters.AddWithValue("@id_rol", comboBox1.SelectedIndex);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TDni.Clear();
            Tcorreo.Clear();
            TUsuario.Clear();
            TTelefono.Clear();
            TDireccion.Clear();
            TContraseña.Clear();
            comboBox1.SelectedIndex = -1;

            idSeleccionado = 0;
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario primero.");
                return;
            }

            int idRol = comboBox1.SelectedIndex;
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string direccion = TDireccion.Text;
            string dni = TDni.Text;

            string correo = Tcorreo.Text;
            string telefono = TTelefono.Text;
            string usuario = TUsuario.Text;
            string contraseña = TContraseña.Text;
            string sexo = RBMasculino.Checked ? "MASCULINO" : "FEMENINO";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE USUARIOS
                         SET id_rol = @id_rol,
                             nombre = @nombre,
                             apellido = @apellido,
                             direccion = @direccion,
                             dni = @dni,
                             
                             correo = @correo,
                             telefono = @telefono,
                             sexo = @sexo,
                             usuario = @usuario,
                             contraseña = @contraseña
                         WHERE id_usuario = @id_usuario";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@dni", dni);

                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@id_usuario", idSeleccionado);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            CargarDatos();
            LimpiarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["id_usuario"].Value);



                TNombre.Text = fila.Cells["nombre"].Value.ToString();
                TApellido.Text = fila.Cells["apellido"].Value.ToString();
                TDireccion.Text = fila.Cells["direccion"].Value.ToString();
                TDni.Text = fila.Cells["dni"].Value.ToString();
                Tcorreo.Text = fila.Cells["correo"].Value.ToString();
                TTelefono.Text = fila.Cells["telefono"].Value.ToString();
                TUsuario.Text = fila.Cells["usuario"].Value.ToString();
                TContraseña.Text = fila.Cells["contraseña"].Value.ToString();

                // Sexo (RadioButton)
                string sexo = fila.Cells["sexo"].Value.ToString();
                RBMasculino.Checked = (sexo == "MASCULINO");
                RBFemenino.Checked = (sexo == "FEMENINO");

                // Fecha


                // Rol (ComboBox)
                comboBox1.SelectedValue = Convert.ToInt32(fila.Cells["id_rol"].Value);

            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
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

        private void Bsalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }
    }


}
