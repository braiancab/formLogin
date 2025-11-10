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
            dataGridView1.Location = new Point(152, 288);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1255, 501);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BVolver);
            panel1.Controls.Add(LTitulo);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 133);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 101);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Volver";
            // 
            // BVolver
            // 
            BVolver.Image = Properties.Resources.volver;
            BVolver.Location = new Point(17, 4);
            BVolver.Margin = new Padding(3, 4, 3, 4);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(91, 93);
            BVolver.TabIndex = 1;
            BVolver.UseVisualStyleBackColor = true;
            BVolver.Click += BVolver_Click;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo.Location = new Point(683, 33);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(179, 46);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "Historial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(691, 259);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // BFiltrar
            // 
            BFiltrar.Location = new Point(1310, 253);
            BFiltrar.Margin = new Padding(3, 4, 3, 4);
            BFiltrar.Name = "BFiltrar";
            BFiltrar.Size = new Size(86, 31);
            BFiltrar.TabIndex = 3;
            BFiltrar.Text = "Filtrar";
            BFiltrar.UseVisualStyleBackColor = true;
            BFiltrar.Click += BFiltrar_Click;
            // 
            // TNombreFiltro
            // 
            TNombreFiltro.Location = new Point(763, 253);
            TNombreFiltro.Margin = new Padding(3, 4, 3, 4);
            TNombreFiltro.Name = "TNombreFiltro";
            TNombreFiltro.Size = new Size(201, 27);
            TNombreFiltro.TabIndex = 4;
            // 
            // RBTodos
            // 
            RBTodos.AutoSize = true;
            RBTodos.Location = new Point(1089, 259);
            RBTodos.Margin = new Padding(3, 4, 3, 4);
            RBTodos.Name = "RBTodos";
            RBTodos.Size = new Size(117, 24);
            RBTodos.TabIndex = 5;
            RBTodos.TabStop = true;
            RBTodos.Text = "Mostrar todo";
            RBTodos.UseVisualStyleBackColor = true;
            // 
            // formHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 972);
            Controls.Add(RBTodos);
            Controls.Add(TNombreFiltro);
            Controls.Add(BFiltrar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formHistorial";
            Text = "formHistorial";
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