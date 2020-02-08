using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Serialization.Json;

namespace API_Test
{
    public class Post_Delete_Classes
    {
        public Post_Delete_Classes()
        {

        }
        protected string dataToPost(string strName, string strSalary, string strAge)
        {
            string responseText = "";
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '}', '{', '"' };
            List<string> dataToDelete = new List<string>();
            string strStringToVal = "";

            string url = "http://dummy.restapiexample.com/api/v1/create";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "POST";

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{ \"name\": \"" + strName + "\"," +
                                  "\"salary\": \"" + strSalary + "\"," +
                                  "\"age\": \"" + strAge + "\" }";

                streamWriter.Write(json);
                streamWriter.Flush();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                responseText = streamReader.ReadToEnd();
                Console.WriteLine("CREATE POST RESPONSE IS: " + responseText);
            }
            string[] dataToDeleteOne = responseText.Split(delimiterChars);


            foreach (var element in dataToDeleteOne)
            {
                if (!String.IsNullOrEmpty(element))
                {
                    strStringToVal = element;
                    dataToDelete.Add(element);
                }



            }
            return strStringToVal;
        }

        protected string dataToDelete(string valToDelete)
        {

            string responseTextToDelete = "";


            Console.WriteLine("MEMBER ID TO DELETE IS: " + valToDelete);

            string urlToDelete = "http://dummy.restapiexample.com/api/v1/delete/" + valToDelete;
            Console.WriteLine("URL TO DELETE IS: " + urlToDelete);

            var httpWebRequestToDelete = (HttpWebRequest)WebRequest.Create(urlToDelete);
            httpWebRequestToDelete.Method = "DELETE";

            var httpResponseToDelete = (HttpWebResponse)httpWebRequestToDelete.GetResponse();
            using (var streamReader = new StreamReader(httpResponseToDelete.GetResponseStream()))
            {
                responseTextToDelete = streamReader.ReadToEnd();
            }
            return responseTextToDelete;
        }
    }
}
