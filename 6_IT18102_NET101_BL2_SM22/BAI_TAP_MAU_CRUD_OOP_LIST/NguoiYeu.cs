using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_CRUD_OOP_LIST
{
    public class NguoiYeu
    {
        private string ma;
        private string ten;
        private int ns;
        private int trangThai;//1. Còn yêu - 2 Hết Yêu

        public NguoiYeu()
        {
        }

        public NguoiYeu(string ma, string ten, int ns, int trangThai)
        {
            this.ma = ma;
            this.ten = ten;
            this.ns = ns;
            this.trangThai = trangThai;
        }

        public string Ma
        {
            get => ma;
            set => ma = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int Ns
        {
            get => ns;
            set => ns = value;
        }

        public int TrangThai
        {
            get => trangThai;
            set => trangThai = value;
        }

        public void InRaManHinh()
        {
            Console.WriteLine($"{ma} {ten} {ns} {2022 - ns}  {(trangThai == 1 ? "Còn yêu" : "Hết yêu")}");
        }
    }
}