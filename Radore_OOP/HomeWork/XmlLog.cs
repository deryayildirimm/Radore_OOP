using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.HomeWork
{
    public class XmlLog : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine(message + " xml e kaydedildi");
        }

     
    }
}
