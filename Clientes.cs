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
    public partial class Clientes : Form
    {

        private Form _FormAnterior;
        public Clientes(Form formAnterior)
        {
            InitializeComponent();
            _FormAnterior = formAnterior;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            TNYApellido.Clear();
            TDireccion.Clear();
            TDni.Clear();
            TTelefono.Clear();
        }
    }
}
