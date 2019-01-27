using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_cadastro_de_usuarios
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Cpf { get; set; }
    }
}
