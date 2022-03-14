using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hinh newHinh = new hcn();
            hinh hinhVuong = new hinhVuong();


            newHinh.NhapTT();
            hinhVuong.NhapTT();

            Console.WriteLine(newHinh.HienThi());
            Console.WriteLine(hinhVuong.HienThi());
        }
    }
}
