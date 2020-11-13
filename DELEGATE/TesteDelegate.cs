using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia_Exemplo
{
    public delegate int operation(int number1, int number2);    

    class TesteDelegate
    {
              
        public static int soma (int number1, int number2)
        {
              return number1 + number2;
        }
               
        public static int multiplicacao (int number1, int number2)
        {
              return number1*number2;
        }
    }
}
