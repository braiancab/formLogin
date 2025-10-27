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
            panel1.Size = new Size(1035, 133);
            panel1.TabIndex = 0;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(863, 21);
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
            LProductos.Location = new Point(448, 35);
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 269);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1035, 389);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbTamanioPagina
            // 
            cmbTamanioPagina.FormattingEnabled = true;
            cmbTamanioPagina.Location = new Point(20, 196);
            cmbTamanioPagina.Name = "cmbTamanioPagina";
            cmbTamanioPagina.Size = new Size(151, 28);
            cmbTamanioPagina.TabIndex = 3;
            cmbTamanioPagina.SelectedIndexChanged += cmbTamanioPagina_SelectedIndexChanged;
            // 
            // labelPagina
            // 
            labelPagina.AutoSize = true;
            labelPagina.Location = new Point(19, 164);
            labelPagina.Name = "labelPagina";
            labelPagina.Size = new Size(60, 20);
            labelPagina.TabIndex = 4;
            labelPagina.Text = "Mostrar";
            labelPagina.Click += labelPagina_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(304, 203);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(156, 29);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = "<< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(488, 203);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(156, 29);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = ">> Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1058, 749);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(labelPagina);
            Controls.Add(cmbTamanioPagina);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
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
    }
}