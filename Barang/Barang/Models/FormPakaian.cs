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
    public partial class FormPakaian : Form
    {
        private List<Pakaian> _daftarPakaian;
        public List<Pakaian> DaftarPakaian
        {
            get { return _daftarPakaian; }
            set { _daftarPakaian = value; }
        }

        private List<Warna> _daftarWarna;
        public List<Warna> DaftarWarna
        {
            get { return _daftarWarna; }
            set { _daftarWarna = value; }
        }

        private List<UkuranPakaian> _daftarUkuranPk;
        public List<UkuranPakaian> DaftarUkuranPk
        {
            get { return _daftarUkuranPk; }
            set { _daftarUkuranPk = value; }
        }

        public FormPakaian()
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

        public FormPakaian(List<Pakaian> daftarPakaian, List<UkuranPakaian> daftarUkuranPk, List<Warna> daftarWarna)
        {
            InitializeComponent();
            DaftarWarna = daftarWarna;
            DaftarUkuranPk = daftarUkuranPk;
            DaftarPakaian = daftarPakaian;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Merk";
            dataGridView1.Columns[1].Name = "Warna Pakaian";
            dataGridView1.Columns[2].Name = "Ukuran Pakaian";
            loadPakaian();
            for (int i = 0; i < daftarWarna.Count(); i++)
            {
                comboBox1.Items.Add(new Item(i, daftarWarna.ElementAt(i).Jenis));
            }
            for (int i = 0; i <daftarUkuranPk.Count(); i++)
            {
                comboBox2.Items.Add(new Item(i, daftarUkuranPk.ElementAt(i).UkPakaian));
            }

        }

        public void loadPakaian()
        {

            foreach (var pakaian in DaftarPakaian)
            {
                dataGridView1.Rows.Add(pakaian.Merk, pakaian.WarnaPk.Jenis, pakaian.UkuranPk.UkPakaian);
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
                Pakaian itemPakaian = new Pakaian();
                itemPakaian.Merk = textBox1.Text;
                itemPakaian.WarnaPk = DaftarWarna.ElementAt(comboBox1.SelectedIndex);
                itemPakaian.UkuranPk = DaftarUkuranPk.ElementAt(comboBox2.SelectedIndex);
                DaftarPakaian.Add(itemPakaian);
                dataGridView1.Rows.Add(itemPakaian.Merk, itemPakaian.WarnaPk.Jenis, itemPakaian.UkuranPk.UkPakaian);
                }
          }

             private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

             private void FormPakaian_Load(object sender, EventArgs e)
            {

            }      
    }
}
