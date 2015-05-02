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
            Grid g = new Grid(20, 20);
            Console.WriteLine(g.ToString());
            Console.WriteLine("Hi");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
    }
}
