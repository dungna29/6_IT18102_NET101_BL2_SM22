using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_Methoa
{
    internal class Method_TraVe
    {
        /*
          *  Phương thức trả về là :
          *   Công thức chung:
          *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
          *  {
          *          Body code
          *          return <Kiểu trả về của phương thức>
          *  }
          */
        /*
        * Hướng dẫn sử dụng:
        *      1. Phương thức phải có kiểu trả về là các kiểu dữ liệu...
        *      2. Phải Sử dụng return <giá trị hoặc tập giá trị> đúng với kiểu dữ liệu
        */

        //Ví dụ 1:
        public int TinhTong(int a, int b)
        {
            return a + b;
        }

        //Ví dụ 2: 1 Mảng năm sinh từ 1800 => 2022
        public List<int> GetNamSinhs()
        {
            List<int> list = new List<int>();
            for (int i = 1800; i <= 2022; i++)
            {
                list.Add(i);
            }
            return list;
        }

        //Các tham số tương tự như bên bài void
    }
}