using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
namespace formLogin
{
    public partial class FormBackUp : Form
    {

        private Form _FormAnterior;
        public FormBackUp(Form formAnterior)
        {
            InitializeComponent();
            _FormAnterior = formAnterior;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        private void BRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    TRuta.Text = fbd.SelectedPath;
                }
            }
        }

        private void FormBackUp_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name FROM sys.databases WHERE database_id > 4"; // ignora system db
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBoxBD.Items.Add(dr[0].ToString());
                }
            }
        }

       
        private void BBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                string database = comboBoxBD.Text;   // Nombre de la BD seleccionada
                string path = TRuta.Text;          // Ruta donde guardar el .bak

                if (string.IsNullOrEmpty(database) || string.IsNullOrEmpty(path))
                {
                    MessageBox.Show("Debe seleccionar una base de datos y una ruta para guardar el backup.");
                    return;
                }

                // Crear carpeta si no existe
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                // Conexión al servidor
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Crear archivo de respaldo con fecha y hora
                    string fileName = $"{database}_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                    string fullPath = System.IO.Path.Combine(path, fileName);

                    string query = $"BACKUP DATABASE [{database}] TO DISK = '{fullPath}'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Backup creado correctamente en:\n{fullPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
