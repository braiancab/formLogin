using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class FormMenu : Form
    {
        private Form _FormAnterior;
        private string rol;
        public FormMenu(string rolUsuario, Form formAnterior)
        {
            InitializeComponent();
            rol = rolUsuario;
            _FormAnterior = formAnterior;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {



            if (rol == "admin")
            {
                //Botones por rol
                BBackUp.Enabled = true;
                BCarrito.Enabled = false;
                BCliente.Enabled = false;
                BSalir.Enabled = true;
                BReporte.Enabled = true;
                BProductos.Enabled = false;
                BUsuario.Enabled = true;
                //Labels por rol
                LBackup.Enabled = true;
                LCarrito.Enabled = false;
                LClientes.Enabled = false;
                LSalir.Enabled = true;
                LUsuarios.Enabled = true;
                LProductos.Enabled = false;
                LReportes.Enabled = true;
            }
            else if (rol == "gerente")
            {
                //Botones por rol
                BBackUp.Enabled = false;
                BCarrito.Enabled = false;
                BCliente.Enabled = true;
                BSalir.Enabled = true;
                BReporte.Enabled = true;
                BProductos.Enabled = true;
                BUsuario.Enabled = false;
                //Labels por rol
                LBackup.Enabled = false;
                LCarrito.Enabled = false;
                LClientes.Enabled = true;
                LSalir.Enabled = true;
                LUsuarios.Enabled = false;
                LProductos.Enabled = true;
                LReportes.Enabled = true;
            }
            else if (rol == "vendedor")
            {
                //Botones por rol
                BBackUp.Enabled = false;
                BCarrito.Enabled = true;
                BCliente.Enabled = true;
                BSalir.Enabled = true;
                BReporte.Enabled = true;
                BProductos.Enabled = false;
                BUsuario.Enabled = false;
                //Labels por rol
                LBackup.Enabled = false;
                LCarrito.Enabled = true;
                LClientes.Enabled = true;
                LSalir.Enabled = true;
                LUsuarios.Enabled = false;
                LProductos.Enabled = false;
                LReportes.Enabled = true;
            }

            //label1.Text = $"Rol actual: {rol.ToUpper()}";
            //Cuando tenga poner el label de el rol
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        private void BUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarios f = new FormUsuarios();
            f.Show();
            this.Hide();
        }
    }
}
