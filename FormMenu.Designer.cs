namespace formLogin
{
    partial class FormMenu
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
            LClientes = new Label();
            LProductos = new Label();
            LNombreUser = new Label();
            label1 = new Label();
            LReportes = new Label();
            LRolUser = new Label();
            LCarrito = new Label();
            LUsuarios = new Label();
            LBackup = new Label();
            LSalir = new Label();
            BBackUp = new Button();
            BUsuario = new Button();
            BCarrito = new Button();
            BReporte = new Button();
            BProductos = new Button();
            BSalir = new Button();
            BCliente = new Button();
            LTimer = new Label();
            LFecha = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LClientes);
            panel1.Controls.Add(LProductos);
            panel1.Controls.Add(LNombreUser);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LReportes);
            panel1.Controls.Add(LRolUser);
            panel1.Controls.Add(LCarrito);
            panel1.Controls.Add(LUsuarios);
            panel1.Controls.Add(LBackup);
            panel1.Controls.Add(LSalir);
            panel1.Controls.Add(BBackUp);
            panel1.Controls.Add(BUsuario);
            panel1.Controls.Add(BCarrito);
            panel1.Controls.Add(BReporte);
            panel1.Controls.Add(BProductos);
            panel1.Controls.Add(BSalir);
            panel1.Controls.Add(BCliente);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 133);
            panel1.TabIndex = 0;
            // 
            // LClientes
            // 
            LClientes.AutoSize = true;
            LClientes.Location = new Point(38, 113);
            LClientes.Name = "LClientes";
            LClientes.Size = new Size(61, 20);
            LClientes.TabIndex = 13;
            LClientes.Text = "Clientes";
            // 
            // LProductos
            // 
            LProductos.AutoSize = true;
            LProductos.Location = new Point(131, 113);
            LProductos.Name = "LProductos";
            LProductos.Size = new Size(75, 20);
            LProductos.TabIndex = 12;
            LProductos.Text = "Productos";
            // 
            // LNombreUser
            // 
            LNombreUser.AutoSize = true;
            LNombreUser.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombreUser.Location = new Point(913, 73);
            LNombreUser.Name = "LNombreUser";
            LNombreUser.Size = new Size(60, 23);
            LNombreUser.TabIndex = 3;
            LNombreUser.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(974, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // LReportes
            // 
            LReportes.AutoSize = true;
            LReportes.Location = new Point(232, 113);
            LReportes.Name = "LReportes";
            LReportes.Size = new Size(68, 20);
            LReportes.TabIndex = 11;
            LReportes.Text = "Reportes";
            // 
            // LRolUser
            // 
            LRolUser.AutoSize = true;
            LRolUser.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LRolUser.Location = new Point(913, 16);
            LRolUser.Name = "LRolUser";
            LRolUser.Size = new Size(97, 35);
            LRolUser.TabIndex = 1;
            LRolUser.Text = "usuario";
            // 
            // LCarrito
            // 
            LCarrito.AutoSize = true;
            LCarrito.Location = new Point(338, 113);
            LCarrito.Name = "LCarrito";
            LCarrito.Size = new Size(54, 20);
            LCarrito.TabIndex = 10;
            LCarrito.Text = "Carrito";
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Location = new Point(431, 113);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(65, 20);
            LUsuarios.TabIndex = 9;
            LUsuarios.Text = "Usuarios";
            // 
            // LBackup
            // 
            LBackup.AutoSize = true;
            LBackup.Location = new Point(526, 115);
            LBackup.Name = "LBackup";
            LBackup.Size = new Size(63, 20);
            LBackup.TabIndex = 8;
            LBackup.Text = "Back Up";
            // 
            // LSalir
            // 
            LSalir.AutoSize = true;
            LSalir.Location = new Point(1456, 113);
            LSalir.Name = "LSalir";
            LSalir.Size = new Size(38, 20);
            LSalir.TabIndex = 7;
            LSalir.Text = "Salir";
            // 
            // BBackUp
            // 
            BBackUp.Image = Properties.Resources.copia_de_respaldo;
            BBackUp.Location = new Point(511, 16);
            BBackUp.Margin = new Padding(3, 4, 3, 4);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(91, 93);
            BBackUp.TabIndex = 6;
            BBackUp.UseVisualStyleBackColor = true;
            BBackUp.Click += BBackUp_Click;
            // 
            // BUsuario
            // 
            BUsuario.Image = Properties.Resources.nueva_cuenta;
            BUsuario.Location = new Point(413, 16);
            BUsuario.Margin = new Padding(3, 4, 3, 4);
            BUsuario.Name = "BUsuario";
            BUsuario.Size = new Size(91, 93);
            BUsuario.TabIndex = 5;
            BUsuario.UseVisualStyleBackColor = true;
            BUsuario.Click += BUsuario_Click;
            // 
            // BCarrito
            // 
            BCarrito.Image = Properties.Resources.carrito_de_compras;
            BCarrito.Location = new Point(314, 16);
            BCarrito.Margin = new Padding(3, 4, 3, 4);
            BCarrito.Name = "BCarrito";
            BCarrito.Size = new Size(91, 93);
            BCarrito.TabIndex = 4;
            BCarrito.UseVisualStyleBackColor = true;
            BCarrito.Click += BCarrito_Click;
            // 
            // BReporte
            // 
            BReporte.Image = Properties.Resources.estadisticas;
            BReporte.Location = new Point(216, 16);
            BReporte.Margin = new Padding(3, 4, 3, 4);
            BReporte.Name = "BReporte";
            BReporte.Size = new Size(91, 93);
            BReporte.TabIndex = 3;
            BReporte.UseVisualStyleBackColor = true;
            BReporte.Click += BReporte_Click;
            // 
            // BProductos
            // 
            BProductos.Image = Properties.Resources.camiseta_de_manga_corta;
            BProductos.Location = new Point(118, 16);
            BProductos.Margin = new Padding(3, 4, 3, 4);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(91, 93);
            BProductos.TabIndex = 2;
            BProductos.UseVisualStyleBackColor = true;
            BProductos.Click += BProductos_Click;
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.cerrar_sesion__1_;
            BSalir.Location = new Point(1423, 16);
            BSalir.Margin = new Padding(3, 4, 3, 4);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(91, 93);
            BSalir.TabIndex = 1;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // BCliente
            // 
            BCliente.Image = Properties.Resources.cliente;
            BCliente.Location = new Point(19, 16);
            BCliente.Margin = new Padding(3, 4, 3, 4);
            BCliente.Name = "BCliente";
            BCliente.Size = new Size(91, 93);
            BCliente.TabIndex = 0;
            BCliente.UseVisualStyleBackColor = true;
            BCliente.Click += BCliente_Click;
            // 
            // LTimer
            // 
            LTimer.Anchor = AnchorStyles.Top;
            LTimer.AutoSize = true;
            LTimer.Font = new Font("Sitka Heading", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTimer.ForeColor = SystemColors.Highlight;
            LTimer.Location = new Point(576, 172);
            LTimer.Name = "LTimer";
            LTimer.Size = new Size(263, 116);
            LTimer.TabIndex = 1;
            LTimer.Text = "label3";
            // 
            // LFecha
            // 
            LFecha.Anchor = AnchorStyles.Top;
            LFecha.AutoSize = true;
            LFecha.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LFecha.Location = new Point(595, 295);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(67, 29);
            LFecha.TabIndex = 2;
            LFecha.Text = "label3";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1545, 972);
            Controls.Add(LFecha);
            Controls.Add(LTimer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BCliente;
        private Button BSalir;
        private Button BProductos;
        private Button BReporte;
        private Button BUsuario;
        private Button BCarrito;
        private Button BBackUp;
        private Label LClientes;
        private Label LProductos;
        private Label LReportes;
        private Label LCarrito;
        private Label LUsuarios;
        private Label LBackup;
        private Label LSalir;
        private Label label1;
        private Label LRolUser;
        private Label LTimer;
        private Label LFecha;
        private Label LNombreUser;
    }
}