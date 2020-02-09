using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace POST_DELETE
{
    [TestClass]
    public class UnitTest1
    {


        public class Employee
        {
            public string status { get; set; }
            public Data data { get; set; }
    
        }


        public class Data
        {

            public string  name { get; set; }
            public int salary { get; set; }

            public int age { get; set; }

            public int id { get; set; }

        }


        [TestMethod]
        public void TestMethod1()
        {


            var url = "http://dummy.restapiexample.com/api/v1/create";
            WebRequest post = HttpWebRequest.Create(url);


            post.ContentType = "application/json; charset=utf-8";
            post.Method = "POST";

            using (var streamWriter = new StreamWriter(post.GetRequestStream()))
            {
                string json = "{\"name\":\"luis\",\"salary\":\"500\",\"age\":\"36\"}";


                streamWriter.Write(json);
                streamWriter.Flush();
                Console.WriteLine("POST Sent: " + json);
            }




            WebResponse response = post.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string responseText = reader.ReadToEnd();

            Console.WriteLine("Response Received: " + responseText);



            Employee json2 = JsonConvert.DeserializeObject<Employee>(responseText);


            Console.WriteLine($"Delete Request Sent: http://dummy.restapiexample.com/api/v1/delete/{json2.data.id}");



            var url2 = $"http://dummy.restapiexample.com/api/v1/delete/{json2.data.id}";
            WebRequest post2 = HttpWebRequest.Create(url2);
            post2.Method = "DELETE";

            using (var streamWriter2 = new StreamWriter(post2.GetRequestStream()))
            {

                WebResponse response2 = post2.GetResponse();

                StreamReader reader2 = new StreamReader(response2.GetResponseStream());

                string responseText2 = reader2.ReadToEnd();

                Console.WriteLine($"Response Received when trying to delete Employee: {json2.data.name} with id: {json2.data.id} \n" + responseText2);



            }



        }
    }
}
