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
            LUser = new Label();
            LNombre = new Label();
            LApellido = new Label();
            LUsuario1 = new Label();
            LDni = new Label();
            label5 = new Label();
            LDireccion = new Label();
            LCorreo = new Label();
            LContraseña = new Label();
            LFecha = new Label();
            TDireccion = new TextBox();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TUsuario = new TextBox();
            TContraseña = new TextBox();
            Tcorreo = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            LTelefono = new Label();
            TTelefono = new TextBox();
            LSexo = new Label();
            RBMasculino = new RadioButton();
            RBFemenino = new RadioButton();
            BGuardar = new Button();
            BCancelar = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LUser);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 91);
            panel1.TabIndex = 0;
            // 
            // LUser
            // 
            LUser.AutoSize = true;
            LUser.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LUser.Location = new Point(459, 29);
            LUser.Name = "LUser";
            LUser.Size = new Size(116, 32);
            LUser.TabIndex = 0;
            LUser.Text = "Usuarios";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(220, 124);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(57, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre: ";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(220, 162);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(57, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido: ";
            // 
            // LUsuario1
            // 
            LUsuario1.AutoSize = true;
            LUsuario1.Location = new Point(529, 298);
            LUsuario1.Name = "LUsuario1";
            LUsuario1.Size = new Size(53, 15);
            LUsuario1.TabIndex = 3;
            LUsuario1.Text = "Usuario: ";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(527, 162);
            LDni.Name = "LDni";
            LDni.Size = new Size(39, 15);
            LDni.TabIndex = 4;
            LDni.Text = "D.N.I: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 200);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 5;
            label5.Text = "Rol: ";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(527, 124);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(60, 15);
            LDireccion.TabIndex = 6;
            LDireccion.Text = "Direccion:";
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Location = new Point(220, 233);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(49, 15);
            LCorreo.TabIndex = 7;
            LCorreo.Text = "Correo: ";
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(220, 298);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(73, 15);
            LContraseña.TabIndex = 8;
            LContraseña.Text = "Contraseña: ";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Location = new Point(220, 200);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(44, 15);
            LFecha.TabIndex = 9;
            LFecha.Text = "Fecha: ";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(588, 121);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(215, 23);
            TDireccion.TabIndex = 10;
            // 
            // TDni
            // 
            TDni.Location = new Point(588, 159);
            TDni.Name = "TDni";
            TDni.Size = new Size(215, 23);
            TDni.TabIndex = 11;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(304, 159);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(215, 23);
            TApellido.TabIndex = 12;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(304, 121);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(215, 23);
            TNombre.TabIndex = 13;
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(588, 290);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(215, 23);
            TUsuario.TabIndex = 14;
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(304, 290);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(215, 23);
            TContraseña.TabIndex = 15;
            // 
            // Tcorreo
            // 
            Tcorreo.Location = new Point(304, 230);
            Tcorreo.Name = "Tcorreo";
            Tcorreo.Size = new Size(215, 23);
            Tcorreo.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1-Vendedor", "2-Admin", "3-Gerente" });
            comboBox1.Location = new Point(588, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(304, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(527, 233);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(55, 15);
            LTelefono.TabIndex = 19;
            LTelefono.Text = "Telefono:";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(588, 230);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(215, 23);
            TTelefono.TabIndex = 20;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(220, 267);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(35, 15);
            LSexo.TabIndex = 21;
            LSexo.Text = "Sexo:";
            // 
            // RBMasculino
            // 
            RBMasculino.AutoSize = true;
            RBMasculino.Location = new Point(304, 265);
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
            RBFemenino.Location = new Point(425, 265);
            RBFemenino.Name = "RBFemenino";
            RBFemenino.Size = new Size(78, 19);
            RBFemenino.TabIndex = 23;
            RBFemenino.TabStop = true;
            RBFemenino.Text = "Femenino";
            RBFemenino.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(429, 344);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 24;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(529, 344);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(75, 23);
            BCancelar.TabIndex = 25;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column9, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(12, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(941, 150);
            dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.Name = "Column2";
            // 
            // Column9
            // 
            Column9.HeaderText = "DNI";
            Column9.Name = "Column9";
            // 
            // Column3
            // 
            Column3.HeaderText = "Rol";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Sexo";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Direccion";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Telefono";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Correo";
            Column8.Name = "Column8";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(989, 606);
            Controls.Add(dataGridView1);
            Controls.Add(BCancelar);
            Controls.Add(BGuardar);
            Controls.Add(RBFemenino);
            Controls.Add(RBMasculino);
            Controls.Add(LSexo);
            Controls.Add(TTelefono);
            Controls.Add(LTelefono);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(Tcorreo);
            Controls.Add(TContraseña);
            Controls.Add(TUsuario);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(TDireccion);
            Controls.Add(LFecha);
            Controls.Add(LContraseña);
            Controls.Add(LCorreo);
            Controls.Add(LDireccion);
            Controls.Add(label5);
            Controls.Add(LDni);
            Controls.Add(LUsuario1);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(panel1);
            Name = "FormUsuarios";
            Text = "Usuarios";
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
        private Label LFecha;
        private TextBox TDireccion;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TUsuario;
        private TextBox TContraseña;
        private TextBox Tcorreo;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label LTelefono;
        private TextBox TTelefono;
        private Label LSexo;
        private RadioButton RBMasculino;
        private RadioButton RBFemenino;
        private Button BGuardar;
        private Button BCancelar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}