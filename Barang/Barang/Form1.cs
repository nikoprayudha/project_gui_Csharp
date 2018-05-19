using Barang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barang
{
    public partial class Form1 : Form
    {
        public List<Warna> daftarWarna = new List<Warna>();
        public List<UkuranPakaian> daftarUkuranPk = new List<UkuranPakaian>();
        public List<UkuranSepatu> daftarUkuranSp = new List<UkuranSepatu>();
        public List<Pakaian> daftarPakaian = new List<Pakaian>();
        public List<Sepatu> daftarSepatu = new List<Sepatu>();



        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda ingin menutup ?", "Tutup Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void warnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWarna frmWarna = new FormWarna(daftarWarna);
            frmWarna.ShowDialog();
            /* this.daftarWarna = frmWarna.DaftarWarna; */
        }

        private void ukuranPakaianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUkuranPakaian frmUkuranPk = new FormUkuranPakaian (daftarUkuranPk);
            frmUkuranPk.ShowDialog();
                   }

        private void ukuranSepatuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUkuranSepatu frmUkuranSp = new FormUkuranSepatu(daftarUkuranSp);
            frmUkuranSp.ShowDialog();
            
        }

        private void pakaianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPakaian frmPakaian = new FormPakaian(daftarPakaian, daftarUkuranPk ,daftarWarna);
            frmPakaian.ShowDialog();
        }

        private void sepatuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSepatu frmSepatu = new FormSepatu(daftarSepatu, daftarUkuranSp, daftarWarna);
            frmSepatu.ShowDialog();
        }
    }
}
