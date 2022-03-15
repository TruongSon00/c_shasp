using System;

namespace vehicle
{
    public class truck : vehicle
    {
        protected int truckLoad;

        public truck()
        {

        }
        public truck(string maker, string model, double price, int truckLoad) : base(maker, model, price)
        {
            this.truckLoad = truckLoad;
        }
        public override void NhapTT()
        {
            Console.WriteLine("Nhap thong tin truck");
            base.NhapTT();
            Console.Write("Nhap truckLoad: ");
            truckLoad = Convert.ToInt32(Console.ReadLine());
        }
        public override string HienThi()
        {
            return "Truck: " + base.HienThi() + $", truckLoad: {truckLoad}";
        }
    }
}