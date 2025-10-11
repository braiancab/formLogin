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
            TPrecio = new TextBox();
            TMarca = new TextBox();
            TStock = new TextBox();
            TDescripcion = new TextBox();
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
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 133);
            panel1.TabIndex = 0;
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
            panel2.Location = new Point(166, 157);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 309);
            panel2.TabIndex = 1;
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(120, 213);
            TPrecio.Margin = new Padding(3, 4, 3, 4);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(241, 27);
            TPrecio.TabIndex = 20;
            // 
            // TMarca
            // 
            TMarca.Location = new Point(120, 135);
            TMarca.Margin = new Padding(3, 4, 3, 4);
            TMarca.Name = "TMarca";
            TMarca.Size = new Size(241, 27);
            TMarca.TabIndex = 19;
            // 
            // TStock
            // 
            TStock.Location = new Point(120, 96);
            TStock.Margin = new Padding(3, 4, 3, 4);
            TStock.Name = "TStock";
            TStock.Size = new Size(241, 27);
            TStock.TabIndex = 18;
            // 
            // TDescripcion
            // 
            TDescripcion.Location = new Point(120, 57);
            TDescripcion.Margin = new Padding(3, 4, 3, 4);
            TDescripcion.Name = "TDescripcion";
            TDescripcion.Size = new Size(241, 27);
            TDescripcion.TabIndex = 17;
            // 
            // BCargar
            // 
            BCargar.Location = new Point(552, 217);
            BCargar.Margin = new Padding(3, 4, 3, 4);
            BCargar.Name = "BCargar";
            BCargar.Size = new Size(86, 31);
            BCargar.TabIndex = 16;
            BCargar.Text = "Cargar";
            BCargar.UseVisualStyleBackColor = true;
            BCargar.Click += BCargar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(504, 45);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 153);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(120, 252);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(120, 175);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 13;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(120, 17);
            TNombre.Margin = new Padding(3, 4, 3, 4);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(241, 27);
            TNombre.TabIndex = 7;
            // 
            // LMarca
            // 
            LMarca.AutoSize = true;
            LMarca.Location = new Point(3, 140);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(57, 20);
            LMarca.TabIndex = 6;
            LMarca.Text = "Marca: ";
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Location = new Point(3, 179);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(81, 20);
            LCategoria.TabIndex = 5;
            LCategoria.Text = "Categoria: ";
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Location = new Point(6, 251);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(61, 20);
            LEstado.TabIndex = 4;
            LEstado.Text = "Estado: ";
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(3, 100);
            LStock.Name = "LStock";
            LStock.Size = new Size(52, 20);
            LStock.TabIndex = 3;
            LStock.Text = "Stock: ";
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Location = new Point(6, 217);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(57, 20);
            LPrecio.TabIndex = 2;
            LPrecio.Text = "Precio: ";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Location = new Point(3, 61);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(94, 20);
            LDescripcion.TabIndex = 1;
            LDescripcion.Text = "Descripcion: ";
            // 
            // LNombreProducto
            // 
            LNombreProducto.AutoSize = true;
            LNombreProducto.Location = new Point(3, 21);
            LNombreProducto.Name = "LNombreProducto";
            LNombreProducto.Size = new Size(71, 20);
            LNombreProducto.TabIndex = 0;
            LNombreProducto.Text = "Nombre: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 560);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1035, 200);
            dataGridView1.TabIndex = 2;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(864, 475);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(86, 31);
            BAgregar.TabIndex = 3;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(765, 475);
            BActualizar.Margin = new Padding(3, 4, 3, 4);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(86, 31);
            BActualizar.TabIndex = 4;
            BActualizar.Text = "Actualizar";
            BActualizar.UseVisualStyleBackColor = true;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(963, 473);
            BEliminar.Margin = new Padding(3, 4, 3, 4);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(86, 31);
            BEliminar.TabIndex = 5;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1058, 808);
            Controls.Add(BEliminar);
            Controls.Add(BActualizar);
            Controls.Add(BAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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