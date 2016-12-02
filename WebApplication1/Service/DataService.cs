using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApplication1.Service
{
    public class DataService
    {
        private static List<Models.Album> list = new List<Models.Album>();

        static DataService()
        {
            var item = new Models.Album();

            item.學號 = "1103105352";
            item.姓名 = "黃俊木";
            item.班級 = "四子三丙";
            item.星座 = "天秤座";
            item.生日 = "1996/9/27";
            item.facebook = "https://www.facebook.com/profile.php?id=100000383148753&fref=ts";
            //item.Genre = 8;

            list.Add(item);

            var item2 = new Models.Album();
            item2.學號 = "1103105311";
            item2.姓名 = "李思毅";
            item2.班級 = "四子三丙";
            item2.星座 = "水瓶座";
            item2.生日 = "1996/1/23";
            item2.facebook = "https://www.facebook.com/profile.php?id=100002678443071&fref=ts";
            //item2.Genre = 8; ;
            list.Add(item2);

            

            var item3 = new Models.Album();
            item3.學號 = "1103105302";
            item3.姓名 = "張根維";
            item3.班級 = "四子三丙";
            item3.星座 = "雙魚座";
            item3.生日 = "1996/2/27";
            item3.facebook = "https://www.facebook.com/profile.php?id=100002759816060&fref=ts";
            //item3.Genre = 8; ;
            list.Add(item3);

           

            var item4 = new Models.Album();
            item4.學號 = "1103105339";
            item4.姓名 = "曾文輝";
            item4.班級 = "四子三丙";
            item4.星座 = "射手座";
            item4.生日 = "1995/11/27";
            item4.facebook = "https://www.facebook.com/profile.php?id=100000800300304&fref=ts";
            //item4.Genre = 8; ;
            list.Add(item4);

            var item5 = new Models.Album();
            item5.學號 = "1103105342";
            item5.姓名 = "姚呈政";
            item5.班級 = "四子三丙";
            item5.星座 = "魔羯座";
            item5.生日 = "1995/12/28";
            item5.facebook = "https://www.facebook.com/yao.dong.54?fref=ts";
            //item4.Genre = 8; ;
            list.Add(item5);


            //var table1= new Models.Album();
            //table1.one = "4564 ";
            //table1.two = " ";
            //table1.three = " ";
            //table1.four = " ";
            //table1.five = " ";
            ////table1.six = " ";
            ////table1.seven = " ";
            ////table1.eight = " ";
            ////table1.nine = "行動平台";
            ////table1.ten = "行動平台";
            ////table1.eleven = "行動平台";
            ////table1.twelve = "行動平台";
            //list.Add(table1);

            //var table2 = new Models.Album();
            //table2.one = " ";
            //table2.two = "1 ";
            //table2.three = " ";
            //table2.four = "1 ";
            //table2.five= " ";
            //list.Add(table2);

            //var table3 = new Models.Album();
            //table3.one = " ";
            //table3.two = " 1";
            //table3.three = "1 ";
            //table3.four = " 1";
            //table3.five= " ";
            //list.Add(table3);

            //var table4 = new Models.Album();
            //table4.one = " 1";
            //table4.two= " 1";
            //table4.three = " ";
            //table4.four= " ";
            //table4.five= " ";
            //list.Add(table4);

            //var table5 = new Models.Album();
            //table5.one = " ";
            //table5.two= " ";
            //table5.three = " ";
            //table5.four= " ";
            //table5.five= " 1";
            //list.Add(table5);
        }
        public DataService()
        {

        }

        public List<Models.Album> LoadAllAlbum()
        {
             
            return list;
        }

        public void LoadCandidate()
        {
            using (var webClient = new System.Net.WebClient())
            {
               // var json = webClient(URL);
                // Now parse with JSON.Net
            }
            var baseAddress = "http://www.taichungfes.com.tw/api/Candidate/GetPage";

            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = @"{'PageNo':1,'PageSize':16,'TotalCount':0}";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();

            //
        }



    }
}