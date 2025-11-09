namespace formLogin
{
    partial class FormProducto
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
            BAgregar = new Button();
            LProductos = new Label();
            LVolver = new Label();
            BVolver = new Button();
            dataGridView1 = new DataGridView();
            cmbTamanioPagina = new ComboBox();
            labelPagina = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            LNombre = new Label();
            TNombre = new TextBox();
            RBInactivo = new RadioButton();
            RBActivo = new RadioButton();
            RBTodos = new RadioButton();
            BFiltrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(LProductos);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(BVolver);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1346, 100);
            panel1.TabIndex = 0;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(1190, 16);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(138, 57);
            BAgregar.TabIndex = 3;
            BAgregar.Text = "Agregar Producto";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click_1;
            // 
            // LProductos
            // 
            LProductos.AutoSize = true;
            LProductos.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LProductos.Location = new Point(559, 26);
            LProductos.Name = "LProductos";
            LProductos.Size = new Size(173, 37);
            LProductos.TabIndex = 1;
            LProductos.Text = "Productos";
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(30, 76);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(39, 15);
            LVolver.TabIndex = 1;
            LVolver.Text = "Volver";
            // 
            // BVolver
            // 
            BVolver.Image = Properties.Resources.volver;
            BVolver.Location = new Point(12, 3);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(80, 70);
            BVolver.TabIndex = 1;
            BVolver.UseVisualStyleBackColor = true;
            BVolver.Click += BVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 363);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1150, 292);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbTamanioPagina
            // 
            cmbTamanioPagina.FormattingEnabled = true;
            cmbTamanioPagina.Location = new Point(92, 247);
            cmbTamanioPagina.Margin = new Padding(3, 2, 3, 2);
            cmbTamanioPagina.Name = "cmbTamanioPagina";
            cmbTamanioPagina.Size = new Size(133, 23);
            cmbTamanioPagina.TabIndex = 3;
            cmbTamanioPagina.SelectedIndexChanged += cmbTamanioPagina_SelectedIndexChanged;
            // 
            // labelPagina
            // 
            labelPagina.AutoSize = true;
            labelPagina.Location = new Point(91, 223);
            labelPagina.Name = "labelPagina";
            labelPagina.Size = new Size(48, 15);
            labelPagina.TabIndex = 4;
            labelPagina.Text = "Mostrar";
            labelPagina.Click += labelPagina_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(569, 660);
            btnAnterior.Margin = new Padding(3, 2, 3, 2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(136, 22);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = "<< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(730, 660);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(136, 22);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = ">> Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(92, 336);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(57, 15);
            LNombre.TabIndex = 7;
            LNombre.Text = "Nombre: ";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(155, 334);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(134, 23);
            TNombre.TabIndex = 8;
            // 
            // RBInactivo
            // 
            RBInactivo.AutoSize = true;
            RBInactivo.Location = new Point(700, 338);
            RBInactivo.Name = "RBInactivo";
            RBInactivo.Size = new Size(67, 19);
            RBInactivo.TabIndex = 9;
            RBInactivo.TabStop = true;
            RBInactivo.Text = "Inactivo";
            RBInactivo.UseVisualStyleBackColor = true;
            // 
            // RBActivo
            // 
            RBActivo.AutoSize = true;
            RBActivo.Location = new Point(820, 338);
            RBActivo.Name = "RBActivo";
            RBActivo.Size = new Size(59, 19);
            RBActivo.TabIndex = 10;
            RBActivo.TabStop = true;
            RBActivo.Text = "Activo";
            RBActivo.UseVisualStyleBackColor = true;
            // 
            // RBTodos
            // 
            RBTodos.AutoSize = true;
            RBTodos.Location = new Point(933, 338);
            RBTodos.Name = "RBTodos";
            RBTodos.Size = new Size(56, 19);
            RBTodos.TabIndex = 11;
            RBTodos.TabStop = true;
            RBTodos.Text = "Todos";
            RBTodos.UseVisualStyleBackColor = true;
            // 
            // BFiltrar
            // 
            BFiltrar.Location = new Point(1166, 332);
            BFiltrar.Name = "BFiltrar";
            BFiltrar.Size = new Size(75, 23);
            BFiltrar.TabIndex = 12;
            BFiltrar.Text = "Filtrar";
            BFiltrar.UseVisualStyleBackColor = true;
            BFiltrar.Click += BFiltrar_Click;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1352, 729);
            Controls.Add(BFiltrar);
            Controls.Add(RBTodos);
            Controls.Add(RBActivo);
            Controls.Add(RBInactivo);
            Controls.Add(TNombre);
            Controls.Add(LNombre);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(labelPagina);
            Controls.Add(cmbTamanioPagina);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormProducto";
            Text = "FormProducto";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BVolver;
        private Label LProductos;
        private Label LVolver;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button BAgregar;
        private ComboBox cmbTamanioPagina;
        private Label labelPagina;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label LNombre;
        private TextBox TNombre;
        private RadioButton RBInactivo;
        private RadioButton RBActivo;
        private RadioButton RBTodos;
        private Button BFiltrar;
    }
}