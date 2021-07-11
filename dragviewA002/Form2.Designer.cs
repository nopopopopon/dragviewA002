namespace dragviewA002
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2A = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2A)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2A
            // 
            this.pictureBox2A.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2A.MaximumSize = new System.Drawing.Size(1100, 790);
            this.pictureBox2A.Name = "pictureBox2A";
            this.pictureBox2A.Size = new System.Drawing.Size(767, 628);
            this.pictureBox2A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2A.TabIndex = 0;
            this.pictureBox2A.TabStop = false;
            this.pictureBox2A.WaitOnLoad = true;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.pictureBox2A);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResizeEnd += new System.EventHandler(this.Form2_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2A)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox2A;
    }
}