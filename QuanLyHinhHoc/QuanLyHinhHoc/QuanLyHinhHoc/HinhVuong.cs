using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhVuong
    {
        private double canhHV;
        public double c
        {
            get { return canhHV; }
            set { canhHV = value; }
        }
        private double chuViHV;
        public double cV
        {
            get { return chuViHV; }
            set { chuViHV = value; }
        }
        private double dienTichHV;
        public double dT
        {
            get { return dienTichHV; }
            set { dienTichHV = value; }
        }
        public HinhVuong()
        {

        }
        public HinhVuong(double canh)
        {
            canhHV = canh;
            ChuVi();
            DienTich();
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhập vào độ dài cạnh: ");
                c = double.Parse(Console.ReadLine());
            } while (c < 0);
            ChuVi();
            DienTich();
        }
        public override string ToString()
        {
            return string.Format("Hình vuông: Cạnh {0}, Chu vi {1}, Diện tích {2}", c, ChuVi(), DienTich());

        }
        public double ChuVi()
        {
            return canhHV * 4;
        }
        public double DienTich()
        {
            return canhHV * canhHV;
        }
    }
}
