using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Jobsheet2
{
    class JajarGenjang
    {

        public int alas, tinggi, simir;
      
        public int hitungLuas()
        {
            int luas = alas * tinggi;
            return luas;
        }
        public int hitungKeliling()
        {
            int keliling = 2 * alas + 2 * simir;
            return keliling;
        }
    }
}
