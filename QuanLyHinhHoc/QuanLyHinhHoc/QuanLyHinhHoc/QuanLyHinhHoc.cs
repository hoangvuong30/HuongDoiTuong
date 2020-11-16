using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyHinhHoc
{
    class QuanLyHinhHoc
    {

        List<HinhVuong> danhSachHinhVuong = new List<HinhVuong>();
        List<HinhChuNhat> danhSachHinhChuNhat = new List<HinhChuNhat>();
        List<HinhTron> danhSachHinhTron = new List<HinhTron>();
        public void NhapDuLieu()
        {
            Console.WriteLine("Hình vuông: ");
            HinhVuong hv = new HinhVuong();
            hv.Nhap();
            Console.WriteLine(hv);
            Console.WriteLine("\nHình tròn: ");
            HinhTron ht = new HinhTron();
            ht.Nhap();
            Console.WriteLine(ht);
            Console.WriteLine("\nHình chữ nhật: ");
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.Nhap();
            Console.WriteLine(hcn);
        }
        public void DocTuFile()
        {
            string p = @"data.txt";
            StreamReader sr = new StreamReader(p);
            string s="";
            while ((s = sr.ReadLine()) != null)
            {
                string[] t = s.Split(' ');
                if (t[0] == "HT")
                    danhSachHinhTron.Add(new HinhTron(double.Parse(t[1])));
                else if (t[0] == "HV")
                    danhSachHinhVuong.Add(new HinhVuong(double.Parse(t[1])));
                else if (t[0] == "HCN")
                    danhSachHinhChuNhat.Add(new HinhChuNhat(double.Parse(t[1])));
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Danh sách hình tròn: ");
            Console.WriteLine(danhSachHinhTron);
            Console.WriteLine("Danh sách hình vuông: ");
            Console.WriteLine(danhSachHinhVuong);
            Console.WriteLine("Danh sách hình chữ nhật: ");
            Console.WriteLine(danhSachHinhChuNhat);
        }
        public void NhapBangTay()
        {
            string s = "";
            do
            {
                Console.WriteLine("Nhập theo định dạng, mỗi lần nhập là 1 hình(HT 4, HCN 4 5, HV 5");
                s = Console.ReadLine();
                string[] t = s.Split(' ');
                if (t[0] == "HT")
                    danhSachHinhTron.Add(new HinhTron(double.Parse(t[1])));
                else if (t[0] == "HV")
                    danhSachHinhVuong.Add(new HinhVuong(double.Parse(t[1])));
                else if (t[0] == "HCN")
                    danhSachHinhChuNhat(new HinhChuNhat(double.Parse(t[1])));
                else return;
            } while (s == "");
        }
        public List<HinhVuong> Tim_DTHV_Max()
        {
            List<HinhVuong> kq = new List<HinhVuong>();
            kq.Di


            return kq;
        }

        private void danhSachHinhChuNhat(HinhChuNhat hinhChuNhat)
        {
            throw new NotImplementedException();
        }
        public double TimMax()
        {
            double max = double.MinValue;
            for (int i = 0; i < max; i++)
                if (i > max)
                    max = i;
            return max;
        }
        public double TimMin()
        {
            double min = double.MaxValue;
            for (int i = 0; i > min; i--)
                if (i < min)
                    min = i;
            return min;
        }
    }
    
      
}

