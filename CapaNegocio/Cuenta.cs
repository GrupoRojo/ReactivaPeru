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
    public class Cuenta : Interfaces.ICuenta
    {
        //declaro objeto
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del Pros. Almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        //metodos de Cuenta
        public bool ExisteCuenta(string usuario_o_correo, string contra)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spExisteCuenta", usuario_o_correo, contra);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet InfoCuenta(ECuenta cuenta)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            return datos.TraerDataSet("spInfoCuenta", cuenta.CodCuenta);
        }

        public bool AgregarCuenta(ECuenta cuenta)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spAgregarCuenta", cuenta.CorreoSeguro, cuenta.Usuario, cuenta.Contrasena, DateTime.Now);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool DesactivarCuenta(ECuenta cuenta)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spDesactivarCuenta", cuenta.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ReactivarCuenta(ECuenta cuenta)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spReactivarCuenta", cuenta.CodCuenta);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarCuentaContra(ECuenta cuenta,string NuevaContra)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarCuentaContra", cuenta.CodCuenta,cuenta.Contrasena,NuevaContra);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarCuentaSeudo(ECuenta cuenta)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarCuentaSeudo", cuenta.CodCuenta, cuenta.Seudonimo);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool ActualizarCuentaPriva(ECuenta cuenta)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarCuentaPriva", cuenta.CodCuenta, cuenta.CodPrivacidad);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        

        
    }
}
