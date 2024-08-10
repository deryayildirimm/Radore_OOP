using Radore_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Classes
{
    public class Baba : Insan,IOku,IDinle
    {
        public void dinle(string isim)
        {
            Console.WriteLine(isim + " dinliyor...");
        }

        public void oku(string isim)
        {
            Console.WriteLine(isim + " okuyor...");
        }

       
    }
}
