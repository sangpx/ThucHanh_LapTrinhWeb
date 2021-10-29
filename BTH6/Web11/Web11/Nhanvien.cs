using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web11
{
    public class Nhanvien
    {
        string hoten;
        int namsinh;
        public Nhanvien()
        {

        }
        public Nhanvien (string hoten, int namsinh)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public int Namsinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }
    }
}