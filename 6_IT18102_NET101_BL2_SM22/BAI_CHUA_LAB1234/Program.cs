using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_CHUA_LAB1234
{
    internal class Program
    {
        /*
         Bài 0: In bảng cửu chương theo khoảng mà người dùng nhập vào.

         Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.

         Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điều thông báo Trượt hoặt đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.

         Bài 3: Viết 1 chương trình nhập nhiều  thông tin của sinh viên POLY. Mỗi sinh viên khi nhập vào cần các thông tin sau: Tên, Năm Sinh, Msv. Sau khi người dùng nhập xong hết thông tin sinh viên cần thêm thì sẽ in tất cả ra màn hình lưu in thêm tuổi của mỗi sinh viên tương ứng.(Gợi ý mỗi thuộc tính là một mảng)

         Bài 4: Viết 1 chương trình cho phép nhập 1 mảng số nguyên. Khi nhập số nguyên vào thì sẽ nhập số mới nhất đứng ở Index 0 và đưa số ở vị trí 0 trước đó về cuối.

        */

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai0();
        }

        private static void Bai4()
        {
            int[] arrNumers;
            int size;
            Console.Write("Mời bạn nhập số lượng: ");
            size = Convert.ToInt32(Console.ReadLine());
            arrNumers = new int[size];
            for (int i = 0; i < size; i++)
            {
                //i = 2
                Console.WriteLine("Mời bạn nhập số thứ " + i);
                arrNumers[i] = Convert.ToInt32(Console.ReadLine());//9
                int temp = arrNumers[0];//2
                arrNumers[0] = arrNumers[i];//9
                arrNumers[i] = temp;//2
                //9 1 2
            }
        }

        private static void Bai3()
        {
            string[] arrMaSVs, arrTens;
            int size;
            Console.Write("Mời bạn nhập số lượng sv: ");
            size = Convert.ToInt32(Console.ReadLine());
            arrMaSVs = new string[size];
            arrTens = new string[size];
            for (int i = 0; i < arrMaSVs.Length; i++)
            {
                Console.WriteLine("Mời bạn nhập tên thứ " + i);
                arrMaSVs[i] = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập msv thứ " + i);
                arrTens[i] = Console.ReadLine();
            }

            for (int i = 0; i < arrMaSVs.Length; i++)
            {
                Console.WriteLine($"Mã: {arrMaSVs[i]} - Tên: {arrTens[i]}");
            }
        }

        private static void Bai0()
        {
            //Bài 0: In bảng cửu chương theo khoảng mà người dùng nhập vào.
            int khoang1, khoang2;
            Console.Write("Mời bạn nhập khoảng 1: ");
            khoang1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập khoảng 1: ");
            khoang2 = Convert.ToInt32(Console.ReadLine());
            if (khoang1 > khoang2)
            {
                int temp = khoang1;
                khoang1 = khoang2;
                khoang2 = temp;
            }
            for (int i = khoang1; i <= khoang2; i++)//5 7
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
    }
}