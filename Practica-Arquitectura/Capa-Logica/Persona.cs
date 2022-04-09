using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Persona
    {
        //Nombre y Apellido, DNI, Fecha de nacimiento, Ciudad, Ingresos netos anuales.
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public int IngresosNetos { get; set; }


        /*
         * 2- Se necesita un método que permita calcular para una persona específica, 
         * si puede acceder a una cobertura pasada como parámetro, teniendo en cuenta que el costo de la misma 
         * no puede ser mayor que los ingresos netos anuales de la persona. Este método debe retornar un valor booleano.
         */
        public bool PuedeAcceder(Cobertura cobertura)
        {                      
            return cobertura.GetCostoTotal() < this.IngresosNetos;
        }
    }
}
