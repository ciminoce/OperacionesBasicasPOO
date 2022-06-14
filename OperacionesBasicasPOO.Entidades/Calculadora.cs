using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OperacionesBasicasPOO.Entidades
{
    public static class  Calculadora
    {
        public static double Calcular(int nro1, int nro2, char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return nro1 + nro2;
                    break;
                case '-':
                    return nro1 - nro2;
                    break;
                case '*':
                    return nro1 * nro2;
                case '/':
                    if (Validar(nro2))
                    {
                        return nro1 / nro2;
                    }

                    throw new DivideByZeroException("No se puede dividir por cero");
                default:
                    throw new ArgumentException("Operación no contemplada o caracter erróneo");
            }
        }

        private static bool Validar(int nro2)
        {
            return nro2 != 0;
        }
    }
}
