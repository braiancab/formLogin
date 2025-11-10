namespace formLogin
{
    partial class formHistorial
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            BVolver = new Button();
            LTitulo = new Label();
            label2 = new Label();
            BFiltrar = new Button();
            TNombreFiltro = new TextBox();
            RBTodos = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(133, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1098, 376);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BVolver);
            panel1.Controls.Add(LTitulo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 76);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Volver";
            // 
            // BVolver
            // 
            BVolver.Image = Properties.Resources.volver;
            BVolver.Location = new Point(15, 3);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(80, 70);
            BVolver.TabIndex = 1;
            BVolver.UseVisualStyleBackColor = true;
            BVolver.Click += BVolver_Click;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo.Location = new Point(598, 25);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(148, 37);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "Historial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(605, 194);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // BFiltrar
            // 
            BFiltrar.Location = new Point(1146, 190);
            BFiltrar.Name = "BFiltrar";
            BFiltrar.Size = new Size(75, 23);
            BFiltrar.TabIndex = 3;
            BFiltrar.Text = "Filtrar";
            BFiltrar.UseVisualStyleBackColor = true;
            BFiltrar.Click += BFiltrar_Click;
            // 
            // TNombreFiltro
            // 
            TNombreFiltro.Location = new Point(668, 190);
            TNombreFiltro.Name = "TNombreFiltro";
            TNombreFiltro.Size = new Size(176, 23);
            TNombreFiltro.TabIndex = 4;
            // 
            // RBTodos
            // 
            RBTodos.AutoSize = true;
            RBTodos.Location = new Point(953, 194);
            RBTodos.Name = "RBTodos";
            RBTodos.Size = new Size(94, 19);
            RBTodos.TabIndex = 5;
            RBTodos.TabStop = true;
            RBTodos.Text = "Mostrar todo";
            RBTodos.UseVisualStyleBackColor = true;
            // 
            // formHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 729);
            Controls.Add(RBTodos);
            Controls.Add(TNombreFiltro);
            Controls.Add(BFiltrar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "formHistorial";
            Text = "formHistorial";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label LTitulo;
        private Button BVolver;
        private Label label1;
        private Label label2;
        private Button BFiltrar;
        private TextBox TNombreFiltro;
        private RadioButton RBTodos;
    }
}