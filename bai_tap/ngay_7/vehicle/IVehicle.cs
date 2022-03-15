using System;

namespace vehicle
{
    public interface IVehicle
    {
        public string maker { set; get; }
        public string model { set; get; }

        public double price { set; get; }
        public void NhapTT();
        public string HienThi();

        public IVehicle this[int i]
        {
            set; get;
        }
    }
}