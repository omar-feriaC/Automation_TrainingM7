using System;
using System.Net;
using System.Text;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Get_JSON_test.API_POM_Class;

namespace Get_JSON_test
{
    [TestClass]
    public class GetJSONTest:clsAPI
    {
        [TestMethod]
        public void GetResponseFromJSON()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/employees");

            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine("Lenght of the content is {0}", response.ContentLength);
            Console.WriteLine("Type of the content is {0}", response.ContentType);

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            Console.WriteLine("Response stream received.");
            Console.WriteLine(readStream.ReadToEnd());
            response.Close();
            readStream.Close();
        }

        [TestMethod]
        public void PostToEndPoint()
        {
            try
            {
                string webAddres = "http://dummy.restapiexample.com/api/v1/create";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddres);
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string Employee = "{ \"name\": \"Daniel\"," + 
                                  "\"salary\": \"1000000\"," + 
                                  "\"age\": \"33\" }";

                streamWriter.Write(Employee);
                Console.WriteLine(Employee);
                streamWriter.Flush();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var Response = streamReader.ReadToEnd();
                Console.WriteLine(Response);

                }
            }

            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        [TestMethod]
        public void DeleteToEndPoint()
        {
            try
            {
                string webAddr = "http://dummy.restapiexample.com/api/v1/delete/2";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.Method = "DELETE";

                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Accept = "application/json";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{ \"name\": \"Daniel\"," +
                                  "\"salary\": \"1000000\"," +
                                  "\"age\": \"33\" }";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var respText = streamReader.ReadToEnd();
                    Console.WriteLine(respText);
                }
            }

            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
    [TestClass]
    public class PostAndDeleteAPI
    {
        [TestMethod]
        public void PostAndDelete()
        {
            try
            {

                string strStringToVal = clsAPI.Post("Daniel", "1000", "33");
                string strStringToDelete = clsAPI.Delete(strStringToVal);
                Console.WriteLine("DELETE RESPONSE IS: " + strStringToDelete);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    
}
