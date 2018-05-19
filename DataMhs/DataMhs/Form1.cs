using DataMhs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMhs
{
    public partial class Form1 : Form
    {
        public List<Agama> daftarAgama = new List<Agama>();
        public List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin akan menutup ?", "Tutup Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void agamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgama frmAgama = new FormAgama(daftarAgama);
            frmAgama.ShowDialog();
            this.daftarAgama = frmAgama.DaftarAgama;
        }

        private void dataKemahasiswaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FormMahasiswa frmMhs = new FormMahasiswa(daftarAgama , daftarMahasiswa);
            frmMhs.ShowDialog();
           
        }
    }
}
