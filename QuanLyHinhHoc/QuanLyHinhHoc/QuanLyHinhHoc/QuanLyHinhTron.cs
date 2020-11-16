using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class QuanLyHinhTron
    {
        public List<HinhTron> ds_ht = new List<HinhTron>();
        public HinhTron this[int index]
        {
            get { return ds_ht[index]; }
        }
        public int Dem
        {
            get { return ds_ht.Count; }
        }
        public void Them(HinhTron a)
        {
            ds_ht.Add(a);
        }
        public void Xoa(HinhTron a)
        {
            ds_ht.Remove(a);
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            string s="";
            foreach (var item in ds_ht)
		    s+=item+"\n";
            return s;  
        }
    }
}
