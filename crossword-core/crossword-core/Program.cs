using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossword_core
{ 
    class Program
    {
        public void Run()
        {
            Grid g = new Grid(10, 10);
            Console.WriteLine(g.ToString());
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
    }
}
