﻿using System;
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
    interface IHabilidad
    {
        //Declaro metodos para una Clase (Herencia y Polomorfismo)
        DataSet ListarHabilidad(EHabilidad habilidad);
        bool InsertarHabilidad(EHabilidad habilidad);
        bool ActualizarHabilidad(EHabilidad habilidad);
        bool EliminarHabilidad(EHabilidad habilidad);
    }
}
