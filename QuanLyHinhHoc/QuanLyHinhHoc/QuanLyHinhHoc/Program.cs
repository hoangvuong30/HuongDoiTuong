using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyHinhHoc
{
    enum Menu
    {
        Thoat,
        NhapDuLieuBangTay,
        NhapDuLieuTuFile,
        FindHVCoDTMax,
        FindHCNCoDTMin,
        FindHTCoBKMax,
        XepDSHVTangGiamTheoCV,
        XepDSHTTangGiamTheoCV,
        XepDSHCNTangGiamTheoCV,
        FindHinhDTMaxMin,
        FindHinhCVMaxMin,
        HienThiHinhTangGiamTheoDT,
        HienThiHinhTangGiamTheoCV,
        RemoveHinhDTMaxMin,
        RemoveHinhCVMaxMin
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyHinhHoc qlhh = new QuanLyHinhHoc();
            qlhh.NhapDuLieu();
            Console.Clear();
            XuLyMenu();
            Console.ReadLine();
            

        }
        //static void DocTuFile()
        //{
        //    FileStream fs = new FileStream("data.txt",FileMode.Open);
        //    StreamReader sr=new StreamReader(fs,Encoding.UTF8);
        //    String doc=sr.ReadToEnd();
        //    sr.Close();
        //    Console.ReadLine();
        //}




        static void XuatMenu()
        {
            Console.WriteLine("0.   Thoát");
            Console.WriteLine("1.	Nhập bằng tay");
            Console.WriteLine("2.	Nhập từ file");
            Console.WriteLine("3.	Tìm hình vuông có diện tích lớn nhất");
            Console.WriteLine("4.	Tìm hình chữ nhật có diện tích nhỏ nhất");
            Console.WriteLine("5.	Tìm hình tròn có bán kính lớn nhất");
            Console.WriteLine("6.	Sắp xếp danh sách hình vuông theo chiều tăngm giảm của chu vi");
            Console.WriteLine("7.	Sắp xếp danh sách hình tròn theo chiều tăngm giảm của chu vi");
            Console.WriteLine("8.	Sắp xếp danh sách hình chữ nhật theo chiều tăng giảm của chu vi");
            Console.WriteLine("9.	Tìm các hình có diện tích lớn nhất, nhỏ nhất");
            Console.WriteLine("10.	Tìm các hình có chu vi lớn nhất, nhỏ nhất");
            Console.WriteLine("11.	Hiển thị tất cả các hình theo chiều tăng, giảm của diện tích");
            Console.WriteLine("12.	Hiển thị tất cả các hình theo chiều tăng, giảm của chu vi");
            Console.WriteLine("13.	 Xóa các hình có diện tích nhỏ nhất, lớn nhất");
            Console.WriteLine("14.	Xóa các hình có chu vi nhỏ nhất, lớn nhất");
        }
        static void XuLyMenu()
        {
            
            Console.Clear();
            XuatMenu();
        BatDau:
            Console.WriteLine("Nhập số thứ tự để thực hiện chức năng của chương trình: ");
        int kq;
        bool dung = int.TryParse(Console.ReadLine(), out kq);
        if (!dung)
        {
            Console.WriteLine("Nhap sai!!!");
            Console.ReadLine();
            goto BatDau;
        }
        Menu nhap = (Menu)kq;
        switch (nhap)
        {
            case Menu.Thoat:
                break;
            case Menu.NhapDuLieuBangTay:
                
                break;
            case Menu.NhapDuLieuTuFile:
                DocTuFile();
                break;
            case Menu.FindHVCoDTMax:
                break;
            case Menu.FindHCNCoDTMin:
                break;
            case Menu.FindHTCoBKMax:
                break;
            case Menu.XepDSHVTangGiamTheoCV:
                break;
            case Menu.XepDSHTTangGiamTheoCV:
                break;
            case Menu.XepDSHCNTangGiamTheoCV:
                break;
            case Menu.FindHinhDTMaxMin:
                break;
            case Menu.FindHinhCVMaxMin:
                break;
            case Menu.HienThiHinhTangGiamTheoDT:
                break;
            case Menu.HienThiHinhTangGiamTheoCV:
                break;
            case Menu.RemoveHinhDTMaxMin:
                break;
            case Menu.RemoveHinhCVMaxMin:
                break;
            default:
                break;
        }

        }

        private static void DocTuFile()
        {
            throw new NotImplementedException();
        }

    }
}
