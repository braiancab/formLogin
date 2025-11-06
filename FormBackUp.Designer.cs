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
            LTimerBackup = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BBackUp = new Button();
            comboBoxBD = new ComboBox();
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
            LBasededatos.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBasededatos.ForeColor = SystemColors.ActiveCaptionText;
            LBasededatos.Location = new Point(31, 158);
            LBasededatos.Name = "LBasededatos";
            LBasededatos.Size = new Size(94, 16);
            LBasededatos.TabIndex = 1;
            LBasededatos.Text = "Base de datos:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(LTimerBackup);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
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
            // LTimerBackup
            // 
            LTimerBackup.AutoSize = true;
            LTimerBackup.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTimerBackup.Location = new Point(284, 19);
            LTimerBackup.Name = "LTimerBackup";
            LTimerBackup.Size = new Size(70, 28);
            LTimerBackup.TabIndex = 12;
            LTimerBackup.Text = "LABEL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 119);
            label4.Name = "label4";
            label4.Size = new Size(179, 16);
            label4.TabIndex = 11;
            label4.Text = "2- Presione el boton Backup";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 85);
            label3.Name = "label3";
            label3.Size = new Size(191, 16);
            label3.TabIndex = 10;
            label3.Text = "1- Seleccione su base de datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 58);
            label2.Name = "label2";
            label2.Size = new Size(216, 18);
            label2.TabIndex = 9;
            label2.Text = "Si desea hacerlo manualmente:";
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
            comboBoxBD.Location = new Point(155, 156);
            comboBoxBD.Name = "comboBoxBD";
            comboBoxBD.Size = new Size(361, 23);
            comboBoxBD.TabIndex = 5;
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label LTimerBackup;
    }
}