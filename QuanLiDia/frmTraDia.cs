using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XuLy;

namespace QuanLiDia
{
    public partial class frmTraDia : Form
    {
        public QuanlidiaDataContext dt;
        public frmTraDia()
        {
            InitializeComponent();
        }

        private void txtDiskID_TextChanged(object sender, EventArgs e)
        {
            txtTime.Text = "";
            try
            {
               SearchDisk(txtDiskID.Text);
                if (txtTime.Text.Equals(""))
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                }         
                else
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                }                          
            }
            catch
            {

            }
        }
        private void SearchDisk(string id)
        {
            dt = new QuanlidiaDataContext();
            var v = (from r in dt.ChiTietThueTras
                     join a in dt.TTThueDias on r.MaPhieuThue equals a.MaPhieuThue
                     where r.MaDia ==id
                     select new
                     {
                         a.NgayThue,
                         r.NgayTra
                     });
            foreach (var x in v)
            {
                if (x.NgayThue != null)
                
                    txtTime.Text = Convert.ToDateTime( x.NgayThue).ToString();
                
                else
                    txtTime.Text = "Không tìm thấy thông tin";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            CheckStatusDisk(txtDiskID.Text);
            txtDiskID.Clear();
            txtTime.Text = "";
        }
        private void TinhNgay1(string ma)
        {
            dt = new QuanlidiaDataContext();
            var v = (from r in dt.ChiTietThueTras
                     join a in dt.TTThueDias on r.MaPhieuThue equals a.MaPhieuThue
                     where r.MaPhieuThue == ma
                     select new
                     {
                         a.MaPhieuThue,
                         r.MaDia,
                         a.NgayThue,
                         r.NgayTra
                     });
            foreach (var x in v)
            {
                if (x.NgayThue != null)
                {
                    txtTime.Text = x.NgayThue.ToString();
                    textBox1.Text = x.MaPhieuThue.ToString();
                }
            }
            DateTime futurDate = DateTime.Parse(txtTime.Text);
            DateTime TodayDate = dateTimePicker1.Value;
            var numberOfDays = (TodayDate - futurDate).Days;
            textBox2.Text = numberOfDays.ToString();
        }
        private void TinhNgay(string ma)
        {
            dt = new QuanlidiaDataContext();
            var v = (from r in dt.ChiTietThueTras
                     join a in dt.TTThueDias on r.MaPhieuThue equals a.MaPhieuThue
                     where r.MaDia == ma
                     select new
                     {
                         a.MaPhieuThue,
                         r.MaDia,
                         a.NgayThue,
                         r.NgayTra
                     });
            foreach (var x in v)
            {
                if (x.NgayThue != null)
                {
                    txtTime.Text = x.NgayThue.ToString();
                    textBox1.Text = x.MaPhieuThue.ToString();
                }
            }          
            DateTime futurDate = DateTime.Parse(txtTime.Text);
            DateTime TodayDate = dateTimePicker1.Value;
            var numberOfDays = (TodayDate - futurDate).Days;
            textBox2.Text = numberOfDays.ToString();
        }
        public void CheckStatusDisk(string id)
        {
            dt = new QuanlidiaDataContext();     
            try
            {
                var tra = dt.ChiTietThueTras.Where(b => b.MaDia == id && b.NgayTra == null).FirstOrDefault();
                if(tra==null)
                {
                    MessageBox.Show("Đĩa đã được trả");
                }
                else
                {
                    tra.NgayTra = dateTimePicker1.Value;
                    var dis = dt.DVD_CDs.Where(nv => nv.MaDia == id).FirstOrDefault();
                    dis.Status = "on the shelf";
                    dt.SubmitChanges();
                    TinhNgay(txtDiskID.Text);
                    CalLateFee();
                    MessageBox.Show("Success");
                }
            }
            catch
            {
                MessageBox.Show("Đĩa đã được trả");
            }
        }
        public void KiemTraMoreDia(string id)
        {
            dt = new QuanlidiaDataContext();
            try
            {
                var tra = dt.ChiTietThueTras.Where(b => b.MaPhieuThue == id && b.NgayTra == null);
            foreach (var x in tra)
            {
                if (x == null)
                {
                    MessageBox.Show("Đĩa đã được trả");
                }
                else
                {
                    var trad = dt.ChiTietThueTras.Where(b => b.MaPhieuThue == id && b.NgayTra == null);
                    foreach (var v in trad)
                    {
                        v.NgayTra = dateTimePicker1.Value;
                        var g = dt.ChiTietThueTras.Where(b => b.MaPhieuThue == id);
                            foreach (var tu in g)
                            {
                                var i = dt.DVD_CDs.Where(l => l.MaDia == tu.MaDia);
                                foreach (var h in i)
                                {
                                    h.Status = "on the shelf";
                                    dt.SubmitChanges();
                                }
                            }
                     }
                    dt.SubmitChanges();
                    }
                }
                TinhNgay1(textBox1.Text);
                CalLateFee1();
            }
            catch
            {
                MessageBox.Show("Đĩa đã được trả");
            }
        }


        public void CalLateFee()
        {
            if (Int32.Parse(textBox2.Text) > 7)
            {
                dt = new QuanlidiaDataContext();
                var u = dt.ChiTietThueTras.Where(b => b.MaDia == txtDiskID.Text && b.MaPhieuThue==textBox1.Text).FirstOrDefault();
                u.PhiTreHan = (float.Parse("1000")*(Int32.Parse((textBox2.Text))-7));         
                    DialogResult dialogResult = MessageBox.Show("Trễ " + (Int32.Parse(textBox2.Text)-7) + " ngày" + " \rPhí: " + u.PhiTreHan, "Thanh Toán phí trễ hạn", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    { 
                        MessageBox.Show("Thanh toán thành công");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    u.PhiTreHan = (float.Parse("1000") * (float.Parse((textBox2.Text))-7));
                    dt.SubmitChanges();
                    }
                       
               
            }
        }
        public void CalLateFee1()
        {
            if (Int32.Parse(textBox2.Text) > 7)
            {
                float t = 0;
                int dem = 0;
                dt = new QuanlidiaDataContext();
                foreach(DataGridViewRow item in dataGridView1.Rows) { dem++; }
                t = ((dem-1) * ((float.Parse("1000"))* (Int32.Parse(textBox2.Text) - 7)));
                DialogResult dialogResult = MessageBox.Show("Trễ:" + (Int32.Parse(textBox2.Text) - 7) + "Ngày" +  "\rTổng Phí Trễ Hạn là:" + t.ToString(), "Thanh Toán phí trễ hạn", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var y = dt.ChiTietThueTras.Where(b => b.MaPhieuThue == textBox1.Text && b.NgayTra==null);
                    foreach (var tu in y)
                    {
                        tu.PhiTreHan = null;
                    }              
                }
                else if (dialogResult == DialogResult.No)
                {
                    var y = dt.ChiTietThueTras.Where(b => b.MaPhieuThue == textBox1.Text && b.NgayTra==dateTimePicker1.Value);
                    foreach (var k in y)
                    {
                        k.PhiTreHan = ((float.Parse("1000")) * (Int32.Parse(textBox2.Text) - 7));
                        dt.SubmitChanges();
                        //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        //    {
                        //        if (k.MaDia == dataGridView1.Rows[i].Cells[1].Value.ToString())
                        //        {
                        //            k.PhiTreHan = ((float.Parse("1000")) * (Int32.Parse(textBox2.Text) - 7));
                        //            dt.SubmitChanges();
                        //        }
                        //    }
                    }
                }
            }      
        }
        private void frmTraDia_Load(object sender, EventArgs e)
        {
            txtTime.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            dt = new QuanlidiaDataContext();
            var tra = dt.ChiTietThueTras.Where(b => b.MaDia == txtDiskID.Text && b.NgayTra == null).FirstOrDefault();
            if (tra == null)
            {
                MessageBox.Show("Đĩa đã được trả");
                txtDiskID.Clear();
                button1.Enabled = false;
                button2.Enabled = false;

            }
            else
            {
                var ue = dt.ChiTietThueTras.Where(b => b.MaDia == txtDiskID.Text);
                foreach (var tu in ue)
                {
                    var u = dt.ChiTietThueTras.Where(b => b.MaDia == txtDiskID.Text && b.NgayTra == null);
                    foreach (var t in u)
                    {
                        textBox1.Text = t.MaPhieuThue;
                    }

                    if (textBox1.Text.Equals(""))
                    {
                        MessageBox.Show("Đĩa đã được trả");
                        button1.Enabled = false;
                        txtDiskID.Clear();
                    }
                    //else
                    //{

                    //}              
                }
                TimAllDia(textBox1.Text);
                KiemTraMoreDia(textBox1.Text);
                MessageBox.Show("Success");
            }           
        }
        private void TimAllDia(string id)
        {
            dt = new QuanlidiaDataContext();
            var g = dt.ChiTietThueTras.Where(b => b.MaPhieuThue == id && b.NgayTra==null);
            dataGridView1.DataSource = g;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            CalLateFee1();
            MessageBox.Show("Success");
        }
    }
}
