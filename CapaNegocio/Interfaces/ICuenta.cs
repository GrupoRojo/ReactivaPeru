using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//uso la Entidad
using CapaEntidad;
//Buffer de memoria
using System.Data; //por si la funcion retorna un DataSet = tabla

namespace CapaNegocio.Interfaces
{
    interface ICuenta
    {
        //Declaro metodos para una Clase (Herencia y Polomorfismo)
        bool ExisteCuenta(string usuario_o_correo, string contra);
        DataSet InfoCuenta(ECuenta cuenta);
        bool AgregarCuenta(ECuenta cuenta);
        bool DesactivarCuenta(ECuenta cuenta);
        bool ReactivarCuenta(ECuenta cuenta);
        bool ActualizarCuentaContra(ECuenta cuenta, string NuevaContra);
        bool ActualizarCuentaSeudo(ECuenta cuenta);
        bool ActualizarCuentaPriva(ECuenta cuenta);

    }
}
