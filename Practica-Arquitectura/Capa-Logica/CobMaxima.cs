using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class CobMaxima : Cobertura
    {
        public int CostoTotal
        {
            get { return this.CostoTotal; }

            set
            {
                foreach(Enfermedad enfermedad in ListaEnfermedades)
                {
                    this.CostoTotal += enfermedad.Costo;
                }
            }
        }
        public override int GetCostoTotal()
            { return this.CostoTotal; }
    }
}
