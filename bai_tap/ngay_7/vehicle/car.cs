using System;

namespace vehicle
{
    public class car : vehicle
    {
        protected string color;
        public car() { }
        public car(string maker, string model, double price, string color) : base(maker, model, price)
        {
            this.color = color;
        }
        public override void NhapTT()
        {
            Console.WriteLine("Nhap thong tin car");
            base.NhapTT();
            Console.Write("Nhap color: ");
            color = Console.ReadLine();
        }
        public override string HienThi()
        {
            return "car: " + base.HienThi() + $", color: {color}";
        }
    }
}