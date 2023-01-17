using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_Getting_into_Git
{
    class Program
    {
        private int steve;
        
        public void setSteve(int s)
        {
            steve = s; 
        }

        public int getSteve()
        {
            return steve; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("hello world " + 5);
            //Console.ReadKey();
            Console.WriteLine("setting steve to 4");
            Program p = new Program(); 
            p.setSteve(4);
            Console.WriteLine("Steve is: " + p.getSteve());
            Console.ReadKey();
        }
    }
}
