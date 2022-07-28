using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_KeThua
{
    internal class SinhVienA
    {
        private string msv;
        private string ten;
        private string diaChi;
        private string sdt;
        private string ns;
        private string nganhHoc;

        public SinhVienA()
        {
        }

        public SinhVienA(string msv, string ten, string diaChi, string sdt, string ns)
        {
            this.msv = msv;
            this.ten = ten;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.ns = ns;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Ns
        {
            get => ns;
            set => ns = value;
        }

        public void InRaManHinh()
        {
        }
    }
}