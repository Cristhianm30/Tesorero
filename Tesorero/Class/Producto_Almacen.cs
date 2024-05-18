using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Producto_Almacen
    {
        public int ID_Producto_Almacen { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public string Unidad_Medida { get; set; }
        public decimal Precio_Unitario { get; set; }
    }
}
