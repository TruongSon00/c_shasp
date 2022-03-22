using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiHetMonAP
{
    public class Cylinder
    {
        public double Radius;
        public double Height;
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;
        public const double pi = Math.PI;
        public Cylinder()
        {
            Radius = 0;
            Height = 0;
        }
        public Cylinder(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public double radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double height
        {
            get { return height; }
            set { height = value; }
        }

        public void NhapTT()
        {
            Console.WriteLine("nhap dimentstions cua cylinder");
            Console.WriteLine("Radius: ");
            Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            Height = double.Parse(Console.ReadLine());
        }
        public void Process()
        {
            BaseArea = Radius * Radius * pi;

            LateralArea = 2 * pi * Radius * Height;

            TotalArea = 2 * pi * Radius * (Height + Radius);

            Volume = pi * Radius * Radius * Height;
        }

        public string Result()
        {
            Process();

            return $"Base:   {BaseArea}  | Lateral:   {LateralArea}   | Total:   {TotalArea}   | Volume:   {Volume}";

        }
    }
}
