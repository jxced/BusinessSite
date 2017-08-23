using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace CommonLib
{
    using System.Web;
    using System.Web.Mvc;
    public static class Kits
    {
        /// <summary>
        /// /MD5加密
        /// </summary>
        /// <param name="sourceStr">需要加密的字符串</param>
        /// <returns></returns>
        public static string GetMD5(string sourceStr)
        {
            StringBuilder sb = new StringBuilder();
            using (MD5 md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(sourceStr));

                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
            }
            return sb.ToString().Replace("-", "");
        }

        /// <summary>
        /// 接口数据转Json
        /// </summary>
        /// <param name="postValue"></param>
        /// <returns></returns>
        public static string GetJsonByPostValue(string postValue)
        {
            Regex rx = new Regex("=(?!\"|{|\\[|&)");
            Regex rx2 = new Regex("(?<!\"|}|]|=)&");
            Regex rx3 = new Regex("(?<!\"|}|]|=)$");
            var requestContent = rx.Replace(postValue, ":\"");
            requestContent = rx2.Replace(requestContent, "\",");
            requestContent = requestContent.Replace("=&", ":null,");
            requestContent = requestContent.Replace("=", ":").Replace("&", ",");
            if (rx3.IsMatch(requestContent))
                requestContent = "{" + requestContent + "\"}";
            else
                requestContent = "{" + requestContent + "}";

            return requestContent;
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="htmler"></param>
        /// <param name="area"></param>
        /// <param name="action"></param>
        /// <param name="controller"></param>
        /// <param name="pagerSize"></param>
        /// <returns></returns>
        public static  MvcHtmlString PaperHelper(this HtmlHelper htmler,string area,string action,string controller,string pagerSize,int total )
        {
            string currentIndex= HttpContext.Current.Request.QueryString["currentpager"]==null?"1": HttpContext.Current.Request.QueryString["currentpager"];
            int totalcount= (int)System.Math.Ceiling((decimal)total / int.Parse(pagerSize));
            area = area == null ? "" : "/" + area;
            string url = area + "/" + controller + "/" + action + "?currentpager={0}&pagerSize={1}";
            StringBuilder html = new StringBuilder(200);
            html.Append("<div class=\"am - cf\">");
            html.Append("<div class=\"am - fr\">");
            html.Append("<ul class=\"am-pagination\">");
            html.Append("<li ><a href = \""+string.Format(url, int.Parse(currentIndex)==1?1: int.Parse(currentIndex)-1, pagerSize) +"\" >«</a></li>");
            for (int i = 1; i <= totalcount; i++)
            {
                html.Append("<li><a href = \"" + string.Format(url, i, pagerSize) + "\" >"+i+"</a></li>");
            }
            html.Append("<li ><a href = \"" + string.Format(url, int.Parse(currentIndex) == totalcount ?totalcount : int.Parse(currentIndex) + 1, pagerSize) +"\" >»</a></li>");
            html.Append("</ul></div></div>");
            return new MvcHtmlString (html.ToString());
        }

        public static MvcHtmlString test(this HtmlHelper htmler)
        {
            StringBuilder s = new StringBuilder(200);
            s.Append("<span class=\"am - icon - pencil - square - o\"></span> 编辑");
            return new MvcHtmlString(s.ToString());
        }
    }
}