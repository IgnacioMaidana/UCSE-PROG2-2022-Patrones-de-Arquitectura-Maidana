using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class CobNormal : Cobertura
    {
        public int CostoTotal
        {
            get { return this.CostoTotal; }

            set
            {
                foreach (Enfermedad enfermedad in ListaEnfermedades)                
                    this.CostoTotal += enfermedad.Costo;

                this.CostoTotal = this.CostoTotal / ListaEnfermedades.Count() + CostoBase;
                
            }
        }
        public override int GetCostoTotal()
            { return this.CostoTotal; }
    }
}
