namespace formLogin
{
    partial class FormCarrito
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
            LVentas = new Label();
            LVolver = new Label();
            BSalir = new Button();
            panel2 = new Panel();
            TVendedor = new TextBox();
            numericUpDown1 = new NumericUpDown();
            LCantidad = new Label();
            TDescripcion = new TextBox();
            LDescripcion = new Label();
            comboBox3 = new ComboBox();
            LProductos = new Label();
            comboBox2 = new ComboBox();
            LCliente = new Label();
            LVendedor = new Label();
            LFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            LStock = new Label();
            textBox1 = new TextBox();
            LFactura = new Label();
            comboBox1 = new ComboBox();
            BGuardar = new Button();
            BCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LVentas);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(BSalir);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 100);
            panel1.TabIndex = 0;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LVentas.Location = new Point(392, 26);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(105, 37);
            LVentas.TabIndex = 1;
            LVentas.Text = "Ventas";
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(32, 76);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(39, 15);
            LVolver.TabIndex = 1;
            LVolver.Text = "Volver";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.volver;
            BSalir.Location = new Point(13, 3);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(80, 70);
            BSalir.TabIndex = 1;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(LFactura);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(LStock);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(LFecha);
            panel2.Controls.Add(TVendedor);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(LCantidad);
            panel2.Controls.Add(TDescripcion);
            panel2.Controls.Add(LDescripcion);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(LProductos);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(LCliente);
            panel2.Controls.Add(LVendedor);
            panel2.Location = new Point(145, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 232);
            panel2.TabIndex = 1;
            // 
            // TVendedor
            // 
            TVendedor.Location = new Point(69, 3);
            TVendedor.Name = "TVendedor";
            TVendedor.Size = new Size(180, 23);
            TVendedor.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(128, 81);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // LCantidad
            // 
            LCantidad.AutoSize = true;
            LCantidad.Location = new Point(0, 83);
            LCantidad.Name = "LCantidad";
            LCantidad.Size = new Size(61, 15);
            LCantidad.TabIndex = 8;
            LCantidad.Text = "Cantidad: ";
            // 
            // TDescripcion
            // 
            TDescripcion.Location = new Point(337, 42);
            TDescripcion.Name = "TDescripcion";
            TDescripcion.Size = new Size(299, 23);
            TDescripcion.TabIndex = 7;
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Location = new Point(256, 45);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(75, 15);
            LDescripcion.TabIndex = 6;
            LDescripcion.Text = "Descripcion: ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(128, 42);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 5;
            // 
            // LProductos
            // 
            LProductos.AutoSize = true;
            LProductos.Location = new Point(0, 45);
            LProductos.Name = "LProductos";
            LProductos.Size = new Size(121, 15);
            LProductos.TabIndex = 4;
            LProductos.Text = "Seleccione Producto: ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(463, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Location = new Point(348, 6);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(109, 15);
            LCliente.TabIndex = 2;
            LCliente.Text = "Seleccione Cliente: ";
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.Location = new Point(0, 6);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(63, 15);
            LVendedor.TabIndex = 0;
            LVendedor.Text = "Vendedor: ";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Location = new Point(259, 89);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(44, 15);
            LFecha.TabIndex = 11;
            LFecha.Text = "Fecha: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(337, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(0, 124);
            LStock.Name = "LStock";
            LStock.Size = new Size(42, 15);
            LStock.TabIndex = 13;
            LStock.Text = "Stock: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 14;
            // 
            // LFactura
            // 
            LFactura.AutoSize = true;
            LFactura.Location = new Point(259, 129);
            LFactura.Name = "LFactura";
            LFactura.Size = new Size(76, 15);
            LFactura.TabIndex = 15;
            LFactura.Text = "Factura tipo: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(337, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 16;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(633, 369);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 2;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(725, 369);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(75, 23);
            BCancelar.TabIndex = 3;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(926, 606);
            Controls.Add(BCancelar);
            Controls.Add(BGuardar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCarrito";
            Text = "FormCarrito";
            Load += FormCarrito_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BSalir;
        private Label LVolver;
        private Label LVentas;
        private Panel panel2;
        private Label LVendedor;
        private ComboBox comboBox2;
        private Label LCliente;
        private TextBox TDescripcion;
        private Label LDescripcion;
        private ComboBox comboBox3;
        private Label LProductos;
        private TextBox TVendedor;
        private NumericUpDown numericUpDown1;
        private Label LCantidad;
        private ComboBox comboBox1;
        private Label LFactura;
        private TextBox textBox1;
        private Label LStock;
        private DateTimePicker dateTimePicker1;
        private Label LFecha;
        private Button BGuardar;
        private Button BCancelar;
    }
}