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
//using System.Data; //por si la funcion retorna un DataSet = tabla

namespace CapaNegocio
{
    public class Info : Interfaces.IInfo
    {
        //declaro objeto
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del Pros. Almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        public DataSet ListarInfo(EInfo info)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            return datos.TraerDataSet("spListarInfo", info.CodCuenta);
        }
        public bool ActualizarInfo(EInfo info)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarInfo", info.Apellidos, info.Nombres, info.Nacimiento,info.DNI,info.Informacion,info.Direccion,info.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        
    }
}
