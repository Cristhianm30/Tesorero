using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Inventario
    {
        public int ID_Inventario {  get; set; }
        public int ID_Producto_Almacen { get; set; }
        public decimal Cantidad_Stock { get; set; }
        public string Fecha_Ultima_Actualizacion { get; set; }

    }
}
