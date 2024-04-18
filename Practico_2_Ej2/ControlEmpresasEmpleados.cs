using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej2
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "IAlpha" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Udelar" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "SpaceZ" });
            listaEmpresas.Add(new Empresa { Id = 4, Nombre = "TechCorp" });
            listaEmpresas.Add(new Empresa { Id = 5, Nombre = "SoftWare Solutions" });
            listaEmpresas.Add(new Empresa { Id = 6, Nombre = "GlobalTech" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "JuanR", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "GonzaloT", Cargo = "CEO", EmpresaId = 2, Salario = 2888 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 7, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 3, Salario = 3800 });
            listaEmpleados.Add(new Empleado { Id = 8, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 3, Salario = 3888 }); 
            listaEmpleados.Add(new Empleado { Id = 9, Nombre = "Pedro", Cargo = "CEO", EmpresaId = 4, Salario = 3500 });
            listaEmpleados.Add(new Empleado { Id = 10, Nombre = "María", Cargo = "Desarrollador", EmpresaId = 4, Salario = 2200 });
            listaEmpleados.Add(new Empleado { Id = 11, Nombre = "Ana", Cargo = "Analista", EmpresaId = 4, Salario = 2400 });
            listaEmpleados.Add(new Empleado { Id = 12, Nombre = "José", Cargo = "CEO", EmpresaId = 5, Salario = 3200 });
            listaEmpleados.Add(new Empleado { Id = 13, Nombre = "Laura", Cargo = "Desarrollador", EmpresaId = 5, Salario = 2100 });
            listaEmpleados.Add(new Empleado { Id = 14, Nombre = "Carlos", Cargo = "Tester", EmpresaId = 5, Salario = 2300 });
            listaEmpleados.Add(new Empleado { Id = 15, Nombre = "Marta", Cargo = "Marketing", EmpresaId = 6, Salario = 3800 });
            listaEmpleados.Add(new Empleado { Id = 16, Nombre = "David", Cargo = "Analista", EmpresaId = 6, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 17, Nombre = "Elena", Cargo = "Artista", EmpresaId = 6, Salario = 2200 });
        }

        public void getCeo()
        {
            var empleados = from empleado in listaEmpleados
                            where empleado.Cargo == "CEO"
                            select empleado;

            foreach (Empleado elemento in empleados)
                elemento.getDatosEmpleado();
        }

        public void getEmpleadosOrdenados()
        {
            var empleados = from empleado in listaEmpleados
                            orderby empleado.Nombre
                            select empleado;

            foreach (Empleado elemento in empleados)
                elemento.getDatosEmpleado();
        }

        public void getEmpleadosOrdenadosSegun()
        {
            var empleados = from empleado in listaEmpleados
                            orderby empleado.Salario
                            select empleado;

            foreach (Empleado elemento in empleados)
                elemento.getDatosEmpleado();
        }

        public void getEmpleadosEmpresa(int _Empresa)
        {
            var empleados = from empleado in listaEmpleados
                            join empresa in listaEmpresas on empleado.EmpresaId equals empresa.Id
                            where empresa.Id == _Empresa
                            select empleado;

            foreach (Empleado elemento in empleados)
                elemento.getDatosEmpleado();
        }

        public void promedioSalario()
        {
            var consulta = from e in listaEmpleados
                           group e by e.EmpresaId into g
                           select new { empresa = g.Key, PromedioSalario = g.Average(e => e.Salario) };

            foreach (var resultado in consulta)
            {
                switch (resultado.empresa)
                {
                    case 1:
                        Console.WriteLine($"Empresa IAlpha - Promedio de salario: {resultado.PromedioSalario}");
                        break;
                    case 2:
                        Console.WriteLine($"Empresa Udelar - Promedio de salario: {resultado.PromedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"Empresa SpaceZ - Promedio de salario: {resultado.PromedioSalario}");
                        break;
                    case 4:
                        Console.WriteLine($"Empresa TechCorp - Promedio de salario: {resultado.PromedioSalario}");
                        break;
                    case 5:
                        Console.WriteLine($"Empresa SoftWare Solutions - Promedio de salario: {resultado.PromedioSalario}");
                        break;
                    case 6:
                        Console.WriteLine($"Empresa GlobalTech - Promedio de salario: {resultado.PromedioSalario}");
                        break;
                }
            }
        }
    }
}
