using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_CRUD_OOP_LIST
{
    internal class Program
    {
        //Menu
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            QLNguoiYeuService ny = new QLNguoiYeuService();
            string input;
            do
            {
                Console.WriteLine("Chức năng quản lý NY.");
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Lọc");
                Console.WriteLine("6. Xuất Ds");
                Console.WriteLine("7. Thoát");
                Console.Write("Mời bạn chọn: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ny.ThemNY();
                        break;

                    case "2":
                        ny.UpdateNY();
                        break;

                    case "3":
                        ny.DeleteNY();
                        break;

                    case "4":
                        ny.TimKiemNY();
                        break;

                    case "5":
                        ny.LocTrangThaiNY();
                        break;

                    case "6":
                        ny.XuatDs();
                        break;

                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            } while (input != "7");
        }
    }
}