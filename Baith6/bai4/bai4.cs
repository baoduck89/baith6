using System;
using System.Collections.Generic;
using System.Text;

namespace Baith6.bai4
{
    abstract class Dichvu
    {
        protected double Dongia;
        public virtual void Nhap()
        {
            Console.Write("Nhap don gia:"); Dongia = double.Parse(Console.ReadLine());
        }
        public abstract double Tinhtien();
        public virtual void Hien()
        {
            Console.WriteLine("Don gia =" + Dongia);
        }

    }
    class Giattay : Dichvu
    {
        private double sokg;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap sokg="); sokg = double.Parse(Console.ReadLine());
        }
        public override double Tinhtien()
        {
            if (sokg <= 10)
                return sokg * Dongia;
            else
            {
                return sokg * Dongia * 0.95;
            }
        }
        public override void Hien()
        {
            Console.WriteLine("Dich vu giat tay");
            base.Hien();
            Console.WriteLine("So kg quan ao:{0}\t Tong tien:{1}", sokg, Tinhtien());
        }
    }
    class Thuexe : Dichvu
    {
        private double sogio;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so gio thue:"); sogio = double.Parse(Console.ReadLine());
        }
        public override double Tinhtien()
        {
            if (sogio <= 7)
                return sogio * Dongia;
            else
            {
                return sogio * Dongia * 0.9;
            }
        }
        public override void Hien()
        {
            Console.WriteLine("Dich vu thue xe");
            base.Hien();
            Console.WriteLine("So gio thue xe:{0}\t Tong tien:{1}", sogio, Tinhtien());
        }
    }
    class HoaDon
    {
        private string makh, tenkh, diachi;
        private List<Dichvu> ds;
        public void Nhap()
        {
            Console.Write("Nhap ma khach hang:"); makh = Console.ReadLine();
            Console.Write("Nhap ten khach hang:"); tenkh = Console.ReadLine();
            Console.Write("Nhap dia chi  khach hang:"); diachi = Console.ReadLine();
            Console.WriteLine("Nhap dich vu ma khach hang thue");
            ds = new List<Dichvu>();
            char ch; Dichvu tg;
            Console.WriteLine("Co su dung dich vu thue xe (X)  K");
            ch = char.Parse(Console.ReadLine());
            if (char.ToUpper(ch) == 'X')
            {
                tg = new Thuexe(); tg.Nhap(); ds.Add(tg);
            }
            Console.WriteLine("Co su dung dich vu  giat tay(G) K");
            ch = char.Parse(Console.ReadLine());
            if (char.ToUpper(ch) == 'G')
            {
                tg = new Giattay(); tg.Nhap(); ds.Add(tg);
            }

        }
        public double Trigia
        {
            get
            {
                double s = 0;
                foreach (Dichvu x in ds)
                    s += x.Tinhtien();
                return s;
            }
        }
        public void Hien()
        {
            Console.WriteLine("Ma khach hang:{0}\tTen khach hang:{1}\tDia chi:{2}", makh, tenkh, diachi);
            if (ds.Count == 0)
                Console.WriteLine("Khach hang khong su dung dich vu nao");
            else
            {
                Console.WriteLine("Cac dich vu khach hang da thue");
                foreach (Dichvu x in ds)
                    x.Hien();
                Console.WriteLine("Tri gia hoa don:" + Trigia);
            }
        }
    }
    class App3
    {
        static void Main4()
        {
            HoaDon H = new HoaDon();
            H.Nhap();
            H.Hien();
            Console.ReadKey();

        }
    }

}
