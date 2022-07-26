using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_2_4_Methoa;

namespace BAI_2_4_Method
{
    internal class Program
    {  /*
       *  Bài 2.9 Phương thức - Method
       *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
       *  LỢI ÍCH: - Giúp quản lý code tốt hơn
       *           - Tái sử dụng
       *
       *  Công thức chung:
       *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
       *  {
       *          Body code
       *  }
         *
       * <Phạm vi truy cập> - Access Specifier:Public,Private,Protected, Default, Internal
       *
       * <Kiểu trả về> : có 2 kiểu trả về và không trả về
       *          - Kiểu không trả về: void
       *          - Kiểu trả về: là giá trị đơn(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
       *
       * <Tên phương thức>: Tên động từ viết thường + tên.
       * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số và kiểu dữ liệu.

        PHƯƠNG THỨC KHÔNG ĐƯỢC TRÙNG TÊN NHƯNG ĐƯỢC PHÉP TRÙNG TÊN VÀ KHÁC THAM SỐ
       */

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phương thức void

            //Phần 1: Muốn gọi 1 phương thức là cần biết phương đó tên là gì và nằm ở class nào.
            MethodVoid mt = new MethodVoid();//Phương thức nằm ở đây
            mt.TinhTong2So();//Gọi đến phương thức cần sử dụng và kết thúc bằng dấu ();

            //Phương thức có tham số lưu ý:
            /*
             * 1. Truyền tham số đúng theo vị trí
             * 2. Đúng kiểu dữ liệu
             * 3. Truyền đủ tham số đầu vào không được thiếu.
             * 4. Đối với phương thức nạp chồng thì số lượng tham số và kiểu dữ liệu sẽ quyết định gọi đến phương thức nào
             */
            //mt.TinhTong(1); Sai vì thiếu tham số
            mt.TinhTong();//Đang gọi đến method TinhTong() không tham số
            mt.TinhTong(1, "1");
            mt.TinhTong(1, 2, 3);

            #endregion Phương thức void

            #region Phương thức trả về

            //Hãy coi phương thức trả về như 1 giá trị có kiểu dữ liệu và sử dụng nó như những gì đã được học
            Method_TraVe mtv = new Method_TraVe();
            List<int> lst123 = mtv.GetNamSinhs();

            for (int i = 0; i < mtv.GetNamSinhs().Count; i++)
            {
                Console.WriteLine(mtv.GetNamSinhs()[i]);
            }

            #endregion Phương thức trả về
        }
    }
}