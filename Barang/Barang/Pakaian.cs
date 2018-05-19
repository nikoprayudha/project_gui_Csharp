using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barang
{
    public class Pakaian
    {
        private String merk;
        private UkuranPakaian _ukuranPk;
        private Warna _warnaPk;
         
        public String Merk
        {
            get { return merk; }
            set { merk = value; }
        }

        public UkuranPakaian UkuranPk
        {
            get { return _ukuranPk; }
            set { _ukuranPk = value; }
        }

        public Warna WarnaPk
        {
            get { return _warnaPk; }
            set { _warnaPk = value; }
        }


    }
}
