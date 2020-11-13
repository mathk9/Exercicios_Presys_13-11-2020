using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia_Exemplo
{
    public class ICMS : Imposto
    {            
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
