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
    public partial class FormAgama : Form
    {

        private List<Agama> _daftarAgama;
        public List<Agama> DaftarAgama
        {
            get { return _daftarAgama; }
            set { _daftarAgama = value; }
        } 

        public FormAgama()
        {
            InitializeComponent();
        }

        public FormAgama(List<Agama> daftarAgama)
        {
            InitializeComponent();
            DaftarAgama = daftarAgama;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Keterangan";
            loadAgama();
        } 

        private void Kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadAgama()
        {
            foreach (var agama in DaftarAgama)
            {
                dataGridView1.Rows.Add(agama.Keterangan);
            }
        }

        private void FormAgama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    if (dataGridView1.Rows[row].Cells[col].Value != null &&
                      dataGridView1.Rows[row].Cells[col].Value.Equals(textBox1.Text))
                    {
                        MessageBox.Show("Maaf ! Duplicate Data"); 
                        return;
                    }
                }
            }

          if (textBox1.Text == "")
            {
                MessageBox.Show("------MOHON MENGISIKAN DATA-------");
            }
            else {
                Agama itemAgama = new Agama();
                itemAgama.Keterangan = textBox1.Text;
                DaftarAgama.Add(itemAgama);
                dataGridView1.Rows.Add(textBox1.Text);
            }
        }
    }
}
