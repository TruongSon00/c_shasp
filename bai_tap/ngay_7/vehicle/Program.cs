using System;

namespace vehicle
{

    public class test
    {

        protected static int index = 0;
        public static void Main(string[] args)
        {


            IVehicle xe = new vehicle();
            xe[index++] = new car("Truong son", "BMW", 32000, "Do");
            xe[index++] = new car("Truong son", "Mes", 22000, "xanh");
            xe[index++] = new car("Long Vu", "Honda", 42000, "tim");
            xe[index++] = new truck("Long Vu", "toyoda", 52000, 16);
            xe[index++] = new truck("Thanh Long", "mayback", 12000, 33);
            int choose, chon;
            do
            {
                Console.WriteLine("\t--------- Main --------");
                Console.Write("1. Input");
                Console.Write("\t\t2. display");
                Console.Write("\n3. sort by price");
                Console.Write("\t4. search by model");
                Console.Write("\nNhap lua chon: ");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.Write("1. Car");
                        Console.Write("\t\t2. Truck");

                        Console.Write("\nNhap lua chon: ");
                        chon = Convert.ToInt32(Console.ReadLine());
                        if (chon == 1)
                        {
                            xe[index] = new car();
                            xe[index++].NhapTT();
                        }
                        else if (chon == 2)
                        {
                            xe[index] = new truck();
                            xe[index++].NhapTT();
                        }
                        else
                        {

                        }
                        break;
                    case 2:
                        for (int i = 0; i < index; i++)
                        {
                            Console.WriteLine(xe[i].HienThi());
                        }
                        break;

                    case 3:
                        IVehicle ram = new vehicle();
                        for (int i = 0; i < index; i++)
                        {
                            for (int j = i + 1; j < index; j++)
                            {
                                if (xe[i].price > xe[j].price)
                                {
                                    ram = xe[i];
                                    xe[i] = xe[j];
                                    xe[j] = ram;
                                }
                            }
                        }
                        for (int i = 0; i < index; i++)
                        {
                            Console.WriteLine(xe[i].HienThi());
                        }
                        break;
                    case 4:
                        Console.Write("Nhap model tim kiem: ");
                        string model = Console.ReadLine();
                        for (int i = 0; i < index; i++)
                        {
                            if (xe[i].model.Contains(model))
                                Console.WriteLine(xe[i].HienThi());
                        }
                        break;
                    default:
                        Console.WriteLine("Lua chon khong ton tai!!!");
                        break;
                }

            } while (true);

        }
    }
}