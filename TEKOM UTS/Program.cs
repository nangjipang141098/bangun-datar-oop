using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEKOM_UTS
{

    class variabel_persegi
    {

        protected int s;

        public void variabel_hitung_persegi(int sisi)
        {
            s = sisi;
        }

    }

    class persegi : variabel_persegi
    {

        public int hitung_luas_persegi()
        {
            double lp = Convert.ToDouble(s);
            double hlp = Math.Pow(2, lp);
            int hlpp = Convert.ToInt16(hlp);
            return hlpp;
        }

        public int hitung_keliling_persegi()
        {
            return (2 * ( s * s ) ) ;
        }

    }

    class variabel_lingkaran
    {

        protected double j;

        public void variabel_hitung_lingkaran(double jari)
        {
            j = jari;
        }

    }

    class lingkaran : variabel_lingkaran
    {

        double phi = 3.14;

        public double hitung_luas_lingkaran()
        {
            return phi * Math.Pow(2, j); 
        }

        public double hitung_keliling_lingkaran()
        {
            return (2 * ( phi * Math.Pow(2, j)  ) );
        }

    }

    class variabel_persegi_panjang
    {

        protected int p, l;

        public void variabel_hitung_persegi_panjang(int panjang, int lebar)
        {
            p = panjang;
            l = lebar;
        }

    }

    class persegi_panjang : variabel_persegi_panjang
    {

        public int hitung_luas_persegi_panjang()
        {
            return p * l;
        }

        public int hitung_keliling_persegi_panjang()
        {
            return (2 * (p + l));
        }
    }

    class variabel_segitiga
    {

        protected int a, t;
        protected int s1, s2, s3;

        public void variabel_hitung_luas_segitiga(int alas, int tinggi)
        {
            a = alas;
            t = tinggi;
        }

        public void variabel_hitung_keliling_segitiga(int sisi1, int sisi2, int sisi3)
        {
            s1 = sisi1;
            s2 = sisi2;
            s3 = sisi3;
        }
    }

    class segitiga : variabel_segitiga
    {

        public int hitung_luas_segitiga()
        {
            return a * t;
        }

        public int hitung_keliling_segitiga()
        {
            return s1 + s2 + s3;
        }

    }

    class objek
    {

        public void persegi()
        {
            Console.WriteLine("SELAMAT DATANG DIPERHITUNGAN PERSEGI");
            Console.WriteLine();

            Console.Write("MASUKAN SISI");
            int sisi = int.Parse(Console.ReadLine());

            persegi p = new persegi();
            p.variabel_hitung_persegi(sisi);

            Console.WriteLine("LUAS PERSEGI ADALAH : " + p.hitung_luas_persegi());
            Console.WriteLine("KELILING PERSEGI ADALAH : " + p.hitung_keliling_persegi());
            Console.ReadLine();
        }

        public void persegi_panjang()
        {
            Console.WriteLine("SELAMAT DATANG DIPERHITUNGAN PERSEGI PANJANG");
            Console.WriteLine();

            Console.Write("MASUKAN PANJANG : ");
            int panjang = int.Parse(Console.ReadLine());

            Console.Write("MASUKAN LEBAR : ");
            int lebar = int.Parse(Console.ReadLine());


            persegi_panjang pp = new persegi_panjang();
            pp.variabel_hitung_persegi_panjang(panjang, lebar);

            Console.WriteLine("LUAS PERSEGI PANJANG ADALAH : " + pp.hitung_luas_persegi_panjang());
            Console.WriteLine("KELILING PERSEGI PANJANG ADALAH : " + pp.hitung_keliling_persegi_panjang());
            Console.ReadLine();

        }

        public void lingkaran()
        {
            Console.WriteLine("SELAMAT DATANG DI PERHITUNGAN LINGKARAN ");
            Console.WriteLine();

            Console.Write("SILAHKAN MASUKAN JARI - JARI : ");
            double jari = double.Parse(Console.ReadLine());

            lingkaran l = new lingkaran();

            l.variabel_hitung_lingkaran(jari);

            Console.WriteLine("LUAS LINGKARAN ADALAH : " + l.hitung_luas_lingkaran());
            Console.WriteLine("KELILING LINGKARAN ADALAH : " + l.hitung_keliling_lingkaran());
            Console.ReadLine();
        }

        public void segitiga()
        {
            Console.WriteLine("SELAMAT DATANG DIPERHITUNGA SEGITIGA ");
            Console.WriteLine();
            Console.WriteLine("SILAHKAN MASUKAN PILIHAN ANDA ");
            Console.WriteLine("1. HITUNG LUAS SEGITIGA ");
            Console.WriteLine("2. HITUNG KELILING SEGITIGA ");
            string pilihan_menu_segitiga = Console.ReadLine();

            switch (pilihan_menu_segitiga)
            {
                case "1":
                    segitiga sgl = new segitiga();

                    Console.WriteLine("MASUKAN ALAS : ");
                    int alas = int.Parse(Console.ReadLine());

                    Console.Write("MASUKAN TINGGI : ");
                    int tinggi = int.Parse(Console.ReadLine());
                    break;

                    sgl.variabel_hitung_luas_segitiga(alas, tinggi);

                    Console.WriteLine("LUAS SEGITIGA ADALAH : " + sgl.hitung_luas_segitiga());
                    Console.ReadLine();

                case "2":
                    segitiga sgk = new segitiga();

                    Console.Write("MASUKAN SISI 1 : ");
                    int sisi1 = int.Parse(Console.ReadLine());

                    Console.Write("MASUKAN SISI 2 : ");
                    int sisi2 = int.Parse(Console.ReadLine());

                    Console.Write("MASUKAN SISI 3 ");
                    int sisi3 = int.Parse(Console.ReadLine());

                    sgk.variabel_hitung_keliling_segitiga(sisi1, sisi2, sisi3);

                    Console.WriteLine("KELILING SEGITIGA ADALAH : " + sgk.hitung_keliling_segitiga());
                    Console.ReadLine();


                    

                 
                    break;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            menu:
            Console.WriteLine("DANANG AJI PANGESTU ");
            Console.WriteLine("TEKNIK KOMPILASI R01");
            Console.WriteLine("UJIAN TENGAH SEMESTER");

            Console.WriteLine();

            Console.WriteLine("SELAMAT DATANG PROGRAM MENGHITUNG BANGUN DATAR");
            Console.WriteLine("MASUKAN PILIHAN ANDA : ");
            Console.WriteLine("1. PERSEGI");
            Console.WriteLine("2. PERSEGI PANJANG");
            Console.WriteLine("3. LINGKARAN");
            Console.WriteLine("3. SEGITIGA");
            Console.WriteLine("MASUKAN PILIHAN ANDA : ");
            string menu_utama = Console.ReadLine();
            Console.Clear();

            switch(menu_utama)
            {
                    
                case "1":
                    objek obj_persegi = new objek();
                    obj_persegi.persegi();
                    Console.ReadLine();
                    Console.Clear();
                    goto menu;
                    break;

                case "2":
                    objek obj_persegi_panjang = new objek();
                    obj_persegi_panjang.persegi_panjang();
                    Console.ReadLine();
                    Console.Clear();
                    goto menu;
                    break;

                case "3":
                    objek obj_lingkaran = new objek();
                    obj_lingkaran.lingkaran();
                    Console.ReadLine();
                    Console.Clear();
                    goto menu;
                    break;

                case "4":
                    objek obj_segitiga = new objek();
                    obj_segitiga.segitiga();
                    Console.ReadLine();
                    Console.Clear();
                    goto menu;
                    break;
            }
  

        }
    }

}
