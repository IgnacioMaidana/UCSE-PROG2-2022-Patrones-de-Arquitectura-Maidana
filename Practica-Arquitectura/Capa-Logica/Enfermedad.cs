using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Enfermedad
    {
        //tipo de enfermedad (CORONARIA, MENTAL, ETC), nombre y un costo asociado.
        public Enfermedad TipoEnfermedad { get; set; }
        public string Nombre { get; set; }
        public int Costo { get; set; }
    }
}
