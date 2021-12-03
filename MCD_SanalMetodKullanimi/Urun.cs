using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetodKullanimi
{
    public class Urun : Base
    {
        public Urun()
        {
            Console.WriteLine("Ürün");
        }

        public override void EkranaYaz(string data)
        {
            Console.WriteLine("Ürün => " + data);
        }
    }
}
