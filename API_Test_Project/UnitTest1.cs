using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace API_Test_Project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create a request for the URL.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/employees");
            HttpWebResponse response =(HttpWebResponse)request.GetResponse();

            //WebResponse response = request.GetResponse();
            // Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            List<data> employees = new List<data>();

            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                responseFromServer = JsonConvert.SerializeObject(response.GetResponseStream());
                employees.Add(JsonConvert.DeserializeObject<data>(responseFromServer));

                // Display the content.  
                Console.WriteLine(responseFromServer);
            }
            
            // Close the response.  
            response.Close();

            foreach(data employee in employees )
            {
                Console.WriteLine(employee.employee_name);

            }

        }
    }
}
