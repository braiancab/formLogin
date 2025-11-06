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
using static formLogin.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


using System.IO;
using Timer = System.Windows.Forms.Timer;

namespace formLogin
{
    public partial class FormBackUp : Form
    {

       
        private bool backupRealizadoHoy = false; // Para evitar múltiples ejecuciones el mismo día

        private Usuario _usuario;
        private Form _FormAnterior;

        private DateTime proximoBackup;  // guarda la fecha y hora del siguiente backup
        public FormBackUp(Usuario usuario, Form formAnterior)
        {
            InitializeComponent();
            IniciarTimerBackup();
            _FormAnterior = formAnterior;
            _usuario = usuario;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }

        private void IniciarTimerBackup()
        {

            // 📅 Definir el próximo backup (hoy a las 21:00 o mañana si ya pasó)
            proximoBackup = DateTime.Today.AddHours(21);
            if (DateTime.Now > proximoBackup)
                proximoBackup = proximoBackup.AddDays(1);



            Timer timerBackup = new Timer();
            timerBackup.Interval = 60000; // cada 1 minuto
            timerBackup.Tick += TimerBackup_Tick;
            timerBackup.Start();
        }

        private void TimerBackup_Tick(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;

            // ⏱ Mostrar cuenta regresiva en un Label del formulario
            TimeSpan restante = proximoBackup - ahora;
            if (restante.TotalSeconds > 0)
            {
                LTiempoBackup.Text = $"Próximo backup en: {restante:hh\\:mm\\:ss}";
            }
            else
            {
                LTiempoBackup.Text = "Realizando backup...";
            }

            // ⏰ Ejecutar backup automáticamente a las 21:00
            if (ahora >= proximoBackup && !backupRealizadoHoy)
            {
                CrearBackupAutomatico();
                backupRealizadoHoy = true;

                // Programar el próximo backup para mañana
                proximoBackup = proximoBackup.AddDays(1);
            }

            // 🔄 Reiniciar la bandera a medianoche
            if (ahora.Hour == 0 && ahora.Minute == 0 && ahora.Second == 0)
                backupRealizadoHoy = false;
        }


        private void CrearBackupAutomatico()
        {
            try
            {
                string database = "BD_TALLER"; // Cambiar por tu base
                string path = @"C:\Users\Braian\OneDrive\BackupsSQL";

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string fileName = $"{database}_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                    string fullPath = Path.Combine(path, fileName);
                    string query = $"BACKUP DATABASE [{database}] TO DISK = '{fullPath}'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        // Si querés mostrar algo:
                        // MessageBox.Show($"Backup automático realizado en:\n{fullPath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en backup automático: " + ex.Message);
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
                // 🔐 Verificar rol
                if (_usuario.Rol != "Administrador")
                {
                    MessageBox.Show("Solo los usuarios administradores pueden crear backups.",
                                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔑 Solicitar clave de seguridad
                string claveIngresada = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la clave de seguridad para continuar:",
                    "Confirmar Backup",
                    "");

                // Verificar la clave
                string claveCorrecta = "1234seguro"; // podés guardarla en config o BD
                if (claveIngresada != claveCorrecta)
                {
                    MessageBox.Show("Clave incorrecta. Operación cancelada.",
                                    "Error de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } catch { }
                try
            {
                string database = comboBoxBD.Text;   // Nombre de la BD seleccionada
                //  string path = TRuta.Text;          // Ruta donde guardar el .bak
                string path = @"C:\Users\Braian\OneDrive\BackupsSQL";
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
