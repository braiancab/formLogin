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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1346, 100);
            panel1.TabIndex = 0;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.BackColor = SystemColors.ActiveCaption;
            LCliente.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCliente.Location = new Point(559, 26);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(144, 37);
            LCliente.TabIndex = 2;
            LCliente.Text = "Clientes";
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(33, 76);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(39, 15);
            LVolver.TabIndex = 1;
            LVolver.Text = "Volver";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.volver;
            BSalir.Location = new Point(12, 3);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(80, 70);
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
            panel2.Location = new Point(373, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 232);
            panel2.TabIndex = 1;
            // 
            // BVaciar
            // 
            BVaciar.Location = new Point(351, 65);
            BVaciar.Name = "BVaciar";
            BVaciar.Size = new Size(75, 23);
            BVaciar.TabIndex = 14;
            BVaciar.Text = "Vaciar";
            BVaciar.UseVisualStyleBackColor = true;
            BVaciar.Click += BVaciar_Click;
            // 
            // BActivar
            // 
            BActivar.Location = new Point(488, 167);
            BActivar.Name = "BActivar";
            BActivar.Size = new Size(75, 23);
            BActivar.TabIndex = 13;
            BActivar.Text = "Activar";
            BActivar.UseVisualStyleBackColor = true;
            BActivar.Click += BActivar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(243, 192);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 4;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(153, 192);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(75, 23);
            BActualizar.TabIndex = 5;
            BActualizar.Text = "Actualizar";
            BActualizar.UseVisualStyleBackColor = true;
            BActualizar.Click += BActualizar_Click;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(60, 192);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(75, 23);
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
            pictureBox1.Location = new Point(446, 16);
            pictureBox1.Margin = new Padding(7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(7);
            pictureBox1.Size = new Size(145, 141);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LTipo
            // 
            LTipo.AutoSize = true;
            LTipo.Location = new Point(92, 142);
            LTipo.Name = "LTipo";
            LTipo.Size = new Size(33, 15);
            LTipo.TabIndex = 10;
            LTipo.Text = "Tipo:";
            // 
            // RBEmpresa
            // 
            RBEmpresa.AutoSize = true;
            RBEmpresa.Location = new Point(255, 142);
            RBEmpresa.Name = "RBEmpresa";
            RBEmpresa.Size = new Size(70, 19);
            RBEmpresa.TabIndex = 9;
            RBEmpresa.TabStop = true;
            RBEmpresa.Text = "Empresa";
            RBEmpresa.UseVisualStyleBackColor = true;
            // 
            // RBPersona
            // 
            RBPersona.AutoSize = true;
            RBPersona.Location = new Point(137, 142);
            RBPersona.Name = "RBPersona";
            RBPersona.Size = new Size(67, 19);
            RBPersona.TabIndex = 8;
            RBPersona.TabStop = true;
            RBPersona.Text = "Persona";
            RBPersona.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(137, 113);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(196, 23);
            TTelefono.TabIndex = 7;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(72, 116);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(58, 15);
            LTelefono.TabIndex = 6;
            LTelefono.Text = "Telefono: ";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(137, 80);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(196, 23);
            TDireccion.TabIndex = 5;
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(67, 83);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(63, 15);
            LDireccion.TabIndex = 4;
            LDireccion.Text = "Direccion: ";
            // 
            // TDni
            // 
            TDni.Location = new Point(137, 48);
            TDni.Name = "TDni";
            TDni.Size = new Size(196, 23);
            TDni.TabIndex = 3;
            // 
            // LCUIT
            // 
            LCUIT.AutoSize = true;
            LCUIT.Location = new Point(97, 51);
            LCUIT.Name = "LCUIT";
            LCUIT.Size = new Size(35, 15);
            LCUIT.TabIndex = 2;
            LCUIT.Text = "CUIT:";
            // 
            // TNRazonSocial
            // 
            TNRazonSocial.Location = new Point(137, 16);
            TNRazonSocial.Name = "TNRazonSocial";
            TNRazonSocial.Size = new Size(196, 23);
            TNRazonSocial.TabIndex = 1;
            // 
            // LNYApellido
            // 
            LNYApellido.AutoSize = true;
            LNYApellido.Location = new Point(3, 19);
            LNYApellido.Name = "LNYApellido";
            LNYApellido.Size = new Size(127, 15);
            LNYApellido.TabIndex = 0;
            LNYApellido.Text = "Nombre/ Razon social:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Location = new Point(240, 444);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(906, 276);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(243, 421);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre:";
            // 
            // TFiltroNombre
            // 
            TFiltroNombre.Location = new Point(303, 415);
            TFiltroNombre.Name = "TFiltroNombre";
            TFiltroNombre.Size = new Size(132, 23);
            TFiltroNombre.TabIndex = 3;
            // 
            // LDoc
            // 
            LDoc.AutoSize = true;
            LDoc.Location = new Point(441, 421);
            LDoc.Name = "LDoc";
            LDoc.Size = new Size(30, 15);
            LDoc.TabIndex = 4;
            LDoc.Text = "DNI:";
            // 
            // TFiltroDni
            // 
            TFiltroDni.Location = new Point(477, 415);
            TFiltroDni.Name = "TFiltroDni";
            TFiltroDni.Size = new Size(132, 23);
            TFiltroDni.TabIndex = 5;
            // 
            // RBInactivo
            // 
            RBInactivo.AutoSize = true;
            RBInactivo.Location = new Point(792, 417);
            RBInactivo.Name = "RBInactivo";
            RBInactivo.Size = new Size(67, 19);
            RBInactivo.TabIndex = 6;
            RBInactivo.TabStop = true;
            RBInactivo.Text = "Inactivo";
            RBInactivo.UseVisualStyleBackColor = true;
            // 
            // RBActivo
            // 
            RBActivo.AutoSize = true;
            RBActivo.Location = new Point(865, 417);
            RBActivo.Name = "RBActivo";
            RBActivo.Size = new Size(59, 19);
            RBActivo.TabIndex = 7;
            RBActivo.TabStop = true;
            RBActivo.Text = "Activo";
            RBActivo.UseVisualStyleBackColor = true;
            // 
            // RBTodos
            // 
            RBTodos.AutoSize = true;
            RBTodos.Location = new Point(930, 417);
            RBTodos.Name = "RBTodos";
            RBTodos.Size = new Size(56, 19);
            RBTodos.TabIndex = 8;
            RBTodos.TabStop = true;
            RBTodos.Text = "Todos";
            RBTodos.UseVisualStyleBackColor = true;
            // 
            // BFiltrar
            // 
            BFiltrar.Location = new Point(1071, 415);
            BFiltrar.Name = "BFiltrar";
            BFiltrar.Size = new Size(75, 23);
            BFiltrar.TabIndex = 9;
            BFiltrar.Text = "Filtrar";
            BFiltrar.UseVisualStyleBackColor = true;
            BFiltrar.Click += BFiltrar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1352, 729);
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
            Name = "Clientes";
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
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