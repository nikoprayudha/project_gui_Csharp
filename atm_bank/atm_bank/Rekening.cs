namespace atm_bank
{
    internal class Rekening
    {
        private double saldo;

        public Rekening(double v)
        {
            this.saldo = v;
        }

        public double mSaldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void tarik(double jumlah)
        {
            saldo = mSaldo - jumlah;
           
        }

        public void setor(double jumlah)
        {
            saldo = mSaldo + jumlah;
        }

    }
}