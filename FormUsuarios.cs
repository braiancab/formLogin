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
        private SqlConnection conn;

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
                string query = @"
            SELECT 
                u.id_usuario,
                u.id_rol,
                r.nombre AS rol,
                u.activo,
                 CASE 
                  WHEN u.activo = 1 THEN 'Activo'
                 ELSE 'Inactivo'
                 END AS estado,
                u.nombre,
                u.apellido,
                u.direccion,
                u.dni,
                u.correo,
                u.telefono,
                u.sexo,
                u.usuario,
                u.contraseña
            FROM Usuarios u
            INNER JOIN Rol r ON u.id_rol = r.id_rol;";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id_usuario"].HeaderText = "Identificacion";
                dataGridView1.Columns["rol"].HeaderText = "Rol";
                dataGridView1.Columns["activo"].Visible = false; // lo ocultás visualmente
                dataGridView1.Columns["id_rol"].Visible = false; // lo ocultás visualmente
                dataGridView1.Columns["estado"].HeaderText = "Estado";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["apellido"].HeaderText = "Apellido";
                dataGridView1.Columns["direccion"].HeaderText = "Dirección";
                dataGridView1.Columns["dni"].HeaderText = "DNI";
                dataGridView1.Columns["correo"].HeaderText = "Correo electrónico";
                dataGridView1.Columns["telefono"].HeaderText = "Teléfono";
                dataGridView1.Columns["sexo"].HeaderText = "Sexo";
                dataGridView1.Columns["usuario"].HeaderText = "Usuario";
                dataGridView1.Columns["contraseña"].HeaderText = "Contraseña";
            }
        }



        private void BAgregar_Click(object sender, EventArgs e)
        {
            string hash = Seguridad.HashPassword(TContraseña.Text);

            string passwordHash = Seguridad.HashPassword(TContraseña.Text);
            if (!ValidarCampos())
                return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (id_rol,activo,Nombre,Apellido,Correo,Direccion,Dni,Telefono,Sexo,Contraseña,Usuario) VALUES (@id_rol,@activo,@Nombre, @Apellido,@Correo,@Direccion,@Dni,@Telefono,@Sexo,@Contraseña,@Usuario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@activo", 1);
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
                cmd.Parameters.AddWithValue("@Contraseña", passwordHash);
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
            string hash = Seguridad.HashPassword(TContraseña.Text);

            string passwordHash = Seguridad.HashPassword(TContraseña.Text);
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
                cmd.Parameters.AddWithValue("@Contraseña", passwordHash);
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


                int activo = Convert.ToInt32(fila.Cells["activo"].Value);

                if (activo == 0)
                {
                    BActivar.Visible = true;  // mostrar botón activar
                }
                else
                {
                    BActivar.Visible = false; // ocultar si ya está activo
                }


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
                string query = "UPDATE Usuarios SET activo=0 WHERE id_usuario = @id_usuario";
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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Primero verificamos si el DNI ya existe
                string checkQuery = "SELECT COUNT(*) FROM Usuarios WHERE Dni = @Dni AND id_usuario <> @id_usuario";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Dni", TDni.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@id_usuario", idSeleccionado);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El DNI ya se encuentra registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false; // Cancelamos la inserción
                    }
                }

                // Validar Correo
                string checkCorreoQuery = "SELECT COUNT(*) FROM Usuarios WHERE correo = @correo AND id_usuario <> @id_usuario";
                using (SqlCommand checkCmd = new SqlCommand(checkCorreoQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@correo", Tcorreo.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@id_usuario", idSeleccionado);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("El correo electrónico ya se encuentra registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                // Validar Teléfono
                string checkTelefonoQuery = "SELECT COUNT(*) FROM Usuarios WHERE telefono = @telefono AND id_usuario <> @id_usuario";
                using (SqlCommand checkCmd = new SqlCommand(checkTelefonoQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@telefono", TTelefono.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@id_usuario", idSeleccionado);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("El teléfono ya se encuentra registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }


            }





            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol en el ComboBox.");
                return false;
            }
            bool seleccionado = groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>().Any(r => r.Checked);
            if (!seleccionado)
            {
                MessageBox.Show("Debe seleccionar sexo.");
                return false;
            }

            // ✅ Si pasa todas las validaciones
            return true;
        }

        private void BActivar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_usuario"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Usuarios SET activo = 1 WHERE id_usuario = @id_usuario";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario activado correctamente.");

                // Recargar los datos en el DataGridView
                CargarDatos();

                BActivar.Visible = false; // ocultar el botón otra vez
            }
        }

        private void BFiltrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =  @"
            SELECT 
                u.id_usuario,
                u.id_rol,
                r.nombre AS rol,
                u.activo,
                 CASE 
                  WHEN u.activo = 1 THEN 'Activo'
                 ELSE 'Inactivo'
                 END AS estado,
                u.nombre,
                u.apellido,
                u.direccion,
                u.dni,
                u.correo,
                u.telefono,
                u.sexo,
                u.usuario,
                u.contraseña
            FROM Usuarios u
            INNER JOIN Rol r ON u.id_rol = r.id_rol WHERE 1=1"; // base de la consulta




                // Filtros dinámicos
                if (!string.IsNullOrWhiteSpace(TFiltroNombre.Text))
                    query += " AND nombre LIKE @nombre";

                if (!string.IsNullOrWhiteSpace(TFiltroApellido.Text))
                    query += " AND apellido LIKE @apellido";

                if (!string.IsNullOrWhiteSpace(TFiltroDni.Text))
                    query += " AND dni LIKE @dni";

                if (RBActivo.Checked)  // si seleccionaste activo
                    query += " AND activo = 1";
                else if (RBInactivo.Checked) // si seleccionaste Inactivo
                    query += " AND activo = 0";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Agregar parámetros solo si los campos tienen valor
                if (!string.IsNullOrWhiteSpace(TFiltroNombre.Text))
                    cmd.Parameters.AddWithValue("@nombre", "%" + TFiltroNombre.Text + "%");

                if (!string.IsNullOrWhiteSpace(TFiltroApellido.Text))
                    cmd.Parameters.AddWithValue("@apellido", "%" + TFiltroApellido.Text + "%");

                if (!string.IsNullOrWhiteSpace(TFiltroDni.Text))
                    cmd.Parameters.AddWithValue("@dni", "%" + TFiltroDni.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void BVaciar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }


}
