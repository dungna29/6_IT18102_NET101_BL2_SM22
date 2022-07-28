using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_KeThua
{
    internal class GiangVienA
    {
        private string mgv;
        private string ten;
        private string diaChi;
        private string sdt;
        private string ns;
        private string nganhDay;

        public GiangVienA()
        {
        }

        public GiangVienA(string mgv, string ten, string diaChi, string sdt, string ns, string nganhDay)
        {
            this.mgv = mgv;
            this.ten = ten;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.ns = ns;
            this.nganhDay = nganhDay;
        }

        public string Mgv
        {
            get => mgv;
            set => mgv = value;
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

        public string NganhDay
        {
            get => nganhDay;
            set => nganhDay = value;
        }

        public void InRaManHinh()
        {
        }
    }
}