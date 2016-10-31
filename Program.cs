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
        }
    }
}
