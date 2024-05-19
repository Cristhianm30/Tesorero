using System;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        #region "Variables Propias"
            int ID_Usuario = 0;
            int Estado_Guardar = 0;


        #endregion

        #region "Metodos Propios"
        private void Limpiar_Texto()
        {
            Txt_Buscar.Text = "";
            Txt_Contrasena.Text = "";
            Txt_Nombre_Usuario.Text = "";
            Cbox_Rol.Text = "";
        }
        private void Estado_texto (bool lEstado)
        {
            Txt_Buscar.Enabled = lEstado;
            Txt_Contrasena.Enabled = lEstado;
            Txt_Nombre_Usuario.Enabled = lEstado;
        }

        private void Estado_Botones_Procesos(bool lEstado)
        {
            Btn_Cancelar.Visible = lEstado;
            Btn_Guardar.Visible = lEstado; 
        }

        private void Estado_Botones_Principales(bool lEstado)
        {
            Btn_Registrar.Enabled = lEstado;
            Btn_Actualizar.Enabled = lEstado;
            Btn_Eliminar.Enabled = lEstado;
            Btn_Regresar.Enabled = lEstado;
        }
        #endregion

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Estado_Guardar = 1; //Nuevo registro
            this.Limpiar_Texto();
            this.Estado_texto(true);
            this.Estado_Botones_Procesos(true);
            this.Estado_Botones_Principales(false);
            this.Txt_Nombre_Usuario.Focus();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Estado_Guardar = 0;
            this.Limpiar_Texto();
            this.Estado_texto(false);
            this.Estado_Botones_Procesos(false);
            this.Estado_Botones_Principales(true);
        }
    }
}
