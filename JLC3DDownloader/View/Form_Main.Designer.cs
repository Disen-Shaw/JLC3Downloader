namespace JLC3DDownloader
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.toolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.tsBtn_SelectSavePath = new System.Windows.Forms.ToolStripButton();
            this.tsTxtBx_SelectSavePath = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtn_TopMost = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.grpBx_CSVDownload = new System.Windows.Forms.GroupBox();
            this.btn_CSVDownload = new System.Windows.Forms.Button();
            this.btn_CSVSelect = new System.Windows.Forms.Button();
            this.txtBx_CSVPath = new System.Windows.Forms.TextBox();
            this.grpBx_SignalDownload = new System.Windows.Forms.GroupBox();
            this.txtBx_SignalDownloadText = new System.Windows.Forms.TextBox();
            this.btn_SignalDownload = new System.Windows.Forms.Button();
            this.txtBx_ObjectCode = new System.Windows.Forms.TextBox();
            this.pnl_Log = new System.Windows.Forms.Panel();
            this.txtBx_Log = new System.Windows.Forms.TextBox();
            this.toolStrip_Main.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.grpBx_CSVDownload.SuspendLayout();
            this.grpBx_SignalDownload.SuspendLayout();
            this.pnl_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_Main
            // 
            this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_SelectSavePath,
            this.tsTxtBx_SelectSavePath,
            this.tsBtn_TopMost,
            this.toolStripSeparator2});
            this.toolStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Main.Name = "toolStrip_Main";
            this.toolStrip_Main.Size = new System.Drawing.Size(644, 25);
            this.toolStrip_Main.TabIndex = 0;
            this.toolStrip_Main.Text = "toolStrip1";
            // 
            // tsBtn_SelectSavePath
            // 
            this.tsBtn_SelectSavePath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtn_SelectSavePath.Font = new System.Drawing.Font("黑体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtn_SelectSavePath.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_SelectSavePath.Image")));
            this.tsBtn_SelectSavePath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_SelectSavePath.Name = "tsBtn_SelectSavePath";
            this.tsBtn_SelectSavePath.Size = new System.Drawing.Size(95, 22);
            this.tsBtn_SelectSavePath.Text = "选择保存目录";
            this.tsBtn_SelectSavePath.Click += new System.EventHandler(this.tsBtn_SelectSavePath_Click);
            // 
            // tsTxtBx_SelectSavePath
            // 
            this.tsTxtBx_SelectSavePath.Font = new System.Drawing.Font("黑体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsTxtBx_SelectSavePath.Name = "tsTxtBx_SelectSavePath";
            this.tsTxtBx_SelectSavePath.ReadOnly = true;
            this.tsTxtBx_SelectSavePath.Size = new System.Drawing.Size(500, 25);
            // 
            // tsBtn_TopMost
            // 
            this.tsBtn_TopMost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtn_TopMost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtn_TopMost.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_TopMost.Image")));
            this.tsBtn_TopMost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_TopMost.Name = "tsBtn_TopMost";
            this.tsBtn_TopMost.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_TopMost.Text = "-";
            this.tsBtn_TopMost.ToolTipText = "显示在最上层";
            this.tsBtn_TopMost.Click += new System.EventHandler(this.tsBtn_TopMost_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pnl_Main
            // 
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Main.Controls.Add(this.grpBx_CSVDownload);
            this.pnl_Main.Controls.Add(this.grpBx_SignalDownload);
            this.pnl_Main.Controls.Add(this.pnl_Log);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 25);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(644, 188);
            this.pnl_Main.TabIndex = 1;
            // 
            // grpBx_CSVDownload
            // 
            this.grpBx_CSVDownload.Controls.Add(this.btn_CSVDownload);
            this.grpBx_CSVDownload.Controls.Add(this.btn_CSVSelect);
            this.grpBx_CSVDownload.Controls.Add(this.txtBx_CSVPath);
            this.grpBx_CSVDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBx_CSVDownload.Location = new System.Drawing.Point(301, 0);
            this.grpBx_CSVDownload.Name = "grpBx_CSVDownload";
            this.grpBx_CSVDownload.Size = new System.Drawing.Size(339, 74);
            this.grpBx_CSVDownload.TabIndex = 2;
            this.grpBx_CSVDownload.TabStop = false;
            this.grpBx_CSVDownload.Text = "CSV文件下载";
            // 
            // btn_CSVDownload
            // 
            this.btn_CSVDownload.Location = new System.Drawing.Point(169, 46);
            this.btn_CSVDownload.Name = "btn_CSVDownload";
            this.btn_CSVDownload.Size = new System.Drawing.Size(160, 22);
            this.btn_CSVDownload.TabIndex = 1;
            this.btn_CSVDownload.Text = "CSV下载";
            this.btn_CSVDownload.UseVisualStyleBackColor = true;
            this.btn_CSVDownload.Click += new System.EventHandler(this.btn_CSVDownload_Click);
            // 
            // btn_CSVSelect
            // 
            this.btn_CSVSelect.Location = new System.Drawing.Point(3, 46);
            this.btn_CSVSelect.Name = "btn_CSVSelect";
            this.btn_CSVSelect.Size = new System.Drawing.Size(160, 22);
            this.btn_CSVSelect.TabIndex = 1;
            this.btn_CSVSelect.Text = "文件选择";
            this.btn_CSVSelect.UseVisualStyleBackColor = true;
            this.btn_CSVSelect.Click += new System.EventHandler(this.btn_CSVSelect_Click);
            // 
            // txtBx_CSVPath
            // 
            this.txtBx_CSVPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBx_CSVPath.Location = new System.Drawing.Point(3, 18);
            this.txtBx_CSVPath.Name = "txtBx_CSVPath";
            this.txtBx_CSVPath.ReadOnly = true;
            this.txtBx_CSVPath.Size = new System.Drawing.Size(333, 22);
            this.txtBx_CSVPath.TabIndex = 0;
            // 
            // grpBx_SignalDownload
            // 
            this.grpBx_SignalDownload.Controls.Add(this.txtBx_SignalDownloadText);
            this.grpBx_SignalDownload.Controls.Add(this.btn_SignalDownload);
            this.grpBx_SignalDownload.Controls.Add(this.txtBx_ObjectCode);
            this.grpBx_SignalDownload.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBx_SignalDownload.Location = new System.Drawing.Point(0, 0);
            this.grpBx_SignalDownload.Name = "grpBx_SignalDownload";
            this.grpBx_SignalDownload.Size = new System.Drawing.Size(301, 74);
            this.grpBx_SignalDownload.TabIndex = 1;
            this.grpBx_SignalDownload.TabStop = false;
            this.grpBx_SignalDownload.Text = "简单下载";
            // 
            // txtBx_SignalDownloadText
            // 
            this.txtBx_SignalDownloadText.Location = new System.Drawing.Point(6, 18);
            this.txtBx_SignalDownloadText.Name = "txtBx_SignalDownloadText";
            this.txtBx_SignalDownloadText.Size = new System.Drawing.Size(289, 22);
            this.txtBx_SignalDownloadText.TabIndex = 2;
            this.txtBx_SignalDownloadText.Text = "元件备注";
            // 
            // btn_SignalDownload
            // 
            this.btn_SignalDownload.Location = new System.Drawing.Point(212, 46);
            this.btn_SignalDownload.Name = "btn_SignalDownload";
            this.btn_SignalDownload.Size = new System.Drawing.Size(83, 22);
            this.btn_SignalDownload.TabIndex = 1;
            this.btn_SignalDownload.Text = "下载";
            this.btn_SignalDownload.UseVisualStyleBackColor = true;
            this.btn_SignalDownload.Click += new System.EventHandler(this.btn_SignalDownload_Click);
            // 
            // txtBx_ObjectCode
            // 
            this.txtBx_ObjectCode.Location = new System.Drawing.Point(6, 46);
            this.txtBx_ObjectCode.Name = "txtBx_ObjectCode";
            this.txtBx_ObjectCode.Size = new System.Drawing.Size(200, 22);
            this.txtBx_ObjectCode.TabIndex = 0;
            // 
            // pnl_Log
            // 
            this.pnl_Log.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Log.Controls.Add(this.txtBx_Log);
            this.pnl_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Log.Location = new System.Drawing.Point(0, 74);
            this.pnl_Log.Name = "pnl_Log";
            this.pnl_Log.Size = new System.Drawing.Size(640, 110);
            this.pnl_Log.TabIndex = 0;
            // 
            // txtBx_Log
            // 
            this.txtBx_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBx_Log.Location = new System.Drawing.Point(0, 0);
            this.txtBx_Log.Multiline = true;
            this.txtBx_Log.Name = "txtBx_Log";
            this.txtBx_Log.ReadOnly = true;
            this.txtBx_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_Log.Size = new System.Drawing.Size(636, 106);
            this.txtBx_Log.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 213);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.toolStrip_Main);
            this.Font = new System.Drawing.Font("黑体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Main";
            this.Text = "嘉立创3D封装下载器_V1.0.0";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.toolStrip_Main.ResumeLayout(false);
            this.toolStrip_Main.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.grpBx_CSVDownload.ResumeLayout(false);
            this.grpBx_CSVDownload.PerformLayout();
            this.grpBx_SignalDownload.ResumeLayout(false);
            this.grpBx_SignalDownload.PerformLayout();
            this.pnl_Log.ResumeLayout(false);
            this.pnl_Log.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_Main;
        private System.Windows.Forms.ToolStripButton tsBtn_SelectSavePath;
        private System.Windows.Forms.ToolStripTextBox tsTxtBx_SelectSavePath;
        private System.Windows.Forms.ToolStripButton tsBtn_TopMost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Log;
        private System.Windows.Forms.TextBox txtBx_Log;
        private System.Windows.Forms.GroupBox grpBx_SignalDownload;
        private System.Windows.Forms.TextBox txtBx_ObjectCode;
        private System.Windows.Forms.Button btn_SignalDownload;
        private System.Windows.Forms.GroupBox grpBx_CSVDownload;
        private System.Windows.Forms.TextBox txtBx_CSVPath;
        private System.Windows.Forms.Button btn_CSVSelect;
        private System.Windows.Forms.Button btn_CSVDownload;
        private System.Windows.Forms.TextBox txtBx_SignalDownloadText;
    }
}

