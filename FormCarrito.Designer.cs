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
            BFinalizar = new Button();
            BCancelar = new Button();
            panel3 = new Panel();
            LTotal = new Label();
            BAgregar = new Button();
            TTotal = new TextBox();
            TTalle = new TextBox();
            TDescuento = new TextBox();
            LDescuento = new Label();
            LTalle = new Label();
            TPrecio = new TextBox();
            TCantidad = new TextBox();
            label2 = new Label();
            LPrecio = new Label();
            TStock = new TextBox();
            LStock = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            BFinalizarGuardar = new Button();
            TTotalVenta = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LVentas);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(BSalir);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 133);
            panel1.TabIndex = 0;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LVentas.Location = new Point(639, 35);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(150, 46);
            LVentas.TabIndex = 1;
            LVentas.Text = "Ventas";
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(37, 101);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(50, 20);
            LVolver.TabIndex = 1;
            LVolver.Text = "Volver";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.volver;
            BSalir.Location = new Point(15, 4);
            BSalir.Margin = new Padding(3, 4, 3, 4);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(91, 93);
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
            panel2.Location = new Point(61, 171);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 139);
            panel2.TabIndex = 1;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Location = new Point(384, 16);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(47, 20);
            LFecha.TabIndex = 21;
            LFecha.Text = "Fecha";
            // 
            // LNombreVendedor
            // 
            LNombreVendedor.AutoSize = true;
            LNombreVendedor.Location = new Point(96, 16);
            LNombreVendedor.Name = "LNombreVendedor";
            LNombreVendedor.Size = new Size(50, 20);
            LNombreVendedor.TabIndex = 20;
            LNombreVendedor.Text = "label1";
            // 
            // BNuevoCliente
            // 
            BNuevoCliente.BackColor = Color.MintCream;
            BNuevoCliente.Image = Properties.Resources.nueva_cuenta__1_;
            BNuevoCliente.Location = new Point(501, 72);
            BNuevoCliente.Margin = new Padding(3, 4, 3, 4);
            BNuevoCliente.Name = "BNuevoCliente";
            BNuevoCliente.Size = new Size(86, 31);
            BNuevoCliente.TabIndex = 19;
            BNuevoCliente.UseVisualStyleBackColor = false;
            BNuevoCliente.Click += BNuevoCliente_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(168, 72);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(303, 28);
            comboBox2.TabIndex = 3;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Location = new Point(15, 77);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(137, 20);
            LCliente.TabIndex = 2;
            LCliente.Text = "Seleccione Cliente: ";
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.Location = new Point(15, 16);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(80, 20);
            LVendedor.TabIndex = 0;
            LVendedor.Text = "Vendedor: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(168, 39);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(303, 28);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BFinalizar
            // 
            BFinalizar.Location = new Point(87, 33);
            BFinalizar.Margin = new Padding(3, 4, 3, 4);
            BFinalizar.Name = "BFinalizar";
            BFinalizar.Size = new Size(86, 31);
            BFinalizar.TabIndex = 2;
            BFinalizar.Text = "Finalizar";
            BFinalizar.UseVisualStyleBackColor = true;
            BFinalizar.Click += BFinalizar_Click;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(192, 33);
            BCancelar.Margin = new Padding(3, 4, 3, 4);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(86, 31);
            BCancelar.TabIndex = 3;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(LTotal);
            panel3.Controls.Add(BAgregar);
            panel3.Controls.Add(TTotal);
            panel3.Controls.Add(TTalle);
            panel3.Controls.Add(TDescuento);
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
            panel3.Location = new Point(61, 317);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(599, 244);
            panel3.TabIndex = 22;
            // 
            // LTotal
            // 
            LTotal.AutoSize = true;
            LTotal.Location = new Point(384, 168);
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(45, 20);
            LTotal.TabIndex = 29;
            LTotal.Text = "Total:";
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(501, 192);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(86, 31);
            BAgregar.TabIndex = 32;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // TTotal
            // 
            TTotal.Location = new Point(384, 192);
            TTotal.Margin = new Padding(3, 4, 3, 4);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(87, 27);
            TTotal.TabIndex = 28;
            // 
            // TTalle
            // 
            TTalle.Location = new Point(384, 115);
            TTalle.Margin = new Padding(3, 4, 3, 4);
            TTalle.Name = "TTalle";
            TTalle.Size = new Size(87, 27);
            TTalle.TabIndex = 31;
            // 
            // TDescuento
            // 
            TDescuento.Location = new Point(207, 192);
            TDescuento.Margin = new Padding(3, 4, 3, 4);
            TDescuento.Name = "TDescuento";
            TDescuento.Size = new Size(87, 27);
            TDescuento.TabIndex = 27;
            TDescuento.TextChanged += TDescuento_TextChanged;
            // 
            // LDescuento
            // 
            LDescuento.AutoSize = true;
            LDescuento.Location = new Point(207, 168);
            LDescuento.Name = "LDescuento";
            LDescuento.Size = new Size(82, 20);
            LDescuento.TabIndex = 26;
            LDescuento.Text = "Descuento:";
            // 
            // LTalle
            // 
            LTalle.AutoSize = true;
            LTalle.Location = new Point(384, 91);
            LTalle.Name = "LTalle";
            LTalle.Size = new Size(46, 20);
            LTalle.TabIndex = 30;
            LTalle.Text = "Talle: ";
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(207, 115);
            TPrecio.Margin = new Padding(3, 4, 3, 4);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(87, 27);
            TPrecio.TabIndex = 29;
            // 
            // TCantidad
            // 
            TCantidad.Location = new Point(23, 192);
            TCantidad.Margin = new Padding(3, 4, 3, 4);
            TCantidad.Name = "TCantidad";
            TCantidad.Size = new Size(87, 27);
            TCantidad.TabIndex = 25;
            TCantidad.TextChanged += TCantidad_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 168);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 24;
            label2.Text = "Cantidad: ";
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Location = new Point(207, 91);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(57, 20);
            LPrecio.TabIndex = 28;
            LPrecio.Text = "Precio: ";
            // 
            // TStock
            // 
            TStock.Location = new Point(23, 115);
            TStock.Margin = new Padding(3, 4, 3, 4);
            TStock.Name = "TStock";
            TStock.Size = new Size(87, 27);
            TStock.TabIndex = 27;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(23, 91);
            LStock.Name = "LStock";
            LStock.Size = new Size(52, 20);
            LStock.TabIndex = 26;
            LStock.Text = "Stock: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 23;
            label1.Text = "Seleccione producto: ";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(BFinalizarGuardar);
            panel4.Controls.Add(TTotalVenta);
            panel4.Controls.Add(BCancelar);
            panel4.Controls.Add(BFinalizar);
            panel4.Location = new Point(61, 600);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1439, 89);
            panel4.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1049, 47);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 30;
            label3.Text = "Total de la compra: ";
            // 
            // BFinalizarGuardar
            // 
            BFinalizarGuardar.Location = new Point(309, 35);
            BFinalizarGuardar.Margin = new Padding(3, 4, 3, 4);
            BFinalizarGuardar.Name = "BFinalizarGuardar";
            BFinalizarGuardar.Size = new Size(163, 31);
            BFinalizarGuardar.TabIndex = 29;
            BFinalizarGuardar.Text = "Imprimir";
            BFinalizarGuardar.UseVisualStyleBackColor = true;
            BFinalizarGuardar.Click += BFinalizarGuardar_Click;
            // 
            // TTotalVenta
            // 
            TTotalVenta.Location = new Point(1195, 36);
            TTotalVenta.Margin = new Padding(3, 4, 3, 4);
            TTotalVenta.Name = "TTotalVenta";
            TTotalVenta.Size = new Size(220, 27);
            TTotalVenta.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(688, 171);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(811, 388);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1545, 972);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCarrito";
            Text = "ma";
            Load += FormCarrito_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button BFinalizar;
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
        private TextBox TDescuento;
        private Label LDescuento;
        private Button BAgregar;
        private DataGridView dataGridView1;
        private TextBox TTotalVenta;
        private Button BFinalizarGuardar;
        private Label label3;
    }
}