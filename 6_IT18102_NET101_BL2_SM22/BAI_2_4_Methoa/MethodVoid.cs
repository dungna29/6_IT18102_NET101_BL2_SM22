using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_Method
{
    internal class MethodVoid
    {
        /*
        *  Phương thức không trả về là : Void
        *   Công thức chung:
        *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
        *  {
        *          Body code
        *  }
        */

        //Phương thức không trả về không tham số
        public void TinhTong2So()
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        // public void TinhTong2So() // Vì 2 phương thức giống nhau cả tên và tham số
        // {
        //
        // }
        public void TinhTong()
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        //Phương thức không trả về nhưng có tham số
        //Phương thức trùng tên nhưng phải khác tham số được gọi là nạp chồng phương thức (Overloading) trong tính đa hình OOP

        public void TinhTong(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void TinhTong(int a, string b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void TinhTong(int a, int b, int c)
        {
            Console.WriteLine($"{a} + {b}+ {c} = {a + b + c}");
        }

        //Ngoài ra có thể truyền tham số là những kiểu dữ liệu khác nhau không nhất thiết phải giải giống nhau.
    }
}