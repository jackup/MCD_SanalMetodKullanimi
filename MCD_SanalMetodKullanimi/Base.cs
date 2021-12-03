using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetodKullanimi
{
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Base Class");
        }

        public virtual void EkranaYaz(string data)
        {
            Console.WriteLine(data);
        }
    }
}
