using iTextSharp.text.pdf.codec.wmf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace formLogin
{
    public partial class Clientes : Form
    {
        private Form _FormAnterior;
        //Conectar con base de datos
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;     //Identifica el elemento de datagridview 
        private SqlConnection conn;


     

        public Clientes( Form formAnterior)
        {
            InitializeComponent();
            cargarDatos();
            _FormAnterior = formAnterior;
            
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            _FormAnterior.Show();
            this.Close();
        }






        private void limpiarCampos()
        {
            TNRazonSocial.Clear();
            TDireccion.Clear();
            TTelefono.Clear();
            TDni.Clear();
            idSeleccionado = 0;

        }

        private void cargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                c.id_cliente,
                c.activo,
                CASE 
                 WHEN c.activo = 1 THEN 'Activo'
                 ELSE 'Inactivo'
                 END AS estado,
                c.nombre,
                c.direccion,
                c.cuit,
                c.telefono,
                c.tipo

                FROM Cliente c";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false; // 👈 evita la fila vacía
                dataGridView1.ReadOnly = true; // opcional: evita edición manual
                dataGridView1.Columns["id_cliente"].HeaderText = "Identificacion";              
                dataGridView1.Columns["activo"].Visible = false;
                dataGridView1.Columns["estado"].HeaderText = "Estado";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre/Razon social";
                dataGridView1.Columns["direccion"].HeaderText = "Dirección";
                dataGridView1.Columns["cuit"].HeaderText = "DNI/CUIT";
                dataGridView1.Columns["telefono"].HeaderText = "Teléfono";
                dataGridView1.Columns["tipo"].HeaderText = "Tipo";
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
                return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cliente (activo,nombre,direccion,cuit,telefono,tipo) VALUES (@activo,@nombre,@direccion,@cuit,@telefono,@tipo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@activo", 1);
                cmd.Parameters.AddWithValue("@nombre", TNRazonSocial.Text);
                cmd.Parameters.AddWithValue("@direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@cuit", TDni.Text);
                cmd.Parameters.AddWithValue("@telefono", TTelefono.Text);

                string tipo = "";

                if (RBPersona.Checked)
                {
                    tipo = "Persona";
                }
                else if (RBEmpresa.Checked)
                {
                    tipo = "Empresa";
                }
                cmd.Parameters.AddWithValue("@tipo", tipo);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            cargarDatos();
           
            limpiarCampos();
            // Volvemos al formulario anterior
            if (_FormAnterior is FormCarrito carrito)
            {
                carrito.cargarClientes();  // recarga los datos del combo
                carrito.Show();            // muestra el carrito nuevamente
            }
        

        }


        private bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(TDireccion.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TTelefono.Text) ||
                string.IsNullOrWhiteSpace(TNRazonSocial.Text)
                )
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Primero verificamos si el DNI ya existe
                string checkQuery = "SELECT COUNT(*) FROM Cliente WHERE cuit = @cuit AND id_cliente <> @id_cliente";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@cuit", TDni.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@id_cliente", idSeleccionado);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El DNI ya se encuentra registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false; // Cancelamos la inserción
                    }
                }

                string checkTelefonoQuery = "SELECT COUNT(*) FROM Cliente WHERE telefono = @telefono AND id_cliente <> @id_cliente";
                using (SqlCommand checkCmd = new SqlCommand(checkTelefonoQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@telefono", TTelefono.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@id_cliente", idSeleccionado);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("El teléfono ya se encuentra registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }


            }

            bool seleccionado = panel2.Controls.OfType<System.Windows.Forms.RadioButton>().Any(r => r.Checked);
            if (!seleccionado)
            {
                MessageBox.Show("Debe seleccionar tipo.");
                return false;
            }

            // ✅ Si pasa todas las validaciones
            return true;
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;
            if (!validarCampos())
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cliente SET nombre=@nombre,direccion=@direccion,cuit=@cuit,telefono=@telefono,tipo=@tipo WHERE id_cliente=@id_cliente";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", TNRazonSocial.Text);
                cmd.Parameters.AddWithValue("@direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@cuit", TDni.Text);
                cmd.Parameters.AddWithValue("@telefono", TTelefono.Text);
                string Tipo = "";

                if (RBPersona.Checked)
                {
                    Tipo = "Persona";
                }
                else if (RBEmpresa.Checked)
                {
                    Tipo = "Empresa";
                }

                cmd.Parameters.AddWithValue("@tipo", Tipo);
                cmd.Parameters.AddWithValue("@id_cliente", idSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            cargarDatos();
          
            limpiarCampos();
            // Volvemos al formulario anterior
            if (_FormAnterior is FormCarrito carrito)
            {
                carrito.cargarClientes();  // recarga los datos del combo
                carrito.Show();            // muestra el carrito nuevamente
            }


        }

        private void BVaciar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["id_cliente"].Value);

                TNRazonSocial.Text = fila.Cells["nombre"].Value.ToString();
                TDni.Text = fila.Cells["cuit"].Value.ToString();
                TDireccion.Text = fila.Cells["direccion"].Value.ToString();
                TTelefono.Text = fila.Cells["telefono"].Value.ToString();
                int activo = Convert.ToInt32(fila.Cells["activo"].Value);

                string tipo = fila.Cells["tipo"].Value.ToString();
                RBPersona.Checked = (tipo == "PERSONA");
                RBEmpresa.Checked = (tipo == "EMPRESA");


                if (activo == 0)
                {
                    BActivar.Visible = true;  // mostrar botón activar
                }
                else
                {
                    BActivar.Visible = false; // ocultar si ya está activo
                }
            }
         

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cliente SET activo=0 WHERE id_cliente = @id_cliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", idSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            cargarDatos();
          
            limpiarCampos();
        }

        private void BActivar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_cliente"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Cliente SET activo = 1 WHERE id_cliente = @id_cliente";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", idUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario activado correctamente.");

                // Recargar los datos en el DataGridView
                cargarDatos();
              
                BActivar.Visible = false; // ocultar el botón otra vez
            }
            // Volvemos al formulario anterior
            if (_FormAnterior is FormCarrito carrito)
            {
                carrito.cargarClientes();  // recarga los datos del combo
                carrito.Show();            // muestra el carrito nuevamente
            }

        }

        private void BFiltrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =  @"
                SELECT
                c.id_cliente,
                c.activo,
                CASE
                 WHEN c.activo = 1 THEN 'Activo'
                 ELSE 'Inactivo'
                 END AS estado,
                c.nombre,
                c.direccion,
                c.cuit,
                c.telefono,
                c.tipo

                FROM Cliente c
                WHERE 1=1"; // base de la consulta




                // Filtros dinámicos
                if (!string.IsNullOrWhiteSpace(TFiltroNombre.Text))
                    query += " AND nombre LIKE @nombre";

                if (!string.IsNullOrWhiteSpace(TFiltroDni.Text))
                    query += " AND cuit LIKE @cuit";

                if (RBActivo.Checked)  // si seleccionaste activo
                    query += " AND activo = 1";
                else if (RBInactivo.Checked) // si seleccionaste Inactivo
                    query += " AND activo = 0";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Agregar parámetros solo si los campos tienen valor
                if (!string.IsNullOrWhiteSpace(TFiltroNombre.Text))
                    cmd.Parameters.AddWithValue("@nombre", "%" + TFiltroNombre.Text + "%");

                if (!string.IsNullOrWhiteSpace(TFiltroDni.Text))
                    cmd.Parameters.AddWithValue("@cuit", "%" + TFiltroDni.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

       
    }
}
