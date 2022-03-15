using System;

namespace vehicle
{
    public class vehicle : IVehicle
    {
        public string maker { set; get; }
        public string model { set; get; }

        public double price { set; get; }

        public vehicle()
        {

        }
        public vehicle(string maker, string model, double price)
        {
            this.maker = maker;
            this.model = model;
            this.price = price;
        }

        public virtual void NhapTT()
        {
            Console.Write("Nhap maker: ");
            maker = Console.ReadLine();

            Console.Write("Nhap model: ");
            model = Console.ReadLine();

            Console.Write("Nhap Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }
        public virtual string HienThi()
        {
            return $"Maker: {this.maker}, model: {model}, price: {price}";
        }
        public IVehicle[] xe = new vehicle[100];


        public IVehicle this[int i]
        {
            set { xe[i] = value; }
            get => xe[i];
        }
    }
}