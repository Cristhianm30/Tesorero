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
            Cbox_Rol.Enabled = lEstado;
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

        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 50;
            Dgv_Listado.Columns[0].HeaderText = "ID";
            Dgv_Listado.Columns[1].Width = 230;
            Dgv_Listado.Columns[1].HeaderText = "Usuario";
            Dgv_Listado.Columns[2].Width = 225;
            Dgv_Listado.Columns[2].HeaderText = "Rol";
            Dgv_Listado.Columns[3].Visible = false;


        }

        private void Listado_usuario(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            Dgv_Listado.DataSource = Datos.Listado_Usuario(cTexto);
            this.Formato();
        }

        private void Listado_Rol()
        {
            try
            {
                D_Usuarios Datos = new D_Usuarios();
                Cbox_Rol.DataSource= Datos.Listado_Rol();
                Cbox_Rol.ValueMember = "ID_Rol";
                Cbox_Rol.DisplayMember = "Descripcion";

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_Rol();
            this.Listado_usuario("%");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.Listado_usuario(Txt_Buscar.Text);
        }
    }
}
