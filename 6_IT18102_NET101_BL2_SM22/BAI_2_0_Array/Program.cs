using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_Array
{
    internal class Program
    {
        /*
        * Phần 1: Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán.
        *
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Khai báo biến
            int a = 5;

            //2. Khai báo mảng
            int[] arrNumbers;//Khai bao báo mảng
            arrNumbers = new int[5];//Khởi tạo 1 mảng 5 phần tử

            string[] arrNames = new string[6];//Khởi tạo 1 mảng 6 phần tử

            string[] arrMonHocs = { "C#1", "C#2", "C#3" };//Khởi tạo 3 phần tử
            string[] arrMonHocs1 = new[] { "C#1", "C#2", "C#3" };//Khai báo kiểu ngầm định
            string[] arrMonHocs2 = new string[] { "C#1", "C#2", "C#3" };//Khai báo kiểu tường minh

            var arrNumbers1 = new[] { 1, 2, 3, 4, 5, 6, 7 };//Var sẽ hiểu là mảng nguyên
            var arrNumbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };//Var sẽ hiểu là mảng nguyên

            //3. Gán giá trị cho mảng thông qua index
            arrNumbers[0] = 8;
            arrNumbers[1] = 81;
            arrNumbers[2] = 82;
            arrNumbers[3] = 83;
            arrNumbers[0] = 84;//Ghi đè giá trị tại Index 0

            //4. Lấy được giá trị: " Gán vào vị trí nào thì lấy ra đúng vị trí đó"
            Console.WriteLine(arrNumbers[1]);

            //Xuất tất cả các phần tử:
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}