namespace formLogin
{
    partial class Clientes
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
            LCliente = new Label();
            LVolver = new Label();
            BSalir = new Button();
            panel2 = new Panel();
            BVaciar = new Button();
            BActivar = new Button();
            BEliminar = new Button();
            BActualizar = new Button();
            BAgregar = new Button();
            pictureBox1 = new PictureBox();
            LTipo = new Label();
            RBEmpresa = new RadioButton();
            RBPersona = new RadioButton();
            TTelefono = new TextBox();
            LTelefono = new Label();
            TDireccion = new TextBox();
            LDireccion = new Label();
            TDni = new TextBox();
            LCUIT = new Label();
            TNRazonSocial = new TextBox();
            LNYApellido = new Label();
            dataGridView1 = new DataGridView();
            LNombre = new Label();
            TFiltroNombre = new TextBox();
            LDoc = new Label();
            TFiltroDni = new TextBox();
            RBInactivo = new RadioButton();
            RBActivo = new RadioButton();
            RBTodos = new RadioButton();
            BFiltrar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LCliente);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(BSalir);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1538, 133);
            panel1.TabIndex = 0;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.BackColor = SystemColors.ActiveCaption;
            LCliente.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCliente.Location = new Point(639, 35);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(173, 46);
            LCliente.TabIndex = 2;
            LCliente.Text = "Clientes";
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(38, 101);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(50, 20);
            LVolver.TabIndex = 1;
            LVolver.Text = "Volver";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.volver;
            BSalir.Location = new Point(14, 4);
            BSalir.Margin = new Padding(3, 4, 3, 4);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(91, 93);
            BSalir.TabIndex = 1;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(BVaciar);
            panel2.Controls.Add(BActivar);
            panel2.Controls.Add(BEliminar);
            panel2.Controls.Add(BActualizar);
            panel2.Controls.Add(BAgregar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(LTipo);
            panel2.Controls.Add(RBEmpresa);
            panel2.Controls.Add(RBPersona);
            panel2.Controls.Add(TTelefono);
            panel2.Controls.Add(LTelefono);
            panel2.Controls.Add(TDireccion);
            panel2.Controls.Add(LDireccion);
            panel2.Controls.Add(TDni);
            panel2.Controls.Add(LCUIT);
            panel2.Controls.Add(TNRazonSocial);
            panel2.Controls.Add(LNYApellido);
            panel2.Location = new Point(426, 157);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 309);
            panel2.TabIndex = 1;
            // 
            // BVaciar
            // 
            BVaciar.Location = new Point(401, 87);
            BVaciar.Margin = new Padding(3, 4, 3, 4);
            BVaciar.Name = "BVaciar";
            BVaciar.Size = new Size(86, 31);
            BVaciar.TabIndex = 14;
            BVaciar.Text = "Vaciar";
            BVaciar.UseVisualStyleBackColor = true;
            BVaciar.Click += BVaciar_Click;
            // 
            // BActivar
            // 
            BActivar.Location = new Point(558, 223);
            BActivar.Margin = new Padding(3, 4, 3, 4);
            BActivar.Name = "BActivar";
            BActivar.Size = new Size(86, 31);
            BActivar.TabIndex = 13;
            BActivar.Text = "Activar";
            BActivar.UseVisualStyleBackColor = true;
            BActivar.Click += BActivar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(278, 256);
            BEliminar.Margin = new Padding(3, 4, 3, 4);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(86, 31);
            BEliminar.TabIndex = 4;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(175, 256);
            BActualizar.Margin = new Padding(3, 4, 3, 4);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(86, 31);
            BActualizar.TabIndex = 5;
            BActualizar.Text = "Actualizar";
            BActualizar.UseVisualStyleBackColor = true;
            BActualizar.Click += BActualizar_Click;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(69, 256);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(86, 31);
            BAgregar.TabIndex = 12;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = Properties.Resources.lista_de_contactos;
            pictureBox1.Location = new Point(510, 21);
            pictureBox1.Margin = new Padding(8, 9, 8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(8, 9, 8, 9);
            pictureBox1.Size = new Size(166, 188);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LTipo
            // 
            LTipo.AutoSize = true;
            LTipo.Location = new Point(105, 189);
            LTipo.Name = "LTipo";
            LTipo.Size = new Size(42, 20);
            LTipo.TabIndex = 10;
            LTipo.Text = "Tipo:";
            // 
            // RBEmpresa
            // 
            RBEmpresa.AutoSize = true;
            RBEmpresa.Location = new Point(291, 189);
            RBEmpresa.Margin = new Padding(3, 4, 3, 4);
            RBEmpresa.Name = "RBEmpresa";
            RBEmpresa.Size = new Size(87, 24);
            RBEmpresa.TabIndex = 9;
            RBEmpresa.TabStop = true;
            RBEmpresa.Text = "Empresa";
            RBEmpresa.UseVisualStyleBackColor = true;
            // 
            // RBPersona
            // 
            RBPersona.AutoSize = true;
            RBPersona.Location = new Point(157, 189);
            RBPersona.Margin = new Padding(3, 4, 3, 4);
            RBPersona.Name = "RBPersona";
            RBPersona.Size = new Size(81, 24);
            RBPersona.TabIndex = 8;
            RBPersona.TabStop = true;
            RBPersona.Text = "Persona";
            RBPersona.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(157, 151);
            TTelefono.Margin = new Padding(3, 4, 3, 4);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(223, 27);
            TTelefono.TabIndex = 7;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(82, 155);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(74, 20);
            LTelefono.TabIndex = 6;
            LTelefono.Text = "Telefono: ";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(157, 107);
            TDireccion.Margin = new Padding(3, 4, 3, 4);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(223, 27);
            TDireccion.TabIndex = 5;
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(77, 111);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(79, 20);
            LDireccion.TabIndex = 4;
            LDireccion.Text = "Direccion: ";
            // 
            // TDni
            // 
            TDni.Location = new Point(157, 64);
            TDni.Margin = new Padding(3, 4, 3, 4);
            TDni.Name = "TDni";
            TDni.Size = new Size(223, 27);
            TDni.TabIndex = 3;
            // 
            // LCUIT
            // 
            LCUIT.AutoSize = true;
            LCUIT.Location = new Point(111, 68);
            LCUIT.Name = "LCUIT";
            LCUIT.Size = new Size(43, 20);
            LCUIT.TabIndex = 2;
            LCUIT.Text = "CUIT:";
            // 
            // TNRazonSocial
            // 
            TNRazonSocial.Location = new Point(157, 21);
            TNRazonSocial.Margin = new Padding(3, 4, 3, 4);
            TNRazonSocial.Name = "TNRazonSocial";
            TNRazonSocial.Size = new Size(223, 27);
            TNRazonSocial.TabIndex = 1;
            // 
            // LNYApellido
            // 
            LNYApellido.AutoSize = true;
            LNYApellido.Location = new Point(3, 25);
            LNYApellido.Name = "LNYApellido";
            LNYApellido.Size = new Size(160, 20);
            LNYApellido.TabIndex = 0;
            LNYApellido.Text = "Nombre/ Razon social:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(274, 592);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1035, 368);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(278, 561);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(67, 20);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre:";
            // 
            // TFiltroNombre
            // 
            TFiltroNombre.Location = new Point(346, 553);
            TFiltroNombre.Margin = new Padding(3, 4, 3, 4);
            TFiltroNombre.Name = "TFiltroNombre";
            TFiltroNombre.Size = new Size(150, 27);
            TFiltroNombre.TabIndex = 3;
            // 
            // LDoc
            // 
            LDoc.AutoSize = true;
            LDoc.Location = new Point(504, 561);
            LDoc.Name = "LDoc";
            LDoc.Size = new Size(38, 20);
            LDoc.TabIndex = 4;
            LDoc.Text = "DNI:";
            // 
            // TFiltroDni
            // 
            TFiltroDni.Location = new Point(545, 553);
            TFiltroDni.Margin = new Padding(3, 4, 3, 4);
            TFiltroDni.Name = "TFiltroDni";
            TFiltroDni.Size = new Size(150, 27);
            TFiltroDni.TabIndex = 5;
            // 
            // RBInactivo
            // 
            RBInactivo.AutoSize = true;
            RBInactivo.Location = new Point(905, 556);
            RBInactivo.Margin = new Padding(3, 4, 3, 4);
            RBInactivo.Name = "RBInactivo";
            RBInactivo.Size = new Size(82, 24);
            RBInactivo.TabIndex = 6;
            RBInactivo.TabStop = true;
            RBInactivo.Text = "Inactivo";
            RBInactivo.UseVisualStyleBackColor = true;
            // 
            // RBActivo
            // 
            RBActivo.AutoSize = true;
            RBActivo.Location = new Point(989, 556);
            RBActivo.Margin = new Padding(3, 4, 3, 4);
            RBActivo.Name = "RBActivo";
            RBActivo.Size = new Size(72, 24);
            RBActivo.TabIndex = 7;
            RBActivo.TabStop = true;
            RBActivo.Text = "Activo";
            RBActivo.UseVisualStyleBackColor = true;
            // 
            // RBTodos
            // 
            RBTodos.AutoSize = true;
            RBTodos.Location = new Point(1063, 556);
            RBTodos.Margin = new Padding(3, 4, 3, 4);
            RBTodos.Name = "RBTodos";
            RBTodos.Size = new Size(70, 24);
            RBTodos.TabIndex = 8;
            RBTodos.TabStop = true;
            RBTodos.Text = "Todos";
            RBTodos.UseVisualStyleBackColor = true;
            // 
            // BFiltrar
            // 
            BFiltrar.Location = new Point(1224, 553);
            BFiltrar.Margin = new Padding(3, 4, 3, 4);
            BFiltrar.Name = "BFiltrar";
            BFiltrar.Size = new Size(86, 31);
            BFiltrar.TabIndex = 9;
            BFiltrar.Text = "Filtrar";
            BFiltrar.UseVisualStyleBackColor = true;
            BFiltrar.Click += BFiltrar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1545, 972);
            Controls.Add(BFiltrar);
            Controls.Add(RBTodos);
            Controls.Add(RBActivo);
            Controls.Add(RBInactivo);
            Controls.Add(TFiltroDni);
            Controls.Add(LDoc);
            Controls.Add(TFiltroNombre);
            Controls.Add(LNombre);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BSalir;
        private Label LVolver;
        private Label LCliente;
        private Panel panel2;
        private TextBox TNRazonSocial;
        private Label LNYApellido;
        private TextBox TDni;
        private Label LCUIT;
        private TextBox TTelefono;
        private Label LTelefono;
        private TextBox TDireccion;
        private Label LDireccion;
        private Label LTipo;
        private RadioButton RBEmpresa;
        private RadioButton RBPersona;
        private PictureBox pictureBox1;
        private Button BAgregar;
        private DataGridView dataGridView1;
        private Button BEliminar;
        private Button BActualizar;
        private Button BActivar;
        private Button BVaciar;
        private Label LNombre;
        private TextBox TFiltroNombre;
        private Label LDoc;
        private TextBox TFiltroDni;
        private RadioButton RBInactivo;
        private RadioButton RBActivo;
        private RadioButton RBTodos;
        private Button BFiltrar;
    }
}