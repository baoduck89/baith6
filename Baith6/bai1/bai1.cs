using System;
using System.Collections.Generic;
using System.Text;

namespace Baith6.bai1
{
        class Nhanvien
        {
            private string hoten, diachi;
            private DateTime ngaysinh;
            public Nhanvien()
            {
                hoten = diachi = " ";
                ngaysinh = DateTime.Now;
            }
            public Nhanvien(string hoten, string diachi, DateTime ngaysinh)
            {
                this.hoten = hoten;
                this.diachi = diachi;
                this.ngaysinh = ngaysinh;
            }
            public virtual void Nhap()
            {
                Console.Write("Nhap Ho ten:"); hoten = Console.ReadLine();
                Console.Write("Nhap dia chi:"); diachi = Console.ReadLine();
                Console.Write("Nhap ngay sinh:"); ngaysinh = DateTime.Parse(Console.ReadLine());
            }
            public virtual int tinhluong()
            {
                return 0;
            }
            public virtual void Hien()
            {
                Console.WriteLine("Ho ten:{0}\tDia chi:{1}\tngay sinh:{2}", hoten, diachi, ngaysinh);
            }


        }
        class NVSX : Nhanvien
        {
            private int sosanpham;
            public NVSX() : base()
            {
                sosanpham = 0;
            }
            public NVSX(string hoten, string diachi, DateTime ngaysinh, int sosanpham) : base(hoten, diachi, ngaysinh)
            {
                this.sosanpham = sosanpham;
            }
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhap so san pham:"); sosanpham = int.Parse(Console.ReadLine());
            }
            public override int tinhluong()
            {
                return sosanpham * 20000;
            }
            public override void Hien()
            {
                base.Hien();
                Console.WriteLine("So san pham:{0}\tTinh luong:{1}", sosanpham, tinhluong());
            }

        }
        class NVCN : Nhanvien
        {
            private int songaycong;
            public NVCN() : base()
            {
                songaycong = 0;
            }
            public NVCN(string hoten, string diachi, DateTime ngaysinh, int songaycong) : base(hoten, diachi, ngaysinh)
            {
                this.songaycong = songaycong;
            }
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhap so ngay cong:"); songaycong = int.Parse(Console.ReadLine());
            }
            public override int tinhluong()
            {
                return +songaycong * 50000;
            }
            public override void Hien()
            {
                base.Hien();
                Console.WriteLine("So ngay cong:{0}\ttinhluong:{1}", songaycong, tinhluong());
            }

        }
        class NVQL : Nhanvien
        {
            private int hesoluong;
            private int luongcoban;
            public NVQL() : base()
            {
                hesoluong = luongcoban = 0;
            }
            public NVQL(string hoten, string diachi, DateTime ngaysinh, int hesoluong, int luongcoban) : base(hoten, diachi, ngaysinh)
            {
                this.hesoluong = hesoluong;
                this.luongcoban = luongcoban;
            }
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhap he so luong:" + hesoluong); hesoluong = int.Parse(Console.ReadLine());
                Console.Write("Nhap luong co ban:"); luongcoban = int.Parse(Console.ReadLine());
            }
            public override int tinhluong()
            {
                return base.tinhluong() + hesoluong * luongcoban;

            }
            public override void Hien()
            {
                base.Hien();
                Console.WriteLine("He so luong:{0}\t Luong co ban:{1}\tinh luong:{2}", hesoluong, luongcoban, tinhluong());
            }

        }
        class QLNV
        {
            private int sonv;
            private Nhanvien[] ds;
            public void Nhap()
            {
                Console.Write("Nhap so nhan vien:"); sonv = int.Parse(Console.ReadLine());
                ds = new Nhanvien[sonv];
                for (int i = 0; i < sonv; i++)
                {
                    Console.WriteLine("Ban muon nhap thong tin cho nhan vien quanly(Q), cong nhan{C},san xuat{S}");
                    char ch = char.Parse(Console.ReadLine());
                    switch (char.ToUpper(ch))
                    {
                        case 'Q': ds[i] = new NVQL(); ds[i].Nhap(); break;
                        case 'C': ds[i] = new NVCN(); ds[i].Nhap(); break;
                        case 'S': ds[i] = new NVSX(); ds[i].Nhap(); break;
                    }
                }
            }
            public void Hien()
            {
                for (int i = 0; i < sonv; i++)
                    ds[i].Hien();
            }
        }
        class Program
        {
            static void Main1(string[] args)
            {
                QLNV t = new QLNV();
                t.Nhap();
                t.Hien();
                Console.ReadKey();
            }
        }
    }

