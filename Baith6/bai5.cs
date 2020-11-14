using System;

namespace Baith6
{
    abstract class Phong
    {
        protected int songaythue;
        public Phong()
        {
            songaythue = 0;
        }
        public Phong(int songaythue)
        {
            this.songaythue = songaythue;
        }

        public abstract double Tinhtien();
        public abstract void Hien();

    }
    class PhongA : Phong
    {
        private double tiendv;
        public PhongA() : base()
        {
            tiendv = 0;
        }
        public PhongA(int songaythue) : base(songaythue)
        {
            Console.WriteLine("Nhap tien dich vu:"); tiendv = double.Parse(Console.ReadLine());
        }
        public override double Tinhtien()
        {
            if (songaythue <= 5) return 80 * songaythue + tiendv;
            else
            {
                return 80 * songaythue * 0.9 + tiendv;
            }
        }
        public override void Hien()
        {
            Console.WriteLine("Dich vu phong A");
            Console.WriteLine("Tien dich vu:{0}\t Tong tien:{1} USD", tiendv, Tinhtien());
        }
    }
    class PhongB : Phong
    {
        public PhongB() : base()
        {
        }
        public PhongB(int songaythue) : base(songaythue) { }
        public override double Tinhtien()
        {
            if (songaythue <= 5) return songaythue * 60;
            else
            {
                return songaythue * 60 * 0.9;
            }
        }
        public override void Hien()
        {
            Console.WriteLine("Dich vu phong B");
            Console.WriteLine("Tong tien:{0} USD", Tinhtien());
        }
    }
    class PhongC : Phong
    {
        public PhongC() : base()
        {
        }
        public PhongC(int songaythue) : base(songaythue) { }
        public override double Tinhtien()
        {
            return songaythue * 40;
        }
        public override void Hien()
        {
            Console.WriteLine("Dich vu phong B");
            Console.WriteLine("Tong tien:{0} USD" + Tinhtien());
        }
    }
    class Tienthuephong
    {
        private string Tenkh;
        private int songaythue;
        private Phong loaiphong;
        public void Nhap()
        {
            Console.Write("Ho ten:"); Tenkh = Console.ReadLine();
            Console.Write("So ngay thue:"); songaythue = int.Parse(Console.ReadLine());
            Console.WriteLine("Khach hang o pA B and C"); char ch = char.Parse(Console.ReadLine());
            switch (char.ToUpper(ch))
            {
                case 'A': loaiphong = new PhongA(songaythue); break;
                case 'B': loaiphong = new PhongB(songaythue); break;
                case 'C': loaiphong = new PhongC(songaythue); break;
            }
        }
        public void Hien()
        {
            Console.WriteLine("Ten kh:{0}\t So ngaythue:{1}\t", Tenkh, songaythue);
            Console.WriteLine("Phong khach hang su dung");
            loaiphong.Hien();
        }



    }
    class App
    {
        static void Main()
        {
            Tienthuephong t = new Tienthuephong();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
}   