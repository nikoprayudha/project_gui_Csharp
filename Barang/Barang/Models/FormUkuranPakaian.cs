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
    public partial class FormUkuranPakaian : Form
    {
        private List<UkuranPakaian> _daftarUkuranPk;
        public List<UkuranPakaian> DaftarUkuranPk
        {
            get { return _daftarUkuranPk; }
            set { _daftarUkuranPk = value; }
        }

        public FormUkuranPakaian()
        {
            InitializeComponent();
        }

        public FormUkuranPakaian(List<UkuranPakaian> daftarUkuranPk)
        {
            InitializeComponent();
            DaftarUkuranPk = daftarUkuranPk;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Ukuran Pakaian";
            loadUkuranPakaian();
        }

        public void loadUkuranPakaian()
        {
            foreach (var ukuranPk in DaftarUkuranPk)
            {
                dataGridView1.Rows.Add(ukuranPk.UkPakaian);
            }
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].Cells[0].Value != null &&
                      dataGridView1.Rows[row].Cells[0].Value.Equals(textBox1.Text))
                {
                    MessageBox.Show("Maaf ! Duplicate Data");
                    return;
                }
            }/*end for*/

            if (textBox1.Text == "")
                {
                MessageBox.Show("------MOHON MENGISIKAN DATA-------");
            }
            else {
                UkuranPakaian itemUkuranPk = new UkuranPakaian();
                itemUkuranPk.UkPakaian = textBox1.Text;
                DaftarUkuranPk.Add(itemUkuranPk);
                dataGridView1.Rows.Add(textBox1.Text);
            } /*end if else*/
          
        }
    }
}
