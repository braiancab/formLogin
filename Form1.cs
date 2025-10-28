using Microsoft.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Net;
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
            string usuario = TNombreUsuario.Text.Trim();
            string contraseña = TContraUsuario.Text.Trim();


            if (string.IsNullOrWhiteSpace(TNombreUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario.");
                TNombreUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TContraUsuario.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña.");
                TContraUsuario.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT u.id_usuario, u.Nombre, u.Apellido, u.Dni, 
                        u.Correo, u.Usuario, r.nombre as id_rol
                 FROM Usuarios u
                 INNER JOIN Rol r ON u.id_rol = r.id_rol
                 WHERE u.Usuario = @usuario AND u.Contraseña = @contraseña AND u.activo = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Creamos el objeto usuario con los datos de la BD
                    Usuario user = new Usuario()
                    {
                        Id = Convert.ToInt32(dr["id_usuario"]),
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Dni = dr["Dni"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Rol = dr["id_rol"].ToString(),
                        Username = dr["Usuario"].ToString()
                    };

                    // Abrimos el menú
                    FormMenu menu = new FormMenu(user, this);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
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
