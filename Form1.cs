using Microsoft.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Net;
using static formLogin.Form1;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace formLogin
{


    public partial class Form1 : Form
    {


        private bool verContra = false;
        //Conectar con base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";
        //  int idSeleccionado = 0;     //Identifica el elemento de datagridview 
        public Form1()
        {
            InitializeComponent();

        }

        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Dni { get; set; }
            public string Correo { get; set; }
            public string Rol { get; set; }
            public string Username { get; set; }
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.dni, 
                        u.correo, u.usuario, r.nombre as id_rol, u.contraseña, u.id_rol
                 FROM Usuarios u
                 INNER JOIN Rol r ON u.id_rol = r.id_rol
                 WHERE u.usuario = @usuario AND u.activo = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", TNombreUsuario.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    

                    string hashAlmacenado = reader["contraseña"].ToString();

                    // ✅ Compara el hash de la contraseña ingresada con la guardada
                    if (Seguridad.VerificarPassword(TContraUsuario.Text, hashAlmacenado))
                    {
                        string nombre = reader["nombre"].ToString();
                     

                        Usuario user = new Usuario()
                        {
                            Id = Convert.ToInt32(reader["id_usuario"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Dni = reader["Dni"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Rol = reader["id_rol"].ToString(),
                            Username = reader["Usuario"].ToString()
                        };

                        // Abrimos el menú
                        FormMenu menu = new FormMenu(user, this);
                        menu.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        // Ver como hacer para presionar enter y pase a otro textbox
        private void TNombreUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita que aparezca el espacio
                e.Handled = true;//evita el sonido de enter

                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void TContraUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita que aparezca el espacio
                e.Handled = true;//evita el sonido de enter

                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            verContra = !verContra;
            if (verContra)
            {
                TContraUsuario.PasswordChar = '\0';
                pictureBox2.Image = formLogin.Properties.Resources.visible;
            } else
            {
                TContraUsuario.PasswordChar = '*';
                pictureBox2.Image = formLogin.Properties.Resources.ojo;
            }
        }
    }
}
