namespace ImgMng
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.textBoxFiNa = new System.Windows.Forms.TextBox();
            this.buttonFS = new System.Windows.Forms.Button();
            this.buttonSt = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxFiNa
            // 
            this.textBoxFiNa.Location = new System.Drawing.Point(12, 14);
            this.textBoxFiNa.Name = "textBoxFiNa";
            this.textBoxFiNa.Size = new System.Drawing.Size(285, 19);
            this.textBoxFiNa.TabIndex = 0;
            // 
            // buttonFS
            // 
            this.buttonFS.Location = new System.Drawing.Point(303, 12);
            this.buttonFS.Name = "buttonFS";
            this.buttonFS.Size = new System.Drawing.Size(75, 23);
            this.buttonFS.TabIndex = 1;
            this.buttonFS.Text = "ファイル選択";
            this.buttonFS.UseVisualStyleBackColor = true;
            this.buttonFS.Click += new System.EventHandler(this.buttonFS_Click);
            // 
            // buttonSt
            // 
            this.buttonSt.Location = new System.Drawing.Point(129, 39);
            this.buttonSt.Name = "buttonSt";
            this.buttonSt.Size = new System.Drawing.Size(75, 23);
            this.buttonSt.TabIndex = 2;
            this.buttonSt.Text = "開始";
            this.buttonSt.UseVisualStyleBackColor = true;
            this.buttonSt.Click += new System.EventHandler(this.buttonSt_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(13, 76);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(284, 19);
            this.textBoxOut.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 107);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.buttonSt);
            this.Controls.Add(this.buttonFS);
            this.Controls.Add(this.textBoxFiNa);
            this.Name = "Form1";
            this.Text = "ImgMng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFiNa;
        private System.Windows.Forms.Button buttonFS;
        private System.Windows.Forms.Button buttonSt;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

