using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGit
{
    class Program
    {
        static void Main(string[] args)
        {
            fish f = new fish() { Name = "fish1", Weight=100, Price=200};
            Console.WriteLine(f.ToString());
            fish f2 = new fish() { Name = "fish2", Weight = 200, Price = 300 };
            Console.WriteLine(f2.ToString());
        }
    }
}
