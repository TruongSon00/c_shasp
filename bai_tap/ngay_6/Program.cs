using System;

namespace ngay_6
{
    public class main
    {
        public static void Main(string[] args)
        {
            staff nvKD = new staffKinhDoanh("Truong son", 3000000, 50000000);
            staff nvKT = new staffKyThuat("Long Vu", 3000000, 30);

            Console.WriteLine(nvKD.HienThi());
            Console.WriteLine(nvKT.HienThi());
        }
    }
}