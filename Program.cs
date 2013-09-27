using CTOrder;
using CTOrder.com.hujiang.cctalkn;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ordering
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = args.Length == 0 ? "" : args[0];
       
            int hostUserId = 0;
            string[] userIds = null;
            string title = "";
            string[] orderurls = null;
            if (InitOrdering(out hostUserId, out userIds, out title, out orderurls, file))
            {
                #region 订餐
                int touserid = 0;
                ct_api ctorder = new ct_api();
                for (int i = 0; i < userIds.Length; i++)
                {
                    int.TryParse(userIds[i], out touserid);
                    for (int j = 0; j < orderurls.Length; j++)
                    {
                        ctorder.AddUserNotice(hostUserId, touserid, title, orderurls[j]);
                    }
                    Console.Write(".");
                }
                Console.WriteLine("\n已通知完毕！");
                #endregion
            }
            Console.Read();
        }

        #region 订餐信息
        public static bool InitOrdering(out int hostUserId, out string[] userIds, out string title, out string[] orderurls, string filePath="")
        {
            string conf = "";
            if (filePath.Length == 0)
            {
                conf = "conf.xml";
            }
            else
            {
                conf = filePath;   //读取拖放配制文件
            }
            hostUserId = 0;
            userIds = null;
            title = "";
            orderurls = null;

            if (File.Exists(conf))
            {
                OrderingModel om = XmlHelper.XmlDeserializeFromFile<OrderingModel>(conf, Encoding.UTF8);
                try
                {
                    #region 设置信息
                    hostUserId = int.Parse(om.HostUserid);

                    if (om.Userids.IndexOf(',') != -1)
                    {
                        userIds = om.Userids.Split(',');
                    }
                    else
                    {
                        userIds = new string[] { om.Userids };
                    }
                    
                    title = om.Title;

                    if (om.Content.IndexOf("http") == 0) //发送网页信息，查检是否以http://开头
                    {
                        if (om.Content.IndexOf(',') != -1)
                        {
                            orderurls = om.Content.Split(',');
                        }
                        else
                        {
                            orderurls = new string[] { om.Content };
                        }
                    }
                    else                                       //直接发送内容
                    {
                        string text = UBBClass.UBBToHTML(om.Content.Trim());
                        text = text.Replace("\t", "").Replace("\n", "<br/>");
                        orderurls = new string[] { "http://192.168.21.12/ct_dialog.aspx?msg=" + ToUrlEncode(text) };
                    }
                    Console.WriteLine("正在通过CT发送通知...\n");
                    return true;
                    #endregion
                }
                catch
                {
                    Console.WriteLine("设置信息有误，请检查文件" + conf);
                }
            }
            else
            {
                OrderingModel om = new OrderingModel() { HostUserid = "21028091", Userids = "13268190,21028091", Title = "CTOrderingTitle", Content = "http://192.168.21.12/order.htm" };
                XmlHelper.XmlSerializeToFile(om, "conf.xml", Encoding.UTF8);
                Console.WriteLine("已初始化" + conf + ", 请修改重新运行！");
            }
            return false;
        }
        #endregion

        #region ToUrlEncode
        public static string ToUrlEncode(string strCode)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(strCode); //默认是System.Text.Encoding.Default.GetBytes(str)
            System.Text.RegularExpressions.Regex regKey = new System.Text.RegularExpressions.Regex("^[A-Za-z0-9]+$");
            for (int i = 0; i < byStr.Length; i++)
            {
                string strBy = Convert.ToChar(byStr[i]).ToString();
                if (regKey.IsMatch(strBy))
                {
                    //是字母或者数字则不进行转换  
                    sb.Append(strBy);
                }
                else
                {
                    sb.Append(@"%" + Convert.ToString(byStr[i], 16));
                }
            }
            return (sb.ToString());
        }
        #endregion

    }

    public class OrderingModel
    {
        public string HostUserid {get;set;}
        public string Userids {get; set;}
        public string Title {get;set;}
        public string Content { get; set; }
    }
}
