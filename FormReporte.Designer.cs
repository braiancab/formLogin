namespace formLogin
{
    partial class FormReporte
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
            LVolver = new Label();
            LReporte = new Label();
            BSalir = new Button();
            groupBox1 = new GroupBox();
            BGenerar = new Button();
            RBRecaudacion = new RadioButton();
            RBProductos = new RadioButton();
            LTipoReporte = new Label();
            RBVentas = new RadioButton();
            LNombreVendedor = new Label();
            dateTimePicker2 = new DateTimePicker();
            TNombre = new TextBox();
            BBuscar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            LTextoReporte = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(LReporte);
            panel1.Controls.Add(BSalir);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 100);
            panel1.TabIndex = 0;
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
            // LReporte
            // 
            LReporte.Anchor = AnchorStyles.Top;
            LReporte.AutoSize = true;
            LReporte.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LReporte.Location = new Point(598, 25);
            LReporte.Name = "LReporte";
            LReporte.Size = new Size(155, 37);
            LReporte.TabIndex = 1;
            LReporte.Text = "Reportes";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.volver;
            BSalir.Location = new Point(15, 3);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(80, 70);
            BSalir.TabIndex = 1;
            BSalir.TabStop = false;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(BGenerar);
            groupBox1.Controls.Add(RBRecaudacion);
            groupBox1.Controls.Add(RBProductos);
            groupBox1.Controls.Add(LTipoReporte);
            groupBox1.Controls.Add(RBVentas);
            groupBox1.Controls.Add(LNombreVendedor);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(TNombre);
            groupBox1.Controls.Add(BBuscar);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LTextoReporte);
            groupBox1.Location = new Point(364, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 247);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // BGenerar
            // 
            BGenerar.Location = new Point(272, 200);
            BGenerar.Name = "BGenerar";
            BGenerar.Size = new Size(129, 23);
            BGenerar.TabIndex = 10;
            BGenerar.Text = "Generar Reporte";
            BGenerar.UseVisualStyleBackColor = true;
            // 
            // RBRecaudacion
            // 
            RBRecaudacion.AutoSize = true;
            RBRecaudacion.Location = new Point(326, 164);
            RBRecaudacion.Name = "RBRecaudacion";
            RBRecaudacion.Size = new Size(93, 19);
            RBRecaudacion.TabIndex = 9;
            RBRecaudacion.TabStop = true;
            RBRecaudacion.Text = "Recaudacion";
            RBRecaudacion.UseVisualStyleBackColor = true;
            // 
            // RBProductos
            // 
            RBProductos.AutoSize = true;
            RBProductos.Location = new Point(241, 164);
            RBProductos.Name = "RBProductos";
            RBProductos.Size = new Size(79, 19);
            RBProductos.TabIndex = 8;
            RBProductos.TabStop = true;
            RBProductos.Text = "Productos";
            RBProductos.UseVisualStyleBackColor = true;
            // 
            // LTipoReporte
            // 
            LTipoReporte.AutoSize = true;
            LTipoReporte.Location = new Point(6, 164);
            LTipoReporte.Name = "LTipoReporte";
            LTipoReporte.Size = new Size(150, 15);
            LTipoReporte.TabIndex = 7;
            LTipoReporte.Text = "Seleccione tipo de reporte: ";
            // 
            // RBVentas
            // 
            RBVentas.AutoSize = true;
            RBVentas.Location = new Point(176, 164);
            RBVentas.Name = "RBVentas";
            RBVentas.Size = new Size(59, 19);
            RBVentas.TabIndex = 6;
            RBVentas.TabStop = true;
            RBVentas.Text = "Ventas";
            RBVentas.UseVisualStyleBackColor = true;
            // 
            // LNombreVendedor
            // 
            LNombreVendedor.AutoSize = true;
            LNombreVendedor.Location = new Point(6, 93);
            LNombreVendedor.Name = "LNombreVendedor";
            LNombreVendedor.Size = new Size(110, 15);
            LNombreVendedor.TabIndex = 5;
            LNombreVendedor.Text = "Nombre vendedor: ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(449, 45);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(6, 123);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(276, 23);
            TNombre.TabIndex = 4;
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(307, 123);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(84, 23);
            BBuscar.TabIndex = 3;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(76, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 51);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Hasta: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Desde: ";
            // 
            // LTextoReporte
            // 
            LTextoReporte.AutoSize = true;
            LTextoReporte.Location = new Point(15, 19);
            LTextoReporte.Name = "LTextoReporte";
            LTextoReporte.Size = new Size(101, 15);
            LTextoReporte.TabIndex = 0;
            LTextoReporte.Text = "Seleccione fecha: ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 432);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(921, 246);
            dataGridView1.TabIndex = 2;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1352, 729);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "FormReporte";
            Text = "FormReporte";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BSalir;
        private Label LReporte;
        private Label LVolver;
        private GroupBox groupBox1;
        private Label LTextoReporte;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button BBuscar;
        private TextBox TNombre;
        private Label LNombreVendedor;
        private RadioButton RBRecaudacion;
        private RadioButton RBProductos;
        private Label LTipoReporte;
        private RadioButton RBVentas;
        private Button BGenerar;
    }
}