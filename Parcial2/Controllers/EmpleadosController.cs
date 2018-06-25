using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Entidades;
using Parcial2.Servicios;

namespace Parcial2.Controllers
{
    public class EmpleadosController : Controller
    {

        EmpleadoServices empleadoServices = new EmpleadoServices();
        EmpresaServices empresaServices = new EmpresaServices();


        public ActionResult Listar()
        {
            return View(empleadoServices.ListarEmpleados());
        }


        public ActionResult Alta()
        {
                      
            return View(empresaServices.ListarEmpresas());
        }


        [HttpPost]
        public ActionResult Alta(Empleado empleado)
        {
            empleadoServices.CrearEmpleado(empleado);

            return RedirectToAction("Listar");
        }


        public ActionResult Baja(Empleado empleado)
        {

            return View(empleadoServices.ObtenerEmpleadoPorId(empleado.Id)); //retorno a esa vista el empleado seleccionado en el listado
        }


        [HttpPost]
        public ActionResult Baja(int id)
        {
            empleadoServices.EliminarEmpleado(id);

            return RedirectToAction("Listar");
        }


        public ActionResult Modificacion(int id)
        {
            return View(empleadoServices.ObtenerEmpleadoPorId(id));
        }

        [HttpPost]
        public ActionResult Modificacion(Empleado empleado)
        {
            empleadoServices.ModificarEmpleado(empleado);

            return RedirectToAction("Listar");
        }
    }
}