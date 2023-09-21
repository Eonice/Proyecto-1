using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Write
    {
        public static void Main()
        {
            int a, b;
            System.Console.Write("Introduce el primer dato ");
            a = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Introduce el segundo dato ");
            b = System.Convert.ToInt32(Console.ReadLine());
            int multiplicacion = (a + b) * (a - b);
            int resta = (2 * a - 2 * b);
            System.Console.WriteLine("multiplicacion y la resta de ambos es {2} y la resta del doble de cada uno es {3}", a, b, multiplicacion, resta);
        }
    }
}
    