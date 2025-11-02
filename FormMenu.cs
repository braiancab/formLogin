using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static formLogin.Form1;
using Timer = System.Windows.Forms.Timer;

namespace formLogin
{
    public partial class FormMenu : Form
    {
        private Form _FormAnterior;
        private string rol;
        private Usuario _usuario;

        public FormMenu(Usuario usuario, Form formAnterior)
        {
            InitializeComponent();
            _usuario = usuario;
            _FormAnterior = formAnterior;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            Timer timer = new Timer();
            timer.Tick += new EventHandler(hora);
            timer.Interval = 1000; // 1 segundo
            timer.Start();
            LFecha.Text = DateTime.Now.ToLongDateString();


            LNombreUser.Text = _usuario.Nombre + " " + _usuario.Apellido+ " " + _usuario.Dni;
          
            LRolUser.Text = _usuario.Rol;
            if (_usuario.Rol == "Admin")
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
            else if (_usuario.Rol == "Vendedor")
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
            else if (_usuario.Rol == "Gerente")
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


        }

        public void hora(object sender, EventArgs e)
        {
            LTimer.Text = DateTime.Now.ToString("HH : mm : ss");
        }



        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        private void BUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarios f = new FormUsuarios(this);
            f.Show();
            this.Hide();
        }

        private void BBackUp_Click(object sender, EventArgs e)
        {
            FormBackUp f = new FormBackUp(this);
            f.Show();
            this.Hide();
        }

        private void BReporte_Click(object sender, EventArgs e)
        {
            FormReporte f = new FormReporte(this);
            f.Show();
            this.Hide();
        }

        private void BCliente_Click(object sender, EventArgs e)
        {
            Clientes f = new Clientes(this);
            f.Show();
            this.Hide();

        }

        private void BCarrito_Click(object sender, EventArgs e)
        {
            FormCarrito f = new FormCarrito(this);
            f.Show();
            this.Hide();
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            FormProducto f = new FormProducto(this);
            f.Show();
            this.Hide();
        }

     
    }
}
