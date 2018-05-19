using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_bank
{
    public partial class Form1 : Form
    {
        private Nasabah currentNasabah;
        public Form1()
        {
            InitializeComponent();
            Simulasilogin();
        }
        public void Simulasilogin()
        {
            Rekening bri = new Rekening(10000000);
            Nasabah Niko = new Nasabah("Niko","Prayudha");
            Niko.mRekening = bri;
            currentNasabah = Niko;
        }


        /*Inputan Angka*/
        private void btn1_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "0";

        }

        /* Cek Saldo*/
        private void btnCek_Click(object sender, EventArgs e)
        {
            output.AppendText("\nSelamat Datang :" +currentNasabah.mFirstname +  "\n");
            output.AppendText("\nSaldo Anda :" + currentNasabah.mRekening.mSaldo.ToString("#,##0") + "\n");
        }

        /*Setor Uang*/
        private void btnSetor_Click(object sender, EventArgs e)
        {
            if (input.Text == "" )
            {
                MessageBox.Show("------MOHON MENGISIKAN UANG-------");
                output.AppendText("\n MAAF!, ANDA TIDAK BISA MENYETOR UANG \n");
                output.AppendText("\n ------MOHON MENGISIKAN UANG-------\n");
            }
            else
            {
                currentNasabah.mRekening.setor(double.Parse(input.Text));
                output.AppendText("\nAnda Menyetor ke ATM : Rp." + double.Parse(input.Text).ToString("#,##0") + "\n");
                output.AppendText("\nSaldo Anda : Rp." + currentNasabah.mRekening.mSaldo.ToString("#,##0") + "\n");
                
            }
        }

        /*Tarik Uang*/
        private void btnTarik_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                MessageBox.Show("------MOHON MENGISIKAN UANG-------");
                output.AppendText("\nMAAF! ANDA TIDAK BISA MENARIK UANG KOSONG \n");
    
            }
            else if(double.Parse(input.Text) <= currentNasabah.mRekening.mSaldo)
             {
                currentNasabah.mRekening.tarik(double.Parse(input.Text));
                output.AppendText("\nAnda Tarik Uang ke ATM :" + double.Parse(input.Text).ToString("#,##0") + "\n");
                output.AppendText("\nSaldo Anda Sekarang:" + currentNasabah.mRekening.mSaldo.ToString("#,##0") + "\n");
                
            }
            else 
            {
                output.AppendText("\n ----------------------------------");
                output.AppendText("\n MAAAF !!! ANDA TIDAK BISA MENARIK UANG LEBIH DARI SALDO ");
            }
        }
        
        /*Rupiah */
        private void input_TextChanged(object sender, EventArgs e)
        {
            
            input.Text = string.Format("{0:#,##0}", double.Parse(input.Text));

        }
    }
}
