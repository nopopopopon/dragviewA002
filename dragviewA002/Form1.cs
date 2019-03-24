using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dragviewA002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBoxSaike1.AllowDrop = true;  // ここで書かないとエラーになる
        }

        // public class Form2 : Form
        

        /*
 *  pictureBox1イベント 
 */
        private void PictureBoxSaike1_DragEnter(object sender, DragEventArgs e)
        {
            // これをPictureboxSaike1のイベントに登録されてなかったら登録しないと反応しない
            this.ToggleEffectsToDragEvent(e);
        }
        private void PictureBoxSaike1_DragDrop(object sender, DragEventArgs e)
        {
            // これをPictureboxSaike1のイベントに登録されてなかったら登録しないと反応しない
            string fileName = this.GetFileNameToDragEvent(e);
            this.ShowPicture(fileName);
        }
        //ローカルメソッド
        //ドラッグしてきたものがファイルであるなら全てのイベントを受け(copy)、ファイルでないならすべてのイベントを受け付けない
        private void ToggleEffectsToDragEvent(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;

         }
        //ファイルのパスを取得する
        private string GetFileNameToDragEvent(DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (System.IO.File.Exists(fileName[0]) == true)
            {
                return fileName[0];
            }
            else
            {
                return null;
            }
        }
        //pictureBox1にfileNameを与える
        private void ShowPicture(string fileName)
        {
            pictureBoxSaike1.ImageLocation = fileName;

            // ここで　listboxにfilenameを入れる
            listBoxSaike1.Items.Add(fileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

       

        }

        private void pictureBoxSaike1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1A_Click(object sender, EventArgs e)
        {
            // 選択画像表示ボタン1Aがおされたら　画像表示用フォームをloadして表示
            for (int i = 0; i < listBoxSaike1.SelectedItems.Count; i++)
            {
                //Form2クラスのインスタンスを作成する
                Form2 f = new Form2();
                //Form2を表示する
                //ここではモードレスフォームとして表示する

                // リサイズする属性をセット
                // f.FormBorderStyle = FormBorderStyle.Sizable;  // これは効果なしだった
                // 解決法:Form2のSizeGripStyleを強制的にShowにする
                
                f.Show();
                // 先にForm2のPictureBoxをpublic設定にしておかないと下で呼べない
                f.pictureBox2A.ImageLocation = listBoxSaike1.SelectedItems[i].ToString();

                //ディスプレイの高さ
                int h = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
                //ディスプレイの幅
                int w = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;

                //画像データを読み込む
                Bitmap img = new Bitmap(Image.FromFile(listBoxSaike1.SelectedItems[i].ToString()));
                
                //画像サイズを取得
                int width = img.Width;
                int height = img.Height;

                // 表示するウィンドウサイズ
                f.Size = new Size(width,height) ;  // 初期値は画像サイズとする。Size構造体定義して代入
                f.pictureBox2A.Size = new Size(width, height);

                if (width > w) {
                    //　イメージがディスプレイより大きいならディスプレイ大でカット
                    f.Width = w;
                    f.pictureBox2A.Width = w;
                } else
                {
                    f.Width = width;
                }
                if (height > h)
                {
                    f.Height = h;
                    f.pictureBox2A.Height = h;
                }
                else
                {
                    f.Height = height;
                }

                //結果表示
                string str1 = "画面最大サイズ: "+ w.ToString() +" × " + h.ToString();
                string str2 = "画像サイズ: " + width.ToString() + " × " + height.ToString();
                string str3 = "Formサイズ: " + f.Width.ToString() + " × " + f.Height.ToString();
                MessageBox.Show(str1 + str2+str3);

                f.Show();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンREADをクリック
            string path = @"Z:\tmpProG\SAIKETestList.txt";

            // This text is added only once to the file.
            if (File.Exists(path))
            {
                // Create a file to write to.
                string[] str1;
                

                str1 = (File.ReadAllLines(path));
                // int i = str1.Length;


                // 1要素ずつ転記 
                // はいれつ.lengthで要素数を返す
                for (int i=0; i < str1.Length ; i++)
                {
                    listBoxSaike1.Items.Add(str1[i]);
                }
                
            } else
            {
                //メッセージボックスを表示する
                MessageBox.Show("ファイルが見つかりません",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ボタンWRITEをクリック

            string path = @"Z:\tmpProG\SAIKETestList.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                File.WriteAllLines(path, listBoxSaike1.Items.OfType<string>());

                //File.WriteAllLines(path,listBoxSaike1.Items[].ToString);
            } else
            {
                // Create a file to write to.
                File.WriteAllLines(path, listBoxSaike1.Items.OfType<string>());

            }

        }

        private void ListBoxSaike1_click(object sender, EventArgs e)
        {
            // listBoxのプロパティのイベントに登録してリンクしないと反応しない

        }


        // マウスからクリック項目を拾うって左にサンプル画像を出す
        //　画像伸縮はPictureboxのプロパティでZoom選択で自動対応
        void ListBoxSaike1_MouseUp(object sender, MouseEventArgs e)
        {
            // 左クリックされた？
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                // マウス座標から選択すべきアイテムのインデックスを取得
                int index = listBoxSaike1.IndexFromPoint(e.Location);

                // インデックスが取得できたら
                if (index >= 0)
                {
                    // string str1 = listBoxSaike1.Items[index].ToString();
                    // MessageBox.Show("File選択:" + str1);

                    pictureBoxSaike1.ImageLocation = listBoxSaike1.Items[index].ToString();  //画像名セット
                    pictureBoxSaike1.Show();
                }
            }
        }

    }
}
