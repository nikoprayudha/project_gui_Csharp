using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendaftaranMhs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Kolom username*/
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {

                MessageBox.Show("Kolom Username Tidak Boleh Kosong");
            }
        }

        /*Kolom Password*/
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == String.Empty)
            {

                MessageBox.Show("Kolom Password Tidak Boleh Kosong");
            }

        }

        /*Kolom Konfrimasi Password*/
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == String.Empty)
            {

                MessageBox.Show("Kolom Konfrimasi Password Tidak Boleh Kosong");
            }
            else if (textBox3.Text != textBox2.Text) {

                MessageBox.Show("Konfirmasi Password Yang Anda Inputkan Tidak Sama Dengan Password Anda");
            }
        }

        /*Kolom Nama Sesuai Identitas*/
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Kolom Ini Hanya Boleh Diisi Dengan Huruf dan Spasi");
                if (textBox4.Text.Length >=1 ) {
                    textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                }    
            } 

        }

        /*Kolom Nama Sesuai Ijazah*/
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Kolom Ini Hanya Boleh Diisi Dengan Huruf dan Spasi");
                if (textBox5.Text.Length >= 1)
                {
                    textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
                }
            }

        }

        /*Kolom Nomor Identitas*/
        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Text == String.Empty)
            {

                MessageBox.Show("Kolom Nomer Identitas Tidak Boleh Kosong");
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Kolom Ini Hanya Boleh Diisi Dengan Angka");
                if (textBox6.Text.Length >= 1)
                {
                    textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
                }
            }
        }

        /*Kolom Alamat*/
        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (textBox7.Text == String.Empty)
            {

                MessageBox.Show("Kolom Alamat tetap Tidak Boleh Kosong");
            }
        }

        /*Kolom Kelurahan/Desa*/
        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (textBox8.Text == String.Empty)
            {

                MessageBox.Show("Kolom Kelurahan / Desa Tidak Boleh Kosong");
            }

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Kolom Ini Hanya Boleh Diisi Dengan Huruf dan Spasi");
                if (textBox8.Text.Length >= 1)
                {
                    textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
                }
            }
        }

        /*Kolom Kecamatan*/
        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            if (textBox9.Text == String.Empty)
            {

                MessageBox.Show("Kolom Kecamatan Tidak Boleh Kosong");
            }

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Kolom Ini Hanya Boleh Diisi Dengan Huruf dan Spasi");
                if (textBox9.Text.Length >= 1)
                {
                    textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
                }
            }
        }

        /*Kolom Kota/kabupaten*/
        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (textBox10.Text == String.Empty)
            {

                MessageBox.Show("Kolom Kota/Kabupaten Tidak Boleh Kosong");
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Kolom Ini Hanya Boleh Diisi Dengan Huruf dan Spasi");
                if (textBox10.Text.Length >= 1)
                {
                    textBox10.Text = textBox10.Text.Remove(textBox10.Text.Length - 1);
                }
            }
        }

        /*Kolom Email*/
        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            if (textBox11.Text == String.Empty)
            {

                MessageBox.Show("Kolom Email Tidak Boleh Kosong");
            }
              else
              {
                try
                {
                    var email_addr = new System.Net.Mail.MailAddress(textBox11.Text);
                }
                catch
                {
                    MessageBox.Show("Email Yang Anda Masukkan Tidak Valid");
                }       
            } 
        }

        private void textBox12_Validating(object sender, CancelEventArgs e)
        {
            if (textBox12.Text == String.Empty)
            {

                MessageBox.Show("Kolom Email Tidak Boleh Kosong");
            }
            else
            {
                try
                {
                    var email_addr = new System.Net.Mail.MailAddress(textBox12.Text);
                }
                catch
                {
                    MessageBox.Show("Email Yang Anda Masukkan Tidak Valid");
                }
            }

        }
    }
}
