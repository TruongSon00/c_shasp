using System;

namespace HinhHoc
{
    internal class hinhVuong : hcn
    {


        public override void NhapTT()
        {
            Console.Write("Nhap do dai canh: ");
            this.width = Convert.ToInt32(Console.ReadLine());
        }
        public int area(int width)
        {
            Console.WriteLine("Day la tinh dien tich hinh vuong");
            return width * width;
        }

        public int perimeter(int width)
        {
            return width * 4;
        }
        public override string HienThi()
        {
            return $"hinh vuong canh: {this.width} => area: {this.area(width)}, perimater: {this.perimeter(width)} ";
        }




    }
}
