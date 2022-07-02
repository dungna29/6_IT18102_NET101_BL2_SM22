using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_NhapXuat
{
    internal class Program
    {
        /*
         * BÀI 1.2 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //In ra màn hình: cw + tab
            Console.WriteLine("Chào các bạn đến với C#1");
            Console.Write("Block 2 SM22 ");
            Console.WriteLine("- Chuẩn bị nghỉ hè.");

            //Nhập vào năm sinh và in ra màn hình tuổi và năm sinh

            //Bước 1: Xác định số lượng biến sẽ sử dụng
            int ns;

            //Bước 2: Đổ dữ liệu vào các biến nếu cần
            Console.Write("Mời bạn nhập năm sinh: ");
            ns = Convert.ToInt32(Console.ReadLine());//Phải ép về đsung kiểu dữ liệu của biến thì mới gán được giá trị cho ns.
            

            //Bước 3: Xử lý nghiệp vụ
            Console.WriteLine($"Tuổi bạn vừa nhập: {2022 - ns} | Năm sinh: {ns}");
        }
    }
}
