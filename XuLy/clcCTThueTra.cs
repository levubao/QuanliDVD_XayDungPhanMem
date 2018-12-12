using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLy
{
    public class clcCTThueTra:KetNoiCSDL
    {
        public QuanlidiaDataContext dt;
        
        public clcCTThueTra()
        {
            dt = getDatacontex();
        }
        
        public IEnumerable<ChiTietThueTra> GetCTThueTra()
        {
            var p = from n in dt.ChiTietThueTras
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
