using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLy
{
    public class clcDia:KetNoiCSDL
    {
        public QuanlidiaDataContext dt;
        public clcDia()
        {
            dt = getDatacontex();
        }
        public List<DVD_CD> GetMaDiaListTimKiem(string IDDia)
        {
            var mt = from a in dt.DVD_CDs
                     where a.MaDia == IDDia
                     select a;
            return mt.ToList<DVD_CD>();
        }
        public IEnumerable<DVD_CD> GetDia()
        {
            var p = from n in dt.DVD_CDs
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
