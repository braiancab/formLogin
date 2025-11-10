namespace formLogin
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            LVolver = new Label();
            BsalirUs = new Button();
            LUser = new Label();
            LNombre = new Label();
            LApellido = new Label();
            LUsuario1 = new Label();
            LDni = new Label();
            label5 = new Label();
            LDireccion = new Label();
            LCorreo = new Label();
            LContraseña = new Label();
            TDireccion = new TextBox();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TUsuario = new TextBox();
            TContraseña = new TextBox();
            Tcorreo = new TextBox();
            comboBox1 = new ComboBox();
            LTelefono = new Label();
            TTelefono = new TextBox();
            LSexo = new Label();
            RBMasculino = new RadioButton();
            RBFemenino = new RadioButton();
            BAgregar = new Button();
            BEliminar = new Button();
            dataGridView1 = new DataGridView();
            BActualizar = new Button();
            groupBox1 = new GroupBox();
            BVaciar = new Button();
            BActivar = new Button();
            TFiltroNombre = new TextBox();
            TFiltroApellido = new TextBox();
            RBActivo = new RadioButton();
            LFiltroNombre = new Label();
            LFiltroApellido = new Label();
            LFiltroDni = new Label();
            TFiltroDni = new TextBox();
            BFiltrar = new Button();
            RBInactivo = new RadioButton();
            RBTodos = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(BsalirUs);
            panel1.Controls.Add(LUser);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 133);
            panel1.TabIndex = 0;
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(37, 101);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(50, 20);
            LVolver.TabIndex = 28;
            LVolver.Text = "Volver";
            // 
            // BsalirUs
            // 
            BsalirUs.BackColor = Color.White;
            BsalirUs.Image = Properties.Resources.volver;
            BsalirUs.Location = new Point(15, 4);
            BsalirUs.Margin = new Padding(3, 4, 3, 4);
            BsalirUs.Name = "BsalirUs";
            BsalirUs.Size = new Size(91, 93);
            BsalirUs.TabIndex = 30;
            BsalirUs.TabStop = false;
            BsalirUs.UseVisualStyleBackColor = false;
            BsalirUs.Click += Bsalir_Click;
            // 
            // LUser
            // 
            LUser.AutoSize = true;
            LUser.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LUser.Location = new Point(639, 35);
            LUser.Name = "LUser";
            LUser.Size = new Size(189, 46);
            LUser.TabIndex = 0;
            LUser.Text = "Usuarios";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(42, 33);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(71, 20);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre: ";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(42, 84);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(73, 20);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido: ";
            // 
            // LUsuario1
            // 
            LUsuario1.AutoSize = true;
            LUsuario1.Location = new Point(395, 221);
            LUsuario1.Name = "LUsuario1";
            LUsuario1.Size = new Size(66, 20);
            LUsuario1.TabIndex = 3;
            LUsuario1.Text = "Usuario: ";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(393, 84);
            LDni.Name = "LDni";
            LDni.Size = new Size(48, 20);
            LDni.TabIndex = 4;
            LDni.Text = "D.N.I: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 275);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 5;
            label5.Text = "Rol: ";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(393, 33);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(75, 20);
            LDireccion.TabIndex = 6;
            LDireccion.Text = "Direccion:";
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Location = new Point(42, 135);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(61, 20);
            LCorreo.TabIndex = 7;
            LCorreo.Text = "Correo: ";
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(42, 221);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(90, 20);
            LContraseña.TabIndex = 8;
            LContraseña.Text = "Contraseña: ";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(463, 29);
            TDireccion.Margin = new Padding(3, 4, 3, 4);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(245, 27);
            TDireccion.TabIndex = 5;
            // 
            // TDni
            // 
            TDni.Location = new Point(463, 80);
            TDni.Margin = new Padding(3, 4, 3, 4);
            TDni.Name = "TDni";
            TDni.Size = new Size(245, 27);
            TDni.TabIndex = 6;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(138, 80);
            TApellido.Margin = new Padding(3, 4, 3, 4);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(245, 27);
            TApellido.TabIndex = 2;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(138, 29);
            TNombre.Margin = new Padding(3, 4, 3, 4);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(245, 27);
            TNombre.TabIndex = 1;
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(463, 211);
            TUsuario.Margin = new Padding(3, 4, 3, 4);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(245, 27);
            TUsuario.TabIndex = 8;
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(138, 211);
            TContraseña.Margin = new Padding(3, 4, 3, 4);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(245, 27);
            TContraseña.TabIndex = 4;
            // 
            // Tcorreo
            // 
            Tcorreo.Location = new Point(138, 131);
            Tcorreo.Margin = new Padding(3, 4, 3, 4);
            Tcorreo.Name = "Tcorreo";
            Tcorreo.Size = new Size(245, 27);
            Tcorreo.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vendedor", "Admin", "Gerente" });
            comboBox1.Location = new Point(334, 271);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 9;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(393, 135);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(70, 20);
            LTelefono.TabIndex = 19;
            LTelefono.Text = "Telefono:";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(463, 131);
            TTelefono.Margin = new Padding(3, 4, 3, 4);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(245, 27);
            TTelefono.TabIndex = 7;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(42, 180);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(44, 20);
            LSexo.TabIndex = 21;
            LSexo.Text = "Sexo:";
            // 
            // RBMasculino
            // 
            RBMasculino.AutoSize = true;
            RBMasculino.Location = new Point(138, 177);
            RBMasculino.Margin = new Padding(3, 4, 3, 4);
            RBMasculino.Name = "RBMasculino";
            RBMasculino.Size = new Size(97, 24);
            RBMasculino.TabIndex = 22;
            RBMasculino.TabStop = true;
            RBMasculino.Text = "Masculino";
            RBMasculino.UseVisualStyleBackColor = true;
            // 
            // RBFemenino
            // 
            RBFemenino.AutoSize = true;
            RBFemenino.Location = new Point(277, 177);
            RBFemenino.Margin = new Padding(3, 4, 3, 4);
            RBFemenino.Name = "RBFemenino";
            RBFemenino.Size = new Size(95, 24);
            RBFemenino.TabIndex = 23;
            RBFemenino.TabStop = true;
            RBFemenino.Text = "Femenino";
            RBFemenino.UseVisualStyleBackColor = true;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(734, 476);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(86, 31);
            BAgregar.TabIndex = 24;
            BAgregar.TabStop = false;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(833, 475);
            BEliminar.Margin = new Padding(3, 4, 3, 4);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(86, 31);
            BEliminar.TabIndex = 25;
            BEliminar.TabStop = false;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 589);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1256, 367);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(634, 476);
            BActualizar.Margin = new Padding(3, 4, 3, 4);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(86, 32);
            BActualizar.TabIndex = 27;
            BActualizar.TabStop = false;
            BActualizar.Text = "Actualizar";
            BActualizar.UseVisualStyleBackColor = true;
            BActualizar.Click += BActualizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(BVaciar);
            groupBox1.Controls.Add(BActivar);
            groupBox1.Controls.Add(TNombre);
            groupBox1.Controls.Add(LNombre);
            groupBox1.Controls.Add(LApellido);
            groupBox1.Controls.Add(LDni);
            groupBox1.Controls.Add(LDireccion);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(RBFemenino);
            groupBox1.Controls.Add(TDireccion);
            groupBox1.Controls.Add(RBMasculino);
            groupBox1.Controls.Add(TDni);
            groupBox1.Controls.Add(LSexo);
            groupBox1.Controls.Add(TApellido);
            groupBox1.Controls.Add(TTelefono);
            groupBox1.Controls.Add(Tcorreo);
            groupBox1.Controls.Add(LTelefono);
            groupBox1.Controls.Add(LUsuario1);
            groupBox1.Controls.Add(LCorreo);
            groupBox1.Controls.Add(LContraseña);
            groupBox1.Controls.Add(TContraseña);
            groupBox1.Controls.Add(TUsuario);
            groupBox1.Location = new Point(370, 157);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(749, 309);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // BVaciar
            // 
            BVaciar.Location = new Point(623, 269);
            BVaciar.Margin = new Padding(3, 4, 3, 4);
            BVaciar.Name = "BVaciar";
            BVaciar.Size = new Size(86, 31);
            BVaciar.TabIndex = 25;
            BVaciar.Text = "Vaciar";
            BVaciar.UseVisualStyleBackColor = true;
            BVaciar.Click += BVaciar_Click;
            // 
            // BActivar
            // 
            BActivar.BackColor = Color.Transparent;
            BActivar.Location = new Point(623, 169);
            BActivar.Margin = new Padding(3, 4, 3, 4);
            BActivar.Name = "BActivar";
            BActivar.Size = new Size(86, 31);
            BActivar.TabIndex = 24;
            BActivar.Text = "Activar";
            BActivar.UseVisualStyleBackColor = false;
            BActivar.Visible = false;
            BActivar.Click += BActivar_Click;
            // 
            // TFiltroNombre
            // 
            TFiltroNombre.Location = new Point(299, 556);
            TFiltroNombre.Margin = new Padding(3, 4, 3, 4);
            TFiltroNombre.Name = "TFiltroNombre";
            TFiltroNombre.Size = new Size(150, 27);
            TFiltroNombre.TabIndex = 29;
            // 
            // TFiltroApellido
            // 
            TFiltroApellido.Location = new Point(522, 556);
            TFiltroApellido.Margin = new Padding(3, 4, 3, 4);
            TFiltroApellido.Name = "TFiltroApellido";
            TFiltroApellido.Size = new Size(150, 27);
            TFiltroApellido.TabIndex = 30;
            // 
            // RBActivo
            // 
            RBActivo.AutoSize = true;
            RBActivo.Location = new Point(978, 561);
            RBActivo.Margin = new Padding(3, 4, 3, 4);
            RBActivo.Name = "RBActivo";
            RBActivo.Size = new Size(72, 24);
            RBActivo.TabIndex = 31;
            RBActivo.TabStop = true;
            RBActivo.Text = "Activo";
            RBActivo.UseVisualStyleBackColor = true;
            // 
            // LFiltroNombre
            // 
            LFiltroNombre.AutoSize = true;
            LFiltroNombre.Location = new Point(231, 564);
            LFiltroNombre.Name = "LFiltroNombre";
            LFiltroNombre.Size = new Size(67, 20);
            LFiltroNombre.TabIndex = 32;
            LFiltroNombre.Text = "Nombre:";
            // 
            // LFiltroApellido
            // 
            LFiltroApellido.AutoSize = true;
            LFiltroApellido.Location = new Point(454, 564);
            LFiltroApellido.Name = "LFiltroApellido";
            LFiltroApellido.Size = new Size(69, 20);
            LFiltroApellido.TabIndex = 33;
            LFiltroApellido.Text = "Apellido:";
            // 
            // LFiltroDni
            // 
            LFiltroDni.AutoSize = true;
            LFiltroDni.Location = new Point(677, 564);
            LFiltroDni.Name = "LFiltroDni";
            LFiltroDni.Size = new Size(38, 20);
            LFiltroDni.TabIndex = 34;
            LFiltroDni.Text = "DNI:";
            // 
            // TFiltroDni
            // 
            TFiltroDni.Location = new Point(718, 556);
            TFiltroDni.Margin = new Padding(3, 4, 3, 4);
            TFiltroDni.Name = "TFiltroDni";
            TFiltroDni.Size = new Size(150, 27);
            TFiltroDni.TabIndex = 35;
            // 
            // BFiltrar
            // 
            BFiltrar.Location = new Point(1177, 556);
            BFiltrar.Margin = new Padding(3, 4, 3, 4);
            BFiltrar.Name = "BFiltrar";
            BFiltrar.Size = new Size(86, 31);
            BFiltrar.TabIndex = 36;
            BFiltrar.Text = "Filtrar";
            BFiltrar.UseVisualStyleBackColor = true;
            BFiltrar.Click += BFiltrar_Click;
            // 
            // RBInactivo
            // 
            RBInactivo.AutoSize = true;
            RBInactivo.Location = new Point(895, 561);
            RBInactivo.Margin = new Padding(3, 4, 3, 4);
            RBInactivo.Name = "RBInactivo";
            RBInactivo.Size = new Size(82, 24);
            RBInactivo.TabIndex = 37;
            RBInactivo.TabStop = true;
            RBInactivo.Text = "Inactivo";
            RBInactivo.UseVisualStyleBackColor = true;
            // 
            // RBTodos
            // 
            RBTodos.AutoSize = true;
            RBTodos.Location = new Point(1062, 561);
            RBTodos.Margin = new Padding(3, 4, 3, 4);
            RBTodos.Name = "RBTodos";
            RBTodos.Size = new Size(70, 24);
            RBTodos.TabIndex = 38;
            RBTodos.TabStop = true;
            RBTodos.Text = "Todos";
            RBTodos.UseVisualStyleBackColor = true;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1545, 972);
            Controls.Add(RBTodos);
            Controls.Add(RBInactivo);
            Controls.Add(BFiltrar);
            Controls.Add(TFiltroDni);
            Controls.Add(LFiltroDni);
            Controls.Add(LFiltroApellido);
            Controls.Add(LFiltroNombre);
            Controls.Add(RBActivo);
            Controls.Add(TFiltroApellido);
            Controls.Add(TFiltroNombre);
            Controls.Add(groupBox1);
            Controls.Add(BActualizar);
            Controls.Add(dataGridView1);
            Controls.Add(BEliminar);
            Controls.Add(BAgregar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUsuarios";
            Text = "Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LUser;
        private Label LNombre;
        private Label LApellido;
        private Label LUsuario1;
        private Label LDni;
        private Label label5;
        private Label LDireccion;
        private Label LCorreo;
        private Label LContraseña;
        private TextBox TDireccion;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TUsuario;
        private TextBox TContraseña;
        private TextBox Tcorreo;
        private ComboBox comboBox1;
        private Label LTelefono;
        private TextBox TTelefono;
        private Label LSexo;
        private RadioButton RBMasculino;
        private RadioButton RBFemenino;
        private Button BAgregar;
        private Button BEliminar;
        private DataGridView dataGridView1;
        private Button BActualizar;
        private Button BsalirUs;
        private Label LVolver;
        private GroupBox groupBox1;
        private Button BActivar;
        private TextBox TFiltroNombre;
        private TextBox TFiltroApellido;
        private RadioButton RBActivo;
        private Label LFiltroNombre;
        private Label LFiltroApellido;
        private Label LFiltroDni;
        private TextBox TFiltroDni;
        private Button BFiltrar;
        private RadioButton RBInactivo;
        private RadioButton RBTodos;
        private Button BVaciar;
    }
}