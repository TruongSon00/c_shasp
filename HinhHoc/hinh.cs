using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    internal interface hinh
    {

        int width { get; set; }
        int height { get; set; }

        void NhapTT();

        string HienThi();


        int area(int width, int height);

        int perimeter(int width, int height);

    }
}
