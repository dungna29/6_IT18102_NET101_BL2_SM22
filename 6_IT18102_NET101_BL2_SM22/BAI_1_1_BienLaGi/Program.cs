using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_BienLaGi
{
    internal class Program
    {
      
        /*
         * Bài 1.1 Khai báo biến
         * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến được khở tạo trong bộ nhớ ảo khi chương trình khởi chạy.
         *
         * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
         *      Khai báo nhiều biến có cùng kiểu dữ liệu trên cùng 1 dòng:
         *      <Kiểu dữ liệu> <Tên Biến1> = <Giá trị>, <Tên Biến2> = <Giá trị>, <tên biến n>;
         * 1. <Kiểu dữ liệu> 
         *  + Số nguyên:sbyte, byte, long, int
         *  + Sô thực: float, double, decimal
         *  + Chuỗi hoặc ký tự: string, char
         *  + Logic: bool
         *  + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
         * 2. <Tên Biến>
         *  + Quy tắc:
         *      - Tên biến phải có nghĩa
         *      - Có phân biệt chữ hoa chữ thường
         *      - Không bắt đầu bởi số, không dùng từ khóa
         *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
         *  + Khai báo tên biến với 2 từ trở lên:
         *      - Cách 1: normal = firstname
         *      - Cách 2: CamelCase = FirstName, firstName
         *      - Cách 3: Under_Score = first_name, first_Name
         *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
         *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
         *      - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến.
         *      - int _year = 1989;
         * 3.<Giá trị>
         *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
         *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
         *
         */
        private int _a;//Biến toàn cục khai báo bên ngoài phương thức.
        static void Main(string[] args)
        {
            //string: Chuỗi
            string name = "FPOLY";
            string name1, name2, name4 = "C#1";

            //int: Số nguyên
            int b;//Khai báo 1 biến có kiểu nguyên chưa khởi tạo giá trị ban đầu
            b = 5;//Gán giá trị
            long c = 9;////Khai báo 1 biến có kiểu nguyên có khởi tạo giá trị ban đầu

            //Số thực:
            float d = 9.2f;

            //Kiểu dữ liệu ngầm định var(Phải khởi tạo giá trị cho nóm không khai báo bên ngoài phương thức, không được dùng nó làm tham số)
            //var temp1;//Lỗi
            var temp1 = "a";
            var temp2 = 'c';
            var temp3 = 1;
            var temp4 = true;
            var temp5 = 6.7;

            //Logic
            bool temp6 = true;

            //Tất cả các biến thầy khai báo ở trong main là biến cục bộ
        }
    }
}
