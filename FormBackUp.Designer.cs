namespace formLogin
{
    partial class FormBackUp
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
            LVoler = new Label();
            LBackup = new Label();
            BSalir = new Button();
            LBasededatos = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            LTiempoBackup = new Label();
            BBackUp = new Button();
            comboBoxBD = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LVoler);
            panel1.Controls.Add(LBackup);
            panel1.Controls.Add(BSalir);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 100);
            panel1.TabIndex = 0;
            // 
            // LVoler
            // 
            LVoler.AutoSize = true;
            LVoler.Location = new Point(32, 76);
            LVoler.Name = "LVoler";
            LVoler.Size = new Size(39, 15);
            LVoler.TabIndex = 1;
            LVoler.Text = "Volver";
            // 
            // LBackup
            // 
            LBackup.AutoSize = true;
            LBackup.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBackup.Location = new Point(559, 26);
            LBackup.Name = "LBackup";
            LBackup.Size = new Size(143, 37);
            LBackup.TabIndex = 0;
            LBackup.Text = "Back Up";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.volver;
            BSalir.Location = new Point(12, 3);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(80, 70);
            BSalir.TabIndex = 1;
            BSalir.TabStop = false;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // LBasededatos
            // 
            LBasededatos.AutoSize = true;
            LBasededatos.BackColor = Color.Transparent;
            LBasededatos.ForeColor = SystemColors.ActiveCaptionText;
            LBasededatos.Location = new Point(31, 154);
            LBasededatos.Name = "LBasededatos";
            LBasededatos.Size = new Size(82, 15);
            LBasededatos.TabIndex = 1;
            LBasededatos.Text = "Base de datos:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LTiempoBackup);
            groupBox1.Controls.Add(BBackUp);
            groupBox1.Controls.Add(comboBoxBD);
            groupBox1.Controls.Add(LBasededatos);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(317, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 232);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(242, 15);
            label1.TabIndex = 8;
            label1.Text = "El Backup automático se realizará dentro de: ";
            // 
            // LTiempoBackup
            // 
            LTiempoBackup.AutoSize = true;
            LTiempoBackup.Location = new Point(330, 31);
            LTiempoBackup.Name = "LTiempoBackup";
            LTiempoBackup.Size = new Size(38, 15);
            LTiempoBackup.TabIndex = 7;
            LTiempoBackup.Text = "label1";
            // 
            // BBackUp
            // 
            BBackUp.Location = new Point(284, 197);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(84, 29);
            BBackUp.TabIndex = 6;
            BBackUp.Text = "Back Up";
            BBackUp.UseVisualStyleBackColor = true;
            BBackUp.Click += BBackUp_Click;
            // 
            // comboBoxBD
            // 
            comboBoxBD.FormattingEnabled = true;
            comboBoxBD.Location = new Point(148, 151);
            comboBoxBD.Name = "comboBoxBD";
            comboBoxBD.Size = new Size(361, 23);
            comboBoxBD.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 9;
            label2.Text = "Si desea hacerlo manualmente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 93);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 10;
            label3.Text = "1- Seleccione su base de datos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 108);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 11;
            label4.Text = "2- Presione el boton Backup";
            // 
            // FormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1352, 729);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormBackUp";
            Text = "FormBackUp";
            WindowState = FormWindowState.Maximized;
            Load += FormBackUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LBackup;
        private Button BSalir;
        private Label LVoler;
        private Label LBasededatos;
        private GroupBox groupBox1;
        private ComboBox comboBoxBD;
        private Button BBackUp;
        private Label LTiempoBackup;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}