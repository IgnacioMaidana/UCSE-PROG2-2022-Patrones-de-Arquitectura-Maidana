using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Atencion
    {        
        //Si la tiene, se debe registrar una nueva atención, guardando un número autoincremental, 
        //la fecha de atención (que no es la de sistema), los datos de la enfermedad, y los datos del cliente.

        public int Nro { get; set; }
        public DateTime FechaAtencion { get; set; }
        public Enfermedad Enfermedad { get; set; }
        public Persona Persona { get; set; }

        public Atencion(int nro, DateTime fechaAtencion, Enfermedad enfermedad, Persona persona)
        {
            Nro = nro;
            FechaAtencion = fechaAtencion;
            Enfermedad = enfermedad;
            Persona = persona;
        }
    }
}
