using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySunday
{
    public class Lawn
    {
        public async Task Mow()
        {
            Console.WriteLine("Lawn: Start mowing");
            await Task.Delay(5000);
            Console.WriteLine("Lawn: Mowing finished");
        }
    }
}
