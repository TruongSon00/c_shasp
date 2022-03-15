using System;

namespace ngay_6;

public class staffKyThuat : staff
{
    public int ngayCong;


    public staffKyThuat(string name, int luongCoBan, int ngayCong) : base(name, luongCoBan)
    {
        this.ngayCong = ngayCong;
    }

    public override void NhapTT()
    {
        Console.WriteLine("Nhap thong tin staff Ky thuat");
        base.NhapTT();
        Console.Write("Nhap ngay cong: ");
        ngayCong = Convert.ToInt32(Console.ReadLine());

    }
    public override string HienThi()
    {
        return "Nhan vien Ky thuat -> " + base.HienThi();
    }
    public override double TinhLuong()
    {
        return ngayCong * 100000 + luongCoBan;
    }
}