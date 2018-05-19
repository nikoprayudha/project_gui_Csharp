using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Jobsheet1
{
    class persegi
    {
        public int panjang, lebar;

        public int hitungLuas() {
            int luas;
            luas = panjang * lebar;
            return luas;
        }

        public int hitungKeliling() {
            int keliling;
            keliling = 2 * panjang + 2 * lebar;
           return  keliling;
        }
    }
}
