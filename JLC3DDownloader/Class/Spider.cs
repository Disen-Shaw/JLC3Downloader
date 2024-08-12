using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using JLC3DDownloader.Class.Model1NS;
using JLC3DDownloader.Class.Model2NS;
using JLC3DDownloader.Class.Model3NS;
using JLC3DDownloader.Class.Model4NS;
using Newtonsoft.Json;

namespace JLC3DDownloader.Class
{
    public class Spider
    {
        #region 静态成员
        private static string s_path = "0819f05c4eef4c71ace90d822a990e87";
        private static JsonSerializerSettings s_jsonSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        #endregion

        #region 公有成员
        public SpiderDelegate SpiderOperationCallback;
        #endregion

        #region 公有方法
        /// <summary>
        /// 下载 3D 封装
        /// </summary>
        /// <param name="objectCode"></param>
        /// <param name="savePath"></param>
        public async void Download(string objectCode, string fileName, string savePath)
        {
            try
            {
                var response0 = await "https://pro.lceda.cn/api/eda/product/search".PostMultipartAsync(mp => mp
                    .AddString("keyword", objectCode)
                    .AddString("needAggs", "true")
                    .AddString("url", "/ api / eda / product / list")
                    .AddString("currPage", "1")
                    .AddString("pageSize", "10")
                    ).ReceiveString();
                var model1 = JsonConvert.DeserializeObject<Model1>(response0, s_jsonSettings);
                string hasDevice = model1.result.productList[0].hasDevice;
                var response1 = await "https://pro.lceda.cn/api/devices/searchByIds".PostMultipartAsync(mp => mp
                    .AddString(" uuids[]", hasDevice)
                    .AddString("path", s_path)
                    ).ReceiveString();
                Console.WriteLine(response1);
                var model2 = JsonConvert.DeserializeObject<Model2>(response1, s_jsonSettings);
                string Modelattr = model2.result[0].attributes.Model;
                var response2 = await "https://pro.lceda.cn/api/components/searchByIds?forceOnline=1".PostMultipartAsync(mp => mp
                    .AddString(" uuids[]", Modelattr)
                    .AddString("dataStr", "yes")
                    .AddString("path", s_path)
                    ).ReceiveString();
                var model3 = JsonConvert.DeserializeObject<Model3>(response2, s_jsonSettings);
                string dataStr = model3.result[0].dataStr;
                var model4 = JsonConvert.DeserializeObject<Model4>(dataStr, s_jsonSettings);
                string ModelID = model4.model;
                string footName = fileName + ".step";
                string downloadUrl = "https://modules.lceda.cn/qAxj6KHrDKw4blvCG8QJPs7Y/" + ModelID;
                string text = await downloadUrl.GetStringAsync();
                File.WriteAllText(savePath+ @"\" + footName, text);
                SpiderOperationCallback?.Invoke($"{fileName}: 下载成功");
            }
            catch 
            {
                SpiderOperationCallback?.Invoke($"{fileName}: 未找到元器件信息");
                return;
            }
        }

        /// <summary>
        /// 根据字典下载
        /// </summary>
        /// <param name="objDictionary"></param>
        public void DownloadDictionary(Dictionary<string, string> objDictionary, string savePath)
        {
            foreach (var item in objDictionary )
            {
                Download(item.Value, item.Key,savePath);
            }
        }

        #endregion

        #region 类型定义

        /// <summary>
        /// 爬虫操作代理
        /// </summary>
        /// <param name="result"></param>
        public delegate void SpiderDelegate(string result);
        #endregion
    }
}
