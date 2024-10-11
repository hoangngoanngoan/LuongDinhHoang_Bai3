using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuongDinhHoang_Bai3
{
    internal class Order
    {
        protected static int autoID = 0;

        public string MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string TenSanPham { get; set; }
        public string NgayDat { get; set; }
        public int Soluong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }

        public Order()
        {

        }

        public Order(string id)
        {
            MaDonHang = id == null ? $"MADH{++autoID}" : id;
        }

        public Order(string id, string tenkh, string tensp, string ngaydat,int soluong, double dongia) : this(id)
        {
            TenKhachHang = tenkh;
            TenSanPham = tensp;
            NgayDat = ngaydat;
            Soluong = soluong;
            DonGia = dongia;
            ThanhTien = this.TongThanhTien();
        }

        public virtual double TongThanhTien()
        {
            return Soluong * DonGia;
        }
    }

    internal class BulkOrder : Order
    {
        public BulkOrder()
        {

        }

        public BulkOrder(string id, string tenkh, string tensp, string ngaydat,int soluong, double dongia) : base(id, tenkh, tensp, ngaydat,soluong, dongia)
        {

        }

        public override double TongThanhTien()
        {
            return base.TongThanhTien() * 0.8;
        }
    }
}
