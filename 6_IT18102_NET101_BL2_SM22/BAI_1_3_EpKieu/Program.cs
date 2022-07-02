using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_3_EpKieu
{
    internal class Program
    { /*
      * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
      *
      * Công thức ép kiểu tường minh:
      *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
      *
      * P2: Ép kiểu từ string về số
      *  + Phương thức Parse()
      *  + Lớp Convert()
      */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string a, b;
            Console.Write("Mời bạn nhập số a: ");
            a = Console.ReadLine();
            Console.Write("Mời bạn nhập số b: ");
            b = Console.ReadLine();
            Console.WriteLine($"a + b = {a + b}");//? Có thực hiện được phép toán không?
            //Ở trên được gọi là hành động cộng chuỗi hay nối chuỗi

            //Giải pháp: Ép kiểu
            //Cách 1: Dùng Convert về kiểu dữ liệu cần
            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine($"a + b = {c}");

            //Cách 2: Dùng Parse
            int d = int.Parse(a) + int.Parse(b);

            //Ngoài ra 1 vài ví dụ:
            double d1 = double.Parse("7.9");

            // Phần 2: Chuyển đổi kiểu dữ liệu số với nhau
            int t1 = 9;
            double t2 = 7.9;
            //t1 = t2; Lỗi vì kiểu dữ liệu t2 lớn hơn t1
            t2 = t1;//Ép kiểu tự động
            t1 = (int)t2;//Loại bỏ toàn bộ phần thập phân
        }
    }
}
