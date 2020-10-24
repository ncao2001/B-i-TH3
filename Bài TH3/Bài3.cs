using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH3
{
    class Time
    {
        private int gio, giay, phut;
        public Time()
        {
            gio = phut = giay = 0;
        }    
        public Time(int gio, int phut, int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }
        public int Gio
        {
            get
            {
                return gio;
            }
            set
            {
                gio = value;
            }
        }
        public int Phut
        {
            get
            {
                return phut;
            }
            set
            {
                phut = value;
            }
        }
        public int Giay
        {
            get
            {
                return giay;
            }
            set
            {
                giay = value;
            }
        }
        public Time Normalize(int gio, int phut, int giay)
        {
            Time t = new Time();
            t.phut += t.giay / 60;
            t.giay = t.giay % 60;
            t.gio += t.phut / 60;
            t.phut = t.phut % 60;
            t.gio = t.gio % 24;
            return t;
        }
        public void Hien()
        {
            Console.WriteLine("Thoi gian hien hanh: {0}-{1}-{2}", gio, phut, giay);
        }
        public Time Advance(int gio, int phut, int giay)
        {
            Time t = new Time();
            t.gio = this.gio + gio;
            t.phut = this.phut + phut;
            t.giay = this.giay + giay;
            t.phut += t.giay / 60;
            t.giay = t.giay % 60;
            t.gio += t.phut / 60;
            t.phut = t.phut % 60;
            t.gio = t.gio % 24;
            return t;
        }
        static void Main3()
        {

        }
    }
}
