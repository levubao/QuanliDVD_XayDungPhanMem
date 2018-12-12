using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XuLy;

namespace QuanLiDia
{
    public partial class frmThueDia : Form
    {
        public QuanlidiaDataContext dt;
        clcKhachHang objKH = new clcKhachHang();
        clcTTThueTra objTTThueDia = new clcTTThueTra();
        clcCTThueTra objCTThueTra = new clcCTThueTra();
        clcDia objDia = new clcDia();
        IEnumerable<DVD_CD> objListDia;      
        IEnumerable<KhachHang> objListKH;
        IEnumerable<TTThueDia> objListTTThueDia;
        IEnumerable<ChiTietThueTra> objListCTThueTra;
        public frmThueDia()
        {
            InitializeComponent();
        }
       
        private void frmThueDia_Load(object sender, EventArgs e)
        {
            vohh(false);
            btnThue.Enabled = false;
            btnChonDia.Enabled = false;
            txtTT.Enabled = false;
            TaoTieuDeListView(lvwKhachHang);
            TaoTieuDeDiaListView(lvwDia);
            txtMaKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMaDia.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaDia.AutoCompleteSource = AutoCompleteSource.CustomSource;
            objListDia = objDia.GetDia();
            objListKH = objKH.GetKhachHang();
            foreach (KhachHang kh in objListKH)
            { 
                txtMaKH.AutoCompleteCustomSource.Add(kh.MaKH);
            }
            foreach (DVD_CD kh in objListDia)
            {
                txtMaDia.AutoCompleteCustomSource.Add(kh.MaDia);
            }
        }            
        void TaoTieuDeDiaListView(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.Columns.Add("Ma Dia", 50, HorizontalAlignment.Left);
            lvw.Columns.Add("Mo Ta", 250, HorizontalAlignment.Left);
            lvw.Columns.Add("Status", 80, HorizontalAlignment.Left);
            lvw.Columns.Add("Gia", 70, HorizontalAlignment.Center);
            lvw.View = View.Details;
            lvw.FullRowSelect = true;
            lvw.GridLines = true;
        }
        void TaoTieuDeListView(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.Columns.Add("Mã KH", 50, HorizontalAlignment.Left);
            lvw.Columns.Add("Họ Tên", 130, HorizontalAlignment.Left);
            lvw.Columns.Add("SĐT", 80, HorizontalAlignment.Left);
            lvw.Columns.Add("Email", 100, HorizontalAlignment.Left);
            lvw.Columns.Add("Address", 100, HorizontalAlignment.Center);          
            lvw.View = View.Details;
            lvw.FullRowSelect = true;
            lvw.GridLines = true;
        }
        void LoadToListView(ListView lvw, IEnumerable<KhachHang> dsKH)
        {
            lvw.Items.Clear();
            ListViewItem lvwItem;
            foreach (KhachHang item in dsKH)
            {
                lvwItem = new ListViewItem(item.MaKH);
                lvwItem.SubItems.Add(item.TenKH);
                lvwItem.SubItems.Add(item.SoDienThoai);
                lvwItem.SubItems.Add(item.Email);
                lvwItem.SubItems.Add(item.Address);
                lvwItem.Tag = item;//chính là 1 objMayTinh
                lvw.Items.Add(lvwItem);
            }
        }
        private void btnChonDia_Click(object sender, EventArgs e)
        {
            try
                {
                decimal tong = 0;
                string strNhap = txtMaDia.Text;
                    List<DVD_CD> dsDia;
                    dsDia = objDia.GetMaDiaListTimKiem(strNhap);
                    TaoTieuDeDiaListView(lvwDia);
                    dt = new QuanlidiaDataContext();
                    ChiTietThueTra r = new ChiTietThueTra();
                    r.MaPhieuThue = txtMaPT.Text;
                    r.MaDia = txtMaDia.Text;
                    var dis = dt.DVD_CDs.Where(nv => nv.MaDia == txtMaDia.Text).FirstOrDefault();                
                    btnThue.Enabled = true;     
                        if (dis.Status != "lease")
                        {
                    dis.Status = "lease";
                            dt.ChiTietThueTras.InsertOnSubmit(r);
                            dt.SubmitChanges();
                            LoadDiaToListView(lvwDia, dsDia);
                    if (lvwDia.Items.Count > 0)
                    {
                        foreach (ListViewItem item in lvwDia.Items)
                        {
                            tong += Convert.ToDecimal(item.SubItems[3].Text);
                        }             
                    }
                    txtTT.Text = tong.ToString(); 
                }
                else
                        {
                    //MessageBox.Show("Đĩa không còn cho thuê");
                    MessageBox.Show("Đĩa đã được thuê vui lòng chọn đĩa khác!!!");
                    btnThue.Enabled = false;
                }
                txtMaDia.Focus();
            }
                catch
                {
                    MessageBox.Show("Đĩa trùng");
                }
        }
        void LoadDiaToListView(ListView lvw, IEnumerable<DVD_CD> dsDia)
        {
            ListViewItem lvwItem;

            foreach (DVD_CD item in dsDia)
            {
                lvwItem = new ListViewItem(item.MaDia);
                lvwItem.SubItems.Add(item.MoTa);
                lvwItem.SubItems.Add(item.Status);
                lvwItem.SubItems.Add(item.Gia.ToString());
                lvwItem.Tag = item;//chính là 1 objDia
                lvw.Items.Add(lvwItem);
                btnChonDia.Enabled = false;
            }
        }
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            string strNhap = txtMaKH.Text;
            List<KhachHang> dsKH;
            dsKH = objKH.GetMaKhachHangListTimKiem(strNhap);
            LoadToListView(lvwKhachHang, dsKH);
            txtTenKH.Clear();
            foreach (KhachHang item in dsKH)
            {
                txtTenKH.Text = item.TenKH;
            }
            if (txtTenKH.Text.Equals(""))
                button3.Enabled = false;
            else
                button3.Enabled = true;          
        }
        private void vohh(bool l)
        {
            txtMaDia.Enabled = l;
            txtGia.Enabled = l;
            btnChonDia.Enabled = l;
            button3.Enabled = l;
            textBox2.Enabled = l;
            txtTenDia.Enabled = l;
            button1.Enabled = l;
        }
        private void txtMaDia_TextChanged(object sender, EventArgs e)
        {
            dt = new QuanlidiaDataContext();
            string strNhap = txtMaDia.Text;
            List<DVD_CD> dsDia;
            dsDia = objDia.GetMaDiaListTimKiem(strNhap);
            textBox2.Clear();
            txtGia.Clear();
            txtTenDia.Clear();
            foreach (DVD_CD item in dsDia)
            {
                txtGia.Text = Convert.ToInt32( item.Gia).ToString();
                textBox2.Text = item.MoTa;
            }
            if (textBox2.Text.Equals(""))
            {
               // btnChonDia.Enabled = false;
                btnThue.Enabled = false;
            }
            else
              //  btnChonDia.Enabled = true;
                btnThue.Enabled = false;
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
                dt = new QuanlidiaDataContext();
                var dis = dt.TTThueDias.Where(nv => nv.MaPhieuThue == txtMaPT.Text).FirstOrDefault();
                dis.Cost = float.Parse(txtTT.Text);
                dt.SubmitChanges();
                txtMaPT.Enabled = true;
                txtMaKH.Enabled = true;
                txtMaDia.Enabled = false;
                reset();
            //vohh(false);
            //btnThue.Enabled = false;
            //btnChonDia.Enabled = false;
            //txtTT.Enabled = false;
            ////TaoTieuDeListView(lvwKhachHang);
            ////TaoTieuDeDiaListView(lvwDia);
            //txtMaKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtMaKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtMaDia.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtMaDia.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //objListDia = objDia.GetDia();
            //objListKH = objKH.GetKhachHang();
            //foreach (KhachHang kh in objListKH)
            //{
            //    txtMaKH.AutoCompleteCustomSource.Add(kh.MaKH);
            //}
            //foreach (DVD_CD kh in objListDia)
            //{
            //    txtMaDia.AutoCompleteCustomSource.Add(kh.MaDia);
            //}
            
            
            //frmThueDia_Load(sender, e);

            
        }
        private void reset()
        {
            txtMaPT.Clear();
            txtTenKH.Clear();
            txtMaKH.Clear();
            txtMaDia.Clear();
            txtGia.Clear();
            txtTT.Clear();
            lvwDia.Clear();
            lvwKhachHang.Clear();
            txtTenDia.Clear();
            txtMaPT.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != null && txtMaPT.Text != null)
            {
                try
                {
                    if (txtMaPT.Text.Equals(""))
                    {
                        MessageBox.Show("Mã Phiếu Thuê Ko Được Trống");
                        txtMaPT.Focus();
                    }
                    else
                    {
                        vohh(true);
                        txtMaPT.Enabled = false;
                        txtMaKH.Enabled = false;
                        txtGia.Enabled = false;
                        txtTenDia.Enabled = false;
                        textBox2.Enabled = false;
                        dt = new QuanlidiaDataContext();
                        TTThueDia newpt = new TTThueDia();
                        newpt.MaPhieuThue = txtMaPT.Text;
                        newpt.NgayThue = Convert.ToDateTime(dtpNgaythue.Text);
                        newpt.MaKH = txtMaKH.Text;
                        dt.TTThueDias.InsertOnSubmit(newpt);
                        dt.SubmitChanges();
                        MessageBox.Show("Ok");
                        btnChonDia.Enabled = false;
                        txtMaDia.Focus();
                        button3.Enabled = false;
                    }     
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã Phiếu Thuê Trùng");
                    txtMaPT.Clear();
                    txtMaPT.Enabled = true;
                    txtMaPT.Focus();
                    txtMaDia.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Mã Khách lỗi");
                txtMaKH.Clear();
                txtMaKH.Focus();
            }        
        }

        private void btnCheckFees_Click(object sender, EventArgs e)
        {
            float tti = 0;
            dt = new QuanlidiaDataContext();
           
            if (txtMaKH.Text != "")
            {
                try
                {
                    if(txtTenKH.Text.Equals(""))
                    { MessageBox.Show("Khách hàng không tồn tại"); }
                    else
                    {
                        var m = (from t in dt.KhachHangs
                                 join y in dt.TTThueDias on t.MaKH equals y.MaKH
                                 join u in dt.ChiTietThueTras on y.MaPhieuThue equals u.MaPhieuThue
                                 where t.MaKH == txtMaKH.Text && u.PhiTreHan != null
                                 select new
                                 {
                                     y.MaKH,
                                     u.MaDia,
                                     u.MaPhieuThue,
                                     u.PhiTreHan
                                 });
                        // dataGridView1.DataSource = m; //kiểm tra bảng m tạo ra dưới datagridview
                        foreach (var g in m)
                        {
                            tti += float.Parse(g.PhiTreHan.ToString());
                            //dataGridView1.DataSource = dt.ChiTietThueTras;  //lấy phí trễ hạn theo diaID xuất lên datagridview              
                        }
                        if (tti != 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("Phí Trễ Hạn: " + tti.ToString(), "Thanh Toán phí trễ hạn", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                var mi = (from t in dt.KhachHangs
                                          join y in dt.TTThueDias on t.MaKH equals y.MaKH
                                          join u in dt.ChiTietThueTras on y.MaPhieuThue equals u.MaPhieuThue
                                          where t.MaKH == txtMaKH.Text && u.PhiTreHan != null
                                          select new
                                          {
                                              y.MaKH,
                                              u.MaDia,
                                              u.MaPhieuThue,
                                              u.PhiTreHan
                                          });

                                foreach (var g in mi)
                                {
                                    var dis = dt.ChiTietThueTras.Where(nv => nv.MaDia == g.MaDia);
                                    foreach (var y in dis)
                                    {
                                        y.PhiTreHan = null;
                                        dt.SubmitChanges();
                                    }
                                }
                                MessageBox.Show("Thanh toán thành công");
                            }
                            else if (dialogResult == DialogResult.No)
                            {

                                MessageBox.Show("Lần sau nhớ mang tiền!!!");
                            }
                        }
                        else
                            MessageBox.Show("Không có phí trễ hạn");
                    }
                }
                catch { }
            }
            //else { MessageBox.Show()}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var dis = dt.DVD_CDs.Where(nv => nv.MaDia == txtMaDia.Text).FirstOrDefault();
            //if (dis.Status == "lease")
            //{
            //    MessageBox.Show("Đĩa Không Còn Cho Thuê");
            //}
            if (textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Đĩa Không Tồn Tại");
                if (lvwDia.Items.Count > 0)
                {
                    btnThue.Enabled = true;
                }
                txtMaDia.Focus();
                btnChonDia.Enabled = false;
                }
                else
                {
                    var t = (from y in dt.TieuDes
                             join q in dt.DVD_CDs on y.MaTieuDe equals q.MaTieuDe
                             where (q.MaDia == txtMaDia.Text)
                             select new { q.MaDia, y.TenTieuDe }).FirstOrDefault();
                    txtTenDia.Text = t.TenTieuDe;
                btnChonDia.Enabled = true;
                }                                
        }
    }
}
