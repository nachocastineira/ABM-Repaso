using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parcial2.Entidades;

namespace Parcial2.Servicios
{
    public class EmpresaServices
    {
        Parcial2Entities bd = new Parcial2Entities();

        public List<Empresa> ListarEmpresas()
        {
            return bd.Empresa.ToList();
        }

        public void CrearEmpresa(Empresa empresa)
        {
            Empresa nuevaEmpresa = new Empresa();

            nuevaEmpresa.Id = empresa.Id;
            nuevaEmpresa.Nombre = empresa.Nombre;
            nuevaEmpresa.Direccion = empresa.Direccion;
            nuevaEmpresa.Ciudad = empresa.Ciudad;

            bd.Empresa.Add(nuevaEmpresa);
            bd.SaveChanges();
        }
    }
}