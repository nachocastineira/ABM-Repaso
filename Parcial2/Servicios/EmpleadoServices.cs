using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parcial2.Entidades;

namespace Parcial2.Servicios
{
    public class EmpleadoServices
    {
        Parcial2Entities bd = new Parcial2Entities();

        public List<Empleado> ListarEmpleados()
        {
            return bd.Empleado.OrderBy(e => e.Apellido).ToList(); //los listo ordernados por apellido
        }

        public Empleado ObtenerEmpleadoPorId(int idSeleccionado)
        {
            return bd.Empleado.FirstOrDefault(e => e.Id == idSeleccionado);
        }

        public void CrearEmpleado(Empleado empleado)
        {
            Empleado nuevoEmpleado = new Empleado();

            nuevoEmpleado.Id = empleado.Id;
            nuevoEmpleado.Nombre = empleado.Nombre;
            nuevoEmpleado.Apellido = empleado.Apellido;
            nuevoEmpleado.Edad = empleado.Edad;
            nuevoEmpleado.Id_Empresa = empleado.Id_Empresa;

            bd.Empleado.Add(nuevoEmpleado);
            bd.SaveChanges();
        }

        public void ModificarEmpleado (Empleado empleadoSeleccionado)
        {
            Empleado empleadoActual = bd.Empleado.FirstOrDefault(e => e.Id == empleadoSeleccionado.Id);

            empleadoActual.Nombre = empleadoSeleccionado.Nombre;
            empleadoActual.Apellido = empleadoSeleccionado.Apellido;
            empleadoActual.Edad = empleadoSeleccionado.Edad;
            empleadoActual.Id_Empresa = empleadoSeleccionado.Id_Empresa;

            bd.SaveChanges();
        }

        public void EliminarEmpleado(int idSeleccionado)
        {
            Empleado empleadoABorrar = ObtenerEmpleadoPorId(idSeleccionado);

            bd.Empleado.Remove(empleadoABorrar);
            bd.SaveChanges();
        }
    }
}