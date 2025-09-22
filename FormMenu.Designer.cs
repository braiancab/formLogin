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
            LReportes = new Label();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LClientes);
            panel1.Controls.Add(LProductos);
            panel1.Controls.Add(LReportes);
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 100);
            panel1.TabIndex = 0;
            // 
            // LClientes
            // 
            LClientes.AutoSize = true;
            LClientes.Location = new Point(33, 85);
            LClientes.Name = "LClientes";
            LClientes.Size = new Size(49, 15);
            LClientes.TabIndex = 13;
            LClientes.Text = "Clientes";
            // 
            // LProductos
            // 
            LProductos.AutoSize = true;
            LProductos.Location = new Point(115, 85);
            LProductos.Name = "LProductos";
            LProductos.Size = new Size(61, 15);
            LProductos.TabIndex = 12;
            LProductos.Text = "Productos";
            // 
            // LReportes
            // 
            LReportes.AutoSize = true;
            LReportes.Location = new Point(203, 85);
            LReportes.Name = "LReportes";
            LReportes.Size = new Size(53, 15);
            LReportes.TabIndex = 11;
            LReportes.Text = "Reportes";
            // 
            // LCarrito
            // 
            LCarrito.AutoSize = true;
            LCarrito.Location = new Point(296, 85);
            LCarrito.Name = "LCarrito";
            LCarrito.Size = new Size(43, 15);
            LCarrito.TabIndex = 10;
            LCarrito.Text = "Carrito";
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Location = new Point(377, 85);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(52, 15);
            LUsuarios.TabIndex = 9;
            LUsuarios.Text = "Usuarios";
            // 
            // LBackup
            // 
            LBackup.AutoSize = true;
            LBackup.Location = new Point(460, 86);
            LBackup.Name = "LBackup";
            LBackup.Size = new Size(50, 15);
            LBackup.TabIndex = 8;
            LBackup.Text = "Back Up";
            // 
            // LSalir
            // 
            LSalir.AutoSize = true;
            LSalir.Location = new Point(843, 85);
            LSalir.Name = "LSalir";
            LSalir.Size = new Size(29, 15);
            LSalir.TabIndex = 7;
            LSalir.Text = "Salir";
            // 
            // BBackUp
            // 
            BBackUp.Image = Properties.Resources.copia_de_respaldo;
            BBackUp.Location = new Point(447, 12);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(80, 70);
            BBackUp.TabIndex = 6;
            BBackUp.UseVisualStyleBackColor = true;
            BBackUp.Click += BBackUp_Click;
            // 
            // BUsuario
            // 
            BUsuario.Image = Properties.Resources.nueva_cuenta;
            BUsuario.Location = new Point(361, 12);
            BUsuario.Name = "BUsuario";
            BUsuario.Size = new Size(80, 70);
            BUsuario.TabIndex = 5;
            BUsuario.UseVisualStyleBackColor = true;
            BUsuario.Click += BUsuario_Click;
            // 
            // BCarrito
            // 
            BCarrito.Image = Properties.Resources.carrito_de_compras;
            BCarrito.Location = new Point(275, 12);
            BCarrito.Name = "BCarrito";
            BCarrito.Size = new Size(80, 70);
            BCarrito.TabIndex = 4;
            BCarrito.UseVisualStyleBackColor = true;
            BCarrito.Click += BCarrito_Click;
            // 
            // BReporte
            // 
            BReporte.Image = Properties.Resources.estadisticas;
            BReporte.Location = new Point(189, 12);
            BReporte.Name = "BReporte";
            BReporte.Size = new Size(80, 70);
            BReporte.TabIndex = 3;
            BReporte.UseVisualStyleBackColor = true;
            BReporte.Click += BReporte_Click;
            // 
            // BProductos
            // 
            BProductos.Image = Properties.Resources.camiseta_de_manga_corta;
            BProductos.Location = new Point(103, 12);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(80, 70);
            BProductos.TabIndex = 2;
            BProductos.UseVisualStyleBackColor = true;
            BProductos.Click += BProductos_Click;
            // 
            // BSalir
            // 
            BSalir.Image = Properties.Resources.cerrar_sesion__1_;
            BSalir.Location = new Point(814, 12);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(80, 70);
            BSalir.TabIndex = 1;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // BCliente
            // 
            BCliente.Image = Properties.Resources.cliente;
            BCliente.Location = new Point(17, 12);
            BCliente.Name = "BCliente";
            BCliente.Size = new Size(80, 70);
            BCliente.TabIndex = 0;
            BCliente.UseVisualStyleBackColor = true;
            BCliente.Click += BCliente_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(926, 606);
            Controls.Add(panel1);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
    }
}