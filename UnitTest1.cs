using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using APIExercise1.BaseFiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace APIExercise1

{
    [TestClass]
    public class UnitTest1
    {
        [Test]
        public void TestMethodAPIRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/employees");

            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine("Content length is {0}", response.ContentLength);
            Console.WriteLine("Content type is {0}", response.ContentType);

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            Console.WriteLine("Response stream received.");
            Console.WriteLine(readStream.ReadToEnd());
            response.Close();
            readStream.Close();
        }
        [Test]
        public void TestMethodAPIPost()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/create");
            request.ContentType = "application/json; charset=UTF-8";
            request.Method = "POST";
            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"name\":\"Edmund Carat\"," +
                              "\"salary\":\"123000\"," +
                              "\"age\":\"33\"}";  

                streamWriter.Write(json);
                streamWriter.Flush();
            }

            //Request action
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine("Content length is {0}", response.ContentLength);
            Console.WriteLine("Content type is {0}", response.ContentType);

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            Console.WriteLine("Response stream received.");
            Console.WriteLine(readStream.ReadToEnd());
            response.Close();
            readStream.Close();
        }

        [Test]
        public void TestMethodAPIDelete()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/delete/2");
            request.Method = "DELETE";
            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            //Request action
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine("Content length is {0}", response.ContentLength);
            Console.WriteLine("Content type is {0}", response.ContentType);

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            Console.WriteLine("Response stream received.");
            Console.WriteLine(readStream.ReadToEnd());
            response.Close();
            readStream.Close();
        }
        [Test]
        public void TestMethodClassApi()
        {
            var myClassDummyApi = new clsDummyRestApi();
            string id = myClassDummyApi.post("Edmund Carat", "123000", "33");
            Console.WriteLine("Created employee id : {0}",id);
            
            string delStatMessage = myClassDummyApi.delete(id);
            Console.WriteLine(delStatMessage);
        }
    }
}
