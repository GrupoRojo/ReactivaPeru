﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWeb.RefServicio2 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefServicio2.ServicioCV2Soap")]
    public interface ServicioCV2Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstudioListar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet EstudioListar(int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstudioListar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> EstudioListarAsync(int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstudioInsertar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] EstudioInsertar(string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstudioInsertar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EstudioInsertarAsync(string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstudioActualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] EstudioActualizar(int CodEstudio, string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstudioActualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EstudioActualizarAsync(int CodEstudio, string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstudioEliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] EstudioEliminar(int CodEstudio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstudioEliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EstudioEliminarAsync(int CodEstudio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TrabajoListar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet TrabajoListar(int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TrabajoListar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> TrabajoListarAsync(int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TrabajoInsertar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] TrabajoInsertar(string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TrabajoInsertar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> TrabajoInsertarAsync(string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TrabajoActualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] TrabajoActualizar(int CodTrabajo, string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TrabajoActualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> TrabajoActualizarAsync(int CodTrabajo, string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TrabajoEliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] TrabajoEliminar(int CodTrabajo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TrabajoEliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> TrabajoEliminarAsync(int CodTrabajo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioCV2SoapChannel : ClienteWeb.RefServicio2.ServicioCV2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioCV2SoapClient : System.ServiceModel.ClientBase<ClienteWeb.RefServicio2.ServicioCV2Soap>, ClienteWeb.RefServicio2.ServicioCV2Soap {
        
        public ServicioCV2SoapClient() {
        }
        
        public ServicioCV2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioCV2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCV2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCV2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet EstudioListar(int CodCuenta) {
            return base.Channel.EstudioListar(CodCuenta);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> EstudioListarAsync(int CodCuenta) {
            return base.Channel.EstudioListarAsync(CodCuenta);
        }
        
        public string[] EstudioInsertar(string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta) {
            return base.Channel.EstudioInsertar(Vision, Institucion, Facultad, Carrera, inicio, Fin, CodCuenta);
        }
        
        public System.Threading.Tasks.Task<string[]> EstudioInsertarAsync(string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta) {
            return base.Channel.EstudioInsertarAsync(Vision, Institucion, Facultad, Carrera, inicio, Fin, CodCuenta);
        }
        
        public string[] EstudioActualizar(int CodEstudio, string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta) {
            return base.Channel.EstudioActualizar(CodEstudio, Vision, Institucion, Facultad, Carrera, inicio, Fin, CodCuenta);
        }
        
        public System.Threading.Tasks.Task<string[]> EstudioActualizarAsync(int CodEstudio, string Vision, string Institucion, string Facultad, string Carrera, string inicio, string Fin, int CodCuenta) {
            return base.Channel.EstudioActualizarAsync(CodEstudio, Vision, Institucion, Facultad, Carrera, inicio, Fin, CodCuenta);
        }
        
        public string[] EstudioEliminar(int CodEstudio) {
            return base.Channel.EstudioEliminar(CodEstudio);
        }
        
        public System.Threading.Tasks.Task<string[]> EstudioEliminarAsync(int CodEstudio) {
            return base.Channel.EstudioEliminarAsync(CodEstudio);
        }
        
        public System.Data.DataSet TrabajoListar(int CodCuenta) {
            return base.Channel.TrabajoListar(CodCuenta);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> TrabajoListarAsync(int CodCuenta) {
            return base.Channel.TrabajoListarAsync(CodCuenta);
        }
        
        public string[] TrabajoInsertar(string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta) {
            return base.Channel.TrabajoInsertar(Vision, Empresa, Puesto, Supervisor, Inicio, Fin, CodCuenta);
        }
        
        public System.Threading.Tasks.Task<string[]> TrabajoInsertarAsync(string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta) {
            return base.Channel.TrabajoInsertarAsync(Vision, Empresa, Puesto, Supervisor, Inicio, Fin, CodCuenta);
        }
        
        public string[] TrabajoActualizar(int CodTrabajo, string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta) {
            return base.Channel.TrabajoActualizar(CodTrabajo, Vision, Empresa, Puesto, Supervisor, Inicio, Fin, CodCuenta);
        }
        
        public System.Threading.Tasks.Task<string[]> TrabajoActualizarAsync(int CodTrabajo, string Vision, string Empresa, string Puesto, string Supervisor, string Inicio, string Fin, int CodCuenta) {
            return base.Channel.TrabajoActualizarAsync(CodTrabajo, Vision, Empresa, Puesto, Supervisor, Inicio, Fin, CodCuenta);
        }
        
        public string[] TrabajoEliminar(int CodTrabajo) {
            return base.Channel.TrabajoEliminar(CodTrabajo);
        }
        
        public System.Threading.Tasks.Task<string[]> TrabajoEliminarAsync(int CodTrabajo) {
            return base.Channel.TrabajoEliminarAsync(CodTrabajo);
        }
    }
}
