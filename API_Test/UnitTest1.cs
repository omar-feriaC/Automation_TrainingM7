using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace API_Test
{

    [TestClass]
    public class API_Test : Post_Delete_Classes
    {
        [Test]
        public void TestMethod1()
        { 
            try
            {

                string strStringToVal = this.dataToPost("Jose", "12", "13");
                string strStringToDelete = this.dataToDelete(strStringToVal);
                Console.WriteLine("DELETE RESPONSE IS: " + strStringToDelete);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
