using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIExercise1.BaseFiles
{


    class clsDummyRestApi
    {
        internal string post(string name, string salary, string age)
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
                string json = "{\"name\":\""+name+"\"," +
                              "\"salary\":\""+salary+"\"," +
                              "\"age\":\""+age+"\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
            }
            //Request action
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string statusMessage = readStream.ReadToEnd();
            //Console.WriteLine("Response stream received.");
            Console.WriteLine(statusMessage);
            
            string[] splitString = statusMessage.Split(new[] { "\",\"id\":" }, StringSplitOptions.None);
            
            response.Close();
            readStream.Close();

            return splitString[splitString.Length - 1].Substring(0, splitString[splitString.Length - 1].Length-2);
        }

        internal string delete(string id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dummy.restapiexample.com/api/v1/delete/"+id);
            request.Method = "DELETE";
            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            //Request action
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string statusMessage = readStream.ReadToEnd();
            //Console.WriteLine("Response stream received.");
            Console.WriteLine(statusMessage);

            response.Close();
            readStream.Close();
            return statusMessage;
        }
    }
}
