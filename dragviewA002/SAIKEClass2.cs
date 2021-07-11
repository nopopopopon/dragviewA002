using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace dragviewA002
{
    public class SAIKEClass1
    {
        public static Size SAIKEsize(object sender)
        // 静的宣言
        {
            Size i = new Size();
            i = (Size)sender;
            i.Height = 123;
            i.Width = 987;
            return i;

            /*  利用例
                Size i = new Size(45,78);
                i = SAIKECOMMON.SAIKEsize(i);
            */
        }
    }
}
