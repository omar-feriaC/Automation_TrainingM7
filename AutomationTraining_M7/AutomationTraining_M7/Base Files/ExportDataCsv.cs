using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTraining_M7.Reporting;
using AutomationTraining_M7.Data_Model;

namespace AutomationTraining_M7.Base_Files
{
    class ExportDataCsv:clsReportManager
    {
        public string FileName { get; set; }
        public string Header { get; set; }
        public List<Candidates> Member { get; set; }

        public ExportDataCsv(string pstrTechnologies)
        {
            FileName = $"{pstrTechnologies}_{DateTime.Now.ToString("MMddyyyy_HHmmss")}.csv";
            Header = "Actor Name,Profile/Role,LinkedIn URL,Last Job,Experience,Skills and Validations,Tools and technologies";
            Member = new List<Candidates>();
        }

        public void fnCreateFile(List<Candidates> plstCan)
        {
            StreamWriter file = File.CreateText(fnGetCSVPath() + FileName);
            file.WriteLine(Header);
            foreach (Candidates candidate in plstCan)
            {
                file.WriteLine($"\"{candidate.ActorName}\", \"{candidate.ProfileRole}\", \"{ candidate.LinkedInUrl}\", \"{candidate.LastJob}\", \"{candidate.Experience}\", \"{candidate.SkillsValidations}\", \"{candidate.ToolsTechnologies}\"");
            }
            file.Close();
                       
        }
    }
}

