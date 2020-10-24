using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH3
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0; ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu so:");
            ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            ms = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else Console.WriteLine("{0}/{1}", ts, ms);
        }
        public int Uscln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public PS Rutgon()
        {
            int uc = Uscln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        public PS Tong2PS(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS Tong(PS so)
        {
            PS t = new PS();
            t.ts = this.ts + so.ts*this.ms;
            t.ms=this.ms;
            return t.Rutgon();
        }
        public PS Hieu2PS(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS Hieu(PS so)
        {
            PS t = new PS();
            t.ts = this.ts -so.ts * this.ms;
            t.ms = this.ms;
            return t.Rutgon();
        }
        public static PS operator +(PS t1, PS t2)
        {
            PS t = new PS();
            t.ts = t1.ts * t2.ms + t1.ms * t2.ts;
            t.ms = t1.ms * t2.ms;
            return t.Rutgon();
        }
    }
    class App
    {
        static void Main1()
        {
            PS t1 = new PS(7, 6);
            PS t2 = new PS(2, 3);
            Console.WriteLine("Tong hai phan so");
            PS tong2PS = t1.Tong2PS(t2);
            tong2PS.Hien();
            Console.WriteLine("Hieu hai phan so");
            PS hieu2PS = t1.Hieu2PS(t2);
            hieu2PS.Hien();
            Console.ReadKey();
        }
    }
}
