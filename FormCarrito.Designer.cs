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
            comboBox1 = new ComboBox();
            LNombreVendedor = new Label();
            BNuevoCliente = new Button();
            comboBox2 = new ComboBox();
            LCliente = new Label();
            LVendedor = new Label();
            BGuardar = new Button();
            BCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(LNombreVendedor);
            panel2.Controls.Add(BNuevoCliente);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(LCliente);
            panel2.Controls.Add(LVendedor);
            panel2.Location = new Point(303, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 104);
            panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(456, 392);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
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
            comboBox2.Location = new Point(134, 54);
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
            // BGuardar
            // 
            BGuardar.Location = new Point(791, 461);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 2;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(883, 461);
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
            ClientSize = new Size(1352, 729);
            Controls.Add(comboBox1);
            Controls.Add(BCancelar);
            Controls.Add(BGuardar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCarrito";
            Text = "FormCarrito";
            WindowState = FormWindowState.Maximized;
            Load += FormCarrito_Load;
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
    }
}