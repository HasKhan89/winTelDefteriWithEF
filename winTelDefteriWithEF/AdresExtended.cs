using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winTelDefteriWithEF
{
    public partial class Adres
    {
        public override string ToString()
        {
            // Eğer adrestanim özelliğinin değeri 10 karakterden büyük ise,
            // ilk 10 karakteri al ve sonuna "..." ekle..
            // aksi halde(10 karakterden az yada eşit ise) hepsini al.
            if(AdresTanim.Length > 10)
            {
                return AdresTanim.Substring(0, 10) + "...";
            }
            else
            {
                return AdresTanim;
            }
        }
    }
}
