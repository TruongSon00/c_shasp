using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    internal class Tiger : Animal
    {
        public Tiger(string name, float weight) : base(name, weight) { }
        public Tiger() { }
        public override string show()
        {
            return $"Name: {name}, Weight: {weight}, keu: gu ... gu ... gu";
        }
    }
}
