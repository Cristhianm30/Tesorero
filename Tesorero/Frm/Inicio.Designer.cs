namespace Tesorero.Frm
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Btn_Inicio = new System.Windows.Forms.Button();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Contrasena = new System.Windows.Forms.Label();
            this.textBox_Contrasena = new System.Windows.Forms.TextBox();
            this.pictureBox_Logo_Logotipo = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo_Logotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Inicio
            // 
            this.Btn_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(59)))));
            this.Btn_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Inicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Inicio.Font = new System.Drawing.Font("Constantia", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(121)))));
            this.Btn_Inicio.Location = new System.Drawing.Point(403, 296);
            this.Btn_Inicio.Name = "Btn_Inicio";
            this.Btn_Inicio.Size = new System.Drawing.Size(185, 46);
            this.Btn_Inicio.TabIndex = 0;
            this.Btn_Inicio.Text = "Inicio";
            this.Btn_Inicio.UseVisualStyleBackColor = false;
            this.Btn_Inicio.Click += new System.EventHandler(this.Btn_Inicio_Click);
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(62)))));
            this.textBox_Usuario.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(121)))));
            this.textBox_Usuario.Location = new System.Drawing.Point(352, 116);
            this.textBox_Usuario.MaxLength = 25;
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(300, 31);
            this.textBox_Usuario.TabIndex = 2;
            this.textBox_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.Lbl_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Usuario.ImageKey = "pirata (1).png";
            this.Lbl_Usuario.ImageList = this.imageList1;
            this.Lbl_Usuario.Location = new System.Drawing.Point(349, 77);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(119, 26);
            this.Lbl_Usuario.TabIndex = 3;
            this.Lbl_Usuario.Text = "       Usuario";
            this.Lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Contrasena
            // 
            this.Lbl_Contrasena.AutoSize = true;
            this.Lbl_Contrasena.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(37)))));
            this.Lbl_Contrasena.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Contrasena.ImageKey = "pirata.png";
            this.Lbl_Contrasena.ImageList = this.imageList1;
            this.Lbl_Contrasena.Location = new System.Drawing.Point(347, 181);
            this.Lbl_Contrasena.Name = "Lbl_Contrasena";
            this.Lbl_Contrasena.Size = new System.Drawing.Size(150, 26);
            this.Lbl_Contrasena.TabIndex = 5;
            this.Lbl_Contrasena.Text = "       Contraseña";
            this.Lbl_Contrasena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Contrasena.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Contrasena
            // 
            this.textBox_Contrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(62)))));
            this.textBox_Contrasena.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(121)))));
            this.textBox_Contrasena.Location = new System.Drawing.Point(352, 220);
            this.textBox_Contrasena.MaxLength = 25;
            this.textBox_Contrasena.Name = "textBox_Contrasena";
            this.textBox_Contrasena.PasswordChar = '*';
            this.textBox_Contrasena.Size = new System.Drawing.Size(300, 31);
            this.textBox_Contrasena.TabIndex = 4;
            this.textBox_Contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Contrasena.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox_Logo_Logotipo
            // 
            this.pictureBox_Logo_Logotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.pictureBox_Logo_Logotipo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo_Logotipo.Image")));
            this.pictureBox_Logo_Logotipo.Location = new System.Drawing.Point(12, 53);
            this.pictureBox_Logo_Logotipo.Name = "pictureBox_Logo_Logotipo";
            this.pictureBox_Logo_Logotipo.Size = new System.Drawing.Size(241, 234);
            this.pictureBox_Logo_Logotipo.TabIndex = 6;
            this.pictureBox_Logo_Logotipo.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(274, 376);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pirata (1).png");
            this.imageList1.Images.SetKeyName(1, "pirata.png");
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(191)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(743, 376);
            this.Controls.Add(this.pictureBox_Logo_Logotipo);
            this.Controls.Add(this.Lbl_Contrasena);
            this.Controls.Add(this.textBox_Contrasena);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.Btn_Inicio);
            this.Controls.Add(this.splitter1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tesorero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo_Logotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Inicio;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Contrasena;
        private System.Windows.Forms.TextBox textBox_Contrasena;
        private System.Windows.Forms.PictureBox pictureBox_Logo_Logotipo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

