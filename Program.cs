using System;
namespace Sinhvien
{
    class Sinhvien
    {
        string ten;
        string ngaysinh;
        double hocphi;

        public Sinhvien(string a, string b, double c)
        {
            this.ten = a;
            this.ngaysinh = b;
            this.hocphi = c;
        }
        public string getTen()
        {
            return ten;
        }
        public string getNgaysinh()
        {
            return ngaysinh;
        }
        public double getHocphi()
        {
            return hocphi;
        }
    }

    class SinhvienTN : Sinhvien
    {
        int luongthang;
        public SinhvienTN(string ten, string ngaysinh, double hocphi, int luongthang) : base(ten, ngaysinh, hocphi)
        {
            this.luongthang = luongthang;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhvienTN a;
            a = new SinhvienTN("Ya Dat", "03/05/2004", 16000000, 0);
            Console.WriteLine("Hello,World");
        }
    }
}
