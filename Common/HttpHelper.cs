using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WebApiTest.Common
{
    // 用于后端通用请求的帮助类
    public class HttpHepler
    {
        /// <summary>
        /// 异步Post请求，
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="formData"></param>
        /// <param name="mediaType"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static async Task<string> GetDataPostUrlYB(string URL, List<KeyValuePair<string, string>> formData = null, string mediaType = "application/json", string charset = "UTF-8")
        {
            formData = formData ?? new List<KeyValuePair<string, string>>();
            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(formData);
                content.Headers.ContentType = new MediaTypeHeaderValue(mediaType);
                content.Headers.ContentType.CharSet = charset;
                for (int i = 0; i < formData.Count; i++)
                {
                    content.Headers.Add(formData[i].Key, formData[i].Value);
                }
                var response = await client.PostAsync(URL, content).ConfigureAwait(false);
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// 异步Post请求，
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="jsonData"></param>
        /// <param name="mediaType"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static async Task<string> GetDataPostJsonUrlYB(string URL, string jsonData = "", string mediaType = "application/json", string charset = "UTF-8")
        {
            jsonData = jsonData ?? "";
            using (var client = new HttpClient())
            {
                HttpContent content = new StringContent(jsonData);
                content.Headers.ContentType = new MediaTypeHeaderValue(mediaType);
                content.Headers.ContentType.CharSet = charset;
                var response = await client.PostAsync(URL, content).ConfigureAwait(false);
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }


        /// <summary>
        /// 异步GET请求，
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public static async Task<string> GetDataGetUrlYB(string URL, List<KeyValuePair<string, string>> formData = null, string mediaType = "application/json", string charset = "UTF-8")
        {
            formData = formData ?? new List<KeyValuePair<string, string>>();
            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(formData);
                content.Headers.ContentType = new MediaTypeHeaderValue(mediaType);
                content.Headers.ContentType.CharSet = charset;
                return await client.GetStringAsync(URL).ConfigureAwait(false);
            }
        }
    }
}