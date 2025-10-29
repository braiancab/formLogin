namespace formLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TNombreUsuario = new TextBox();
            TContraUsuario = new TextBox();
            LNombre = new Label();
            label1 = new Label();
            LInicioSesion = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            BIngresar = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TNombreUsuario
            // 
            TNombreUsuario.Location = new Point(124, 74);
            TNombreUsuario.Name = "TNombreUsuario";
            TNombreUsuario.Size = new Size(161, 23);
            TNombreUsuario.TabIndex = 0;
            TNombreUsuario.KeyUp += TNombreUsuario_KeyUp;
            // 
            // TContraUsuario
            // 
            TContraUsuario.Location = new Point(124, 126);
            TContraUsuario.Name = "TContraUsuario";
            TContraUsuario.PasswordChar = '*';
            TContraUsuario.Size = new Size(161, 23);
            TContraUsuario.TabIndex = 1;
            TContraUsuario.KeyUp += TContraUsuario_KeyUp;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(24, 77);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(50, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 129);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Contraseña:";
            // 
            // LInicioSesion
            // 
            LInicioSesion.AutoSize = true;
            LInicioSesion.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LInicioSesion.Location = new Point(63, 11);
            LInicioSesion.Name = "LInicioSesion";
            LInicioSesion.Size = new Size(168, 31);
            LInicioSesion.TabIndex = 4;
            LInicioSesion.Text = "Inicio Sesión";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(BIngresar);
            panel1.Controls.Add(TNombreUsuario);
            panel1.Controls.Add(LInicioSesion);
            panel1.Controls.Add(TContraUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(203, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 223);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ojo;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(311, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // BIngresar
            // 
            BIngresar.Location = new Point(163, 188);
            BIngresar.Name = "BIngresar";
            BIngresar.Size = new Size(93, 32);
            BIngresar.TabIndex = 5;
            BIngresar.Text = "Ingresar";
            BIngresar.UseVisualStyleBackColor = true;
            BIngresar.Click += BIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(25, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(612, 276);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TNombreUsuario;
        private TextBox TContraUsuario;
        private Label LNombre;
        private Label label1;
        private Label LInicioSesion;
        private Panel panel1;
        private Button BIngresar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
