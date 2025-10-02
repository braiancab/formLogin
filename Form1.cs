using Microsoft.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;

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
                try
                {
                    conn.Open();
                    string query = "SELECT id_rol FROM Usuarios WHERE usuario = @usuario AND contraseña = @contraseña AND activo = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                 
                    object result = cmd.ExecuteScalar();
                    

                    if (result != null ) // Si encontró un usuario válido
                    {
                        int idRol = Convert.ToInt32(result);

                      




                        switch (idRol)
                        {
                            case 0: // Gerente
                                FormMenu fg = new FormMenu("Gerente", this);
                                fg.Show();
                                this.Hide();

                                break;

                            case 1: // Vendedor
                                FormMenu fv = new FormMenu("Vendedor", this);
                                fv.Show();
                                this.Hide();
                                break;

                            case 2: // Admin

                                FormMenu fa = new FormMenu("Admin", this);
                                fa.Show();
                                this.Hide();
                                break;

                            default:
                                MessageBox.Show("⚠ Rol no reconocido en el sistema.");
                                break;
                        }

                        this.Hide(); // Ocultamos el login
                    }
                    else
                    {
                        MessageBox.Show(" Acceso no permitido");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
