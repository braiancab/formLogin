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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            groupBox1.Location = new Point(44, 132);
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
            chartArea3.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartVentas.Legends.Add(legend3);
            chartVentas.Location = new Point(763, 132);
            chartVentas.Name = "chartVentas";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartVentas.Series.Add(series3);
            chartVentas.Size = new Size(522, 272);
            chartVentas.TabIndex = 3;
            chartVentas.Text = "chartVentas";
            // 
            // chartTopProductos
            // 
            chartArea4.Name = "ChartArea1";
            chartTopProductos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartTopProductos.Legends.Add(legend4);
            chartTopProductos.Location = new Point(108, 408);
            chartTopProductos.Name = "chartTopProductos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartTopProductos.Series.Add(series4);
            chartTopProductos.Size = new Size(522, 272);
            chartTopProductos.TabIndex = 4;
            chartTopProductos.Text = "chartTopProductos";
            // 
            // LPromedioDiario
            // 
            LPromedioDiario.AutoSize = true;
            LPromedioDiario.Location = new Point(14, 126);
            LPromedioDiario.Name = "LPromedioDiario";
            LPromedioDiario.Size = new Size(38, 15);
            LPromedioDiario.TabIndex = 5;
            LPromedioDiario.Text = "label3";
            // 
            // LProcentaje
            // 
            LProcentaje.AutoSize = true;
            LProcentaje.Location = new Point(14, 174);
            LProcentaje.Name = "LProcentaje";
            LProcentaje.Size = new Size(38, 15);
            LProcentaje.TabIndex = 6;
            LProcentaje.Text = "label3";
            // 
            // LTotalVentas
            // 
            LTotalVentas.AutoSize = true;
            LTotalVentas.Location = new Point(14, 75);
            LTotalVentas.Name = "LTotalVentas";
            LTotalVentas.Size = new Size(38, 15);
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
            panel2.Location = new Point(842, 441);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 239);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 10);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 8;
            label3.Text = "Mediciones";
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1352, 729);
            Controls.Add(panel2);
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