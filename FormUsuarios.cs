//using System.Data.SqlClient;//
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
    public partial class FormUsuarios : Form
    {
        private Form _FormAnterior; //variable del formulario anterior

        //Conectar con base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;     //Identifica el elemento de datagridview 


        public FormUsuarios(Form formAnterior)
        {
            InitializeComponent();
            CargarDatos();
            this.Load += FormUsuarios_Load;
            _FormAnterior = formAnterior;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);


        }


        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita el sonido "beep"
                SendKeys.Send("{TAB}");    // mueve al siguiente control
            }

            // Si cae en el botón Salir, vuelve a mover
            if (ActiveControl == BsalirUs)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }


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

            if (!ValidarCampos())
                return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (id_rol,Nombre,Apellido,Correo,Direccion,Dni,Telefono,Sexo,Contraseña,Usuario) VALUES (@id_rol,@Nombre, @Apellido,@Correo,@Direccion,@Dni,@Telefono,@Sexo,@Contraseña,@Usuario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", TApellido.Text);
                cmd.Parameters.AddWithValue("@id_rol", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@Correo", Tcorreo.Text);
                cmd.Parameters.AddWithValue("@Direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@Dni", TDni.Text);
                cmd.Parameters.AddWithValue("@Telefono", TTelefono.Text);

                string sexo = "";

                if (RBMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                else if (RBFemenino.Checked)
                {
                    sexo = "Femenino";
                }
                cmd.Parameters.AddWithValue("@Sexo", sexo);
                cmd.Parameters.AddWithValue("@Contraseña", TContraseña.Text);
                cmd.Parameters.AddWithValue("@Usuario", TUsuario.Text);

                conn.Open();
                cmd.ExecuteNonQuery();

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
            if (idSeleccionado == 0) return;
            if (!ValidarCampos())
                return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET id_rol=@id_rol,Nombre=@Nombre,Apellido=@Apellido,Direccion=@Direccion,Dni=@Dni,Correo=@Correo,Telefono=@Telefono,Sexo=@sexo,Usuario=@Usuario,Contraseña=@Contraseña  WHERE id_usuario=@id_usuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_rol", comboBox1.SelectedIndex);
                cmd.Parameters.AddWithValue("@Nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", TApellido.Text);
                cmd.Parameters.AddWithValue("@Correo", Tcorreo.Text);
                cmd.Parameters.AddWithValue("@Direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@Dni", TDni.Text);
                cmd.Parameters.AddWithValue("@Telefono", TTelefono.Text);
                string sexo = "";

                if (RBMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                else if (RBFemenino.Checked)
                {
                    sexo = "Femenino";
                }

                cmd.Parameters.AddWithValue("@Sexo", sexo);
                cmd.Parameters.AddWithValue("@Contraseña", TContraseña.Text);
                cmd.Parameters.AddWithValue("@Usuario", TUsuario.Text);
                cmd.Parameters.AddWithValue("@id_usuario", idSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
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
                comboBox1.SelectedValue = Convert.ToInt32(fila.Cells["id_rol"].Value);
                TNombre.Text = fila.Cells["Nombre"].Value.ToString();
                TApellido.Text = fila.Cells["Apellido"].Value.ToString();
                Tcorreo.Text = fila.Cells["Correo"].Value.ToString();
                TDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                TDni.Text = fila.Cells["Dni"].Value.ToString();
                TTelefono.Text = fila.Cells["Telefono"].Value.ToString();

                string sexo = fila.Cells["sexo"].Value.ToString();
                RBMasculino.Checked = (sexo == "MASCULINO");
                RBFemenino.Checked = (sexo == "FEMENINO");


                TContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
                TUsuario.Text = fila.Cells["Usuario"].Value.ToString();
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

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuarios WHERE id_usuario=@id_usuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_usuario", idSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TDireccion.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(Tcorreo.Text) ||
                string.IsNullOrWhiteSpace(TTelefono.Text) ||
                string.IsNullOrWhiteSpace(TContraseña.Text) ||
                string.IsNullOrWhiteSpace(TUsuario.Text)

                )
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return false;
            }


            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol en el ComboBox.");
                return false;
            }
            bool seleccionado = groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>().Any(r => r.Checked);
            if (!seleccionado)
            {
                MessageBox.Show("Debe seleccionar una opción en los RadioButton.");
                return false;
            }

            // ✅ Si pasa todas las validaciones
            return true;
        }

       
    }


}
