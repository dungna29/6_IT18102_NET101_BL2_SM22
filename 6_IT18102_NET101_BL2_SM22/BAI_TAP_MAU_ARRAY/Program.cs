using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_ARRAY
{
    internal class Program
    {
        /*
         * Bài tập mảng:
         *  1. Nhập mảng
         *  2. Xuất mảng
         *  3. Tìm kiếm tuyệt đối
         *  4. Sort
         *  5. Thoát
         */

        //Trên cùng luôn là các biến toàn cục
        private static string _input = "1";

        private static string[] _arrMsv;

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Menu();
        }

        //Phương thức menu
        private static void Menu()
        {
            while (!(_input == "5"))
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Nhập mảng");
                Console.WriteLine("2. Xuất mảng");
                Console.WriteLine("3. Tìm kiếm");
                Console.WriteLine("4. Sort");
                Console.WriteLine("5. Thoát");
                Console.Write("Mời bạn chọn chức năng: ");
                _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        NhapMang();
                        break;

                    case "2":
                        XuatMang();
                        break;

                    case "3":
                        TimKiem();
                        break;

                    case "4":
                        Sort();
                        break;

                    case "5":
                        Console.WriteLine("Chào tạm biệt");
                        break;

                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            }
        }

        private static void NhapMang()
        {
            Console.Write("Mời bạn nhập số lượng: ");
            _input = Console.ReadLine();//Hứng số lượng phần tử mảng
            _arrMsv = new string[Convert.ToInt16(_input)];//Khởi tạo mảng ngay khi người dùng nhập số lượng
            for (int i = 0; i < _arrMsv.Length; i++)
            {
                Console.Write($"Mời bạn nhập phần tử thứ {i}: ");
                _arrMsv[i] = Console.ReadLine();//Gán giá trị cho mảng
            }
            Console.WriteLine("Chúc mừng bạn đã nhập thành công");
        }

        private static void XuatMang()
        {
            foreach (var x in _arrMsv)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }

        private static void TimKiem()
        {
            Console.Write("Mời bạn nhập tên: ");
            _input = Console.ReadLine();
            //Cách 1:
            // foreach (var x in _arrMsv)
            // {
            //     if (x == _input)
            //     {
            //         Console.Write(x + " ");
            //         return;
            //     }
            // }

            //Cách 2: Sử dụng LINQ để tìm
            Console.WriteLine(_arrMsv.ToList().FirstOrDefault(c => c == _input));
        }

        private static void Sort()
        {
            //Cách 1: Sử dụng thuật toán nổi bọt Bubble Sort tương tự như môn C

            //Cách 2: Sử dụng LINQ để sort
            var temp = _arrMsv.ToList().OrderBy(c => c).ToArray();
            _arrMsv = temp;

            //Cách 3: Sử dụng lớp Array
            //Array.Sort(_arrMsv);
        }

        /*
         Bài 0: In bảng cửu chương theo khoảng mà người dùng nhập vào.

         Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.

         Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điều thông báo Trượt hoặt đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.

         Bài 3: Viết 1 chương trình nhập nhiều  thông tin của sinh viên POLY. Mỗi sinh viên khi nhập vào cần các thông tin sau: Tên, Năm Sinh, Msv. Sau khi người dùng nhập xong hết thông tin sinh viên cần thêm thì sẽ in tất cả ra màn hình lưu in thêm tuổi của mỗi sinh viên tương ứng.(Gợi ý mỗi thuộc tính là một mảng)

         Bài 4: Viết 1 chương trình cho phép nhập 1 mảng số nguyên. Khi nhập số nguyên vào thì sẽ nhập số mới nhất đứng ở Index 0 và đưa số ở vị trí 0 trước đó về cuối.

        */
    }
}