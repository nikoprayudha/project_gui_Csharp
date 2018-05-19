using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barang.Models
{
    public partial class FormSepatu : Form
    {
        private List<Sepatu> _daftarSepatu;
        public List<Sepatu> DaftarSepatu
        {
            get { return _daftarSepatu; }
            set { _daftarSepatu = value; }
        }

        private List<Warna> _daftarWarna;
        public List<Warna> DaftarWarna
        {
            get { return _daftarWarna; }
            set { _daftarWarna = value; }
        }

        private List<UkuranSepatu> _daftarUkuranSp;
        public List<UkuranSepatu> DaftarUkuranSp
        {
            get { return _daftarUkuranSp; }
            set { _daftarUkuranSp = value; }
        }

        public FormSepatu()
        {
            InitializeComponent();
        }

        private class Item
        {

            public string Name;
            public int Value;
            public Item(int value, string name)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        public FormSepatu(List<Sepatu> daftarSepatu, List<UkuranSepatu> daftarUkuranSp, List<Warna> daftarWarna)
        {
            InitializeComponent();
            DaftarSepatu = daftarSepatu;
            DaftarUkuranSp = daftarUkuranSp;
            DaftarWarna = daftarWarna;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Merk";
            dataGridView1.Columns[1].Name = "Warna Sepatu";
            dataGridView1.Columns[2].Name = "Ukuran Sepatu";
            loadPakaian();
            for (int i = 0; i < daftarWarna.Count(); i++)
            {
                comboBox1.Items.Add(new Item(i, daftarWarna.ElementAt(i).Jenis));
            }
            for (int i = 0; i < daftarUkuranSp.Count(); i++)
            {
                comboBox2.Items.Add(new Item(i, daftarUkuranSp.ElementAt(i).UkuranSp));
            }

        }

        public void loadPakaian()
        {

            foreach (var pakaian in DaftarSepatu)
            {
                dataGridView1.Rows.Add(pakaian.Merk, pakaian.WarnaSp.Jenis, pakaian.UkuranSp.UkuranSp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].Cells[0].Value != null &&
                      dataGridView1.Rows[row].Cells[0].Value.Equals(textBox1.Text) &&
                      dataGridView1.Rows[row].Cells[1].Value.Equals(comboBox1.Text) &&
                      dataGridView1.Rows[row].Cells[2].Value.Equals(comboBox2.Text))
                {
                    MessageBox.Show("Maaf ! Duplicate Data");
                    return;
                }
            }/*end for*/

            if (textBox1.Text == "")
                 {
                MessageBox.Show("------MOHON MENGISIKAN DATA-------");
                 }
            else
                 {
                Sepatu itemSepatu = new Sepatu();
                itemSepatu.Merk = textBox1.Text;
                itemSepatu.WarnaSp = DaftarWarna.ElementAt(comboBox1.SelectedIndex);
                itemSepatu.UkuranSp = DaftarUkuranSp.ElementAt(comboBox2.SelectedIndex);
                DaftarSepatu.Add(itemSepatu);
                dataGridView1.Rows.Add(itemSepatu.Merk, itemSepatu.WarnaSp.Jenis, itemSepatu.UkuranSp.UkuranSp);
                }
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
