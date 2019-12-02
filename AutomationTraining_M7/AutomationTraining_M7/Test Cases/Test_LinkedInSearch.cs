using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch : Base_Files.LinkedIn_LoginPage
    {
        LinkedIn_SearchPage objSearch;

        [Test]
        public void FirstSearch() {
            objSearch = new LinkedIn_SearchPage(driver);
            //Assert
            LinkedIn_SearchPage.fnEnterSearch("Jose Luis");
        }
        
        
    }
}
