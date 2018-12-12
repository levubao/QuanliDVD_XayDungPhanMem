using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLy
{
    public class KetNoiCSDL
    {
        private QuanlidiaDataContext dt;
        public QuanlidiaDataContext getDatacontex()
        {
            string str = @"Data Source=DESKTOP-POVMTPD\SERVER;Initial Catalog=QLDia;Integrated Security=True";
            dt = new QuanlidiaDataContext(str);
            dt.Connection.Open();
            return dt;
        }
    }
}
