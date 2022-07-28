using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_5_KeThua
{
    internal class F2 : F1
    {
        private string thuoTinh4;

        public F2()
        {
        }

        public F2(string thuocTinh1, string thuocTinh2, string thuoTinh3, string thuoTinh4) : base(thuocTinh1, thuocTinh2, thuoTinh3)
        {
            this.thuoTinh4 = thuoTinh4;
        }
    }
}