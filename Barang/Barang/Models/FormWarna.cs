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
    public partial class FormWarna : Form
    {

        private List<Warna> _daftarWarna;
        public List<Warna> DaftarWarna
        {
            get { return _daftarWarna; }
            set { _daftarWarna = value; }
        }

        public FormWarna()
        {
            InitializeComponent();
        }

        public FormWarna(List<Warna> daftarWarna)
            {
                InitializeComponent();
                DaftarWarna = daftarWarna;
                dataGridView1.ColumnCount = 1;
                dataGridView1.Columns[0].Name = "Jenis";
                loadWarna();
             }

        public void loadWarna() {
            foreach (var warna in DaftarWarna)
            {
                dataGridView1.Rows.Add(warna.Jenis);
            }
        }

        private void FormWarna_Load(object sender, EventArgs e)
        {
            
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
                Warna itemWarna = new Warna();
                itemWarna.Jenis = textBox1.Text;
                DaftarWarna.Add(itemWarna);
                dataGridView1.Rows.Add(textBox1.Text);
            } /*end if */ 
        }
    }
}
