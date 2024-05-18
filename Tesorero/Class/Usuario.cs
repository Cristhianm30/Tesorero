using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Usuario
    {
        public int ID_Usuario {  get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; }
        public int ID_Rol { get; set; }
    }
}
