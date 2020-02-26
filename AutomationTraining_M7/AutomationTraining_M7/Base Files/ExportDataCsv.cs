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
            Header = "";
            Member = new List<Candidates>();
        }

        public void fnCreateFile()
        {
            StreamWriter file = File.CreateText(fnGetCSVPath() + FileName);
            file.WriteLine(Header);
            foreach (Candidates candidate in Member)
            {
                file.WriteLine($"Actor Name: {candidate.ActorName}");
                file.WriteLine($"Profile/Role: {candidate.ProfileRole}");
                file.WriteLine($"LinkedIn URL: {candidate.LinkedInUrl}");
                file.WriteLine($"Actor Name: {candidate.LastJob}");
                file.WriteLine($"Experience: Role: {candidate.ExperienceRole},  Company: {candidate.ExperienceCompany},  Period:{candidate.ExperiencePeriod}");
                file.WriteLine($"Skills and Validations: {candidate.SkillsValidations}");
                file.WriteLine($"Tools and technologies: {candidate.ToolsTechnologies}");                
            }
            file.Close();
        }
    }
}

