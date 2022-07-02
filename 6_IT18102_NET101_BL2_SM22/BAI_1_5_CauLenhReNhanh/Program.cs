using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_5_CauLenhReNhanh
{
    internal class Program
    {
        /*
       * Bài 1.5 Câu điều kiện rẽ nhánh IF
       * ĐƯợc sử dụng để lập điều kiện và sẽ thực thi 1 hành động nào đó nếu thỏa mãn điều kiện.
       *
       * Công thức IF: if + tab       
       *   if (<Điều kiện>)
          {
              If phải luôn đúng
              Một hành động được thi khi thỏa mãn điều kiện
          }
       */
        /*
        * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
        * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
        *
        * Cấu trúc: 
        * if (true)
           {
               Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
           }
           else
           {
               Nếu không thỏa mãn IF thì mặc định là vào ELSE
           }
        */

        /*
       * Bài  1.7 Cầu điều kiện Else If dùng trong trường hợp có nhiều điều kiện khác nhau và thực hành động tương ứng với từng điều kiện. Else If phải luôn True thì mới thực hiện hành động bên trong nó.
       *
       * Lưu ý: Nếu thỏa mãn 1 điều kiện thì nó chỉ thực hiện hành động trong điều kiện đó mà thôi.
       *
       * Công thức:
       *   if (true)
          {
              //Thực hiện 1 hành động nếu If đúng
          }else if (<Điều kiện 1>)
          {
              //Khi If không thỏa mãn và Else If phải true thì mới vào đây thực hiện 1 hành động.
          }else if (<Điều kiện 2>)
          {
              //Tương tự
          }else
          {
              //Khi tất cả các điều kiện ở trên không thỏa mãn thì sẽ vào đây
          }
       */
        static void Main(string[] args)
        {
            double diemCsharp1 = 5;
            if (diemCsharp1 <= 5)
            {
                Console.WriteLine("Chúc mừng bạn đã mất 659k");
                return;
            }

            //Console.WriteLine("Chúc mừng bạn đã qua môn");

            double diemCsharp2 = 4.9;
            if (diemCsharp2 <= 5)
            {
                Console.WriteLine("Chúc mừng bạn đã mất 659k");
            }
            else
            {
                Console.WriteLine("Chúc mừng bạn đã qua môn");
            }

            //Else if
            if (diemCsharp2 >= 9 && diemCsharp2 <=10)
            {
                Console.WriteLine("Xuất sắc");
            }
            else
            {
                if (diemCsharp2 >= 8 && diemCsharp2 < 9)
                {
                    Console.WriteLine("Giỏi");
                }
                else
                {
                    if (diemCsharp2 >= 6 && diemCsharp2 < 8)
                    {
                        Console.WriteLine("Khá");
                    }
                    else
                    {
                        // .....
                    }
                }
            }

            //Else if   
            if (diemCsharp2 >= 9 && diemCsharp2 <= 10)
            {
                Console.WriteLine("Xuất sắc");
            }else if (diemCsharp2 >= 8 && diemCsharp2 <9)
            {
                Console.WriteLine("Giỏi");
            }else if (true)
            {
                //.......
            }
            else
            {
                
            }
        }
        /*
           * Viết 1 chương trình cho người dùng nhập điểm GPA
           * 9 - 10 = Xuất Sắc
           * 8 - 9 = Giỏi
           * 6 - 8 = Khá
           * 5 - 6 = TB
           * 0 - 4 = Học lại
           * Không sử dụng Else IF - Ko dùng return
           * Chỉ dùng IF Else - Không được phép dùng if không. Else không được để null
        */
    }
}
