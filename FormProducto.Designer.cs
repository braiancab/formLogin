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
            panel1.Size = new Size(906, 100);
            panel1.TabIndex = 0;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(755, 16);
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
            LProductos.Location = new Point(392, 26);
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(906, 292);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(926, 562);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormProducto";
            Text = "FormProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
    }
}