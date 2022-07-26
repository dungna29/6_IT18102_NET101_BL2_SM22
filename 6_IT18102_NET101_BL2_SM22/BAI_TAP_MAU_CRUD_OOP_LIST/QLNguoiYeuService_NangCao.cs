using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_CRUD_OOP_LIST
{
    internal class QLNguoiYeuService_NangCao
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
            _input = GetInputValue("bao nhiêu");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _lstNguoiYeus.Add(new NguoiYeu(GetInputValue("mã"), GetInputValue("tên"), Convert.ToInt32(GetInputValue("năm sinh")), Convert.ToInt32(GetInputValue("trạng thái (1 - Còn yêu | 2 - Không còn yêu)"))));
            }
        }

        public void UpdateNY()
        {
            int index = GetIndexByMaNY();
            if (index == -1) Console.WriteLine("Không tìm thấy");
            Console.WriteLine("Mời bạn nhập tên mới: ");
            _lstNguoiYeus[index].Ten = Console.ReadLine();
            Console.WriteLine("Sửa thành công");
        }

        public void DeleteNY()
        {
            int index = GetIndexByMaNY();
            if (index == -1) Console.WriteLine("Không tìm thấy");
            _lstNguoiYeus.RemoveAt(index);
        }

        public void TimKiemNY()
        {
            int index = GetIndexByMaNY();
            if (index == -1) Console.WriteLine("Không tìm thấy");
            _lstNguoiYeus[index].InRaManHinh();
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

        public string GetInputValue(string msg)
        {
            Console.Write($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }

        public int GetIndexByMaNY()
        {
            _input = GetInputValue("mã NY");
            for (int i = 0; i < _lstNguoiYeus.Count; i++)
            {
                if (_lstNguoiYeus[i].Ma.ToLower() == _input.ToLower())
                {
                    return i;
                }
            }
        }
    }
}