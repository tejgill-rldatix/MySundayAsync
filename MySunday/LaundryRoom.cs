using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySunday
{
    public class LaundryRoom
    {
        public async Task<Laundry> WashLaundry(Laundry laundry)
        {
            Console.WriteLine("Laundry: Washer started");
            await Task.Delay(2000);
            Console.WriteLine("Laundry: Washer finished");
            return laundry;
        }

        public async Task<Laundry> DryLaundry(Laundry laundry)
        {
            Console.WriteLine("Laundry: Dryer started");
            await Task.Delay(2000);
            Console.WriteLine("Laundry: Dryer finished");
            return laundry;
        }

        public async Task<Laundry> FoldLaundry(Laundry laundry)
        {
            Console.WriteLine("Laundry: Folding started");
            await Task.Delay(2000);
            Console.WriteLine("Laundry: Folding finished");
            return laundry;
        }
    }
}
