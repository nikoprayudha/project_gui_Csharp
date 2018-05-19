using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Jobsheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PERSEGI");
            persegi myPersegi = new persegi();
            myPersegi.panjang = 5;
            myPersegi.lebar = 3;
            Console.Write("Hasil Luas   : ");
            Console.WriteLine(myPersegi.hitungLuas());
            Console.Write("Hasil Keliling   : ");
            Console.WriteLine(myPersegi.hitungKeliling());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("SEGITIGA SAMA SISI");
            Segitiga mySegitiga = new Segitiga();
            mySegitiga.alas = 5;
            mySegitiga.tinggi = 3;
            Console.Write("Hasil Luas   : ");
            Console.WriteLine(mySegitiga.hitungLuas());
            Console.Write("Hasil Keliling   : ");
            Console.WriteLine(mySegitiga.hitungKeliling());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("JAJAR GENJANG");
            JajaranGenjang myJajarGenjang = new JajaranGenjang();
            myJajarGenjang.alas = 5;
            myJajarGenjang.tinggi = 3;
            myJajarGenjang.simir = 7;
            Console.Write("Hasil Luas   : ");
            Console.WriteLine(myJajarGenjang.hitungLuas());
            Console.Write("Hasil Keliling   : ");
            Console.WriteLine(myJajarGenjang.hitungKeliling());

        }
    }
}
