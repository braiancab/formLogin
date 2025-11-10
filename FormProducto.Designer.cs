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
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1538, 133);
            panel1.TabIndex = 0;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(1360, 21);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(158, 76);
            BAgregar.TabIndex = 3;
            BAgregar.Text = "Agregar Producto";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click_1;
            // 
            // LProductos
            // 
            LProductos.AutoSize = true;
            LProductos.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LProductos.Location = new Point(639, 35);
            LProductos.Name = "LProductos";
            LProductos.Size = new Size(215, 46);
            LProductos.TabIndex = 1;
            LProductos.Text = "Productos";
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(34, 101);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(50, 20);
            LVolver.TabIndex = 1;
            LVolver.Text = "Volver";
            // 
            // BVolver
            // 
            BVolver.Image = Properties.Resources.volver;
            BVolver.Location = new Point(14, 4);
            BVolver.Margin = new Padding(3, 4, 3, 4);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(91, 93);
            BVolver.TabIndex = 1;
            BVolver.UseVisualStyleBackColor = true;
            BVolver.Click += BVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 484);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1314, 389);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbTamanioPagina
            // 
            cmbTamanioPagina.FormattingEnabled = true;
            cmbTamanioPagina.Location = new Point(105, 329);
            cmbTamanioPagina.Name = "cmbTamanioPagina";
            cmbTamanioPagina.Size = new Size(151, 28);
            cmbTamanioPagina.TabIndex = 3;
            cmbTamanioPagina.SelectedIndexChanged += cmbTamanioPagina_SelectedIndexChanged;
            // 
            // labelPagina
            // 
            labelPagina.AutoSize = true;
            labelPagina.Location = new Point(104, 297);
            labelPagina.Name = "labelPagina";
            labelPagina.Size = new Size(60, 20);
            labelPagina.TabIndex = 4;
            labelPagina.Text = "Mostrar";
            labelPagina.Click += labelPagina_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(650, 880);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(155, 29);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = "<< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(834, 880);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(155, 29);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = ">> Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(105, 448);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(71, 20);
            LNombre.TabIndex = 7;
            LNombre.Text = "Nombre: ";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(177, 445);
            TNombre.Margin = new Padding(3, 4, 3, 4);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(153, 27);
            TNombre.TabIndex = 8;
            // 
            // RBInactivo
            // 
            RBInactivo.AutoSize = true;
            RBInactivo.Location = new Point(800, 451);
            RBInactivo.Margin = new Padding(3, 4, 3, 4);
            RBInactivo.Name = "RBInactivo";
            RBInactivo.Size = new Size(82, 24);
            RBInactivo.TabIndex = 9;
            RBInactivo.TabStop = true;
            RBInactivo.Text = "Inactivo";
            RBInactivo.UseVisualStyleBackColor = true;
            // 
            // RBActivo
            // 
            RBActivo.AutoSize = true;
            RBActivo.Location = new Point(937, 451);
            RBActivo.Margin = new Padding(3, 4, 3, 4);
            RBActivo.Name = "RBActivo";
            RBActivo.Size = new Size(72, 24);
            RBActivo.TabIndex = 10;
            RBActivo.TabStop = true;
            RBActivo.Text = "Activo";
            RBActivo.UseVisualStyleBackColor = true;
            // 
            // RBTodos
            // 
            RBTodos.AutoSize = true;
            RBTodos.Location = new Point(1066, 451);
            RBTodos.Margin = new Padding(3, 4, 3, 4);
            RBTodos.Name = "RBTodos";
            RBTodos.Size = new Size(70, 24);
            RBTodos.TabIndex = 11;
            RBTodos.TabStop = true;
            RBTodos.Text = "Todos";
            RBTodos.UseVisualStyleBackColor = true;
            // 
            // BFiltrar
            // 
            BFiltrar.Location = new Point(1333, 443);
            BFiltrar.Margin = new Padding(3, 4, 3, 4);
            BFiltrar.Name = "BFiltrar";
            BFiltrar.Size = new Size(86, 31);
            BFiltrar.TabIndex = 12;
            BFiltrar.Text = "Filtrar";
            BFiltrar.UseVisualStyleBackColor = true;
            BFiltrar.Click += BFiltrar_Click;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1545, 972);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProducto";
            Text = "FormProducto";
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