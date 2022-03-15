using System;

namespace ngay_6;

public class staffKinhDoanh : staff
{
    public int doanhThu;




    public staffKinhDoanh(string name, int luongCoBan, int doanhThu) : base(name, luongCoBan)
    {
        this.doanhThu = doanhThu;
    }

    public override void NhapTT()
    {
        Console.WriteLine("Nhap thong tin staff kinh doanh");
        base.NhapTT();
        Console.Write("Nhap doanh thu: ");
        doanhThu = Convert.ToInt32(Console.ReadLine());

    }
    public override string HienThi()
    {
        return "Nhan vien kinh doanh -> " + base.HienThi();
    }
    public override double TinhLuong()
    {
        return doanhThu / 10 * 1.0 + luongCoBan;
    }
}