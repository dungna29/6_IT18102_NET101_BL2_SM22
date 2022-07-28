using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_KeThua
{
    internal class F1 : F0
    {
        private string thuoTinh3;

        public F1()
        {
        }

        public F1(string thuocTinh1, string thuocTinh2, string thuoTinh3) : base(thuocTinh1, thuocTinh2)
        {
            this.thuoTinh3 = thuoTinh3;
        }
    }
}