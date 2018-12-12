using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLy
{
    public class clcTTThueTra:KetNoiCSDL
    {
        public QuanlidiaDataContext dt;     
        public clcTTThueTra()
        {
            dt = getDatacontex();
        }
        public IEnumerable<TTThueDia> GetTTThueTra()
        {
            var p = from n in dt.TTThueDias
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
