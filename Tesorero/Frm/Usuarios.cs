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
            Txt_Buscar.Enabled= lEstado;
            Dgv_Listado.Enabled = lEstado;
            Btn_Buscar.Enabled = lEstado;
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

        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["ID_Rol"].Value)))
            {
                MessageBox.Show("Selecione un registro","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else{
                ID_Usuario = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["ID_Rol"].Value);
                Txt_Nombre_Usuario.Text = Dgv_Listado.CurrentRow.Cells["Nombre_Usuario"].Value.ToString();
                Txt_Contrasena.Text = "";
                Cbox_Rol.Text = Dgv_Listado.CurrentRow.Cells["Descripcion"].Value.ToString();
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

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (ID_Usuario == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        D_Usuarios Datos = new D_Usuarios();
                        string Respuesta = Datos.Guardar_Usuario(3, new Usuario { ID_Usuario = ID_Usuario });
                        if (int.TryParse(Respuesta, out int codigo))
                        {
                            MessageBox.Show("Registro eliminado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Listado_usuario("%");
                            this.Limpiar_Texto();
                            this.Estado_texto(false);
                            this.Estado_Botones_Procesos(false);
                            this.Estado_Botones_Principales(true);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el registro: " + Respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Estado_Guardar = 2; 
            this.Estado_texto(true);
            Txt_Nombre_Usuario.Enabled = false;
            this.Estado_Botones_Procesos(true);
            this.Estado_Botones_Principales(false);
            this.Txt_Contrasena.Focus();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre_Usuario.Text == string.Empty || Txt_Contrasena.Text == string.Empty || Cbox_Rol.Text == string.Empty)
            {
                MessageBox.Show("Ingrese los datos requeridos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string Respuesta;
                Usuario Pro = new Usuario();
                Pro.ID_Usuario = ID_Usuario;
                Pro.Nombre_Usuario = Txt_Nombre_Usuario.Text;
                Pro.Contrasena = Txt_Contrasena.Text;
                Pro.ID_Rol = Convert.ToInt32(Cbox_Rol.SelectedValue);
                D_Usuarios Datos = new D_Usuarios();
                Respuesta = Datos.Guardar_Usuario(Estado_Guardar, Pro);
                bool esNumero = int.TryParse(Respuesta, out int xCodigo);
                if (esNumero==true) 
                {
                    Estado_Guardar = 0;
                    ID_Usuario = 0;
                    this.Limpiar_Texto();
                    this.Estado_texto(false);
                    this.Estado_Botones_Procesos(false);
                    this.Estado_Botones_Principales(true);
                    this.Listado_usuario("%");
                    MessageBox.Show("Los datos se han guardado correctamente en el codigo #" + Respuesta.Trim(), "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Dgv_Listado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item();
        }
    }
}
