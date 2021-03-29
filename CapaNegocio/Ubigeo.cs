using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Uso:  CapaDatos
using CapaDatos;
//Buffer de memoria
using System.Data; //por si la funcion retorna un DataSet = tabla

namespace CapaNegocio
{
    public class Ubigeo : Interfaces.IUbigeo
    {
        //declaro objeto
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del Pros. Almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        public DataSet Direccion(EUbigeo ubigeo)
        {
            throw new NotImplementedException();
        }

        public DataSet ExtraerCodigoUbigeo(EUbigeo ubigeo)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarDepartamentos()
        {
            throw new NotImplementedException();
        }

        public DataSet ListarDistrito(EUbigeo ubigeo)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarProvincias(EUbigeo ubigeo)
        {
            throw new NotImplementedException();
        }
    }
}
