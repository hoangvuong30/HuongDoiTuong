using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHopMang
{
    class QuanLyMang
    {
        public List<int> DanhSach = new List<int>();

        public QuanLyMang()
        {

        }

        public void Them(int so)
        {
            DanhSach.Add(so);
        }

        public void NhapRandom()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều dài mảng: ");
            int length = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                DanhSach[i] = rand.Next(10);
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < DanhSach.Count; i++)
            {
                Console.Write(DanhSach[i] + "\t");

            }
        }

        public QuanLyMang LaySoChan()
        {
            QuanLyMang kq = new QuanLyMang();
            for (int i = 0; i < DanhSach.Count; i++)
            {
                if (DanhSach[i] % 2 == 0)
                {
                    kq.Them(DanhSach[i]);
                }
            }
            return kq;
        }

        public QuanLyMang LaySoLe()
        {
            return new QuanLyMang { DanhSach = DanhSach.Where(n => n % 2 != 0).ToList() };
        }


        public void SoLeNguocThuTuNhap()
        {

        }



    }
}
