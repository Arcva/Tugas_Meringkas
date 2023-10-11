using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Ringkasan
{
    /*
    //Jika ingin menjalankan program yang ada di bawah, komentar multi-line bisa dihapus terlebih dahulu.
    class program
    {
        static void Main(string[] args)
        {
            //Ringkasan Materi Pada Pertemuan Di 2 Di discord
            /*
            //---- Operator Aritmatika ----
            //Operator Aritmatika
            var hasil = 10 + 14; //penjumlahan
            var hasil1 = 50 - 29; //pengurangan
            var hasil2 = -23; //negatif
            var hasil3 = 5 * 4; //perkalian
            var hasil4 = 20 / 4; //pembagian
            var hasil5 = 30 % 4; //modulus(sisa hasil bagi)

            Console.WriteLine(hasil);
            Console.WriteLine(hasil1);
            Console.WriteLine(hasil2);
            Console.WriteLine(hasil3);
            Console.WriteLine(hasil4);
            Console.WriteLine(hasil5);
            */
            
            /*
            //Increment dan Decrement

            //Incerment
            int a = 3;
            Console.WriteLine(a);
            Console.WriteLine(a++); //hasil nilai ++a sebelum operasi
            Console.WriteLine(a);
            Console.WriteLine(++a); //hasil nilai a++ setelah operasi
            
            //Decrement
            Console.WriteLine(a);
            Console.WriteLine(--a); //hasil nilai -a sebelum operasi 
            Console.WriteLine(a);
            Console.WriteLine(a--); //hasil nilai a- setelah operasi
            */
            
            /*
            //------ Operator Perbandingan ------
            //Merupakan Operator yang mengembalikan nilai boolean(true/false).

            //Membuat Operator Perbandingan
            int b = 10;
            Console.WriteLine(b==10); //sama dengan
            Console.WriteLine(b>5); //lebih dari
            Console.WriteLine(b<11); //kurang dari
            Console.WriteLine(b>=9); //lebih dari sama dengan
            Console.WriteLine(b<=12); //kurang dari sama dengan
            */

            /*
            //-------- Operator Logika ---------
            //Digunakan untuk melakukan operasi logika pada nilai-nilai boolean dan menghasilkan output boolean juga.
    
            //AND(&&)
            //akan diproses jika  memenuhi kondisi.
            //Contoh AND(&&)
            string nama = "Fulan";
            int umur = 18;
            if(nama == "Fulan" && umur == 18)
            {
                Console.WriteLine("Hallo Fulan");
            } 
            //OR(||)
            //akan diproses bila salah satu tidak memenuhi kondisi.
            //Contoh OR(||)
            if(nama == "Fulan" || umur == 17)
            {
                Console.WriteLine("Hallo Fulan (OR)");
            }
            //Negasi/Kebalikan(!)
            //akan membuat nilai true menjadi false dan sebaliknya.
            //Contoh Negasi/Kebalikan(!)
            bool hidup = false;
            bool mati = true;
            if(!hidup)
            {
                Console.WriteLine("Saya Sudah Mati");
            }
            */

            /*
            //------- Array -----------
            //Array digunakan untuk menyimpan koleksi element dengan tipe data yang sama dalam urutan terindeks.
            //indeks array dimulai dari 0, yang berarti element pertama memiliki indeks 0, element kedua 1, dam seterusnya.
            
            //Contoh Array
           string[] divisi = { "web", "mobile", "game", "mulmed", "jaringan" };
           Console.WriteLine(divisi[0]);
           Console.WriteLine(divisi[1]);
           Console.WriteLine(divisi[2]);
           Console.WriteLine(divisi[3]);
           Console.WriteLine(divisi[4]);

           string[] names = new string[5];
            names[0] = "web";
            names[0] = "mobile";
            names[0] = "game";
            names[0] = "mulmed";
            names[0] = "jaringan";
            */

            /*
            //Array 2D
            int[,] number = new int[2,3];
            int[,] numbers = { {1, 2, 3}, { 4, 5, 6} };
            Console.WriteLine(numbers[0, 1]); //output 2
            Console.WriteLine(numbers[1, 2]); //output 6
            */
            
            /*
            //Array 3D
            int[,,] number = new int[2, 2, 3];
            int[,,] numbers = { { {1, 2, 3}, {4, 5, 6} }, { {7, 8, 9}, {10, 11, 12} } };
            Console.WriteLine(numbers[0, 0, 0]); //output 1
            Console.WriteLine(numbers[1, 1, 0]); //output 10
            */
            
            /*
            //--------- List ---------
            //List adalah salah satu struktur data yang fleksibel,digunakan untuk menyimpan kumpulan element/objek dalam urutan 
              tertentu.
            //List termasuk dalam namespace System.Collection.Generic.
            //List dapat menambahkan,menghapus,atau mengakses element-element di dalamnya dengan mudah.

            //Contoh List
            List<int> angka = new List<int>();

            //menambahkan data pada list
            angka.Add(1);
            angka.Add(2);
            angka.Add(3);

            //menambahkan sekaligus beberapa data pada list
            angka.AddRange(new int[3] { 4, 5, 6 });

            //menghapu data/ item pada list
            angka.Remove(1);

            //menghapus data pada list berdasarkan index
            angka.RemoveAt(0);

            //mengetahui index pada suatu data
            angka.IndexOf(3);

            //Mengecek apakah ada data yang sesuai
            Console.WriteLine(angka.Contains(3));

            //Mengecek panjang suatu list
            Console.WriteLine(angka.Count());
            
            foreach (var a in angka)
            {
                Console.WriteLine(a + " ");
            }
            */

            /*
            //------- Pengkondisian -------

            //Else - If
            //Adalah alur program yang digunakan untuk mengambil keputusan berdasarkan kondisi tertentu. Jika kondisi tidak terpenuhi,
              program dapat menjalankan blok kode lain yang kondisinya memenuhi.
            //If statement: Akan dijalankan jika kondisi yang diuji benar(true).
            //Else statement: Akan dijalankan jika kondisi yang diuji salah(false).
            //Else if statement: digunakan unkun menguji beberapa kondisi secara berurutan. Akan dijalankan jika kondisi dalam if sebelumnya
              salah(false), dan kondisi dalam else benar(true).

            //Contoh If 
            int i = 5;
            if (10 > i)
            {
                Console.WriteLine("Benar!");
            }
            else
            {
                Console.WriteLine("Salah!");
            }
            */
            /*
            //Contoh Else
             int i = 12;
            if (10 > i)
            {
                Console.WriteLine("Benar!");
            }
            else
            {
                Console.WriteLine("Salah!");
            }
            */
            /*
            //Contoh Else If
            int nilai = 100;
            if(nilai >= 90)
            {
                Console.WriteLine("Anda mendapatkan A");
            }
            else if (nilai >= 80)
            {
                Console.WriteLine("Anda mendapatkan B");
            }
            else if (nilai >= 70)
            {
                Console.WriteLine("Anda mendapatkan C");
            }
            else 
            {
                Console.WriteLine("Anda mendapatkan D atau E");
            }
            */
            /*
            //Switch 
            //Digunakan dalam pemrograman untuk membuat keputusan berdasarkan nilai ekspresi yang berbeda
            //Memungkinkan program untuk menjalankan blok kode tertentu berdasarkan nilai ekspresi yang cocok dengan salah satu dari beberapa
              kasus yang telah ditentukan.
            //case adalah nilai atau ekspresi yang dibandingkan dengan ekspresi switch.
            //Default adalah case yang dijalankan jika tidak ada case yang cocok dengan ekspresi switch, Default bersifat optional.

            //Contoh Switch
            int nilai = 75;
            switch (nilai)
            {
                case > 95:
                    Console.WriteLine("Memuaskan");
                    break;
                case > 80:
                    Console.WriteLine("Baik");
                    break;
                case >= 75:
                    Console.WriteLine("Cukup");
                    break;
                default:
                    Console.WriteLine("Kurang");
                    break;
            }
            */
            /*
            //----- Ternary Operator -----
            //Merupakan cara singkat untuk mengevaluasi ekspresi berdasarkan kondisi tertentu.
            
            //Contoh Ternary operator
            int angka = 10;
            string hasil = (angka % 2 == 0) ? "Genap" : "Ganjil";
            Console.WriteLine(hasil);
            */

            //------------ Perulangan atau Loop --------------
            //Adalah konsep yang digunakan untuk mengulangi serangkaian perintah tertentu selama kondisinya terpenuhi.
            /*
            //Perulangan - for
            //Bagian Perulangan - for: "inisialisasi"-->(int i=0),"kondisi"-->(i<5),"iterator"-->(i++).
            //Contoh Perulangan - for
            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine("Loop ke -" + i);
            }
            */

            /*
            //Perulangan - While
            //Bagian Perulangan - While: "inisialisasi"-->(int i=0),"kondisi"-->(i<5),"iterator"-->(i++).
            //Iterator ditulis setelah Console.WriteLine.
            //Contoh Perulangan - While
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Loop ke -" + i);
                i++;
            }
            */

            /*
            //Perulangan - Do While
            //Jika kondisi perulangan while tidak terpenuhi, minimal akan keluar satu output.
            //Contoh Perulangan - Do While
            int i = 5;
            do
            {
                Console.WriteLine("Loop ke -" + i);
                i++;
            } while (i < 5);
            */

            /*
            //Perulangan - Foreach
            //Bisa digunakan untuk mengakses/mencetak array.
            //Membuat perulangan - Foreach
            int i = 0;
            int[] angka = new int[5] { 1, 2, 3, 4, 5, };
            foreach (int a in angka)
            {
                Console.WriteLine("ini adalah isi array urut dari indeks ke - " + i++ + " yaitu " + a);
            }
            */

            /*
            //--------- Break dan Continue ----------
            //Break
            //Adalah pernyataan yang digunakan untuk menghentikan eksekusi loop atau keluar dari struktur switch lebih awal.
            //jika ada kode setelah break, kode itu tidak akan dieksekusi.
            //Contoh Break
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Loop ke -" + i);

                if (i == 5)
                {
                    break;
                }
            }
            */
            /*
            //Continue
            //Adalah pernyataan yang digunakan dalam loop untuk melanjukan ke iterasi berikutnya tanpa menjalankan kode di bawahnya 
            //dalam iterasi yang sama.
            //contoh Continue
            for (int i = 0;i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    //mengabaikan angka genap dan menaljutkan ke iterasi berikutnya
                    continue;
                }
                Console.WriteLine(i);
            }
            

             
        }
       
    }
    */

     
    public class program
    {
        //------------ Function ---------------
            //Adalah kode yang digunakan untuk menjalankan tugas tertentu.
            //Memungkinkan untuk mengelompokan sejumlah pernyataan ke dalam satu unit yang dapat digunakan kembali.
            //memiliki nama dan dapat menerima argumen(data yang duteruskan ke dalam) dan mengembalikan nilai(hasil operasi).
            //Contoh Function
            /*
        public static void Main(string[] args)
        {
            Tampil();
        }

        public static void Tampil()
        {
            Console.WriteLine("Game");
        }
        */
        

        //Void function adalah sebuah fungsi yang memiliki niali kembali
        //Selain void, terdapat function yang memiliki nilai kembali, seperti int,string,bool,dan lain-lain.
        //Dalam function yang memiliki nilai kembali,terdapat kata return di akhir program functionnya.
        //Parameter dalam fungsi digunakan untuk mengirim data.

        /*
        //Contoh lain function #1
        public static void Main(string[] args)
        {
            int hasil = Return();
            Console.WriteLine(hasil);
        }

        public static int Return()
        {
            return 5;
        }
        */

        
        //Contoh lain function #2
        public static void Main(string[] args)
        {
            int hasil = Counter(10);
            Console.WriteLine(hasil);
        }

        public static int Counter(int damage)
        {
            return damage + 5;
        }
    }
}