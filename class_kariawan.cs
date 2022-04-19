using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ResponsiPemrograman4385
{
    class Kariawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public int GajiperBulanan { get; set; }
        public int Gajii { get; set; }

        public Kariawan(int nik, string nama, int gajiperBulanan)
        {
            this.NIK = nik;
            this.Nama = nama;

            if (gajiperBulanan < 0)
            {
                this.GajiperBulanan = 0;
                Gajii = Convert.ToInt32((GajiperBulanan * 1.1));
            }
            else
            {
                this.GajiperBulanan = gajiperBulanan;
                Gajii = Convert.ToInt32((GajiperBulanan * 1.1));
            }

        }

    }
}