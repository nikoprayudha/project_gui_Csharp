using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_bank
{
    class Nasabah
    {
        private String firstname;
        private String lastname;
        private Rekening rekening;

        public Nasabah(String v1, String v2) {
            this.firstname = v1;
            this.lastname = v2;
        }

        public Rekening mRekening {
            get { return rekening; }
            set { rekening = value; }
        }

     
        public String mFirstname {
            get { return firstname; }
            set { firstname = value; }
        }

        public String mLastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

    }

}
