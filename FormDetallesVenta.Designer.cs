namespace formLogin
{
    partial class FormDetallesVenta
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
            dataGridView1 = new DataGridView();
            TotalVenta = new Label();
            LTotalVenta = new Label();
            BDescargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(717, 300);
            dataGridView1.TabIndex = 0;
            // 
            // TotalVenta
            // 
            TotalVenta.AutoSize = true;
            TotalVenta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalVenta.Location = new Point(12, 317);
            TotalVenta.Name = "TotalVenta";
            TotalVenta.Size = new Size(111, 17);
            TotalVenta.TabIndex = 1;
            TotalVenta.Text = "Total de la venta:";
            // 
            // LTotalVenta
            // 
            LTotalVenta.AutoSize = true;
            LTotalVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTotalVenta.Location = new Point(160, 317);
            LTotalVenta.Name = "LTotalVenta";
            LTotalVenta.Size = new Size(43, 17);
            LTotalVenta.TabIndex = 2;
            LTotalVenta.Text = "label1";
            // 
            // BDescargar
            // 
            BDescargar.Location = new Point(303, 441);
            BDescargar.Name = "BDescargar";
            BDescargar.Size = new Size(75, 23);
            BDescargar.TabIndex = 3;
            BDescargar.Text = "Descargar";
            BDescargar.UseVisualStyleBackColor = true;
            BDescargar.Click += BDescargar_Click;
            // 
            // FormDetallesVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(717, 476);
            Controls.Add(BDescargar);
            Controls.Add(LTotalVenta);
            Controls.Add(TotalVenta);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormDetallesVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDetallesVenta";
            Load += FormDetallesVenta_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label TotalVenta;
        private Label LTotalVenta;
        private Button BDescargar;
    }
}