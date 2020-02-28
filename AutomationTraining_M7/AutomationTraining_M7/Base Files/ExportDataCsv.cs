using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTraining_M7.Reporting;
using AutomationTraining_M7.Data_Model;
using Syncfusion.XlsIO;
using System.Collections;

namespace AutomationTraining_M7.Base_Files
{
    class ExportDataCsv:clsReportManager
    {
        public string FileName { get; set; }
        public string Header { get; set; }
        public List<Candidates> Member { get; set; }

        public ExportDataCsv(string pstrTechnologies)
        {
            FileName = $"{pstrTechnologies}_{DateTime.Now.ToString("MMddyyyy_HHmmss")}.xlsx";
           // Header = "Actor Name|Profile/Role|LinkedIn URL|Last Job|Experience|Skills and Validations|Tools and technologies";
            Member = new List<Candidates>();
        }
        
        public void fnCreateFile(List<Candidates> plstCan)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Create a new workbook
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet sheet = workbook.Worksheets[0];

                int i = 1;

                foreach (Candidates candidate in plstCan)
                {
                    sheet[$"A{i}"].Text = "Actor Name";
                    sheet[$"A{i}"].CellStyle.Font.Bold = true;
                    sheet[$"A{i + 1}"].Text = candidate.ActorName;
                    sheet[$"A{i}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                    sheet[$"A{i + 1}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                    sheet[$"B{i}"].Text = "Profile Role";
                    sheet[$"B{i}"].CellStyle.Font.Bold = true;
                    sheet[$"B{i + 1}"].Text = candidate.ProfileRole;
                    sheet[$"B{i}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                    sheet[$"B{i + 1}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                    sheet[$"C{i}"].Text = "LinkedIn Url";
                    sheet[$"C{i}"].CellStyle.Font.Bold = true;
                    sheet[$"C{i + 1}"].Text = candidate.LinkedInUrl;
                    sheet[$"C{i}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                    sheet[$"C{i + 1}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                    sheet[$"D{i}"].Text = "Last Job";
                    sheet[$"D{i}"].CellStyle.Font.Bold = true;
                    sheet[$"D{i + 1}"].Text = candidate.LastJob;
                    sheet[$"D{i}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                    sheet[$"D{i + 1}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                    sheet[$"E{i}"].Text = "Experience";
                    sheet[$"E{i}"].CellStyle.Font.Bold = true;
                    sheet[$"E{i + 1}"].Text = candidate.Experience;
                    sheet[$"E{i}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                    sheet[$"E{i + 1}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                    sheet[$"F{i}"].Text = "Skill Validations";
                    sheet[$"F{i}"].CellStyle.Font.Bold = true;
                    sheet[$"F{i + 1}"].Text = candidate.SkillsValidations;
                    sheet[$"F{i}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                    sheet[$"F{i + 1}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                    sheet[$"G{i}"].Text = "Tools Technologies";
                    sheet[$"G{i}"].CellStyle.Font.Bold = true;
                    sheet[$"G{i + 1}"].Text = candidate.ToolsTechnologies;
                    sheet[$"G{i}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                    sheet[$"G{i + 1}"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                    sheet.UsedRange.AutofitColumns();

                    i += 2;
                }

                Stream excelStream = File.Create(Path.GetFullPath(fnGetCSVPath() + FileName));
                workbook.SaveAs(excelStream);
                excelStream.Dispose();
            }
        }
    }
}