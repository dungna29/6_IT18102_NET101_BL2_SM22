using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_KeThua
{
    //Lớp người ta sẽ coi nó là 1 lớp cha và nó như lớp đối tượng bình thường khác
    internal class Nguoi
    {
        //Đưa các thuộc tính chung và phương thức chung lên lớp cha
        private string ten;

        private string diaChi;
        private string sdt;
        private string ns;

        public Nguoi()
        {
        }

        public Nguoi(string ten, string diaChi, string sdt, string ns)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.ns = ns;
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

        public virtual void InRaManHinh()
        {
            Console.WriteLine("InRaManHinh của lớp cha");
        }

        public virtual void Method1()
        {
        }

        private void Method2()
        {
        }
    }
}