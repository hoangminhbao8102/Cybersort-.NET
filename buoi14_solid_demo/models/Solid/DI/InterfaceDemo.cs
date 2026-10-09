public interface IChuVi
{
    public int TinhChuVi();
}

public interface IDienTich
{
    public int TinhDienTich();
}

public class HinhTron : IChuVi, IDienTich
{
    public int TinhChuVi()
    {
        throw new NotImplementedException();
    }

    public int TinhDienTich()
    {
        throw new NotImplementedException();
    }
}

public class ABC
{
    public IChuVi iCV { get; set; }
    public IDienTich iDT { get; set; }

    public ABC(IChuVi iCV, IDienTich iDT)
    {
        this.iCV = iCV;
        this.iDT = iDT;
    }
}

public class MyClass
{
    public HoaDon hd { get; set; }
    public MyClass(HoaDon hdParam)
    {
        this.hd = hdParam;
    }
}