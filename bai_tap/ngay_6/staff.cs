using System;

namespace ngay_6;

public abstract class staff
{
    public string name;
    public int luongCoBan;

    public staff(string name, int luongCoBan)
    {
        this.name = name;
        this.luongCoBan = luongCoBan;
    }

    public staff()
    {

    }
    public virtual void NhapTT()
    {
        Console.Write("Nhap Name staff: ");
        this.name = Console.ReadLine();
        Console.Write("Nhap Name staff: ");
        this.luongCoBan = Convert.ToInt32(Console.ReadLine());
    }

    public virtual string HienThi()
    {
        return $"Name: {this.name}  |  Luong: {this.TinhLuong()}";
    }
    public abstract double TinhLuong();
}