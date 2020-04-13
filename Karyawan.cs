using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ResponsiPemrograman2656
{
    class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public double GajiBulanan { get; set; }
        //public double Diskon { get; set; }

        public Karyawan(int nik, string nama, double gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
            //Diskon = diskon;

            if (GajiBulanan < 0)
            {
                Console.WriteLine("\nNominal tidak valid!, Gaji tidak boleh kurang dari 0 !!!");
                GajiBulanan = 0;
            }
        }
        public void GetDataKaryawan()
        {
            Console.WriteLine("\nNo. Nik/Nama           Gaji Bulanan : ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1.  {0} / {1}     {2}", Nik, Nama, GajiBulanan);
        }
        public void GetDataKaryawan2()
        {
            Console.WriteLine("2.  {0} / {1}     {2}", Nik, Nama, GajiBulanan);
        }

        public void GetDataDiskon()
        {
            double diskon = 0;
            diskon = 0.1 * GajiBulanan+GajiBulanan;
            GajiBulanan += Convert.ToInt32(diskon);
            Console.WriteLine("\nAsyiiiik kenaikan gaji 10% !!!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1.  {0} / {1}     {2}", Nik, Nama, diskon);
        }
        public void GetDataDiskon2()
        {
            double diskon = 0;
            diskon = 0.1 * GajiBulanan + GajiBulanan;
            GajiBulanan += Convert.ToInt32(diskon);
            Console.WriteLine("2.  {0} / {1}     {2}", Nik, Nama, diskon);
        }
    }
}
