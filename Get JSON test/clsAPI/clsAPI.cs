using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace Get_JSON_test.API_POM_Class
{
    public class clsAPI
    {
        public static void GetResponse(string paramGETURL)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(paramGETURL);

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

        public static string Post(string paramName, string paramSalary, string paramAge)
        {
        
                string Response = "";
                char[] Delimiter = { ' ', ',', '.', ':', '\t', '}', '{', '"' };
                List<string> dataToDelete = new List<string>();
                string strStringToVal = "";

                string webAddres = "http://dummy.restapiexample.com/api/v1/create";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddres);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string Employee = "{ \"name\": \"" + paramName + "\"," +
                                  "\"salary\": \"" + paramSalary + "\"," +
                                  "\"age\": \"" + paramAge + "\" }";

                streamWriter.Write(Employee);
                    Console.WriteLine(Employee);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    Response = streamReader.ReadToEnd();
                    Console.WriteLine(Response);
                }

                string[] ID = Response.Split(Delimiter);

                foreach (var element in ID)
                {
                    if (!String.IsNullOrEmpty(element))
                    {
                        strStringToVal = element;
                        dataToDelete.Add(element);
                    }

                }
                return strStringToVal;
        }

        public static string Delete(string valToDelete)
        {
           
            string RespText = "";

            Console.WriteLine("MEMBER ID TO DELETE IS: " + valToDelete);

            string webAddr = "http://dummy.restapiexample.com/api/v1/delete/" + valToDelete;
            Console.WriteLine("URL TO DELETE IS: " + webAddr);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.Method = "DELETE";

            var httpResponseToDelete = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponseToDelete.GetResponseStream()))
            {
                RespText = streamReader.ReadToEnd();
            }
            return RespText;
        }

            
        
    }
}

