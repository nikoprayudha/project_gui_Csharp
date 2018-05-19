using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Jobsheet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lPersegi_TextChanged(object sender, EventArgs e)
        {

        }

        private void pHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hitungP_Click(object sender, EventArgs e)
        {
            Persegi ps = new Persegi();

            ps.panjang = int.Parse(this.pPersegi.Text);
            ps.lebar = int.Parse(this.lPersegi.Text);

            this.pHasilLuas.Text = Convert.ToString(ps.hitungLuas());
            this.pHasilKeliling.Text = Convert.ToString(ps.hitungKeliling());
        }

        private void hitungS_Click(object sender, EventArgs e)
        {
            Segitiga sg = new Segitiga();

            sg.alas = int.Parse(this.aSegitiga.Text);
            sg.tinggi = int.Parse(this.tSegitiga.Text);

            this.sHasilLuas.Text = Convert.ToString(sg.hitungLuas());
            this.sHasilKeliling.Text = Convert.ToString(sg.hitungKeliling());
        }

        private void hitungJ_Click(object sender, EventArgs e)
        {
            JajarGenjang jj = new JajarGenjang();

            jj.alas = int.Parse(this.aJGenjang.Text);
            jj.tinggi = int.Parse(this.tJGenjang.Text);
            jj.simir = int.Parse(this.sJGanjang.Text);

            this.jHasilLuas.Text = Convert.ToString(jj.hitungLuas());
            this.jHasilKeliling.Text = Convert.ToString(jj.hitungKeliling());
        }
    
    }
}
