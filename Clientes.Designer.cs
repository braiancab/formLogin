namespace formLogin
{
    partial class Clientes
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
            LCliente = new Label();
            LVolver = new Label();
            BSalir = new Button();
            panel2 = new Panel();
            BCancelar = new Button();
            BGuardar = new Button();
            pictureBox1 = new PictureBox();
            LSexo = new Label();
            RBFemenino = new RadioButton();
            RBMasculino = new RadioButton();
            TTelefono = new TextBox();
            LTelefono = new Label();
            TDireccion = new TextBox();
            LDireccion = new Label();
            TDni = new TextBox();
            LDni = new Label();
            TNYApellido = new TextBox();
            LNYApellido = new Label();
            dataGridView1 = new DataGridView();
            BActivos = new Button();
            BInactivos = new Button();
            BTodos = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LCliente);
            panel1.Controls.Add(LVolver);
            panel1.Controls.Add(BSalir);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 100);
            panel1.TabIndex = 0;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.BackColor = SystemColors.ActiveCaption;
            LCliente.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCliente.Location = new Point(392, 26);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(144, 37);
            LCliente.TabIndex = 2;
            LCliente.Text = "Clientes";
            // 
            // LVolver
            // 
            LVolver.AutoSize = true;
            LVolver.Location = new Point(33, 76);
            LVolver.Name = "LVolver";
            LVolver.Size = new Size(39, 15);
            LVolver.TabIndex = 1;
            LVolver.Text = "Volver";
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.volver;
            BSalir.Location = new Point(12, 3);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(80, 70);
            BSalir.TabIndex = 1;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(BCancelar);
            panel2.Controls.Add(BGuardar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(LSexo);
            panel2.Controls.Add(RBFemenino);
            panel2.Controls.Add(RBMasculino);
            panel2.Controls.Add(TTelefono);
            panel2.Controls.Add(LTelefono);
            panel2.Controls.Add(TDireccion);
            panel2.Controls.Add(LDireccion);
            panel2.Controls.Add(TDni);
            panel2.Controls.Add(LDni);
            panel2.Controls.Add(TNYApellido);
            panel2.Controls.Add(LNYApellido);
            panel2.Location = new Point(145, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 232);
            panel2.TabIndex = 1;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(243, 197);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(75, 23);
            BCancelar.TabIndex = 13;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(122, 197);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 12;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = Properties.Resources.lista_de_contactos;
            pictureBox1.Location = new Point(446, 16);
            pictureBox1.Margin = new Padding(7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(7);
            pictureBox1.Size = new Size(145, 141);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(78, 142);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(38, 15);
            LSexo.TabIndex = 10;
            LSexo.Text = "Sexo: ";
            // 
            // RBFemenino
            // 
            RBFemenino.AutoSize = true;
            RBFemenino.Location = new Point(240, 142);
            RBFemenino.Name = "RBFemenino";
            RBFemenino.Size = new Size(78, 19);
            RBFemenino.TabIndex = 9;
            RBFemenino.TabStop = true;
            RBFemenino.Text = "Femenino";
            RBFemenino.UseVisualStyleBackColor = true;
            // 
            // RBMasculino
            // 
            RBMasculino.AutoSize = true;
            RBMasculino.Location = new Point(122, 142);
            RBMasculino.Name = "RBMasculino";
            RBMasculino.Size = new Size(80, 19);
            RBMasculino.TabIndex = 8;
            RBMasculino.TabStop = true;
            RBMasculino.Text = "Masculino";
            RBMasculino.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(122, 113);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(196, 23);
            TTelefono.TabIndex = 7;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(58, 116);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(58, 15);
            LTelefono.TabIndex = 6;
            LTelefono.Text = "Telefono: ";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(122, 80);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(196, 23);
            TDireccion.TabIndex = 5;
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(53, 83);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(63, 15);
            LDireccion.TabIndex = 4;
            LDireccion.Text = "Direccion: ";
            // 
            // TDni
            // 
            TDni.Location = new Point(122, 48);
            TDni.Name = "TDni";
            TDni.Size = new Size(196, 23);
            TDni.TabIndex = 3;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(83, 51);
            LDni.Name = "LDni";
            LDni.Size = new Size(33, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI: ";
            // 
            // TNYApellido
            // 
            TNYApellido.Location = new Point(122, 16);
            TNYApellido.Name = "TNYApellido";
            TNYApellido.Size = new Size(196, 23);
            TNYApellido.TabIndex = 1;
            // 
            // LNYApellido
            // 
            LNYApellido.AutoSize = true;
            LNYApellido.Location = new Point(3, 19);
            LNYApellido.Name = "LNYApellido";
            LNYApellido.Size = new Size(113, 15);
            LNYApellido.TabIndex = 0;
            LNYApellido.Text = "Nombre y Apellido: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(906, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BActivos
            // 
            BActivos.Location = new Point(839, 391);
            BActivos.Name = "BActivos";
            BActivos.Size = new Size(75, 23);
            BActivos.TabIndex = 3;
            BActivos.Text = "Activos";
            BActivos.UseVisualStyleBackColor = true;
            // 
            // BInactivos
            // 
            BInactivos.Location = new Point(758, 391);
            BInactivos.Name = "BInactivos";
            BInactivos.Size = new Size(75, 23);
            BInactivos.TabIndex = 4;
            BInactivos.Text = "Inactivos";
            BInactivos.UseVisualStyleBackColor = true;
            // 
            // BTodos
            // 
            BTodos.Location = new Point(677, 391);
            BTodos.Name = "BTodos";
            BTodos.Size = new Size(75, 23);
            BTodos.TabIndex = 5;
            BTodos.Text = "Todos";
            BTodos.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(926, 606);
            Controls.Add(BTodos);
            Controls.Add(BInactivos);
            Controls.Add(BActivos);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Clientes";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BSalir;
        private Label LVolver;
        private Label LCliente;
        private Panel panel2;
        private TextBox TNYApellido;
        private Label LNYApellido;
        private TextBox TDni;
        private Label LDni;
        private TextBox TTelefono;
        private Label LTelefono;
        private TextBox TDireccion;
        private Label LDireccion;
        private Label LSexo;
        private RadioButton RBFemenino;
        private RadioButton RBMasculino;
        private PictureBox pictureBox1;
        private Button BGuardar;
        private Button BCancelar;
        private DataGridView dataGridView1;
        private Button BActivos;
        private Button BInactivos;
        private Button BTodos;
    }
}