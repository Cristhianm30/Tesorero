namespace Tesorero.Frm
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Panel_Footer = new System.Windows.Forms.Panel();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Panel_Contenido = new System.Windows.Forms.Panel();
            this.Btn_Clientes = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Factura = new System.Windows.Forms.Button();
            this.Btn_Productos = new System.Windows.Forms.Button();
            this.Btn_Inventario = new System.Windows.Forms.Button();
            this.Btn_Registro = new System.Windows.Forms.Button();
            this.Btn_proveedores = new System.Windows.Forms.Button();
            this.Btn_Informes = new System.Windows.Forms.Button();
            this.Btn_Ordenar = new System.Windows.Forms.Button();
            this.Img_Logotipo = new System.Windows.Forms.PictureBox();
            this.Lbl_Nombre_Usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Rol = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Usuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Header.SuspendLayout();
            this.Panel_Footer.SuspendLayout();
            this.Panel_Menu.SuspendLayout();
            this.Panel_Contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Logotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(121)))));
            this.Panel_Header.Controls.Add(this.Img_Logotipo);
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(904, 72);
            this.Panel_Header.TabIndex = 0;
            // 
            // Panel_Footer
            // 
            this.Panel_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(108)))));
            this.Panel_Footer.Controls.Add(this.Lbl_Rol);
            this.Panel_Footer.Controls.Add(this.pictureBox1);
            this.Panel_Footer.Controls.Add(this.Lbl_Nombre_Usuario);
            this.Panel_Footer.Location = new System.Drawing.Point(0, 530);
            this.Panel_Footer.Name = "Panel_Footer";
            this.Panel_Footer.Size = new System.Drawing.Size(904, 82);
            this.Panel_Footer.TabIndex = 1;
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(104)))), ((int)(((byte)(68)))));
            this.Panel_Menu.Controls.Add(this.panel2);
            this.Panel_Menu.Controls.Add(this.panel1);
            this.Panel_Menu.Controls.Add(this.Btn_Usuarios);
            this.Panel_Menu.Location = new System.Drawing.Point(902, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(184, 612);
            this.Panel_Menu.TabIndex = 2;
            this.Panel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Menu_Paint);
            // 
            // Panel_Contenido
            // 
            this.Panel_Contenido.BackColor = System.Drawing.Color.Beige;
            this.Panel_Contenido.Controls.Add(this.Btn_Clientes);
            this.Panel_Contenido.Controls.Add(this.btn_Factura);
            this.Panel_Contenido.Controls.Add(this.Btn_Productos);
            this.Panel_Contenido.Controls.Add(this.Btn_Inventario);
            this.Panel_Contenido.Controls.Add(this.Btn_Registro);
            this.Panel_Contenido.Controls.Add(this.Btn_proveedores);
            this.Panel_Contenido.Controls.Add(this.Btn_Informes);
            this.Panel_Contenido.Controls.Add(this.Btn_Ordenar);
            this.Panel_Contenido.Location = new System.Drawing.Point(0, 60);
            this.Panel_Contenido.Name = "Panel_Contenido";
            this.Panel_Contenido.Size = new System.Drawing.Size(904, 474);
            this.Panel_Contenido.TabIndex = 3;
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clientes.ImageKey = "Clientes.png";
            this.Btn_Clientes.ImageList = this.imageList1;
            this.Btn_Clientes.Location = new System.Drawing.Point(705, 276);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.Size = new System.Drawing.Size(154, 126);
            this.Btn_Clientes.TabIndex = 7;
            this.Btn_Clientes.Text = "Clientes";
            this.Btn_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Clientes.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Facturacion.png");
            this.imageList1.Images.SetKeyName(1, "Informes.png");
            this.imageList1.Images.SetKeyName(2, "Inventario.png");
            this.imageList1.Images.SetKeyName(3, "Proveedores.png");
            this.imageList1.Images.SetKeyName(4, "Registro.png");
            this.imageList1.Images.SetKeyName(5, "Productos.png");
            this.imageList1.Images.SetKeyName(6, "Preguntas.png");
            this.imageList1.Images.SetKeyName(7, "Clientes.png");
            this.imageList1.Images.SetKeyName(8, "Ordenar.png");
            this.imageList1.Images.SetKeyName(9, "Salir.png");
            // 
            // btn_Factura
            // 
            this.btn_Factura.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Factura.ImageKey = "Facturacion.png";
            this.btn_Factura.ImageList = this.imageList1;
            this.btn_Factura.Location = new System.Drawing.Point(705, 55);
            this.btn_Factura.Name = "btn_Factura";
            this.btn_Factura.Size = new System.Drawing.Size(154, 126);
            this.btn_Factura.TabIndex = 6;
            this.btn_Factura.Text = "Facturar";
            this.btn_Factura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Factura.UseVisualStyleBackColor = true;
            // 
            // Btn_Productos
            // 
            this.Btn_Productos.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Productos.ImageKey = "Productos.png";
            this.Btn_Productos.ImageList = this.imageList1;
            this.Btn_Productos.Location = new System.Drawing.Point(263, 55);
            this.Btn_Productos.Name = "Btn_Productos";
            this.Btn_Productos.Size = new System.Drawing.Size(154, 126);
            this.Btn_Productos.TabIndex = 5;
            this.Btn_Productos.Text = "Productos";
            this.Btn_Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Productos.UseVisualStyleBackColor = true;
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventario.ImageKey = "Inventario.png";
            this.Btn_Inventario.ImageList = this.imageList1;
            this.Btn_Inventario.Location = new System.Drawing.Point(496, 55);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(154, 126);
            this.Btn_Inventario.TabIndex = 4;
            this.Btn_Inventario.Text = "Inventario";
            this.Btn_Inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Inventario.UseVisualStyleBackColor = true;
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registro.ImageKey = "Registro.png";
            this.Btn_Registro.ImageList = this.imageList1;
            this.Btn_Registro.Location = new System.Drawing.Point(496, 276);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(154, 126);
            this.Btn_Registro.TabIndex = 3;
            this.Btn_Registro.Text = "Registro";
            this.Btn_Registro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Registro.UseVisualStyleBackColor = true;
            // 
            // Btn_proveedores
            // 
            this.Btn_proveedores.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_proveedores.ImageKey = "Proveedores.png";
            this.Btn_proveedores.ImageList = this.imageList1;
            this.Btn_proveedores.Location = new System.Drawing.Point(41, 276);
            this.Btn_proveedores.Name = "Btn_proveedores";
            this.Btn_proveedores.Size = new System.Drawing.Size(154, 126);
            this.Btn_proveedores.TabIndex = 2;
            this.Btn_proveedores.Text = "Proveedores";
            this.Btn_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_proveedores.UseVisualStyleBackColor = true;
            // 
            // Btn_Informes
            // 
            this.Btn_Informes.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Informes.ImageKey = "Informes.png";
            this.Btn_Informes.ImageList = this.imageList1;
            this.Btn_Informes.Location = new System.Drawing.Point(263, 276);
            this.Btn_Informes.Name = "Btn_Informes";
            this.Btn_Informes.Size = new System.Drawing.Size(154, 126);
            this.Btn_Informes.TabIndex = 1;
            this.Btn_Informes.Text = "Informes";
            this.Btn_Informes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Informes.UseVisualStyleBackColor = true;
            // 
            // Btn_Ordenar
            // 
            this.Btn_Ordenar.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ordenar.ImageKey = "Ordenar.png";
            this.Btn_Ordenar.ImageList = this.imageList1;
            this.Btn_Ordenar.Location = new System.Drawing.Point(41, 55);
            this.Btn_Ordenar.Name = "Btn_Ordenar";
            this.Btn_Ordenar.Size = new System.Drawing.Size(154, 126);
            this.Btn_Ordenar.TabIndex = 0;
            this.Btn_Ordenar.Text = "Ordenar";
            this.Btn_Ordenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Ordenar.UseVisualStyleBackColor = true;
            // 
            // Img_Logotipo
            // 
            this.Img_Logotipo.Image = ((System.Drawing.Image)(resources.GetObject("Img_Logotipo.Image")));
            this.Img_Logotipo.Location = new System.Drawing.Point(320, 3);
            this.Img_Logotipo.Name = "Img_Logotipo";
            this.Img_Logotipo.Size = new System.Drawing.Size(300, 69);
            this.Img_Logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Logotipo.TabIndex = 0;
            this.Img_Logotipo.TabStop = false;
            // 
            // Lbl_Nombre_Usuario
            // 
            this.Lbl_Nombre_Usuario.AutoSize = true;
            this.Lbl_Nombre_Usuario.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.Lbl_Nombre_Usuario.Location = new System.Drawing.Point(111, 19);
            this.Lbl_Nombre_Usuario.Name = "Lbl_Nombre_Usuario";
            this.Lbl_Nombre_Usuario.Size = new System.Drawing.Size(74, 23);
            this.Lbl_Nombre_Usuario.TabIndex = 0;
            this.Lbl_Nombre_Usuario.Text = "Usuario";
            this.Lbl_Nombre_Usuario.Click += new System.EventHandler(this.Lbl_Nombre_Usuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 71);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Rol
            // 
            this.Lbl_Rol.AutoSize = true;
            this.Lbl_Rol.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.Lbl_Rol.Location = new System.Drawing.Point(111, 49);
            this.Lbl_Rol.Name = "Lbl_Rol";
            this.Lbl_Rol.Size = new System.Drawing.Size(37, 23);
            this.Lbl_Rol.TabIndex = 2;
            this.Lbl_Rol.Text = "Rol";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_Salir.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.ImageKey = "Salir02.png";
            this.Btn_Salir.ImageList = this.imageList2;
            this.Btn_Salir.Location = new System.Drawing.Point(14, 19);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(160, 50);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "   Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Salir.png");
            this.imageList2.Images.SetKeyName(1, "Salir01.png");
            this.imageList2.Images.SetKeyName(2, "Salir02.png");
            this.imageList2.Images.SetKeyName(3, "guacamayo.png");
            // 
            // Btn_Usuarios
            // 
            this.Btn_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(104)))), ((int)(((byte)(68)))));
            this.Btn_Usuarios.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Usuarios.ForeColor = System.Drawing.Color.Snow;
            this.Btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Usuarios.ImageKey = "guacamayo.png";
            this.Btn_Usuarios.ImageList = this.imageList2;
            this.Btn_Usuarios.Location = new System.Drawing.Point(14, 97);
            this.Btn_Usuarios.Name = "Btn_Usuarios";
            this.Btn_Usuarios.Size = new System.Drawing.Size(160, 55);
            this.Btn_Usuarios.TabIndex = 1;
            this.Btn_Usuarios.Text = "    Usuarios";
            this.Btn_Usuarios.UseVisualStyleBackColor = false;
            this.Btn_Usuarios.Click += new System.EventHandler(this.Btn_Usuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 72);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 82);
            this.panel2.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_Footer);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Contenido);
            this.Controls.Add(this.Panel_Menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tesorero";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Footer.ResumeLayout(false);
            this.Panel_Footer.PerformLayout();
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_Contenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Logotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Panel Panel_Footer;
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Contenido;
        private System.Windows.Forms.Button Btn_Ordenar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_Productos;
        private System.Windows.Forms.Button Btn_Inventario;
        private System.Windows.Forms.Button Btn_Registro;
        private System.Windows.Forms.Button Btn_proveedores;
        private System.Windows.Forms.Button Btn_Informes;
        private System.Windows.Forms.Button Btn_Clientes;
        private System.Windows.Forms.Button btn_Factura;
        private System.Windows.Forms.PictureBox Img_Logotipo;
        private System.Windows.Forms.Label Lbl_Nombre_Usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Rol;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button Btn_Usuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}