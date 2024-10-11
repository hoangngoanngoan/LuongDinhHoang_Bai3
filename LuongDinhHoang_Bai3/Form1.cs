namespace LuongDinhHoang_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Order> dso = new List<Order>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            var soluong = int.Parse(txtsoluong.Text);
            var dongia = double.Parse(txtdongia.Text);
            var tenkh = txttenkh.Text;
            var tensp = txttensp.Text;
            var ngaydat = txtngaydat.Text;
            if (dongia * soluong >= 1000000)
            {
                var newor = new BulkOrder(null, tenkh, tensp, ngaydat, soluong, dongia);
                dso.Add(newor);
            }
            else
            {
                var newor = new Order(null, tenkh, tensp, ngaydat, soluong, dongia);
                dso.Add(newor);
            }
            dt1.DataSource = null;
            dt1.DataSource = dso;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var madh = txtmadonhang.Text;
            foreach(var item in dso)
            {
                if(item.MaDonHang == madh)
                {
                    dso.Remove(item);
                    break;
                }
            }
            dt1.DataSource = null;
            dt1.DataSource = dso;
        }
    }
}
