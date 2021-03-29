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
    interface IFono
    {
        //Declaro metodos para una Clase (Herencia y Polomorfismo)
        DataSet ListarFono(EFono fono);
        bool InsertarFono(EFono fono);
        bool ActualizarFono(EFono fono);
        bool EliminarFono(EFono fono);
    }
}
