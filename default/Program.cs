using System;

namespace assignment
{
    public class main

    {
        public static void inputInt(out int choose)
        {
            while (true)
            {
                try
                {
                    choose = int.Parse(Console.ReadLine());
                    break;
                }
                catch (System.FormatException ex)
                {
                    Console.Write("Yeu cau nhap so!\nNhap lai: ");
                }
            }
        }
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("gd01", "giay dep", 31));
            products.Add(new Product("hq01", "hoa qua", 43));
            products.Add(new Product("lt01", "Lap top", 145));
            products.Add(new Product("dt01", "dien thoai", 100));
            bool find;
            int choose, count;
            string check = "y", id;
            Product newProduct = new Product();
            do
            {
                Console.WriteLine("\n----------------------- Main -----------------------\n");
                Console.Write("\n1. add product record");
                Console.Write("\t\t2. display product records");
                Console.Write("\n3. delete product record");
                Console.Write("\t\t4. Exit");

                Console.Write("\n\nNhap lua chon: ");
                inputInt(out choose);

                switch (choose)
                {
                    case 1:
                        newProduct.NhapTT();
                        products.Add(newProduct);
                        Console.WriteLine($"ban them thanh cong product: {newProduct.HienThi()}");
                        break;

                    case 2:
                        Console.WriteLine("#        id      name        price");
                        count = 0;
                        foreach (Product product in products)
                        {
                            Console.WriteLine($"Product {++count}:  {product.HienThi()}");
                        }
                        break;

                    case 3:
                        Console.Write("Nhap ProductID that you want to delete: ");
                        id = Console.ReadLine();
                        find = false;
                        foreach (Product product in products)
                        {
                            if (product.productId.Equals(id))
                            {
                                Console.WriteLine($"ban da xoa thanh cong product: {product}");
                                products.Remove(product);
                                find = true;
                                break;
                            }
                        }
                        if (!find)
                            Console.WriteLine($"khong ton tai id: {id}");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Lua chon khong phu hop");
                        break;
                }
                if (choose == 4)
                    break;
                Console.Write("Ban co muon tiep tuc khong? (y?n) Enter de tiep tuc...");
                check = Console.ReadLine();
                if ("n".Equals(check))
                    break;
            } while (true);

            Console.WriteLine("thank you used us service! ");
        }
    }
}