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
            Bsalir = new Button();
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
            BCancelar = new Button();
            dataGridView1 = new DataGridView();
            BActualizar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(Bsalir);
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
            // Bsalir
            // 
            Bsalir.BackColor = Color.White;
            Bsalir.Image = Properties.Resources.volver;
            Bsalir.Location = new Point(13, 3);
            Bsalir.Name = "Bsalir";
            Bsalir.Size = new Size(80, 70);
            Bsalir.TabIndex = 1;
            Bsalir.UseVisualStyleBackColor = false;
            Bsalir.Click += Bsalir_Click;
            // 
            // LUser
            // 
            LUser.AutoSize = true;
            LUser.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LUser.Location = new Point(377, 22);
            LUser.Name = "LUser";
            LUser.Size = new Size(154, 37);
            LUser.TabIndex = 0;
            LUser.Text = "Usuarios";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(176, 125);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(57, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre: ";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(176, 163);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(57, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido: ";
            // 
            // LUsuario1
            // 
            LUsuario1.AutoSize = true;
            LUsuario1.Location = new Point(485, 270);
            LUsuario1.Name = "LUsuario1";
            LUsuario1.Size = new Size(53, 15);
            LUsuario1.TabIndex = 3;
            LUsuario1.Text = "Usuario: ";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(483, 163);
            LDni.Name = "LDni";
            LDni.Size = new Size(39, 15);
            LDni.TabIndex = 4;
            LDni.Text = "D.N.I: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 313);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 5;
            label5.Text = "Rol: ";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(483, 125);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(60, 15);
            LDireccion.TabIndex = 6;
            LDireccion.Text = "Direccion:";
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Location = new Point(176, 205);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(49, 15);
            LCorreo.TabIndex = 7;
            LCorreo.Text = "Correo: ";
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(176, 270);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(73, 15);
            LContraseña.TabIndex = 8;
            LContraseña.Text = "Contraseña: ";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(544, 122);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(215, 23);
            TDireccion.TabIndex = 10;
            // 
            // TDni
            // 
            TDni.Location = new Point(544, 160);
            TDni.Name = "TDni";
            TDni.Size = new Size(215, 23);
            TDni.TabIndex = 11;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(260, 160);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(215, 23);
            TApellido.TabIndex = 12;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(260, 122);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(215, 23);
            TNombre.TabIndex = 13;
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(544, 262);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(215, 23);
            TUsuario.TabIndex = 14;
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(260, 262);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(215, 23);
            TContraseña.TabIndex = 15;
            // 
            // Tcorreo
            // 
            Tcorreo.Location = new Point(260, 202);
            Tcorreo.Name = "Tcorreo";
            Tcorreo.Size = new Size(215, 23);
            Tcorreo.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vendedor", "Admin", "Gerente" });
            comboBox1.Location = new Point(439, 310);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(483, 205);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(55, 15);
            LTelefono.TabIndex = 19;
            LTelefono.Text = "Telefono:";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(544, 202);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(215, 23);
            TTelefono.TabIndex = 20;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(176, 239);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(35, 15);
            LSexo.TabIndex = 21;
            LSexo.Text = "Sexo:";
            // 
            // RBMasculino
            // 
            RBMasculino.AutoSize = true;
            RBMasculino.Location = new Point(260, 237);
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
            RBFemenino.Location = new Point(381, 237);
            RBFemenino.Name = "RBFemenino";
            RBFemenino.Size = new Size(78, 19);
            RBFemenino.TabIndex = 23;
            RBFemenino.TabStop = true;
            RBFemenino.Text = "Femenino";
            RBFemenino.UseVisualStyleBackColor = true;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(756, 356);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(75, 23);
            BAgregar.TabIndex = 24;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(843, 355);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(75, 23);
            BCancelar.TabIndex = 25;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(906, 150);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(669, 356);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(75, 24);
            BActualizar.TabIndex = 27;
            BActualizar.Text = "Actualizar";
            BActualizar.UseVisualStyleBackColor = true;
            BActualizar.Click += BActualizar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(929, 606);
            Controls.Add(BActualizar);
            Controls.Add(dataGridView1);
            Controls.Add(BCancelar);
            Controls.Add(BAgregar);
            Controls.Add(RBFemenino);
            Controls.Add(RBMasculino);
            Controls.Add(LSexo);
            Controls.Add(TTelefono);
            Controls.Add(LTelefono);
            Controls.Add(comboBox1);
            Controls.Add(Tcorreo);
            Controls.Add(TContraseña);
            Controls.Add(TUsuario);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(TDireccion);
            Controls.Add(LContraseña);
            Controls.Add(LCorreo);
            Controls.Add(LDireccion);
            Controls.Add(label5);
            Controls.Add(LDni);
            Controls.Add(LUsuario1);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormUsuarios";
            Text = "Usuarios";
            Load += FormUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button BCancelar;
        private DataGridView dataGridView1;
        private Button BActualizar;
        private Button Bsalir;
        private Label LVolver;
    }
}