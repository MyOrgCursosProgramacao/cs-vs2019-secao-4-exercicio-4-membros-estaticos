using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0 / 100.0;
        public static double DolarParaReal(double cotacao, double valor)
        {
            return cotacao * valor * (1 + Iof);
        }
    }
}
