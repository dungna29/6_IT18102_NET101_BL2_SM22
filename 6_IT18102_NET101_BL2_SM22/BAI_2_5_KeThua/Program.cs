using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_KeThua
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            * 1. Khi kế thừa thì lớp con có đầy đủ các thuộc tính và phương của lớp cha cho phép.
            * 2. Khi sử dụng contructor lớp con sẽ vẫn đầy đủ các thuộc tính mà nó được kế thừa.
              3. C#2 trở lên khi nói về kế thừa có nghĩa biến lớp con trở thành chính lớp cha và tự phát triển riêng các thuộc tính và phương thức.
            */
            SinhVien sv = new SinhVien();
            sv.Msv = "PH1";//Thuộc tính của lớp con
            sv.Ten = "Hoàng";//Thuộc tính lớp cha
            sv.InRaManHinh();
            sv.Method1();
        }
    }
}