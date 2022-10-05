using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            this.listaEmpresas = new List<Empresa>();
            this.listaEmpleados =new List<Empleado>();
            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Pildoras" });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Juan", Cargo = "CEO", EmpresaId = 1, Salario = 1500 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Diaz", Cargo = "CEO", EmpresaId = 2, Salario = 1400 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Larry", Cargo = "CO-CEO", EmpresaId = 1, Salario = 1800 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Maria", Cargo = "Administrativo", EmpresaId = 2, Salario = 1900 });
        }
        /// <summary>
        /// Devulve empleados que sean Ceos con linq
        /// </summary>
        public void GetCeo()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;
            foreach (Empleado item in ceos)
            {
                item.getDatosEmpleado();
            }
        }
        public void GetCantidad()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;
            int cantidad = ceos.Count();
            Console.WriteLine(cantidad);
        }
        /// <summary>
        /// Ordena mis empleados utilizando la consulta orderby y si agregamos descending lo ordena al revez
        /// </summary>
        public void GetEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre descending select empleado;
            foreach (Empleado item in empleados)
            {
                item.getDatosEmpleado();
            }
        }
        /// <summary>
        /// devuelve los empleados que pérteneces a la empres pildoras
        /// </summary>
        public void GetEmpleadosPildoras()
        {
            IEnumerable<Empleado> empleadosPildoras = from empleado in listaEmpleados
                                              join empresa in listaEmpresas
                                              on empleado.EmpresaId equals empresa.Id
                                              where empresa.Nombre == "Pildoras"
                                              select empleado;
            foreach (Empleado item in empleadosPildoras)
            {
                item.getDatosEmpleado(); 
            }
        }
        /// <summary>
        /// Devuelve los empleados a los que pertecenen a la empresas por el id del parametro
        /// </summary>
        /// <param name="id"></param>
        public void GetEmpledaosEmpresa(int id)
        {

            IEnumerable<Empleado> empleadosEmpresas = from empleado in listaEmpleados
                                                      join empresa in listaEmpresas
                                                      on empleado.EmpresaId equals empresa.Id
                                                      where empresa.Id == id
                                                      select empleado;
            foreach (Empleado item in empleadosEmpresas)
            {
                item.getDatosEmpleado();
            }
        }
    }
}
