using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia_Exemplo
{
    class NUMEROS_2 : InterfaceTeste
    {

        #region InterfaceTeste Members

        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtrai(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplica(double n1, double n2)
        {
            return n1 * n2;
        }

        #endregion

        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

        public double Eleva(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public double Raiz(double n1, double n2)
        {
            return Math.Pow(n1, 1.0/n2);
        }
               
    }
}
