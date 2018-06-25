using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Entidades;
using Parcial2.Servicios;

namespace Parcial2.Controllers
{
    public class EmpresasController : Controller
    {
        EmpresaServices empresaServices = new EmpresaServices();

        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Empresa empresa)
        {
            empresaServices.CrearEmpresa(empresa);
            
            return View();
        }
    }
}