using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class millas_to_metros
    {
        public static void Main()
        {
            int millas, metros;
            Console.WriteLine("Introduce las millas");
            millas = System.Convert.ToInt32(Console.ReadLine());
            metros = millas * 1852;
            Console.WriteLine("{0} millas equivalen a {1} metros", millas, metros);
        }
    }
}