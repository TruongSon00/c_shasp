using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiThiHetMonAP;

namespace GeometryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.NhapTT();

            Console.ReadLine(cylinder.Result());
        }
    }
}
