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
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROYECTO_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";

        int idSeleccionado = 0;
        public FormUsuarios()
        {
            InitializeComponent();
            CargarDatos();
            this.Load += FormUsuarios_Load;
        }
        private void CargarDatos()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();  //  abrir conexión
                string query = "SELECT * FROM Usuarios";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("La tabla Usuarios no tiene registros.");
                }
            }



        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (id_rol,nombre,apellido,direccion,dni,fecha,correo,telefono,sexo,usuario,contraseña) VALUES (@id_rol,@nombre,@apellido,@direccion,@dni,@fecha,@correo,@telefono,@sexo,@usuario,@contraseña)";
                SqlCommand cmd = new SqlCommand(query, conn);







                int idRol = comboBox1.SelectedIndex;

                cmd.Parameters.AddWithValue("@id_rol", idRol + 1);
                cmd.Parameters.AddWithValue("@nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@apellido", TApellido.Text);
                cmd.Parameters.AddWithValue("@direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@dni", TDni.Text);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@correo", Tcorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", TTelefono.Text);

                string sexo;
                // Verificar cuál está seleccionado
                if (RBMasculino.Checked)
                {
                    sexo = "MASCULINO";
                }
                else if (RBFemenino.Checked)
                {
                    sexo = "FEMENINO";
                }
                else
                {
                    // Opcional: manejar caso donde ninguno esté seleccionado
                    sexo = null;
                }


                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@usuario", TUsuario.Text);
                cmd.Parameters.AddWithValue("@contraseña", TContraseña.Text);

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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
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
            DateTime fecha = dateTimePicker1.Value;
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
                             fecha = @fecha,
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
                    cmd.Parameters.AddWithValue("@fecha", fecha);
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
                dateTimePicker1.Value = Convert.ToDateTime(fila.Cells["fecha"].Value);

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
    }


}
