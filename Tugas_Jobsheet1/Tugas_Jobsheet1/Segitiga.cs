using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Jobsheet1
{
    class Segitiga
    {
        public int alas, tinggi;

        public double hitungLuas() {
            double luas;
            luas = 0.5 * alas * tinggi;
            return luas;
        }
        public int hitungKeliling() {
            int keliling;
            keliling = alas + alas + alas;
            return keliling;
        }

    }
}
