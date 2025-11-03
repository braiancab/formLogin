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
            LFecha = new Label();
            LNombreVendedor = new Label();
            BNuevoCliente = new Button();
            comboBox2 = new ComboBox();
            LCliente = new Label();
            LVendedor = new Label();
            comboBox1 = new ComboBox();
            BGuardar = new Button();
            BCancelar = new Button();
            panel3 = new Panel();
            TTalle = new TextBox();
            LTalle = new Label();
            TPrecio = new TextBox();
            LPrecio = new Label();
            TStock = new TextBox();
            LStock = new Label();
            TCantidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            LDescuento = new Label();
            textBox1 = new TextBox();
            TTotal = new TextBox();
            LTotal = new Label();
            BAgregar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(1328, 100);
            panel1.TabIndex = 0;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LVentas.Location = new Point(559, 26);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(123, 37);
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
            panel2.Controls.Add(LFecha);
            panel2.Controls.Add(LNombreVendedor);
            panel2.Controls.Add(BNuevoCliente);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(LCliente);
            panel2.Controls.Add(LVendedor);
            panel2.Location = new Point(337, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 104);
            panel2.TabIndex = 1;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Location = new Point(353, 12);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(38, 15);
            LFecha.TabIndex = 21;
            LFecha.Text = "Fecha";
            // 
            // LNombreVendedor
            // 
            LNombreVendedor.AutoSize = true;
            LNombreVendedor.Location = new Point(84, 12);
            LNombreVendedor.Name = "LNombreVendedor";
            LNombreVendedor.Size = new Size(38, 15);
            LNombreVendedor.TabIndex = 20;
            LNombreVendedor.Text = "label1";
            // 
            // BNuevoCliente
            // 
            BNuevoCliente.BackColor = Color.MintCream;
            BNuevoCliente.Image = Properties.Resources.nueva_cuenta__1_;
            BNuevoCliente.Location = new Point(506, 54);
            BNuevoCliente.Name = "BNuevoCliente";
            BNuevoCliente.Size = new Size(75, 23);
            BNuevoCliente.TabIndex = 19;
            BNuevoCliente.UseVisualStyleBackColor = false;
            BNuevoCliente.Click += BNuevoCliente_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(147, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(330, 23);
            comboBox2.TabIndex = 3;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Location = new Point(13, 58);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(109, 15);
            LCliente.TabIndex = 2;
            LCliente.Text = "Seleccione Cliente: ";
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.Location = new Point(13, 12);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(63, 15);
            LVendedor.TabIndex = 0;
            LVendedor.Text = "Vendedor: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(765, 542);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 2;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(857, 542);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(75, 23);
            BCancelar.TabIndex = 3;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(LTotal);
            panel3.Controls.Add(BAgregar);
            panel3.Controls.Add(TTotal);
            panel3.Controls.Add(TTalle);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(LDescuento);
            panel3.Controls.Add(LTalle);
            panel3.Controls.Add(TPrecio);
            panel3.Controls.Add(TCantidad);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(LPrecio);
            panel3.Controls.Add(TStock);
            panel3.Controls.Add(LStock);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(comboBox1);
            panel3.Location = new Point(337, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(595, 183);
            panel3.TabIndex = 22;
            // 
            // TTalle
            // 
            TTalle.Location = new Point(481, 74);
            TTalle.Name = "TTalle";
            TTalle.Size = new Size(100, 23);
            TTalle.TabIndex = 31;
            // 
            // LTalle
            // 
            LTalle.AutoSize = true;
            LTalle.Location = new Point(439, 77);
            LTalle.Name = "LTalle";
            LTalle.Size = new Size(36, 15);
            LTalle.TabIndex = 30;
            LTalle.Text = "Talle: ";
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(276, 74);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(100, 23);
            TPrecio.TabIndex = 29;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Location = new Point(224, 77);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(46, 15);
            LPrecio.TabIndex = 28;
            LPrecio.Text = "Precio: ";
            // 
            // TStock
            // 
            TStock.Location = new Point(61, 74);
            TStock.Name = "TStock";
            TStock.Size = new Size(100, 23);
            TStock.TabIndex = 27;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(13, 78);
            LStock.Name = "LStock";
            LStock.Size = new Size(42, 15);
            LStock.TabIndex = 26;
            LStock.Text = "Stock: ";
            // 
            // TCantidad
            // 
            TCantidad.Location = new Point(61, 148);
            TCantidad.Name = "TCantidad";
            TCantidad.Size = new Size(100, 23);
            TCantidad.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 130);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 24;
            label2.Text = "Cantidad: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 23;
            label1.Text = "Seleccione producto: ";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(337, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(595, 67);
            panel4.TabIndex = 26;
            // 
            // LDescuento
            // 
            LDescuento.AutoSize = true;
            LDescuento.Location = new Point(222, 130);
            LDescuento.Name = "LDescuento";
            LDescuento.Size = new Size(66, 15);
            LDescuento.TabIndex = 26;
            LDescuento.Text = "Descuento:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 27;
            // 
            // TTotal
            // 
            TTotal.Location = new Point(377, 148);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(100, 23);
            TTotal.TabIndex = 28;
            // 
            // LTotal
            // 
            LTotal.AutoSize = true;
            LTotal.Location = new Point(377, 130);
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(35, 15);
            LTotal.TabIndex = 29;
            LTotal.Text = "Total:";
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(506, 148);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(75, 23);
            BAgregar.TabIndex = 32;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1352, 729);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(BCancelar);
            Controls.Add(BGuardar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCarrito";
            Text = "ma";
            WindowState = FormWindowState.Maximized;
            Load += FormCarrito_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button BGuardar;
        private Button BCancelar;
        private Button BNuevoCliente;
        private Label LNombreVendedor;
        private ComboBox comboBox1;
        private Label LFecha;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private TextBox TCantidad;
        private TextBox TStock;
        private Label LStock;
        private TextBox TPrecio;
        private Label LPrecio;
        private TextBox TTalle;
        private Label LTalle;
        private Panel panel4;
        private Label LTotal;
        private TextBox TTotal;
        private TextBox textBox1;
        private Label LDescuento;
        private Button BAgregar;
    }
}