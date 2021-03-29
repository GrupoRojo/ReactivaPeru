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
    public class Correo : Interfaces.ICorreo
    {
        //declaro objeto
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del Pros. Almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        public bool ActualizarCorreo(ECorreo correo)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCorreo(ECorreo correo)
        {
            throw new NotImplementedException();
        }

        public bool InsertarCorreo(ECorreo correo)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarCorreo(ECorreo correo)
        {
            throw new NotImplementedException();
        }
    }
}
