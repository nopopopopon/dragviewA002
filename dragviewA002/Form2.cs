using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dragviewA002
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void Form2_ResizeEnd(object sender,EventArgs e)
        {
            // 有効化には　プロパティにイベントを張り付ける必要がある by SAIKE


            //変更後Form2サイズを取得
            int width = Form2.ActiveForm.Size.Width;
            int height = Form2.ActiveForm.Size.Height;

            // 操作対象Formを拾う
            Form2 ff = (Form2 )sender;  
            
            // From2にあわせて画像を伸縮
            double Hiritu_w = (double )width / (double )ff.pictureBox2A.Width;
            double Hiritu_h = (double )height / (double )ff.pictureBox2A.Height;
            double Hiritu_min;  // より小さい比率を入れる用

            if (Hiritu_w <= Hiritu_h) 
            {
                Hiritu_min = Hiritu_w; 
            } else {
                Hiritu_min = Hiritu_h;
            }

            //ff.pictureBox2Aのsizemodeをzoomにする必要がある。Autosizeだと数字変更不可
            
            ff.pictureBox2A.Width = (int )(ff.pictureBox2A.Width * Hiritu_min);  // pictBOXを伸縮
            ff.pictureBox2A.Height = (int)(ff.pictureBox2A.Height * Hiritu_min);

            
            ff.pictureBox2A.Show();
            ff.Show();

            //結果表示
            string str2 = "Form2サイズ: " + width.ToString() + " × " + height.ToString();
            string str1 = " PictBoxサイズ: " + pictureBox2A.Width.ToString() + " × " + pictureBox2A.Height.ToString();
            MessageBox.Show("ユーザーがフォームの移動またはサイズ変更を終了しました" + str2+str1);
        }
    }
}
