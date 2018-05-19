using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barang
{
    public class Sepatu
    {

        private String merk;
        private UkuranSepatu _ukuranSp;
        private Warna _warnaSp;

        public String Merk
        {
            get { return merk; }
            set { merk = value; }
        }

        public UkuranSepatu UkuranSp
        {
            get { return _ukuranSp; }
            set { _ukuranSp = value; }
        }

        public Warna WarnaSp
        {
            get { return _warnaSp; }
            set { _warnaSp = value; }
        }
    }
}
