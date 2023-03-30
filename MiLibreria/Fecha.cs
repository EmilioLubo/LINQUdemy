using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiLibreria
{
    public class Fecha
    {
        private readonly DateTime _date;

        public Fecha() 
        {
            _date = DateTime.UtcNow;
        }
        public long GetTicksFecha()
        {
            return _date.Ticks;
        }
        public override string ToString()
        {
            return _date.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
