namespace dragviewA002
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxSaike1 = new System.Windows.Forms.PictureBox();
            this.listBoxSaike1 = new System.Windows.Forms.ListBox();
            this.button1A = new System.Windows.Forms.Button();
            this.buttonREAD = new System.Windows.Forms.Button();
            this.buttonWRITE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaike1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSaike1
            // 
            this.pictureBoxSaike1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSaike1.Image")));
            this.pictureBoxSaike1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSaike1.InitialImage")));
            this.pictureBoxSaike1.Location = new System.Drawing.Point(13, 28);
            this.pictureBoxSaike1.Name = "pictureBoxSaike1";
            this.pictureBoxSaike1.Size = new System.Drawing.Size(486, 410);
            this.pictureBoxSaike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSaike1.TabIndex = 0;
            this.pictureBoxSaike1.TabStop = false;
            this.pictureBoxSaike1.Click += new System.EventHandler(this.pictureBoxSaike1_Click);
            this.pictureBoxSaike1.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBoxSaike1_DragDrop);
            this.pictureBoxSaike1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBoxSaike1_DragEnter);
            // 
            // listBoxSaike1
            // 
            this.listBoxSaike1.AllowDrop = true;
            this.listBoxSaike1.FormattingEnabled = true;
            this.listBoxSaike1.ItemHeight = 12;
            this.listBoxSaike1.Location = new System.Drawing.Point(521, 28);
            this.listBoxSaike1.Name = "listBoxSaike1";
            this.listBoxSaike1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSaike1.Size = new System.Drawing.Size(267, 400);
            this.listBoxSaike1.TabIndex = 1;
            this.listBoxSaike1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBoxSaike1_MouseUp);
            // 
            // button1A
            // 
            this.button1A.Location = new System.Drawing.Point(521, 435);
            this.button1A.Name = "button1A";
            this.button1A.Size = new System.Drawing.Size(97, 34);
            this.button1A.TabIndex = 2;
            this.button1A.Text = "選択画像表示";
            this.button1A.UseVisualStyleBackColor = true;
            this.button1A.Click += new System.EventHandler(this.button1A_Click);
            // 
            // buttonREAD
            // 
            this.buttonREAD.Location = new System.Drawing.Point(625, 435);
            this.buttonREAD.Name = "buttonREAD";
            this.buttonREAD.Size = new System.Drawing.Size(75, 34);
            this.buttonREAD.TabIndex = 3;
            this.buttonREAD.Text = "リスト読込み";
            this.buttonREAD.UseVisualStyleBackColor = true;
            this.buttonREAD.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWRITE
            // 
            this.buttonWRITE.Location = new System.Drawing.Point(707, 435);
            this.buttonWRITE.Name = "buttonWRITE";
            this.buttonWRITE.Size = new System.Drawing.Size(75, 34);
            this.buttonWRITE.TabIndex = 4;
            this.buttonWRITE.Text = "リスト書出し";
            this.buttonWRITE.UseVisualStyleBackColor = true;
            this.buttonWRITE.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.buttonWRITE);
            this.Controls.Add(this.buttonREAD);
            this.Controls.Add(this.button1A);
            this.Controls.Add(this.listBoxSaike1);
            this.Controls.Add(this.pictureBoxSaike1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaike1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSaike1;
        public System.Windows.Forms.PictureBox pictureBoxSaike1;
        private System.Windows.Forms.Button button1A;
        private System.Windows.Forms.Button buttonREAD;
        private System.Windows.Forms.Button buttonWRITE;
    }
}

