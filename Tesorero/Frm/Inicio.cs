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
                MessageBox.Show("Inicio Exitoso");

            }
            else
            {
                MessageBox.Show("Acceso Denegado.");
            }
        }
    }
}
