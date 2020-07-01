using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan8_Tugas
{
    class KaryawanHarian : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji() { return UpahPerJam * JumlahJamKerja; }
    }
}
