using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan8_Tugas
{
    class KaryawanTetap : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double GajiBulanan { get; set; }
        public override double Gaji() { return GajiBulanan; }
    }
}
