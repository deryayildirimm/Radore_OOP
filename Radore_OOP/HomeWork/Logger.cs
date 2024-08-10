using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.HomeWork
{
    public class Logger 
    {
        private readonly ILog log;

        public Logger(ILog log)
        {
            this.log = log;
        }

        public void LogKaydet(string message)
        {
            log.Log(message);
        }
    }
}
