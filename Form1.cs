namespace formLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras y la tecla de retroceso (Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
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




            string usuario = TNombreUsuario.Text;
            string clave = TContraUsuario.Text;

            if (usuario == "admin" && clave == "123")
            {
                FormMenu f = new FormMenu("admin", this);
                f.Show();
                this.Hide();
            }
            else if (usuario == "gerente" && clave == "123")
            {
                FormMenu f = new FormMenu("gerente", this);
                f.Show();
                this.Hide();
            }
            else if (usuario == "vendedor" && clave == "123")
            {
                FormMenu f = new FormMenu("vendedor", this);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
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
    }
}
