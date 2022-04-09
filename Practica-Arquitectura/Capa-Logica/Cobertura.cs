using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public abstract class Cobertura
    {
        //Descripción, Empresa, Cantidad máxima de personas del grupo familiar,
        //costo base de la cobertura y una lista de enfermedades que están incluidas en la misma.
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public int MaxGrupoFamiliar { get; set; }
        public int CostoBase { get; set; }
        public List<Enfermedad>ListaEnfermedades { get; set; }

        public abstract int GetCostoTotal();

    }
}
