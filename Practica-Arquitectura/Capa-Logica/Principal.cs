using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public sealed class Singleton 
    {
        private readonly static Singleton instance = new Singleton();
        private Singleton()
        {

        }
        public static Singleton Instance
        { get { return instance; } }
    }
}
