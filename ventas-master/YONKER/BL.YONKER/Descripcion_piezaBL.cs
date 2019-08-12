using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.YONKER
{
    public class Descripcion_piezaBL
    {
        public BindingList<Descripcion> ListDescripcion { get; set; }

        public Descripcion_piezaBL()

        public BindingList<Descripcion> ObtenerDescripcion()
    }

    public class Descripcion
    {
        public int Codigo { get; set; }
        public string Descripcion_Nombre { get; set; }
        public double Precio { get; set; }
        public int Excistencia { get; set; }
        public bool Activo { get; set; }
         
    }
}
