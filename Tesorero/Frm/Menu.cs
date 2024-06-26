﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesorero.Frm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        #region "variables propias"

        internal int ID_Usuario {  get; set; }
        internal string Nombre_Usuario { get; set; }
        internal string Contrasena {  get; set; }
        internal string Descripcion { get; set; }
        internal int ID_Rol { get; set;}

        #endregion

        private void Menu_Load(object sender, EventArgs e)
        {
            Lbl_Nombre_Usuario.Text = Nombre_Usuario;
            Lbl_Rol.Text = Descripcion;
        }

        private void Lbl_Nombre_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas Cerrar la Sesion ?","Aviso del Sistema",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Panel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            if (ID_Rol == 1)
            {
                Usuarios Frm_usuarios = new Usuarios();
                Frm_usuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes permisos de administrador para acceder", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void Btn_Ordenar_Click(object sender, EventArgs e)
        {
            Ordenar Frm_Ordenar = new Ordenar();
            Frm_Ordenar.ShowDialog();
        }
    }
}
