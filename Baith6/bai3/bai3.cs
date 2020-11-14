using System;
using System.Collections.Generic;
using System.Text;

namespace Baith6.bai3
{
    class Canbo
    {
        protected string hoten, quequan;
        protected int hsl;
        protected int luongcb;
        public Canbo()
        {
            hoten = quequan = " ";
            hsl = 0;
            luongcb = 3000000;
        }
        public Canbo(string hoten, string quequan, int hsl, int luongcb)
        {
            this.hoten = hoten;
            this.quequan = quequan;
            this.hsl = hsl;
            this.luongcb = luongcb;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten:"); hoten = Console.ReadLine();
            Console.Write("Nhap que quan:"); quequan = Console.ReadLine();
            Console.Write("Nhap he so luong:"); hsl = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban:"); luongcb = int.Parse(Console.ReadLine());
        }
        public virtual double Tinhluong()
        {
            return hsl * luongcb;
        }
        public virtual void Hien()
        {
            Console.WriteLine("Hoten:{0}\tQue quan:{1}\tHe so luong:{2}\tLuong co ban:{3}\tTinh luong:{4}", hoten, quequan, hsl, luongcb, Tinhluong());

        }

    }
    class Giaovien : Canbo
    {
        public override double Tinhluong()
        {
            return base.Tinhluong() * 1.4;
        }
    }
    class Hanhchinh : Canbo
    {
        public override double Tinhluong()
        {
            return base.Tinhluong() + 300000;
        }
    }
    class QLCB
    {
        private int socb;
        private Canbo[] ds;
        public void Nhap()
        {
            Console.Write("Nhap so can bo: "); socb = int.Parse(Console.ReadLine());
            ds = new Canbo[socb];
            for (int i = 0; i < socb; i++)
            {
                Console.WriteLine("Ban muon nhap can bo la giao vien(G) hay Hanh chinh(H)");
                char ch = char.Parse(Console.ReadLine());
                switch (char.ToUpper(ch))
                {
                    case 'G': ds[i] = new Giaovien(); ds[i].Nhap(); break;
                    case 'H': ds[i] = new Hanhchinh(); ds[i].Nhap(); break;
                }
            }
        }
        public void Hien()
        {
            for (int i = 0; i < socb; i++)
                ds[i].Hien();
        }

    }
    class App2
    {
        static void Main3()
        {
            QLCB t = new QLCB();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
}