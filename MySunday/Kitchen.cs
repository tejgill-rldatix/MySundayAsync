using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySunday
{
    public class Dishes { }
    public class Kitchen
    {
        public async Task<Dishes> StartDishwasher(Dishes dishes)
        {
            Console.WriteLine("Kitchen: Dishwasher started");
            await Task.Delay(2000);
            Console.WriteLine("Kitchen: Dishwaser finished");
            return dishes;
        }

        public async Task PutDishesAway(Dishes dishes)
        {
            Console.WriteLine("Kitchen: Start putting away dishes");
            await Task.Delay(1000);
            Console.WriteLine("Kitchen: Finished putting away dishes");
        }
    }
}
