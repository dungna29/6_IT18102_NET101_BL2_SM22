using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_6_ToanTuBaNgoi
{
    internal class Program
    {
        /*
    * TOÁN TỬ 3 NGÔI
    * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string temp1 = 9 > 6 ? "Đúng" : "Sai";
            int temp2 = 9 > 6 ? 1 : 0;
            bool temp3 = 9 > 6 ? false : true;
            double temp4 = 9 > 6 ? 1.0 : 0.0;

            /*
            * Bài tập: Viết 1 chương trình khi nhập thông tin 1 người xác định được là ANH, CHỊ, EM Trai,Em Gái, BẠN
            * Cố định lại Tuổi và Giới Tính của bản thân
            */
            int namSinhBanThan = 2002, gioiTinh = 1;//Cố định 1 = Nam | 0 = Nữ
            //Yêu cầu nhập vào TÊN - NĂM SINH - GIỚI TÍNH có thể xác định được tên gọi như ở trên.
            string tenBan;
            int gtBan, nsBan;
            while (true)
            {
                Console.Write("Mời bạn nhập tên: ");
                tenBan = Console.ReadLine();
                Console.Write("Mời bạn nhập năm sinh: ");
                nsBan = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập giới tính: (1-Nam|0-Nữ)");
                gtBan = Convert.ToInt32(Console.ReadLine());
                
                string temp = (namSinhBanThan > nsBan && gtBan == 1) ? "Anh" :
                    (namSinhBanThan > nsBan && gtBan == 0) ? "Chị" :
                    (namSinhBanThan < nsBan && gtBan == 1) ? "Em Trai" :
                    (namSinhBanThan < nsBan && gtBan == 0) ? "Em Gái" :
                    "Bạn";

                Console.WriteLine($"Chào {temp} {tenBan}");
            }
        }
    }
}
