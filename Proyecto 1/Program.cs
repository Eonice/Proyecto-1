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
    public class Tabla_de_multiplicar
    {
        public static void Main()
        {
            int numero, multiplicador, resultado;
            System.Console.WriteLine("Introduce un numero:");
            numero = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Esta es la tabla de multiplicar de {0}:", numero);
            for (multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                resultado = numero * multiplicador;
                System.Console.WriteLine("{0} x {1} = {2}", numero, multiplicador, resultado);
            }
        }
    }
}
    