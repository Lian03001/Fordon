using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordon_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fordon SAAB = new Fordon("SAAB", "93a", 99);

            Console.WriteLine(SAAB);
        }
    }
}
