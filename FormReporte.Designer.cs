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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            BHistorial = new Button();
            LUsuario = new Label();
            LVolver = new Label();
            LReporte = new Label();
            BSalir = new Button();
            groupBox1 = new GroupBox();
            BGenerar = new Button();
            DTHasta = new DateTimePicker();
            DTDesde = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            LTextoReporte = new Label();
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTopProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BHistorial);
            panel1.Controls.Add(LUsuario);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(LReporte);
            panel1.Controls.Add(BSalir);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 100);
            panel1.TabIndex = 0;
            // 
            // BHistorial
            // 
            BHistorial.Location = new Point(1166, 25);
            BHistorial.Name = "BHistorial";
            BHistorial.Size = new Size(143, 51);
            BHistorial.TabIndex = 4;
            BHistorial.Text = "Historial Ventas";
            BHistorial.UseVisualStyleBackColor = true;
            BHistorial.Click += BHistorial_Click;
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Location = new Point(400, 60);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(38, 15);
            LUsuario.TabIndex = 3;
            LUsuario.Text = "label3";
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
            groupBox1.Controls.Add(DTHasta);
            groupBox1.Controls.Add(DTDesde);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LTextoReporte);
            groupBox1.Location = new Point(27, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 132);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // BGenerar
            // 
            BGenerar.Location = new Point(252, 103);
            BGenerar.Name = "BGenerar";
            BGenerar.Size = new Size(129, 23);
            BGenerar.TabIndex = 10;
            BGenerar.Text = "Generar Reporte";
            BGenerar.UseVisualStyleBackColor = true;
            BGenerar.Click += BGenerar_Click;
            // 
            // DTHasta
            // 
            DTHasta.Format = DateTimePickerFormat.Short;
            DTHasta.Location = new Point(376, 45);
            DTHasta.Name = "DTHasta";
            DTHasta.Size = new Size(200, 23);
            DTHasta.TabIndex = 4;
            // 
            // DTDesde
            // 
            DTDesde.Format = DateTimePickerFormat.Short;
            DTDesde.Location = new Point(76, 45);
            DTDesde.Name = "DTDesde";
            DTDesde.Size = new Size(200, 23);
            DTDesde.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 51);
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
            // chartVentas
            // 
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVentas.Legends.Add(legend1);
            chartVentas.Location = new Point(818, 132);
            chartVentas.Name = "chartVentas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVentas.Series.Add(series1);
            chartVentas.Size = new Size(522, 236);
            chartVentas.TabIndex = 3;
            chartVentas.Text = "chartVentas";
            // 
            // chartTopProductos
            // 
            chartArea2.Name = "ChartArea1";
            chartTopProductos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTopProductos.Legends.Add(legend2);
            chartTopProductos.Location = new Point(27, 470);
            chartTopProductos.Name = "chartTopProductos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTopProductos.Series.Add(series2);
            chartTopProductos.Size = new Size(522, 236);
            chartTopProductos.TabIndex = 4;
            chartTopProductos.Text = "chartTopProductos";
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1352, 729);
            Controls.Add(chartTopProductos);
            Controls.Add(chartVentas);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormReporte";
            Text = "FormReporte";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BSalir;
        private Label LReporte;
        private Label LVolver;
        private GroupBox groupBox1;
        private Label LTextoReporte;
        private DateTimePicker DTHasta;
        private DateTimePicker DTDesde;
        private Label label2;
        private Label label1;
        private Button BGenerar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProductos;
        private Label LUsuario;
        private Button BHistorial;
    }
}