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
            LPromedioDiario = new Label();
            LProcentaje = new Label();
            LTotalVentas = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BHistorial);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(LReporte);
            panel1.Controls.Add(BSalir);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 133);
            panel1.TabIndex = 0;
            // 
            // BHistorial
            // 
            BHistorial.Location = new Point(1333, 33);
            BHistorial.Margin = new Padding(3, 4, 3, 4);
            BHistorial.Name = "BHistorial";
            BHistorial.Size = new Size(163, 68);
            BHistorial.TabIndex = 4;
            BHistorial.Text = "Historial Ventas";
            BHistorial.UseVisualStyleBackColor = true;
            BHistorial.Click += BHistorial_Click;
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
            // LReporte
            // 
            LReporte.Anchor = AnchorStyles.Top;
            LReporte.AutoSize = true;
            LReporte.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LReporte.Location = new Point(683, 33);
            LReporte.Name = "LReporte";
            LReporte.Size = new Size(192, 46);
            LReporte.TabIndex = 1;
            LReporte.Text = "Reportes";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.volver;
            BSalir.Location = new Point(17, 4);
            BSalir.Margin = new Padding(3, 4, 3, 4);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(91, 93);
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
            groupBox1.Location = new Point(50, 176);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(670, 176);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // BGenerar
            // 
            BGenerar.Location = new Point(288, 137);
            BGenerar.Margin = new Padding(3, 4, 3, 4);
            BGenerar.Name = "BGenerar";
            BGenerar.Size = new Size(147, 31);
            BGenerar.TabIndex = 10;
            BGenerar.Text = "Generar Reporte";
            BGenerar.UseVisualStyleBackColor = true;
            BGenerar.Click += BGenerar_Click;
            // 
            // DTHasta
            // 
            DTHasta.Format = DateTimePickerFormat.Short;
            DTHasta.Location = new Point(430, 60);
            DTHasta.Margin = new Padding(3, 4, 3, 4);
            DTHasta.Name = "DTHasta";
            DTHasta.Size = new Size(228, 27);
            DTHasta.TabIndex = 4;
            // 
            // DTDesde
            // 
            DTDesde.Format = DateTimePickerFormat.Short;
            DTDesde.Location = new Point(87, 60);
            DTDesde.Margin = new Padding(3, 4, 3, 4);
            DTDesde.Name = "DTDesde";
            DTDesde.Size = new Size(228, 27);
            DTDesde.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 68);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Hasta: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 68);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Desde: ";
            // 
            // LTextoReporte
            // 
            LTextoReporte.AutoSize = true;
            LTextoReporte.Location = new Point(17, 25);
            LTextoReporte.Name = "LTextoReporte";
            LTextoReporte.Size = new Size(127, 20);
            LTextoReporte.TabIndex = 0;
            LTextoReporte.Text = "Seleccione fecha: ";
            // 
            // chartVentas
            // 
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVentas.Legends.Add(legend1);
            chartVentas.Location = new Point(872, 176);
            chartVentas.Margin = new Padding(3, 4, 3, 4);
            chartVentas.Name = "chartVentas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVentas.Series.Add(series1);
            chartVentas.Size = new Size(597, 363);
            chartVentas.TabIndex = 3;
            chartVentas.Text = "chartVentas";
            // 
            // chartTopProductos
            // 
            chartArea2.Name = "ChartArea1";
            chartTopProductos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTopProductos.Legends.Add(legend2);
            chartTopProductos.Location = new Point(123, 544);
            chartTopProductos.Margin = new Padding(3, 4, 3, 4);
            chartTopProductos.Name = "chartTopProductos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTopProductos.Series.Add(series2);
            chartTopProductos.Size = new Size(597, 363);
            chartTopProductos.TabIndex = 4;
            chartTopProductos.Text = "chartTopProductos";
            // 
            // LPromedioDiario
            // 
            LPromedioDiario.AutoSize = true;
            LPromedioDiario.Location = new Point(16, 168);
            LPromedioDiario.Name = "LPromedioDiario";
            LPromedioDiario.Size = new Size(50, 20);
            LPromedioDiario.TabIndex = 5;
            LPromedioDiario.Text = "label3";
            // 
            // LProcentaje
            // 
            LProcentaje.AutoSize = true;
            LProcentaje.Location = new Point(16, 232);
            LProcentaje.Name = "LProcentaje";
            LProcentaje.Size = new Size(50, 20);
            LProcentaje.TabIndex = 6;
            LProcentaje.Text = "label3";
            // 
            // LTotalVentas
            // 
            LTotalVentas.AutoSize = true;
            LTotalVentas.Location = new Point(16, 100);
            LTotalVentas.Name = "LTotalVentas";
            LTotalVentas.Size = new Size(50, 20);
            LTotalVentas.TabIndex = 7;
            LTotalVentas.Text = "label3";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(LPromedioDiario);
            panel2.Controls.Add(LTotalVentas);
            panel2.Controls.Add(LProcentaje);
            panel2.Location = new Point(962, 588);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 319);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 13);
            label3.Name = "label3";
            label3.Size = new Size(150, 35);
            label3.TabIndex = 8;
            label3.Text = "Mediciones";
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1545, 972);
            Controls.Add(panel2);
            Controls.Add(chartTopProductos);
            Controls.Add(chartVentas);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormReporte";
            Text = "FormReporte";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProductos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button BHistorial;
        private Label LPromedioDiario;
        private Label LProcentaje;
        private Label LTotalVentas;
        private Panel panel2;
        private Label label3;
    }
}