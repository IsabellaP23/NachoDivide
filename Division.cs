
namespace NachoDivide
{
    public class Division
    {
        // <summary>
        // Método Dividir
        // </summar
        // <param name="a"> Operando1 </param>
        // <param name="b"> Operando2 </param>
        // <returns></returns>

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ingrese otro número, no es posible dividir por 0 :)");
            }
            return (a / b);
        }
    }

}
