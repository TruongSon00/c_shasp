using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    internal class hcn : hinh
    {


        public int width { set; get; }
        public int height { set; get; }

        public virtual int area()
        {
            return width * height;
        }
        public virtual int perimeter()
        {
            return (width + height) * 2;
        }

        public virtual string HienThi()
        {
            return $"Hinh chu nhat dai: {this.height}, rong: {width}, perimeter: {this.perimeter()}, area:{this.area()}";
        }

        public virtual void NhapTT()
        {
            Console.Write("Nhap chieu dai: ");
            this.height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap chieu rong: ");
            this.width = Convert.ToInt32(Console.ReadLine());
        }

    }
}
