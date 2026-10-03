using System.Collections.Generic;
using System.Linq;

public class DanhSachNhanVien
{
    private readonly List<NhanVien> danhSach;

    public DanhSachNhanVien()
    {
        danhSach = new List<NhanVien>();
    }

    public bool Them(NhanVien nv)
    {
        if (Tim(nv.MaNV) == null)
        {
            danhSach.Add(nv);
            return true;
        }
        return false;
    }

    public bool Xoa(string maNV)
    {
        var nhanVien = danhSach.FirstOrDefault(nv => nv.MaNV == maNV);
        if (nhanVien != null)
        {
            danhSach.Remove(nhanVien);
            return true;
        }
        return false;
    }

    public NhanVien? Tim(string maNV)
    {
        return danhSach.FirstOrDefault(nv => nv.MaNV == maNV);
    }

    public List<NhanVien> TimTheoChucVu(string chucVu)
    {
        return danhSach.Where(nv => nv.ChucVu == chucVu).ToList();
    }

    public void HienThi()
    {
        foreach (var nv in danhSach)
        {
            Console.WriteLine(nv.MoTa());
        }
    }

    public decimal TongLuong()
    {
        return danhSach.Sum(nv => nv.TienLuong());
    }
}