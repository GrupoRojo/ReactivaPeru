using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// serializar la clase para q sea multilenguaje, multiplataforma
using System.Runtime.Serialization;

namespace CapaEntidad
{
    [DataContract] //se genera un contrato
    public class EFono
    {
        [DataMember] //y se genera sus miembros
        public int CodFono { get; set; }

        [DataMember]
        public char Vision { get; set; }

        [DataMember]
        public string Tipo { get; set; }

        [DataMember]
        public string Numero { get; set; }

        [DataMember]
        public int CodCuenta { get; set; }
    }
}
