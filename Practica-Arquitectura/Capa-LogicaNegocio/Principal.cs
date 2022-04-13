using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public sealed class Singleton 
    {
        private readonly Singleton instance = new Singleton();
        private Singleton()
        {
            
        }
        public Singleton Instance
        { get { return instance; } }


        //Se necesita un método que permita cargar atenciones (cuando una persona usa la cobertura para una enfermedad). 
        //Inicialmente se recibe el DNI de la persona y un código de enfermedad, y en base a su cobertura seleccionada 
        //se debe validar que la misma tenga habilitada esa enfermedad.        
        //Retornar el precio que tiene la enfermedad que originó la atención. En caso de alguna validación incorrecta retornar 0.
        List<Atencion> ListaAtenciones = new List<Atencion>();
        List<Enfermedad> ListaEnfermedades = new List<Enfermedad>();
        List<Persona> ListaClientes = new List<Persona>();

        public int CargarAtencion(int DNI, int codEnfermedad, Cobertura cobertura)
        {            
            
            Persona persona = ListaClientes.Where(x => x.DNI == DNI).First();
            if (persona != null && persona.PuedeAcceder(cobertura))
            {
                if (cobertura.ListaEnfermedades.Exists(x => x.Codigo == codEnfermedad))
                {
                    Enfermedad enfermedad = cobertura.ListaEnfermedades.Where(x => x.Codigo == codEnfermedad).First();
                    Atencion atencion = new Atencion(ListaAtenciones.Count + 1, DateTime.Today, enfermedad, persona);

                    return enfermedad.Costo;
                }                    
            }
            return 0;          

        }
         

    }
}
