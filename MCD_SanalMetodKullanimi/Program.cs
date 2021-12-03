using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetodKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Televizyon T1 = new Televizyon();
            T1.EkranaYaz("Hangisi?");
            Console.WriteLine("************");

            Urun U1 = new Urun();
            U1.EkranaYaz("Merhaba");
            Console.WriteLine("************");

            Base B1 = new Base();
            B1.EkranaYaz("Merhaba");
        }
    }
}
