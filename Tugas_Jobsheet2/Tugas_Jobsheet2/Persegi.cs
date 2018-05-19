using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Jobsheet2
{
    class Persegi
    {
        public  int panjang,lebar;
        
        public int hitungLuas() {
            int luas = panjang * lebar;
            return luas;
        }
        public int hitungKeliling()
        {
            int keliling = 2 * panjang + 2 * lebar;
            return keliling;
        }

    }
}
