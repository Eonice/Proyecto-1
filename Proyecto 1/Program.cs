using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Ejemplo_multiplicacion
    {
        public static void Main()
        {
            int primernumero, segundonumero, multiplicacion;
            Console.WriteLine("Introduce el primer numero");
            primernumero = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            segundonumero = System.Convert.ToInt32(Console.ReadLine());
            multiplicacion = primernumero * segundonumero;
            Console.WriteLine("La multiplicacion entre {0} y {1} es {2}", primernumero, segundonumero, multiplicacion);
        }
    }
}