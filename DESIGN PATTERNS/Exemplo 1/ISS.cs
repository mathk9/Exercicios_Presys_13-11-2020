using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia_Exemplo
{
    class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
