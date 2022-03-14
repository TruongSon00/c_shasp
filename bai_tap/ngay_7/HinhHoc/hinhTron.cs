using System;

namespace HinhHoc
{
    public class hinhTron : hinh
    {
        public int banKinh;
        public void NhapTT()
        {
            Console.Write("Nhap ban kinh: ");
            this.banKinh = Convert.ToInt32(Console.ReadLine());
        }

        public string HienThi()
        {
            return $"Hinh tron ban kinh: {this.banKinh}, perimeter: {this.perimeter()}, area:{this.area()}";

        }


        public int area()
        {
            return (int)(banKinh * banKinh * 3.14);
        }

        public int perimeter()
        {
            return (int)(2 * 3.14 * banKinh);
        }

    }
}