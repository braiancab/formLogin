namespace formLogin
{
    partial class FormAgregarProducto
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
            BSalir = new Button();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            TTalle = new TextBox();
            LColor = new Label();
            LTalle = new Label();
            comboBox1 = new ComboBox();
            LCategoria = new Label();
            TStock = new TextBox();
            LStock = new Label();
            TPrecio = new TextBox();
            LPrecio = new Label();
            TDescripcion = new TextBox();
            TNombre = new TextBox();
            LNombre = new Label();
            LDescripcion = new Label();
            BAgregar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LProductos);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(BSalir);
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
            LProductos.TabIndex = 2;
            LProductos.Text = "Productos";
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
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(TTalle);
            panel2.Controls.Add(LColor);
            panel2.Controls.Add(LTalle);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(LCategoria);
            panel2.Controls.Add(TStock);
            panel2.Controls.Add(LStock);
            panel2.Controls.Add(TPrecio);
            panel2.Controls.Add(LPrecio);
            panel2.Controls.Add(TDescripcion);
            panel2.Controls.Add(TNombre);
            panel2.Controls.Add(LNombre);
            panel2.Controls.Add(LDescripcion);
            panel2.Location = new Point(145, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 232);
            panel2.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(417, 98);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            // 
            // TTalle
            // 
            TTalle.Location = new Point(107, 98);
            TTalle.Name = "TTalle";
            TTalle.Size = new Size(100, 23);
            TTalle.TabIndex = 12;
            // 
            // LColor
            // 
            LColor.AutoSize = true;
            LColor.Location = new Point(357, 101);
            LColor.Name = "LColor";
            LColor.Size = new Size(39, 15);
            LColor.TabIndex = 11;
            LColor.Text = "Color:";
            // 
            // LTalle
            // 
            LTalle.AutoSize = true;
            LTalle.Location = new Point(53, 101);
            LTalle.Name = "LTalle";
            LTalle.Size = new Size(33, 15);
            LTalle.TabIndex = 10;
            LTalle.Text = "Talle:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Location = new Point(22, 140);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(64, 15);
            LCategoria.TabIndex = 8;
            LCategoria.Text = "Categoria: ";
            // 
            // TStock
            // 
            TStock.Location = new Point(417, 63);
            TStock.Name = "TStock";
            TStock.Size = new Size(100, 23);
            TStock.TabIndex = 7;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(357, 66);
            LStock.Name = "LStock";
            LStock.Size = new Size(39, 15);
            LStock.TabIndex = 6;
            LStock.Text = "Stock:";
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(107, 63);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(100, 23);
            TPrecio.TabIndex = 5;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Location = new Point(43, 66);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(43, 15);
            LPrecio.TabIndex = 4;
            LPrecio.Text = "Precio:";
            // 
            // TDescripcion
            // 
            TDescripcion.Location = new Point(417, 25);
            TDescripcion.Name = "TDescripcion";
            TDescripcion.Size = new Size(180, 23);
            TDescripcion.TabIndex = 3;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(107, 25);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(180, 23);
            TNombre.TabIndex = 2;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(29, 28);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(57, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre: ";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Location = new Point(324, 28);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(72, 15);
            LDescripcion.TabIndex = 0;
            LDescripcion.Text = "Descripcion:";
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(449, 356);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(75, 23);
            BAgregar.TabIndex = 2;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // FormAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(926, 562);
            Controls.Add(BAgregar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAgregarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BSalir;
        private Label LVolver;
        private Label LProductos;
        private Panel panel2;
        private Label LNombre;
        private Label LDescripcion;
        private TextBox TNombre;
        private TextBox TDescripcion;
        private Label LCategoria;
        private TextBox TStock;
        private Label LStock;
        private TextBox TPrecio;
        private Label LPrecio;
        private ComboBox comboBox1;
        private Button BAgregar;
        private TextBox TTalle;
        private Label LColor;
        private Label LTalle;
        private ComboBox comboBox2;
    }
}