namespace SpeakerChanger
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ChangerIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ChangerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // ChangerIcon
            // 
            this.ChangerIcon.ContextMenuStrip = this.ChangerContextMenu;
            this.ChangerIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ChangerIcon.Icon")));
            this.ChangerIcon.Text = "音声出力変更";
            this.ChangerIcon.Visible = true;
            this.ChangerIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangerIcon_Click);
            // 
            // ChangerContextMenu
            // 
            this.ChangerContextMenu.Name = "contextMenuStrip1";
            this.ChangerContextMenu.ShowCheckMargin = true;
            this.ChangerContextMenu.ShowImageMargin = false;
            this.ChangerContextMenu.Size = new System.Drawing.Size(61, 4);
            this.ChangerContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Item_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ChangerIcon;
        private System.Windows.Forms.ContextMenuStrip ChangerContextMenu;
    }
}

