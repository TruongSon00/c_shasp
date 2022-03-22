using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Lion("Lion", 200);
            Animal tiger = new Tiger("tigger", 100);

            Console.WriteLine(lion.show());
            Console.WriteLine(tiger.show());
        }
    }
}
