using System;



namespace HinhHoc
{
    internal class demo
    {
        public static void work(hinh hinh1)
        {
            hinh1.NhapTT();
            Console.WriteLine(hinh1.HienThi());
        }

        public static void Main()
        {

            int choose;
            do
            {
                Console.WriteLine("\n\t\t------- Main -----------");
                Console.Write("1. Hinh chu nhat");
                Console.Write("\t\t2. Hinh vuong");
                Console.Write("\n3. Hinh tron");
                Console.WriteLine("\t\t4. Thoat");

                Console.Write("\nNhap lua chon: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        work(new hcn());
                        break;
                    case 2:
                        work(new hinhVuong());

                        break;

                    case 3:
                        work(new hinhTron());

                        break;

                    case 4:
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!!!");
                        break;
                }
            } while (true);

        }

    }
}
