using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataMhs.Models;

namespace DataMhs
{
    public partial class FormMahasiswa : Form
    {
        private List<Agama> _daftarAgama;
        public List<Agama> DaftarAgama
        {
            get { return _daftarAgama; }
            set { _daftarAgama = value; }
        }

        /*lanjutan di siniii !!!!!!!!!!!!!!!!!!!!!*/
        private List<Mahasiswa> _daftarMahasiswa;
        public List<Mahasiswa> DaftarMahasiswa
        {
            get { return _daftarMahasiswa; }
            set { _daftarMahasiswa = value; }
        }

        private class Item {

            public string Name;
            public int value;
            public Item(int value, string name) 
            {
                Name = name; value = value;
            }
            public override string ToString()
            {
                return Name;
            }


        }

        public FormMahasiswa(List<Agama> daftarAgama , List<Mahasiswa> daftarMahasiswa)
        {
            InitializeComponent();
            DaftarAgama = daftarAgama;
            DaftarMahasiswa = daftarMahasiswa;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nama";
            dataGridView1.Columns[1].Name = "Nim";
            dataGridView1.Columns[2].Name = "Agama";
            for(int i= 0; i < daftarAgama.Count(); i++) {

                comboBox1.Items.Add(new Item(i, daftarAgama.ElementAt(i).Keterangan));
            }

        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            foreach (var mahasiswa in DaftarMahasiswa)
            {
                dataGridView1.Rows.Add(mahasiswa.Nama,mahasiswa.Nim,mahasiswa.Agama.Keterangan);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                   if (dataGridView1.Rows[row].Cells[col].Value != null &&
                      dataGridView1.Rows[row].Cells[col].Value.Equals(textBox2.Text))
                    {
                        MessageBox.Show("Maaf Duplicate Data == > Nim / Agama tidak Boleh Sama <== ");
                        return;
                    }
                }
            }  /*tutup for */

            if (textBox1.Text == "")
            {
                MessageBox.Show("------MOHON MENGISIKAN DATA-------");
            }
            else {
                Mahasiswa itemMahasiswa = new Mahasiswa();
                itemMahasiswa.Nama = textBox1.Text;
                itemMahasiswa.Nim = textBox2.Text;
                itemMahasiswa.Agama = DaftarAgama.ElementAt(comboBox1.SelectedIndex);
                DaftarMahasiswa.Add(itemMahasiswa);
                dataGridView1.Rows.Add(itemMahasiswa.Nama, itemMahasiswa.Nim, itemMahasiswa.Agama.Keterangan);
                 } /*tutup if kondisi kosong*/
        }
    }
}
