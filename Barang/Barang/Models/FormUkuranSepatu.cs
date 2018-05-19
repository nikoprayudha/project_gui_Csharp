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
    public partial class FormUkuranSepatu : Form
    {
        private List<UkuranSepatu> _daftarUkuranSp;
        public List<UkuranSepatu> DaftarUkuranSp
        {
            get { return _daftarUkuranSp; }
            set { _daftarUkuranSp = value; }
        }

        public FormUkuranSepatu()
        {
            InitializeComponent();
        }

        public FormUkuranSepatu(List<UkuranSepatu> daftarUkuranSp)
        {
            InitializeComponent();
            DaftarUkuranSp = daftarUkuranSp;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Ukuran Sepatu";
            loadUkuranSepatu();
        }

        public void loadUkuranSepatu()
        {
            foreach (var ukuranSp in DaftarUkuranSp)
            {
                dataGridView1.Rows.Add(ukuranSp.UkuranSp);
            }
        }
        private void button2_Click(object sender, EventArgs e)
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
            else
            {
                UkuranSepatu itemUkuranSp = new UkuranSepatu();
                itemUkuranSp.UkuranSp = textBox1.Text;
                DaftarUkuranSp.Add(itemUkuranSp);
                dataGridView1.Rows.Add(textBox1.Text);
            }/*end if else*/
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
