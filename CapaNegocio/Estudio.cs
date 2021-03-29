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
    public class Estudio : Interfaces.IEstudio
    {
        //declaro objeto
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del Pros. Almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        public bool ActualizarEstudio(EEstudio estudio)
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudio(EEstudio estudio)
        {
            throw new NotImplementedException();
        }

        public bool InsertarEstudio(EEstudio estudio)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarEstudios(EEstudio estudio)
        {
            throw new NotImplementedException();
        }
    }
}
