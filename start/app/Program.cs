
double luongCoBan, luong;
int heso;

do
{
    Console.WriteLine("Nhap luong co ban: ");
    luongCoBan = Convert.ToDouble(Console.ReadLine());
} while (luongCoBan <= 0);

do
{
    Console.WriteLine("Nhap he so luong: ");
    heso = Convert.ToInt32(Console.ReadLine());
} while (heso < 1 || heso > 7);

luong = (heso / 2.0) * luongCoBan;
Console.WriteLine($"Luong co ban: {luong}");


