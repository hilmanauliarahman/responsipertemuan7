using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ResponsiPemrograman2656
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(19112656, "Paijo", 3000000);
            karyawan.GetDataKaryawan();

            Karyawan karyawan2 = new Karyawan(19112658, "Jono", 2000000);
            karyawan.GetDataKaryawan2();


            Karyawan GetDataDiskon = new Karyawan(19112656, "Paijo", 0);
            karyawan.GetDataDiskon();

            Karyawan GetDataDiskon2 = new Karyawan(19112658, "Jono", 0);
            karyawan.GetDataDiskon2();

            Console.ReadKey();
        }
    }
}
