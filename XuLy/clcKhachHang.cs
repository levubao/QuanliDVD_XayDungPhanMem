using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLy
{
    public class clcKhachHang:KetNoiCSDL
    {
        public QuanlidiaDataContext dt;
        
        public clcKhachHang()
        {
            dt = getDatacontex();
            
        }
        public List<KhachHang> GetMaKhachHangListTimKiem(string IDMa)
        {
            var mt = from a in dt.KhachHangs
                     where a.MaKH == IDMa
                     select a;
            return mt.ToList<KhachHang>();
        }
        public IEnumerable<KhachHang> GetKhachHang()
        {
            var p = from n in dt.KhachHangs
                    select n;
            return p;
        }
        public QuanlidiaDataContext GetDataConText()
        {
            return dt;
        }
        public void CapNhat()
        {
            dt.SubmitChanges();
        }

    }
}
