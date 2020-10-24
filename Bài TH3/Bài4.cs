using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH3
{
    class HS
    {
        private int dt, dl, dh;
        private string ten;
        public HS()
        {
            ten = "";
            dt = dl = dh = 0;
        }
        public HS(string ten, int dt, int dl, int dh)
        {
            this.ten = ten;
            this.dt = dt;
            this.dl = dl;
            this.dh = dh;
        }
        public HS(HS t2)
        {
            this.ten = t2.ten;
            this.dt = t2.dt;
            this.dl = t2.dl;
            this.dh = t2.dh;
        }
        public void Nhap()
        {
            Console.Write("Nhap ho ten:");
            ten = Console.ReadLine();
            Console.Write("Nhap diem toan:");
            dt = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly:");
            dl = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa:");
            dh = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", ten, dt, dl, dh);
        }
        public int Dtoan
        {
            get { return dt; }
            set
            {
                if (value >= 0 && value <= 10)
                { dt = value; }
            }
        }
        public int Dly
        {
            get { return dl; }
            set
            {
                if (value >= 0 && value <= 10)
                { dl = value; }
            }
        }
        public int Dhoa
        {
            get { return dh; }
            set
            {
                if (value >= 0 && value <= 10)
                { dh = value; }
            }
        }
    }
    class QLHS
    {
        private HS[] ds;
        private int n;
        public void Nhap()
        {
            Console.Write("Nhap so sinh vien:");
            n = int.Parse(Console.ReadLine());
            ds = new HS[n];
            for (int i = 0; i < ds.Length; ++i)
            {
                Console.WriteLine("Nhap thong tin cho sinh vien" + i + ":");
                ds[i] = new HS();
                ds[i].Nhap();
            }
        }
        public void Hien()
        {
            for (int i = 0; i < ds.Length; ++i)
                ds[i].Hien();
        }
        public void Thilai()
        {
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (ds[i].Dtoan < 5 || ds[i].Dly < 5|| ds[i].Dhoa < 5)
                    {
                        Console.WriteLine("Thi lai!");
                    }
                }
            }
        }
    }
    class APP
    {
        static void Main4()
        {
            QLHS t = new QLHS();
            t.Nhap();
            Console.WriteLine("Danh sach sinh vien:");
            t.Hien();
            t.Thilai();
            Console.ReadKey();
        }
    }
}