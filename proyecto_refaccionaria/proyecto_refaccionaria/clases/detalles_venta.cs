using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_refaccionaria.clases
{
    public class detalles_venta
    {
        public int id_producto { get; set; }
        public int id_venta { get; set; }
        public float precio { get; set; }
        public int cantidad { get; set; }
    }
}
