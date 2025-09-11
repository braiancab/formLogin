using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;//
using Microsoft.Data.SqlClient;


namespace formLogin
{
    public partial class FormUsuarios : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=PROYECTO_TALLER;Trusted_Connection=True;TrustServerCertificate=True;";

        int idSeleccionado = 0;
        public FormUsuarios()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            //   using (SqlConnection conn = new SqlConnection(connectionString))
            //  {
            //    string query = "SELECT * FROM Usuarios";
            //  SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //  DataTable dt = new DataTable();
            // da.Fill(dt);
            // dataGridView1.DataSource = dt;
            // }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();  //  abrir conexión
                string query = "SELECT * FROM Usuarios";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("La tabla Usuarios no tiene registros.");
                }
            }







        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (id_rol,nombre,apellido,direccion,dni,fecha,correo,telefono,sexo,usuario,contraseña) VALUES (@id_rol,@nombre,@apellido,@direccion,@dni,@fecha,@correo,@telefono,@sexo,@usuario,@contraseña)";
                SqlCommand cmd = new SqlCommand(query, conn);

                //Obtener int de combobox1 
                string ValorRol = comboBox1.SelectedItem.ToString();
                //Recortar el valor int
                string idRolString = ValorRol.Split('-')[0];
                //Castear a int
                int idRol = int.Parse(idRolString);

                cmd.Parameters.AddWithValue("@id_rol", idRol);
                cmd.Parameters.AddWithValue("@nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@apellido", TApellido.Text);
                cmd.Parameters.AddWithValue("@direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@dni", TDni.Text);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@correo", Tcorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", TTelefono.Text);

                string sexo;

                // Verificar cuál está seleccionado
                if (RBMasculino.Checked)
                {
                    sexo = "MASCULINO";
                }
                else if (RBFemenino.Checked)
                {
                    sexo = "FEMENINO";
                }
                else
                {
                    // Opcional: manejar caso donde ninguno esté seleccionado
                    sexo = null;
                }


                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@usuario", TUsuario.Text);
                cmd.Parameters.AddWithValue("@contraseña", TContraseña.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TDni.Clear();
            Tcorreo.Clear();
            TUsuario.Clear();
            idSeleccionado = 0;
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET id_rol=@id_rol, nombre=@nombre, apellido=@apellido, direccion=@direccion, dni=@dni,fecha=@fecha,correo=@correo,telefono=@telefono,sexo=@sexo,usuario=@usuario,contraseña=@contraseña WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                //Obtener int de combobox1 

                //

                //Actualizar el comboboxx
                //

                string ValorRol = comboBox1.SelectedItem.ToString();
                //Recortar el valor int
                string idRolString = ValorRol.Split('-')[0];
                //Castear a int
                int idRol = int.Parse(idRolString);
                cmd.Parameters.AddWithValue("@id_rol", idRol);
                cmd.Parameters.AddWithValue("@nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@apellido", TApellido.Text);
                cmd.Parameters.AddWithValue("@direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@dni", TDni.Text);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@correo", Tcorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", TTelefono.Text);
                string sexo;

                // Verificar cuál está seleccionado
                if (RBMasculino.Checked)
                {
                    sexo = "MASCULINO";
                }
                else if (RBFemenino.Checked)
                {
                    sexo = "FEMENINO";
                }
                else
                {
                    // Opcional: manejar caso donde ninguno esté seleccionado
                    sexo = null;
                }


                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@usuario", TUsuario.Text);
                cmd.Parameters.AddWithValue("@contraseña", TContraseña.Text);
                cmd.Parameters.AddWithValue("@Id", idSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["id_usuario"].Value);



                // copiado de chat

                comboBox1.SelectedValue = Convert.ToInt32(fila.Cells["id_rol"].Value);

                // fin
                TNombre.Text = fila.Cells["nombre"].Value.ToString();
                TApellido.Text = fila.Cells["apellido"].Value.ToString();
                TDireccion.Text = fila.Cells["direccion"].Value.ToString();
                TDni.Text = fila.Cells["dni"].Value.ToString();


                // Agregado de chat
                dateTimePicker1.Value = Convert.ToDateTime(fila.Cells["fecha"].Value);


                // fin

                Tcorreo.Text = fila.Cells["correo"].Value.ToString();
                TTelefono.Text = fila.Cells["telefono"].Value.ToString();

                //agregado de chat
                string sexo = fila.Cells["sexo"].Value.ToString();
                if (sexo == "MASCULINO")
                {
                    RBMasculino.Checked = true;
                    RBFemenino.Checked = false;
                }
                else if (sexo == "FEMENINO")
                {
                    RBMasculino.Checked = false;
                    RBFemenino.Checked = true;
                }

                //fin

                TUsuario.Text = fila.Cells["usuario"].Value.ToString();
                TContraseña.Text = fila.Cells["contraseña"].Value.ToString();
                





            }
        }














    }


}
