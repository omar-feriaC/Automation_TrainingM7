using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NUnit.Framework;

namespace API_Test_Project
{
    [TestClass]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            // Create a request for the URL.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/employees");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //WebResponse response = request.GetResponse();
            // Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            GetResponse res = new GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                res = JsonConvert.DeserializeObject<GetResponse>(responseFromServer);

                // Display the content.  
                //Console.WriteLine(responseFromServer);
            }

            // Close the response.  
            response.Close();

            foreach (Employee employee in res.data)
            {
                Console.WriteLine($"ID: {employee.id}  Name: {employee.employee_name}  Salary: {employee.employee_salary}  Age: {employee.employee_age}  Profile Image: {employee.profile_image}");

            }
        }

        [Test]
        public void TestMethod2()
        {
                try
                {
                    string webAddr = "http://dummy.restapiexample.com/api/v1/create";

                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                    httpWebRequest.ContentType = "application/json; charset=utf-8";
                    httpWebRequest.Method = "POST";

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string json = "{ \"name\" : \"Carlos\", \"salary\" : \"123\" , \"age\" : 13 }";

                        streamWriter.Write(json);
                        streamWriter.Flush();
                    }

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var responseText = streamReader.ReadToEnd();
                        Console.WriteLine(responseText);

                        //Now you have your response.
                        //or false depending on information in the response     
                    }
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
         }


        [Test]
        public void TestMethod3()
        {
            try
            {
                string webAddr = "http://dummy.restapiexample.com/api/v1/delete/2";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.Method = "DELETE";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);

                    //Now you have your response.
                    //or false depending on information in the response     
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [Test]
        public void TestMethod4()
        {
            try
            {
                string webAddr = "http://dummy.restapiexample.com/api/v1/create";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                PostReponse res = new PostReponse();

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"name\" : \"Carlos\", \"salary\" : \"123\" , \"age\" : 13}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                              
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);
                    res = JsonConvert.DeserializeObject<PostReponse>(responseText);

                    Console.WriteLine(res.data.id);
                }

                webAddr = $"http://dummy.restapiexample.com/api/v1/delete/{res.data.id}";
                httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.Method = "DELETE";

                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);
 
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
