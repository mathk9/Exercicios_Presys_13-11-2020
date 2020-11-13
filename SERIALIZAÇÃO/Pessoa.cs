using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Criptografia_Exemplo
{
    // [Serializable] ---> mesmo se não colocar,
    // já considera serializável!!!!
    public class Pessoa
    {
        public int ID {get; set;}

        public string Nome { get; set; }

        public string Telefone { get; set; }

       
    }
}
