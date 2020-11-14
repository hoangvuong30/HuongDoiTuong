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

        //List<HinhVuong> danhSachHinhVuong = new List<HinhVuong>();
        
        //List<HinhChuNhat> danhSachHinhChuNhat = new List<HinhChuNhat>();
        //List<HinhTron> danhSachHinhTron = new List<HinhTron>();
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
    }
    
      
}

