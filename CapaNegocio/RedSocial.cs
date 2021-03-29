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
    public class RedSocial : Interfaces.IRedSocial
    {
        //declaro objeto
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del Pros. Almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        public bool ActualizarRedSocial(ERedSocial redsocial)
        {
            throw new NotImplementedException();
        }

        public bool EliminarRedSocial(ERedSocial redsocial)
        {
            throw new NotImplementedException();
        }

        public bool InsertarRedSocial(ERedSocial redsocial)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarRedSocial(ERedSocial redsocial)
        {
            throw new NotImplementedException();
        }
    }
}
