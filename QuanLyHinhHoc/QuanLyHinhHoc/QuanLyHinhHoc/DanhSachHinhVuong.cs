using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class DanhSachHinhVuong
    {
        public List<HinhVuong> ds_hv = new List<HinhVuong>();
        public HinhVuong this[int index]
        {
            get { return ds_hv[index]; }
        }
        public int Dem
        {
            get { return ds_hv.Count; }
        }
        public void Them(HinhVuong a)
        {
            ds_hv.Add(a);
        }
        public void Xoa(HinhVuong a)
        {
            ds_hv.Remove(a);
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in ds_hv)
                s += item + "\n";
            return s;
        }
    }
}
