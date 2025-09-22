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
            LRuta = new Label();
            groupBox1 = new GroupBox();
            BBackUp = new Button();
            comboBoxBD = new ComboBox();
            BRuta = new Button();
            TRuta = new TextBox();
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
            panel1.Size = new Size(906, 100);
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
            LBackup.Location = new Point(392, 26);
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
            LBasededatos.Location = new Point(22, 57);
            LBasededatos.Name = "LBasededatos";
            LBasededatos.Size = new Size(82, 15);
            LBasededatos.TabIndex = 1;
            LBasededatos.Text = "Base de datos:";
            // 
            // LRuta
            // 
            LRuta.AutoSize = true;
            LRuta.BackColor = Color.Transparent;
            LRuta.ForeColor = SystemColors.ActiveCaptionText;
            LRuta.Location = new Point(22, 117);
            LRuta.Name = "LRuta";
            LRuta.Size = new Size(34, 15);
            LRuta.TabIndex = 2;
            LRuta.Text = "Ruta:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(BBackUp);
            groupBox1.Controls.Add(comboBoxBD);
            groupBox1.Controls.Add(BRuta);
            groupBox1.Controls.Add(TRuta);
            groupBox1.Controls.Add(LBasededatos);
            groupBox1.Controls.Add(LRuta);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(145, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 232);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
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
            comboBoxBD.Location = new Point(139, 49);
            comboBoxBD.Name = "comboBoxBD";
            comboBoxBD.Size = new Size(121, 23);
            comboBoxBD.TabIndex = 5;
            // 
            // BRuta
            // 
            BRuta.Location = new Point(525, 114);
            BRuta.Name = "BRuta";
            BRuta.Size = new Size(75, 23);
            BRuta.TabIndex = 4;
            BRuta.Text = "Ruta";
            BRuta.UseVisualStyleBackColor = true;
            BRuta.Click += BRuta_Click;
            // 
            // TRuta
            // 
            TRuta.Location = new Point(139, 114);
            TRuta.Name = "TRuta";
            TRuta.Size = new Size(338, 23);
            TRuta.TabIndex = 3;
            // 
            // FormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(929, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormBackUp";
            Text = "FormBackUp";
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
        private Label LRuta;
        private GroupBox groupBox1;
        private Button BRuta;
        private TextBox TRuta;
        private ComboBox comboBoxBD;
        private Button BBackUp;
    }
}