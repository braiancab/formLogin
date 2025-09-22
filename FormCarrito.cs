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
    public partial class FormCarrito : Form
    {
        private Form _FormAnterior;
        public FormCarrito(Form formAnterior)
        {
            InitializeComponent();
            _FormAnterior = formAnterior;
        }



        private void BSalir_Click(object sender, EventArgs e)
        {

            _FormAnterior.Show();
            this.Close();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            TVendedor.Text = "Vendedor";
        }
    }
}
