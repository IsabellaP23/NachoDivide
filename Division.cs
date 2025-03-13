
namespace NachoDivide
{
    public class Division
    {
        // <summary>
        // M�todo Dividir
        // </summar
        // <param name="a"> Operando1 </param>
        // <param name="b"> Operando2 </param>
        // <returns></returns>

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ingrese otro n�mero, no es posible dividir por 0 :)");
            }
            return (a / b);
        }
    }

}
