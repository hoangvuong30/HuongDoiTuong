using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhChuNhat
    {
        private double chieuRong;
        public double cR
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        private double chieuDai;
        public double cD
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }
        public HinhChuNhat(double rong, double dai)
        {
            chieuRong = rong;
            chieuDai = dai;
        }
        private double chuVi;
        public double cV
        {
            get { return chuVi; }
            set { chuVi = value; }
        }
        private double dienTich;
        private double p;
        public double dT
        {
            get { return dienTich; }
            set { dienTich = value; }
        }
        public HinhChuNhat()
        {

        }

        public HinhChuNhat(double p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhập chiều rộng và chiều dài: ");
                chieuRong = double.Parse(Console.ReadLine());
                chieuDai = double.Parse(Console.ReadLine());
            } while (chieuDai<0&&chieuRong<0);
        }
        public override string ToString()
        {
            return string.Format("Hình chữ nhật: Chiều rộng {0}, Chiều dài {1}, Chu vi {2}, Diện tích {3}",chieuRong,chieuDai, ChuVi(),DienTich());
        }
        public double ChuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }
        public double DienTich()
        {
            return chieuDai * chieuRong;
        }


    }
}
