using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_KeThua
{
    /*
     * 1. Để sử dụng kế thừa thì dùng dấu :
     * 2. C# và JAVA chỉ có đơn kế thừa
     */

    internal class SinhVien : Nguoi//Sinh viên kế thừa lớp cha là lớp Người
    {
        private string msv;
        private string nganhHoc;

        public SinhVien()
        {
        }

        //Tạo contructor có tham số
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Contructor 'ClassCon(Bên trong có tham số của thuộc tính cha)
        //3. Bôi vào các thuộc tính của con -> Quick Actions -> Add Parameter to contructor -> Chọn cái contructor có tham số vừa Generate ra.
        public SinhVien(string ten, string diaChi, string sdt, string ns, string msv, string nganhHoc) : base(ten, diaChi, sdt, ns)
        {
            this.msv = msv;
            this.nganhHoc = nganhHoc;
            //this: Dùng để tham chiếu đến thuộc tính và phương thức của lớp hiện tại
            //base: Dùng để tham chiếu đến thuộc tính và phương thức của lớp cha
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string NganhHoc
        {
            get => nganhHoc;
            set => nganhHoc = value;
        }

        //Tính chất Đa Hình OOP
        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa
        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.
        public override void InRaManHinh()
        {
            Console.WriteLine("Nội dung mới lớp sinh viên");
        }

        public override void Method1()
        {
            base.Method1();
        }
    }
}