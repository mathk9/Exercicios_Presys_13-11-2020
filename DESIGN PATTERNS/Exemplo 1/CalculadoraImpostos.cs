using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia_Exemplo
{
    public class CalculadoraImpostos
    {
        public double Calculo(Orcamento orcamento, Imposto imposto)
        {
            double saida = imposto.Calcula(orcamento);
            return saida;
        }
    }
}
