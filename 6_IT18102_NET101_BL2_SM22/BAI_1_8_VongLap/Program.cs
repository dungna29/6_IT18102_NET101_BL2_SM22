using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_8_VongLap
{
    internal class Program
    {
        private int a;
        /*
         * BàiVòng lặp:
         *
         * Định nghĩa chung cho tất cả vòng lặp:
         * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
         *
         * Các loại vòng lặp: while, do..while, for, foreach
         *
         * Từ khóa sử dụng trong vòng lặp:
         *
         * break - ngắt vòng lặp
         * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
         *
         * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
         * + Cách dùng: wh + tab
         *
         * + Công thức:
         *  while (true)
            {
                //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
            }

            Vòng lặp Do..While: Thực hiện hành động ít nhất là 1 lần. Điều kiện đề vòng lặp chạy giống như While(True).
           Cách gõ: do + tab
           Công thức:
           do {
                      //Thực hiện hành động ít nhất là 1 lần.
           } while (true);

            Cách gõ: for + tab
            Công thức:
             for (int i = 0; i < 10; i++) {
                }
            int i = 0: Điểm bắt đầu của vòng lặp có kiểu số nguyên
            i < 10: Điều kiện để ngắt vòng
            i++: Tăng bước nhẩy lên 1
   */

        private static void Main(string[] args)
        {
            /*
             * Bí kíp dùng vòng lặp:
             *  1. Điểm bắt đầu
             *  2. Điều kiện chạy (Điều kiện ngắt)
             *  3. Bước nhẩy (Giúp đạt điều kiện chạy)
             */
            //1. Vòng lặp for: for + tab
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Tôi sẽ không học lại C#1");
            //}

            //2. Vòng lặp while: wh + tab
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Tôi sẽ không học lại C#1");
                i++;
            }

            //3. Vòng lặp Do...While: do + tab
            //Tương tự muốn sử dụng đảm bảo được 3 yếu tố trên.
            // do
            // {
            // } while (true);

            /*
             * Bài tập 1: In full bảng cửu chương bằng 3 vòng lặp.
             * Bài tập 2: In khoảng bảng cửu chương do người dùng nhập vào.
             */
            //Bài 1: while
            /*
             *  a   b   a x b
             *  1 x 1 = 1
             *  1 x 2 = 2
             *  1 x 3 = 3
             *  ......
             *  1 x 10 = 10
             */
            int a = 1, b = 1;
            while (a <= 10)//Vòng a
            {
                Console.WriteLine("Bảng cửu chương " + a);
                while (b <= 10)//Vòng b
                {
                    Console.WriteLine($"{a} x {b} = {a * b} \n");
                    b++;
                }
                a++;//Sau khi in xong 1 bảng cửu chương thì phải tăng a
                b = 1;//Reset giá trị b
            }
        }
    }
}