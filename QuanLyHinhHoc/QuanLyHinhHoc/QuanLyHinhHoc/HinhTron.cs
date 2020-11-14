using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhTron
    {
        
        private double banKinhHT;
        public double bK
        {
            get { return banKinhHT; }
            set { banKinhHT = value; }
        }
        public HinhTron(double banKinh)
        {
            banKinhHT = banKinh;
        }
        private double chuVi;
        public double cV
        {
            get { return chuVi; }
            set { chuVi = value; }
        }
        private double dienTich;
        public double dT
        {
            get { return dienTich; }
            set { dienTich = value; }
        }

        public HinhTron()
        {
            
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhập bán kính: ");
                bK = double.Parse(Console.ReadLine());

            } while (bK < 0);
            ChuVi();
            DienTich();
        }
        public override string ToString()
        {
            return string.Format("Hình tròn: Bán kính {0}, Chu vi {1}, Diện tích {2}", bK, ChuVi(), DienTich());
        }
        public double ChuVi()
        {
            return 2 * 3.14 * bK;
        }
        public double DienTich(){
            return 3.14 * bK * bK; 
            }   
    }
}
