using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia_Exemplo
{   
    class NUMEROS_1 : InterfaceTeste
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
    }
}
