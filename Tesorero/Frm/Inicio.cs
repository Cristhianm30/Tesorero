using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesorero.Class;

namespace Tesorero.Frm
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        #region "Metodos propios"

        //Cerrar seccion 
        private void cerrar(object sender, FormClosedEventArgs e)
        {
            this.textBox_Usuario.Text = "";
            this.textBox_Contrasena.Text = "";
            this.Show();
            this.textBox_Usuario.Select();
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            DataTable TablaLogin = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            TablaLogin = Datos.login(textBox_Usuario.Text, textBox_Contrasena.Text);
            if (TablaLogin.Rows.Count>0){
                
                //Crea el form menu y muestra menu, luego de adiciona el metodo cerrar y esconde el form inicio
                Menu Frm_menu = new Menu();
                Frm_menu.ID_Usuario = Convert.ToInt32(TablaLogin.Rows[0][0]);
                Frm_menu.Nombre_Usuario = Convert.ToString(TablaLogin.Rows[0][1]);
                Frm_menu.Contrasena = Convert.ToString(TablaLogin.Rows[0][2]);
                Frm_menu.Descripcion = Convert.ToString(TablaLogin.Rows[0][3]);
                Frm_menu.ID_Rol = Convert.ToInt32(TablaLogin.Rows[0][4]);
                Frm_menu.Show();
                Frm_menu.FormClosed += cerrar;
                this.Hide();


            }
            else
            {
                MessageBox.Show("Usuario y/o Password no son valido... Porfavor verifique","Aviso del Sistema.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
