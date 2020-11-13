using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia_Exemplo
{
    public class Orcamento
    {
      public double Valor { get; private set; }
        
      public Orcamento (double valor)
      {
          this.Valor = valor;
      }
    }
}
