using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_CRUD_OOP_LIST
{
    internal class QLNguoiYeuService
    {
        //Nơi code các chức năng quản lý
        //Tất cả các biến toàn cục phải đặt lên đầu và dấu _
        private List<NguoiYeu> _lstNguoiYeus;

        private string _input;
        private NguoiYeu _nguoiYeu;

        public QLNguoiYeuService()
        {
            _lstNguoiYeus = new List<NguoiYeu>();
            FakeNY();//Khi khởi tạo lớp chức năng List sẽ luôn có phần tử bên trong
        }

        private void FakeNY()
        {
            _lstNguoiYeus = new List<NguoiYeu>()
            {
                new NguoiYeu("NY1","A",2000,1),
                new NguoiYeu("NY2","B",2000,0),
                new NguoiYeu("NY3","C",2002,1),
                new NguoiYeu("NY4","C",2003,0),
                new NguoiYeu("NY5","B",2001,1)
            };
        }

        public void ThemNY()
        {
            Console.Write("Bạn muốn thêm bao nhiêu: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _nguoiYeu = new NguoiYeu();
                Console.Write("Mời bạn nhập mã: ");
                _nguoiYeu.Ma = Console.ReadLine();
                Console.Write("Mời bạn nhập tên: ");
                _nguoiYeu.Ten = Console.ReadLine();
                Console.Write("Mời bạn nhập năm sinh: ");
                _nguoiYeu.Ns = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập trạng thái (1 - Còn yêu | 2 - Không còn yêu): ");
                _nguoiYeu.TrangThai = Convert.ToInt32(Console.ReadLine());
                _lstNguoiYeus.Add(_nguoiYeu);
            }
        }

        public void UpdateNY()
        {
            Console.Write("Mời bạn nhập mã NY: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNguoiYeus.Count; i++)
            {
                if (_lstNguoiYeus[i].Ma.ToLower() == _input.ToLower())
                {
                    Console.WriteLine("Mời bạn nhập tên mới: ");
                    _lstNguoiYeus[i].Ten = Console.ReadLine();
                    Console.WriteLine("Sửa thành công");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy");
        }

        public void DeleteNY()
        {
            Console.Write("Mời bạn nhập mã NY: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNguoiYeus.Count; i++)
            {
                if (_lstNguoiYeus[i].Ma.ToLower() == _input.ToLower())
                {
                    _lstNguoiYeus.RemoveAt(i);
                    Console.WriteLine("Xóa thành công");
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy");
        }

        public void TimKiemNY()
        {
            Console.Write("Mời bạn nhập mã NY: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNguoiYeus.Count; i++)
            {
                if (_lstNguoiYeus[i].Ma.ToLower() == _input.ToLower())
                {
                    _lstNguoiYeus[i].InRaManHinh();
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy");
        }

        public void XuatDs()
        {
            if (_lstNguoiYeus.Count <= 0)
            {
                Console.WriteLine("Rất tiếc bạn không có NY mà in");
                return;
            }
            foreach (var x in _lstNguoiYeus)
            {
                x.InRaManHinh();
            }
        }

        public void LocTrangThaiNY()
        {
            if (_lstNguoiYeus.Count <= 0)
            {
                Console.WriteLine("Rất tiếc bạn không có NY mà lọc");
                return;
            }
            foreach (var x in _lstNguoiYeus.OrderByDescending(c => c.TrangThai))
            {
                x.InRaManHinh();
            }
        }
    }
}