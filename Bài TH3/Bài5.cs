using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH3
{
    class Vecto
    {
        private int n;
        private int[] v;
        public Vecto()
        {
            n = 2;
            v = new int[2];
        }
        public Vecto(int n)
        {
            this.n = n;
            v = new int[n];
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cua vecto");
            for (int i = 0; i < n; ++i)
            {
                Console.Write("v[{0}]=", i);
                v[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Hien()
        {
            Console.WriteLine("Thong tin cua vecto");
            for (int i = 0; i < n; ++i)
                Console.Write("{0},", i);
        }
        public Vecto Tong(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; ++i)
                    t.v[i] = this.v[i] + t2.v[i];
                return t;
            }
            else return null;
        }
        public Vecto Hieu(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; ++i)
                    t.v[i] = this.v[i] - t2.v[i];
                return t;
            }
            else return null;
        }
        public Vecto Tich(Vecto t2)
        {
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; ++i)
                    t.v[i] = this.v[i] * t2.v[i];
                return t;
            }
            else return null;
        }
        static void Main5()
        {
            Console.WriteLine("Nhap thong tin cho vecto thu nhat");
            Vecto t1 = new Vecto(5); t1.Nhap();
            Console.WriteLine("Nhap thong tin cho vecto thu nhat");
            Vecto t2 = new Vecto(5); t2.Nhap();
            Console.WriteLine("Tong hai vecto");
            Vecto t3 = t1.Tong(t2);
            if (t3 == null)
                Console.WriteLine("Khong tinh tong duc vi hai vecto co kich thuoc khong bang nhau");
            else
            {
                Console.WriteLine("Tong hai vecto");
                t3.Hien();
            }
            Console.WriteLine("Hieu hai vecto");
            Vecto t4 = t1.Hieu(t2);
            if (t4 == null)
                Console.WriteLine("Khong tinh tong duc vi hai vecto co kich thuoc khong bang nhau");
            else
            {
                Console.WriteLine("Hieu hai vecto");
                t4.Hien();
            }
            Console.ReadKey();
        }
    }
}
