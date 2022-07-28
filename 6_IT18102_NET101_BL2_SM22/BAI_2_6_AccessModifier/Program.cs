using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_AccessModifier
{
    internal class Program
    {/*
         * AccessModifier: sử dụng trên biến, phương thức, class
         * Public: Được phép truy cập ở tất cả các lớp
         * Private: Chỉ được phép sử dụng bên trong class đó.
         * Protected: Chỉ cho phép lớp con mới có quyền truy cập và trong cùng 1 class vẫn truy cập.
         * Internal: Chỉ được truy cập bên trong 1 thư mục.
         *
         * Ngoài ra còn 2 sự kết hợp: protected internal, private protected
         */

        private class SinhVien
        {
            private string att1;//private
            public string att2;//public
            private string att3;//; Default = private
            protected string att4;
            internal string att5;

            //Áp dụng cho Method cũng tự tự
        }

        private class SinhVienPTPM : SinhVien
        {
            public SinhVienPTPM()
            {
                att2 = ";";
                att4 = ";";//Chỉ lớp con mới được dùng
                att5 = ";";
            }
        }

        private class SinhVienWEB
        {
            public SinhVienWEB()
            {
                SinhVien sv = new SinhVien();
                sv.att5 = "";
                sv.att2 = "";
            }
        }

        private static void Main(string[] args)
        {
            SinhVienPTPM sv = new SinhVienPTPM();
            sv.att2 = "";
            sv.att5 = "";
        }
    }
}