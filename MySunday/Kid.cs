using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySunday
{
    public class Kid
    {
        public string Name { get; set; }

        public Kid(string name)
        { Name = name; }

        public async Task Homework()
        {
            Console.WriteLine($"Kids: Start help {Name} with homework");
            await Task.Delay(3000);
            Console.WriteLine($"Kids: Finished help {Name} with homework");
        }
    }
}
