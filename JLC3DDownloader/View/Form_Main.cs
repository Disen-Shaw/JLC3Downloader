using JLC3DDownloader.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLC3DDownloader
{
    public partial class Form_Main : Form
    {
        #region 私有成员

        /// <summary>
        /// 文件保存路径
        /// </summary>
        private string _fileSavePath;

        /// <summary>
        /// CSV 文件目录
        /// </summary>
        private string _csvFilePath;

        private Spider _sp;

        #endregion

        #region 私有方法

        /// <summary>
        /// 添加 Log 信息
        /// </summary>
        /// <param name="logInfo"></param>
        private void LogAppend(string logInfo)
        {
            if (txtBx_Log.InvokeRequired)
            {
                LogAppendDelegate stcb = new LogAppendDelegate(LogAppend);
                Invoke(stcb, new object[] { logInfo });
            }
            else
            {
                txtBx_Log.AppendText("[ " + DateTime.Now.ToString() + " ]" + "\t\t\t\t" + logInfo + "\r\n");
            }
        }

        /// <summary>
        /// 清除 Log 信息
        /// </summary>
        private void LogClear()
        {
            if (txtBx_Log.InvokeRequired)
            {
                LogClearDelegate stcb = new LogClearDelegate(LogClear);
                Invoke(stcb, new object { });
            }
            else
            {
                txtBx_Log.Clear();
            }
        }

        #endregion

        #region 公有方法
        public Form_Main()
        {
            InitializeComponent();
        }

        #endregion

        #region 控件回调

        /// <summary>
        /// 主界面加载回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            _sp = new Spider();
            _sp.SpiderOperationCallback += LogAppend;
        }

        /// <summary>
        /// 选择保存目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtn_SelectSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(fbd.SelectedPath))
                {
                    _fileSavePath = fbd.SelectedPath;
                    LogAppend("下载目录设置成功");
                    tsTxtBx_SelectSavePath.Text = _fileSavePath;
                }
                else
                {
                    LogAppend("下载目录设置失败");
                }
            }
        }

        /// <summary>
        /// 选择最上层显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtn_TopMost_Click(object sender, EventArgs e)
        {
            if (TopMost)
            {
                TopMost = false;
                tsBtn_TopMost.BackColor = SystemColors.Window;
                tsBtn_TopMost.ToolTipText = "普通层级显示";
                LogAppend("已设置为普通层级显示");
            }
            else
            {
                TopMost = true;
                tsBtn_TopMost.BackColor = Color.LightSkyBlue;
                tsBtn_TopMost.ToolTipText = "显示在最上层";
                LogAppend("已设置到最上层显示");
            }
        }

        /// <summary>
        /// 简单下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SignalDownload_Click(object sender, EventArgs e)
        {
            if (!(tsTxtBx_SelectSavePath.Text == ""))
            {
                if (!(txtBx_ObjectCode.Text == ""))
                {
                    _sp.Download(txtBx_ObjectCode.Text, txtBx_SignalDownloadText.Text, _fileSavePath);
                } 
                else
                {
                    LogAppend("请输入元件编码");
                }
            } 
            else
            {
                LogAppend("请先选择下载目录");
            }
        }

        /// <summary>
        /// CSV 文件下载 [.csv 格式: 原件编码, 备注名称]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CSVDownload_Click(object sender, EventArgs e)
        {
            if (!(tsTxtBx_SelectSavePath.Text == ""))
            {
                if (!(txtBx_CSVPath.Text == ""))
                {
                    var lines = File.ReadAllLines(_csvFilePath);
                    var data = from line in lines
                               let values = line.Split(',')
                               select new
                               {
                                   name = values[0],
                                   code = values[1]
                               };

                    // 获取对象字典
                    Dictionary<string, string> objectDictionary = new Dictionary<string, string>();
                    foreach (var item in data)
                    {
                        objectDictionary.Add(item.name, item.code);
                    }
                    LogAppend($"识别到 {objectDictionary.Count} 个元件信息");
                    LogAppend("开始下载... ...");
                    _sp.DownloadDictionary(objectDictionary, _fileSavePath);
                    LogAppend("已完成下载操作");
                } 
                else
                {
                    LogAppend("请选择 csv 文件");
                }
            } 
            else
            {
                LogAppend("请先选择下载目录");
            }
        }

            /// <summary>
            /// 选择 CSV 文件
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btn_CSVSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    if (Path.GetExtension(ofd.FileName).ToLower() == ".csv")
                    {
                        _csvFilePath = ofd.FileName;
                        txtBx_CSVPath.Text = _csvFilePath;
                    }
                    else
                    {
                        LogAppend("文件后缀错误, 请选择后缀为 .csv 的文件!");
                    }
                }
            }
        }
        #endregion

        #region 类型定义

        /// <summary>
        /// 添加 Log 委托
        /// </summary>
        /// <param name="logInfo"></param>
        private delegate void LogAppendDelegate(string logInfo);

        /// <summary>
        /// 清除 Log 委托
        /// </summary>
        private delegate void LogClearDelegate();

        #endregion

    }
}
