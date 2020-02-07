using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace API_Exercise
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetData_WebRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp("http://dummy.restapiexample.com/api/v1/employees");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();

            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            Trace.WriteLine("Response stream received.");
            Trace.WriteLine(readStream.ReadToEnd());
            response.Close();
            readStream.Close();
        }

        [TestMethod]
        public void PostData()
        {
            var resultCreated = string.Empty;
            resultCreated = PostData2();
        }

        [TestMethod]
        public void PostData_WithDelete()
        {
            // Call post method.
            var resultCreated = PostData2();

            // Get Id from the created object.
            var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(resultCreated);
            var id = resultObject.data.id.Value;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/delete/" + id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                resultCreated = result;
                Trace.WriteLine(result.ToString());
            }
        }

        public string PostData2()
        {
            var resultCreated = string.Empty;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"name\":\"test\"," +
                              "\"salary\":\"001\"}";
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                resultCreated = streamReader.ReadToEnd();
                Trace.WriteLine(resultCreated.ToString());
            }

            return resultCreated.ToString();
        }

    }
}
