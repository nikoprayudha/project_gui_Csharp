using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMhs.Models
{
    public class Mahasiswa
    {
        private String nim;
        private String nama;
        private Agama agama;

        public string Nim
        {
            get { return nim;  }
            set { nim = value; }
        }

        public String  Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public Agama Agama
        {
            get { return agama; }
            set { agama = value; }
        }
    }
}
