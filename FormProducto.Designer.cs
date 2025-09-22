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
            LProductos = new Label();
            LVolver = new Label();
            BVolver = new Button();
            panel2 = new Panel();
            BCargar = new Button();
            pictureBox1 = new PictureBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            TNombre = new TextBox();
            LMarca = new Label();
            LCategoria = new Label();
            LEstado = new Label();
            LStock = new Label();
            LPrecio = new Label();
            LDescripcion = new Label();
            LNombreProducto = new Label();
            TDescripcion = new TextBox();
            TStock = new TextBox();
            TMarca = new TextBox();
            TPrecio = new TextBox();
            dataGridView1 = new DataGridView();
            BAgregar = new Button();
            BActualizar = new Button();
            BEliminar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LProductos);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(BVolver);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 100);
            panel1.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(TPrecio);
            panel2.Controls.Add(TMarca);
            panel2.Controls.Add(TStock);
            panel2.Controls.Add(TDescripcion);
            panel2.Controls.Add(BCargar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(TNombre);
            panel2.Controls.Add(LMarca);
            panel2.Controls.Add(LCategoria);
            panel2.Controls.Add(LEstado);
            panel2.Controls.Add(LStock);
            panel2.Controls.Add(LPrecio);
            panel2.Controls.Add(LDescripcion);
            panel2.Controls.Add(LNombreProducto);
            panel2.Location = new Point(145, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 232);
            panel2.TabIndex = 1;
            // 
            // BCargar
            // 
            BCargar.Location = new Point(483, 163);
            BCargar.Name = "BCargar";
            BCargar.Size = new Size(75, 23);
            BCargar.TabIndex = 16;
            BCargar.Text = "Cargar";
            BCargar.UseVisualStyleBackColor = true;
            BCargar.Click += BCargar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(441, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 115);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(105, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(105, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(105, 13);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(211, 23);
            TNombre.TabIndex = 7;
            // 
            // LMarca
            // 
            LMarca.AutoSize = true;
            LMarca.Location = new Point(3, 105);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(46, 15);
            LMarca.TabIndex = 6;
            LMarca.Text = "Marca: ";
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Location = new Point(3, 134);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(64, 15);
            LCategoria.TabIndex = 5;
            LCategoria.Text = "Categoria: ";
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Location = new Point(5, 188);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(48, 15);
            LEstado.TabIndex = 4;
            LEstado.Text = "Estado: ";
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(3, 75);
            LStock.Name = "LStock";
            LStock.Size = new Size(42, 15);
            LStock.TabIndex = 3;
            LStock.Text = "Stock: ";
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Location = new Point(5, 163);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(46, 15);
            LPrecio.TabIndex = 2;
            LPrecio.Text = "Precio: ";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Location = new Point(3, 46);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(75, 15);
            LDescripcion.TabIndex = 1;
            LDescripcion.Text = "Descripcion: ";
            // 
            // LNombreProducto
            // 
            LNombreProducto.AutoSize = true;
            LNombreProducto.Location = new Point(3, 16);
            LNombreProducto.Name = "LNombreProducto";
            LNombreProducto.Size = new Size(57, 15);
            LNombreProducto.TabIndex = 0;
            LNombreProducto.Text = "Nombre: ";
            // 
            // TDescripcion
            // 
            TDescripcion.Location = new Point(105, 43);
            TDescripcion.Name = "TDescripcion";
            TDescripcion.Size = new Size(211, 23);
            TDescripcion.TabIndex = 17;
            // 
            // TStock
            // 
            TStock.Location = new Point(105, 72);
            TStock.Name = "TStock";
            TStock.Size = new Size(211, 23);
            TStock.TabIndex = 18;
            // 
            // TMarca
            // 
            TMarca.Location = new Point(105, 101);
            TMarca.Name = "TMarca";
            TMarca.Size = new Size(211, 23);
            TMarca.TabIndex = 19;
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(105, 160);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(211, 23);
            TPrecio.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(906, 150);
            dataGridView1.TabIndex = 2;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(756, 356);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(75, 23);
            BAgregar.TabIndex = 3;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(669, 356);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(75, 23);
            BActualizar.TabIndex = 4;
            BActualizar.Text = "Actualizar";
            BActualizar.UseVisualStyleBackColor = true;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(843, 355);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 5;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(926, 606);
            Controls.Add(BEliminar);
            Controls.Add(BActualizar);
            Controls.Add(BAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormProducto";
            Text = "FormProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BVolver;
        private Label LProductos;
        private Label LVolver;
        private Panel panel2;
        private Label LCategoria;
        private Label LEstado;
        private Label LStock;
        private Label LPrecio;
        private Label LDescripcion;
        private Label LNombreProducto;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox TNombre;
        private Label LMarca;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button BCargar;
        private PictureBox pictureBox1;
        private TextBox TPrecio;
        private TextBox TMarca;
        private TextBox TStock;
        private TextBox TDescripcion;
        private DataGridView dataGridView1;
        private Button BAgregar;
        private Button BActualizar;
        private Button BEliminar;
    }
}