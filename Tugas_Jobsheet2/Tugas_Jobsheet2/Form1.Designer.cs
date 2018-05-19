namespace Tugas_Jobsheet2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pPersegi = new System.Windows.Forms.TextBox();
            this.lPersegi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pHasilLuas = new System.Windows.Forms.TextBox();
            this.hitungP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pHasilKeliling = new System.Windows.Forms.TextBox();
            this.aSegitiga = new System.Windows.Forms.TextBox();
            this.tSegitiga = new System.Windows.Forms.TextBox();
            this.hitungS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sHasilLuas = new System.Windows.Forms.TextBox();
            this.sHasilKeliling = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.aJGenjang = new System.Windows.Forms.TextBox();
            this.tJGenjang = new System.Windows.Forms.TextBox();
            this.sJGanjang = new System.Windows.Forms.TextBox();
            this.jHasilKeliling = new System.Windows.Forms.TextBox();
            this.jHasilLuas = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.hitungJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSEGI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Panjang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lebar";
            // 
            // pPersegi
            // 
            this.pPersegi.Location = new System.Drawing.Point(94, 69);
            this.pPersegi.Name = "pPersegi";
            this.pPersegi.Size = new System.Drawing.Size(100, 20);
            this.pPersegi.TabIndex = 3;
            // 
            // lPersegi
            // 
            this.lPersegi.Location = new System.Drawing.Point(94, 103);
            this.lPersegi.Name = "lPersegi";
            this.lPersegi.Size = new System.Drawing.Size(100, 20);
            this.lPersegi.TabIndex = 4;
            this.lPersegi.TextChanged += new System.EventHandler(this.lPersegi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "HASIL LUAS :";
            // 
            // pHasilLuas
            // 
            this.pHasilLuas.Location = new System.Drawing.Point(123, 171);
            this.pHasilLuas.Name = "pHasilLuas";
            this.pHasilLuas.Size = new System.Drawing.Size(71, 20);
            this.pHasilLuas.TabIndex = 6;
            this.pHasilLuas.Text = "0";
            this.pHasilLuas.TextChanged += new System.EventHandler(this.pHasil_TextChanged);
            // 
            // hitungP
            // 
            this.hitungP.Location = new System.Drawing.Point(29, 138);
            this.hitungP.Name = "hitungP";
            this.hitungP.Size = new System.Drawing.Size(75, 23);
            this.hitungP.TabIndex = 7;
            this.hitungP.Text = "HITUNG";
            this.hitungP.UseVisualStyleBackColor = true;
            this.hitungP.Click += new System.EventHandler(this.hitungP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "SEGITIGA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tinggi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "HASIL KELILING :";
            // 
            // pHasilKeliling
            // 
            this.pHasilKeliling.Location = new System.Drawing.Point(123, 197);
            this.pHasilKeliling.Name = "pHasilKeliling";
            this.pHasilKeliling.Size = new System.Drawing.Size(71, 20);
            this.pHasilKeliling.TabIndex = 12;
            this.pHasilKeliling.Text = "0";
            // 
            // aSegitiga
            // 
            this.aSegitiga.Location = new System.Drawing.Point(385, 66);
            this.aSegitiga.Name = "aSegitiga";
            this.aSegitiga.Size = new System.Drawing.Size(100, 20);
            this.aSegitiga.TabIndex = 13;
            // 
            // tSegitiga
            // 
            this.tSegitiga.Location = new System.Drawing.Point(385, 100);
            this.tSegitiga.Name = "tSegitiga";
            this.tSegitiga.Size = new System.Drawing.Size(100, 20);
            this.tSegitiga.TabIndex = 14;
            // 
            // hitungS
            // 
            this.hitungS.Location = new System.Drawing.Point(327, 138);
            this.hitungS.Name = "hitungS";
            this.hitungS.Size = new System.Drawing.Size(75, 23);
            this.hitungS.TabIndex = 15;
            this.hitungS.Text = "HITUNG";
            this.hitungS.UseVisualStyleBackColor = true;
            this.hitungS.Click += new System.EventHandler(this.hitungS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "HASIL LUAS :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "HASIL KELILING :";
            // 
            // sHasilLuas
            // 
            this.sHasilLuas.Location = new System.Drawing.Point(425, 171);
            this.sHasilLuas.Name = "sHasilLuas";
            this.sHasilLuas.Size = new System.Drawing.Size(71, 20);
            this.sHasilLuas.TabIndex = 18;
            this.sHasilLuas.Text = "0";
            // 
            // sHasilKeliling
            // 
            this.sHasilKeliling.Location = new System.Drawing.Point(425, 197);
            this.sHasilKeliling.Name = "sHasilKeliling";
            this.sHasilKeliling.Size = new System.Drawing.Size(71, 20);
            this.sHasilKeliling.TabIndex = 19;
            this.sHasilKeliling.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(138, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "JAJAR GENJANG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tinggi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Alas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(141, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Sisi Miring";
            // 
            // aJGenjang
            // 
            this.aJGenjang.Location = new System.Drawing.Point(226, 286);
            this.aJGenjang.Name = "aJGenjang";
            this.aJGenjang.Size = new System.Drawing.Size(100, 20);
            this.aJGenjang.TabIndex = 24;
            // 
            // tJGenjang
            // 
            this.tJGenjang.Location = new System.Drawing.Point(226, 316);
            this.tJGenjang.Name = "tJGenjang";
            this.tJGenjang.Size = new System.Drawing.Size(100, 20);
            this.tJGenjang.TabIndex = 25;
            // 
            // sJGanjang
            // 
            this.sJGanjang.Location = new System.Drawing.Point(226, 349);
            this.sJGanjang.Name = "sJGanjang";
            this.sJGanjang.Size = new System.Drawing.Size(100, 20);
            this.sJGanjang.TabIndex = 26;
            // 
            // jHasilKeliling
            // 
            this.jHasilKeliling.Location = new System.Drawing.Point(242, 447);
            this.jHasilKeliling.Name = "jHasilKeliling";
            this.jHasilKeliling.Size = new System.Drawing.Size(71, 20);
            this.jHasilKeliling.TabIndex = 31;
            this.jHasilKeliling.Text = "0";
            // 
            // jHasilLuas
            // 
            this.jHasilLuas.Location = new System.Drawing.Point(242, 421);
            this.jHasilLuas.Name = "jHasilLuas";
            this.jHasilLuas.Size = new System.Drawing.Size(71, 20);
            this.jHasilLuas.TabIndex = 30;
            this.jHasilLuas.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(141, 454);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "HASIL KELILING :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(141, 424);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "HASIL LUAS :";
            // 
            // hitungJ
            // 
            this.hitungJ.Location = new System.Drawing.Point(144, 388);
            this.hitungJ.Name = "hitungJ";
            this.hitungJ.Size = new System.Drawing.Size(75, 23);
            this.hitungJ.TabIndex = 27;
            this.hitungJ.Text = "HITUNG";
            this.hitungJ.UseVisualStyleBackColor = true;
            this.hitungJ.Click += new System.EventHandler(this.hitungJ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 527);
            this.Controls.Add(this.jHasilKeliling);
            this.Controls.Add(this.jHasilLuas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.hitungJ);
            this.Controls.Add(this.sJGanjang);
            this.Controls.Add(this.tJGenjang);
            this.Controls.Add(this.aJGenjang);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sHasilKeliling);
            this.Controls.Add(this.sHasilLuas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hitungS);
            this.Controls.Add(this.tSegitiga);
            this.Controls.Add(this.aSegitiga);
            this.Controls.Add(this.pHasilKeliling);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hitungP);
            this.Controls.Add(this.pHasilLuas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lPersegi);
            this.Controls.Add(this.pPersegi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pPersegi;
        private System.Windows.Forms.TextBox lPersegi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pHasilLuas;
        private System.Windows.Forms.Button hitungP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pHasilKeliling;
        private System.Windows.Forms.TextBox aSegitiga;
        private System.Windows.Forms.TextBox tSegitiga;
        private System.Windows.Forms.Button hitungS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sHasilLuas;
        private System.Windows.Forms.TextBox sHasilKeliling;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox aJGenjang;
        private System.Windows.Forms.TextBox tJGenjang;
        private System.Windows.Forms.TextBox sJGanjang;
        private System.Windows.Forms.TextBox jHasilKeliling;
        private System.Windows.Forms.TextBox jHasilLuas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button hitungJ;
    }
}

