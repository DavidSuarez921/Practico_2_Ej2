using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej2
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        public int EmpresaId { get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, con cargo {2}, con salario {3} y pertenece a " + "La empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }
}
