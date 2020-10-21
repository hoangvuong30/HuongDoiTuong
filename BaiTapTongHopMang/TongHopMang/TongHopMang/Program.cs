using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHopMang
{
    class Program
    {
        static QuanLyMang QLMang = new QuanLyMang();

        enum Menu
        {
            Thoat,
            Nhap,
            Xuat,
            In6Dong,
            FindMax,
            FindMin,
            DemPhanTuLe,
            DemPhanAmChan,
            SumPhanTu,
            SumPhanTuChan,
            LocSoNguyenTo,
            DemSoNguyenTo,
            SumSoNguyenTo,
            LocSoChinhPhuong,
            SumSoChinhPhuong,
            InSoHoanThien,
            NhapVaTimViTriXDauTien,
            NhapVaDemSoLanXuatHienPhanTuX,
            NhapVaInTatCaViTriXTrongMang,
            NhapVaThemPhanTuXCuoiMang,
            NhapvaThemPhanTuXDauMang,
            NhapVaThemPhanTuXVaoViTrik,
            NhapVaInPhanTuTaik,
            XoaPhanTuCuoi, XoaPhanTuDau,
            NhapVaXoaPhanTuTaik,
            NhapVaXoaPhanTuxDauTien,
            NhapVaXoaTatCaPhanTux,
            XepTang,
            XepGiam
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            XuLyMenu();
            Console.ReadLine();
        }

        static void QuanLyMang()
        {
            throw new NotImplementedException();
        }

        static void XuatMenu()
        {
            Console.WriteLine("==========Các chức năng của chương trình==========");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("0.Thoát");
            Console.WriteLine("1. Nhập tự động");
            Console.WriteLine("2. Xuất mảng vừa nhập");
            Console.WriteLine("3. In 6 dòng:");
            Console.WriteLine("+ Các phần tử chẵn theo thứ tự nhập");
            Console.WriteLine("+ Các phần tử lẻ ngược thứ tự nhập");
            Console.WriteLine("+ Các phần tử ở vị trí chẵn ngược thứ tự nhập");
            Console.WriteLine("+ Các phần tử ở vị trí lẻ theo thứ tự nhập");
            Console.WriteLine("+ Các phần tử âm theo thứ tự nhập");
            Console.WriteLine("+ Các phần tử dương ngược thứ tự nhập");
            Console.WriteLine("4. Tìm phần tử lớn nhất");
            Console.WriteLine("5. Tìm phần tử bé nhất");
            Console.WriteLine("6. Đếm số phần tử lẻ trong mảng");
            Console.WriteLine("7. Đếm số phần tử âm trong mảng");
            Console.WriteLine("8. Tính tổng số phần tử trong mảng");
            Console.WriteLine("9. Tính tổng các phần tử ở vị trí chẳn");
            Console.WriteLine("10. Lọc các số nguyên tố trong mảng");
            Console.WriteLine("11. Đếm các số nguyên tố trong mảng");
            Console.WriteLine("12. Tính tổng các số nguyên tố trong mảng");
            Console.WriteLine("13. Lọc các số chính phương trong mảng");
            Console.WriteLine("14. Tính tổng các số chính phương trong mảng");
            Console.WriteLine("15. In các số hoàn thiện trong mảng");
            Console.WriteLine("16. Nhập phần tử x, tìm vị trí đầu tiên của nó trong mảng(nếu không có thì thông báo)");
            Console.WriteLine("17. Nhập phần tử x, đếm số lần xuất hiện của nó trong mảng(nếu không có thì thông báo)");
            Console.WriteLine("18. Nhập phần tử x, in tất cả các vị trí của nó trong mảng(nếu có)");
            Console.WriteLine("19. Nhập phần tử x, thêm vào cuối mảng");
            Console.WriteLine("20. Nhập phần tử x, thêm vào đầu mảng");
            Console.WriteLine("21. Nhập phần tử x, thêm vào vị trí k(0<k<n)");
            Console.WriteLine("22. Nhập vị trí k(0<k<n), in phần tử tại k");
            Console.WriteLine("23. Xóa phần tử cuối mảng");
            Console.WriteLine("24. Xóa phần tử đầu mảng");
            Console.WriteLine("25. Nhập vị trí k(0<k<n), xóa phần tử tại vị trí k");
            Console.WriteLine("26. Nhập phần tử x, xóa phần tử x đầu tiên trong mảng");
            Console.WriteLine("27. Nhập phần tử x, xóa tất cả các phần tử x trong mảng");
            Console.WriteLine("28. Sắp xếp mảng tăng dần");
            Console.WriteLine("29. Sắp xếp mảng giảm dần");
            Console.WriteLine("--------------------------------------------------");
        }
        static void XuLyMenu()
        {
            while (true)
            {
            batDau:
                Console.Clear();
                XuatMenu();
                Console.Write("Nhập số thứ tự cần thực hiện chương trình: ");
                int kq;
                bool dung = int.TryParse(Console.ReadLine(), out kq);
                if (!dung)
                {
                    Console.WriteLine("Ban nhap sai");
                    Console.ReadLine();
                    goto batDau;
                }
                Menu nhap = (Menu)kq;
                switch (nhap)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.Nhap:
                        QLMang.NhapRandom();
                        break;
                    case Menu.Xuat:
                        QLMang.Xuat();
                        break;

                    case Menu.In6Dong:
                        QLMang.Xuat();
                        Console.WriteLine("Các phần tử chẵn: ");
                        QLMang.PhanTuChan();
                        Console.WriteLine("Các phần tử lẽ ngược thứ tự nhập:");
                        Console.WriteLine("Các phần tử ở vị trí chẵn ngược thứ tự nhập: ");
                        Console.WriteLine("Các phần tử ở vị trí lẻ theo thứ tự nhập:");
                        Console.WriteLine("Các phần tử âm theo thứ tự nhập: ");
                        Console.WriteLine("Các phần tự dương ngược thứ tự nhập: ");
                        break;
                    case Menu.FindMax:
                        break;
                    case Menu.FindMin:
                        break;
                    case Menu.DemPhanTuLe:
                        break;
                    case Menu.DemPhanAmChan:
                        break;
                    case Menu.SumPhanTu:
                        break;
                    case Menu.SumPhanTuChan:
                        break;
                    case Menu.LocSoNguyenTo:
                        break;
                    case Menu.DemSoNguyenTo:
                        break;
                    case Menu.SumSoNguyenTo:
                        break;
                    case Menu.LocSoChinhPhuong:
                        break;
                    case Menu.SumSoChinhPhuong:
                        break;
                    case Menu.InSoHoanThien:
                        break;
                    case Menu.NhapVaTimViTriXDauTien:
                        break;
                    case Menu.NhapVaDemSoLanXuatHienPhanTuX:
                        break;
                    case Menu.NhapVaInTatCaViTriXTrongMang:
                        break;
                    case Menu.NhapVaThemPhanTuXCuoiMang:
                        break;
                    case Menu.NhapvaThemPhanTuXDauMang:
                        break;
                    case Menu.NhapVaThemPhanTuXVaoViTrik:
                        break;
                    case Menu.NhapVaInPhanTuTaik:
                        break;
                    case Menu.XoaPhanTuCuoi:
                        break;
                    case Menu.XoaPhanTuDau:
                        break;
                    case Menu.NhapVaXoaPhanTuTaik:
                        break;
                    case Menu.NhapVaXoaPhanTuxDauTien:
                        break;
                    case Menu.NhapVaXoaTatCaPhanTux:
                        break;
                    case Menu.XepTang:
                        break;
                    case Menu.XepGiam:
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }


        }
    }
}
