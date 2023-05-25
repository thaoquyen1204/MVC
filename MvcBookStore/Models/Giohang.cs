using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcBookStore.Models;

namespace MvcBookStore.Models
{
    public class Giohang
    {
        dbQLBansachDataContext data = new dbQLBansachDataContext();
        public int iMasach { get; set; }
        public string sTensach { set; get; }
        public string sAnhbia { set; get; }
        public Double dDonggia { set; get; }
        public int iSoluong { set; get; }
        public Double dThanhtien
        {
            get { return iSoluong * dDonggia; }
        }
        public Giohang(int Masach)
        {
            iMasach = Masach;
            SACH sach = data.SACHes.Single(n => n.Masach == iMasach);
            sTensach = sach.Tensach;
            sAnhbia = sach.Anhbia;
            dDonggia = double.Parse(sach.Giaban.ToString());
            iSoluong = 1;
        }
    }
}