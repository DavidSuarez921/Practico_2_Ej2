using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej2
{
    internal class Empresa
    {
       
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public void getDatoEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }
}
