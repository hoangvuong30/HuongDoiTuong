using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class QuanLyHinhChuNhat
    {
        public List<HinhChuNhat> ds_hcn = new List<HinhChuNhat>();
        public HinhChuNhat this[int index]
        {
            get { return ds_hcn[index]; }
        }
        public int Dem
        {
            get { return ds_hcn.Count; }
        }
        public void Them(HinhChuNhat a)
        {
            ds_hcn.Add(a);
        }
        public void Xoa(HinhChuNhat a)
        {
            ds_hcn.Remove(a);
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in ds_hcn)
                s += item + "\n";
            return s;
        }
    }
}
