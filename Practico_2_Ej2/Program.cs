using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();
            Console.WriteLine("Promedios por empresas \n----------------------------");
            ce.promedioSalario();
            Console.WriteLine("");
            Console.WriteLine("Peces Gordos \n----------------------------");
            ce.getCeo();
            Console.WriteLine("");
            Console.WriteLine("Plantilla \n----------------------------");
            ce.getEmpleadosOrdenados();
            Console.WriteLine("");
            Console.WriteLine("Plantilla ordenada por salario \n----------------------------");
            ce.getEmpleadosOrdenadosSegun();
            Console.WriteLine("\nIngrese la empresa: (entero 1 a 3)\n1 para IAlpha\n2 para UdelaR\n3 para SpaceZ");
            string _Id = Console.ReadLine();
            try
            {
                int _Empresa = int.Parse(_Id);
                ce.getEmpleadosEmpresa(_Empresa);
            }
            catch
            {
                Console.WriteLine("Ha introducido un Id erroneo. Debe ingresar un numero entero");
            }
        }
    }
}
