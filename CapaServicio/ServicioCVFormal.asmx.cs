using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//Uso la CapaNegocio
using CapaNegocio;
//Uso la CapaEnridad
using CapaEntidad;
//Buffer de memoria
using System.Data; //por si la funcion retorna un DataSet = tabla

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de ServicioCVFormal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCVFormal : System.Web.Services.WebService
    {
        //-----------------------------------------------------------------------
        //  Creo mis Objetos y Entidades  +/
        //-----------------------------------------------------------------------

        //creo un objeto cuneta y la entindadCuenta para usar sus atributos
        private Cuenta cuenta = new Cuenta();
        private ECuenta entindadCuenta = new ECuenta();
        //creo un objeto info y la entindadInfo para usar sus atributos
        private Info info = new Info();
        private EInfo entidadInfo = new EInfo();







        //-----------------------------------------------------------------------
        //  Trabajo con Cuenta  +/
        //-----------------------------------------------------------------------

        [WebMethod(Description = "ExisteCuenta")]
        public string[] ExisteCuenta(string Usuario_o_Correo, string Contrasena)
        {
            string[] arreglo = {
                (cuenta.ExisteCuenta(Usuario_o_Correo,Contrasena)).ToString(),
                cuenta.Mensaje
            };
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "InfoCuenta")]
        public DataSet InfoCuenta(int CodCuenta)
        {
            //lleno atributos de la entidad
            entindadCuenta.CodCuenta = CodCuenta;
            //invoco al metodo del objeto con el parametro entidad
            return cuenta.InfoCuenta(entindadCuenta);
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "AgregarCuenta")]
        public string[] AgregarCuenta(string CorreoSeguro, string Usuario, string Contrasena, DateTime FechaRegistro)
        {
            //lleno atributos de la entidad
            entindadCuenta.CorreoSeguro = CorreoSeguro;
            entindadCuenta.Usuario = Usuario;
            entindadCuenta.Contrasena = Contrasena;
            entindadCuenta.FechaRegistro = FechaRegistro;
            //invoco al metodo del objeto con el parametro entidad
            string[] arreglo = {
                (cuenta.AgregarCuenta(entindadCuenta)).ToString(),
                cuenta.Mensaje
            };
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "DesactivarCuenta")]
        public string[] DesactivarCuenta(int CodCuenta)
        {
            //lleno atributos de la entidad
            entindadCuenta.CodCuenta = CodCuenta;
            //invoco al metodo del objeto con el parametro entidad
            string[] arreglo = {
                (cuenta.DesactivarCuenta(entindadCuenta)).ToString(),
                cuenta.Mensaje
            };
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "ReactivarCuenta")]
        public string[] ReactivarCuenta(int CodCuenta)
        {
            //lleno atributos de la entidad
            entindadCuenta.CodCuenta = CodCuenta;
            //invoco al metodo del objeto con el parametro entidad
            string[] arreglo = {
                (cuenta.ReactivarCuenta(entindadCuenta)).ToString(),
                cuenta.Mensaje
            };
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "ActualizarCuentaContra")]
        public string[] ActualizarCuentaContra(int CodCuenta,string Contrasena, string ContrasenaNueva)
        {
            //lleno atributos de la entidad
            entindadCuenta.CodCuenta = CodCuenta;
            entindadCuenta.Contrasena = Contrasena;
            //invoco al metodo del objeto con el parametro entidad
            string[] arreglo = {
                (cuenta.ActualizarCuentaContra(entindadCuenta,ContrasenaNueva)).ToString(),
                cuenta.Mensaje
            };
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "ActualizarCuentaSeudo")]
        public string[] ActualizarCuentaSeudo(int CodCuenta, string Seudonimo)
        {
            //lleno atributos de la entidad
            entindadCuenta.CodCuenta = CodCuenta;
            entindadCuenta.Seudonimo = Seudonimo;
            //invoco al metodo del objeto con el parametro entidad
            string[] arreglo = {
                (cuenta.ActualizarCuentaSeudo(entindadCuenta)).ToString(),
                cuenta.Mensaje
            };
            return arreglo;
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "ActualizarCuentaPriva")]
        public string[] ActualizarCuentaPriva(int CodCuenta, string CodPrivacidad)
        {
            //lleno atributos de la entidad
            entindadCuenta.CodCuenta = CodCuenta;
            entindadCuenta.CodPrivacidad = CodPrivacidad;
            //invoco al metodo del objeto con el parametro entidad
            string[] arreglo = {
                (cuenta.ActualizarCuentaPriva(entindadCuenta)).ToString(),
                cuenta.Mensaje
            };
            return arreglo;
        }

        //-----------------------------------------------------------------------
        //  Trabajo con Info  +/
        //-----------------------------------------------------------------------

        [WebMethod(Description = "ListarInfo")]
        public DataSet ListarInfo(int CodCuenta)
        {
            //lleno atributos de la entidad
            entidadInfo.CodCuenta = CodCuenta;
            //invoco al metodo del objeto con el parametro entidad
            return info.ListarInfo(entidadInfo);
        }
        //-----------------------------------------------------------------------
        [WebMethod(Description = "ActualizarInfo")]
        public string[] ActualizarInfo(string Apellidos, string Nombres, DateTime Nacimiento, string DNI, string Direccion,string Informacion, int CodCuenta)
        {
            //lleno atributos de la entidad
            entidadInfo.Apellidos = Apellidos;
            entidadInfo.Nombres = Nombres;
            entidadInfo.Nacimiento = Nacimiento;
            entidadInfo.DNI = DNI;
            entidadInfo.Informacion = Informacion;
            entidadInfo.Direccion = Direccion;
            entidadInfo.CodCuenta = CodCuenta;
            //invoco al metodo del objeto con el parametro entidad
            string[] arreglo = {
                (info.ActualizarInfo(entidadInfo)).ToString(),
                info.Mensaje
            };
            return arreglo;
        }
    }
}
