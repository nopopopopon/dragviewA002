using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace dragviewA002
{
    // ソリューションエクスプローラーで追加しないと同じ名前空間名なのに、名前空間にクラスが入らない
    public class SAIKECOMMON
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

        // ディスプレイ と　画像サイズから　画面に入る適正な画像サイズを返す?
      
        public static Size SAIKEmaxWindowSize1(object sender)
        {
            Size i = new Size();
            i = (Size)sender;

            //ディスプレイの高さ
            int DispH = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            //ディスプレイの幅
            int DispW = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;



            return i;
        }


        // あるごりずむ
        // 画面より縦か横がでかい -> どちらが入る&*90%まで全体縮小
        // 画面より両方はみ出る　-> 比率が低いほうにする

    }

}