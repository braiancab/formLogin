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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 100);
            panel1.TabIndex = 0;
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(32, 76);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(39, 15);
            LVolver.TabIndex = 28;
            LVolver.Text = "Volver";
            // 
            // BsalirUs
            // 
            BsalirUs.BackColor = Color.White;
            BsalirUs.Image = Properties.Resources.volver;
            BsalirUs.Location = new Point(13, 3);
            BsalirUs.Name = "BsalirUs";
            BsalirUs.Size = new Size(80, 70);
            BsalirUs.TabIndex = 30;
            BsalirUs.TabStop = false;
            BsalirUs.UseVisualStyleBackColor = false;
            BsalirUs.Click += Bsalir_Click;
            // 
            // LUser
            // 
            LUser.AutoSize = true;
            LUser.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LUser.Location = new Point(392, 26);
            LUser.Name = "LUser";
            LUser.Size = new Size(154, 37);
            LUser.TabIndex = 0;
            LUser.Text = "Usuarios";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(37, 25);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(57, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre: ";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(37, 63);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(57, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido: ";
            // 
            // LUsuario1
            // 
            LUsuario1.AutoSize = true;
            LUsuario1.Location = new Point(346, 166);
            LUsuario1.Name = "LUsuario1";
            LUsuario1.Size = new Size(53, 15);
            LUsuario1.TabIndex = 3;
            LUsuario1.Text = "Usuario: ";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(344, 63);
            LDni.Name = "LDni";
            LDni.Size = new Size(39, 15);
            LDni.TabIndex = 4;
            LDni.Text = "D.N.I: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 206);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 5;
            label5.Text = "Rol: ";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(344, 25);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(60, 15);
            LDireccion.TabIndex = 6;
            LDireccion.Text = "Direccion:";
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Location = new Point(37, 101);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(49, 15);
            LCorreo.TabIndex = 7;
            LCorreo.Text = "Correo: ";
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(37, 166);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(73, 15);
            LContraseña.TabIndex = 8;
            LContraseña.Text = "Contraseña: ";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(405, 22);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(215, 23);
            TDireccion.TabIndex = 5;
            // 
            // TDni
            // 
            TDni.Location = new Point(405, 60);
            TDni.Name = "TDni";
            TDni.Size = new Size(215, 23);
            TDni.TabIndex = 6;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(121, 60);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(215, 23);
            TApellido.TabIndex = 2;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(121, 22);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(215, 23);
            TNombre.TabIndex = 1;
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(405, 158);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(215, 23);
            TUsuario.TabIndex = 8;
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(121, 158);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(215, 23);
            TContraseña.TabIndex = 4;
            // 
            // Tcorreo
            // 
            Tcorreo.Location = new Point(121, 98);
            Tcorreo.Name = "Tcorreo";
            Tcorreo.Size = new Size(215, 23);
            Tcorreo.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vendedor", "Admin", "Gerente" });
            comboBox1.Location = new Point(292, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(344, 101);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(55, 15);
            LTelefono.TabIndex = 19;
            LTelefono.Text = "Telefono:";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(405, 98);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(215, 23);
            TTelefono.TabIndex = 7;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(37, 135);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(35, 15);
            LSexo.TabIndex = 21;
            LSexo.Text = "Sexo:";
            // 
            // RBMasculino
            // 
            RBMasculino.AutoSize = true;
            RBMasculino.Location = new Point(121, 133);
            RBMasculino.Name = "RBMasculino";
            RBMasculino.Size = new Size(80, 19);
            RBMasculino.TabIndex = 22;
            RBMasculino.TabStop = true;
            RBMasculino.Text = "Masculino";
            RBMasculino.UseVisualStyleBackColor = true;
            // 
            // RBFemenino
            // 
            RBFemenino.AutoSize = true;
            RBFemenino.Location = new Point(242, 133);
            RBFemenino.Name = "RBFemenino";
            RBFemenino.Size = new Size(78, 19);
            RBFemenino.TabIndex = 23;
            RBFemenino.TabStop = true;
            RBFemenino.Text = "Femenino";
            RBFemenino.UseVisualStyleBackColor = true;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(463, 357);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(75, 23);
            BAgregar.TabIndex = 24;
            BAgregar.TabStop = false;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(550, 356);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 25;
            BEliminar.TabStop = false;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 444);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(906, 150);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(376, 357);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(75, 24);
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
            groupBox1.Location = new Point(145, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 232);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // BVaciar
            // 
            BVaciar.Location = new Point(545, 202);
            BVaciar.Name = "BVaciar";
            BVaciar.Size = new Size(75, 23);
            BVaciar.TabIndex = 25;
            BVaciar.Text = "Vaciar";
            BVaciar.UseVisualStyleBackColor = true;
            BVaciar.Click += BVaciar_Click;
            // 
            // BActivar
            // 
            BActivar.BackColor = Color.Transparent;
            BActivar.Location = new Point(545, 127);
            BActivar.Name = "BActivar";
            BActivar.Size = new Size(75, 23);
            BActivar.TabIndex = 24;
            BActivar.Text = "Activar";
            BActivar.UseVisualStyleBackColor = false;
            BActivar.Visible = false;
            BActivar.Click += BActivar_Click;
            // 
            // TFiltroNombre
            // 
            TFiltroNombre.Location = new Point(71, 419);
            TFiltroNombre.Name = "TFiltroNombre";
            TFiltroNombre.Size = new Size(132, 23);
            TFiltroNombre.TabIndex = 29;
            // 
            // TFiltroApellido
            // 
            TFiltroApellido.Location = new Point(266, 419);
            TFiltroApellido.Name = "TFiltroApellido";
            TFiltroApellido.Size = new Size(132, 23);
            TFiltroApellido.TabIndex = 30;
            // 
            // RBActivo
            // 
            RBActivo.AutoSize = true;
            RBActivo.Location = new Point(665, 423);
            RBActivo.Name = "RBActivo";
            RBActivo.Size = new Size(59, 19);
            RBActivo.TabIndex = 31;
            RBActivo.TabStop = true;
            RBActivo.Text = "Activo";
            RBActivo.UseVisualStyleBackColor = true;
            // 
            // LFiltroNombre
            // 
            LFiltroNombre.AutoSize = true;
            LFiltroNombre.Location = new Point(11, 425);
            LFiltroNombre.Name = "LFiltroNombre";
            LFiltroNombre.Size = new Size(54, 15);
            LFiltroNombre.TabIndex = 32;
            LFiltroNombre.Text = "Nombre:";
            // 
            // LFiltroApellido
            // 
            LFiltroApellido.AutoSize = true;
            LFiltroApellido.Location = new Point(206, 425);
            LFiltroApellido.Name = "LFiltroApellido";
            LFiltroApellido.Size = new Size(54, 15);
            LFiltroApellido.TabIndex = 33;
            LFiltroApellido.Text = "Apellido:";
            // 
            // LFiltroDni
            // 
            LFiltroDni.AutoSize = true;
            LFiltroDni.Location = new Point(401, 425);
            LFiltroDni.Name = "LFiltroDni";
            LFiltroDni.Size = new Size(30, 15);
            LFiltroDni.TabIndex = 34;
            LFiltroDni.Text = "DNI:";
            // 
            // TFiltroDni
            // 
            TFiltroDni.Location = new Point(437, 419);
            TFiltroDni.Name = "TFiltroDni";
            TFiltroDni.Size = new Size(132, 23);
            TFiltroDni.TabIndex = 35;
            // 
            // BFiltrar
            // 
            BFiltrar.Location = new Point(839, 419);
            BFiltrar.Name = "BFiltrar";
            BFiltrar.Size = new Size(75, 23);
            BFiltrar.TabIndex = 36;
            BFiltrar.Text = "Filtrar";
            BFiltrar.UseVisualStyleBackColor = true;
            BFiltrar.Click += BFiltrar_Click;
            // 
            // RBInactivo
            // 
            RBInactivo.AutoSize = true;
            RBInactivo.Location = new Point(592, 423);
            RBInactivo.Name = "RBInactivo";
            RBInactivo.Size = new Size(67, 19);
            RBInactivo.TabIndex = 37;
            RBInactivo.TabStop = true;
            RBInactivo.Text = "Inactivo";
            RBInactivo.UseVisualStyleBackColor = true;
            // 
            // RBTodos
            // 
            RBTodos.AutoSize = true;
            RBTodos.Location = new Point(738, 423);
            RBTodos.Name = "RBTodos";
            RBTodos.Size = new Size(56, 19);
            RBTodos.TabIndex = 38;
            RBTodos.TabStop = true;
            RBTodos.Text = "Todos";
            RBTodos.UseVisualStyleBackColor = true;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(926, 606);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
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