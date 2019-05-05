using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Office.Interop.Word;

namespace URS.Model
{
    class Report
    {
        DAL dal = new DAL();
        List<Employee> employeeList;

        //Method to generate an report of the occupancyrate
        public void GenerateOccupancyRate()
        {
            employeeList = dal.GetAllData();

            //Create an instance for word app  
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

            //Set animation status for word application  
            winword.ShowAnimation = false;

            //Set status for word application is to be visible or not.  
            winword.Visible = false;

            //Create a missing variable for missing value  
            object missing = System.Reflection.Missing.Value;

            //Create a new document  
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            var data = document.Paragraphs.Add();
            document.Content.Text = "Datum: " + DateTime.Now;
            
            //Add header into the document
            foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
            {
                //Get the header range and add the header details.  
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                headerRange.Font.Size = 18;
                headerRange.Text = "URS ~ Rapportage bezettingsgraad";
            }

            //Add footer into the document
            foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
            {
                //Get the footer range and add the footer details.  
                Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                footerRange.Font.Size = 10;
                footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                footerRange.Text = "Deze rapportage wordt u aangeboden door het URS-systeem van WeShare. De gegevens in deze rapportage zijn gebaseerd op de beschikbare gegevens van het URS-systeem";
            }

            var logo = document.Paragraphs.Add();
            var shape = document.Application.Selection.InlineShapes.AddPicture(@"D:\URS\Resources\calendar.png");
            shape.Height = 100;
            shape.Width = 100;

            //Create a table into the document in a new paragraph
            //Fill table with data from database from DAL
            var table = document.Paragraphs.Add();
            int number = employeeList.Count();
            Paragraph para = document.Content.Paragraphs.Add(ref missing);
            Table firstTable = document.Tables.Add(para.Range, number + 1, 5, ref missing, ref missing);

            float hoursWorked = 0;
            int cell = 1;
            firstTable.Borders.Enable = 1;
            firstTable.Cell(1, 1).Range.Text = "Voornaam";
            firstTable.Cell(1, 2).Range.Text = "Achternaam";
            firstTable.Cell(1, 3).Range.Text = "Contracturen";
            firstTable.Cell(1, 4).Range.Text = "Gewerkte uren";
            firstTable.Cell(1, 5).Range.Text = "Bezettingsgraad";

            //Get data from database
            foreach(Employee employee in employeeList)
            {
                cell += 1;
                firstTable.Cell(cell, 1).Range.Text = employee.firstName.ToString();
                firstTable.Cell(cell, 2).Range.Text = employee.lastName.ToString();
                firstTable.Cell(cell, 3).Range.Text = employee.contractHours.ToString();
                foreach(Hour hour in employee.Hours)
                {
                    hoursWorked += hour.duration;
                    firstTable.Cell(cell, 4).Range.Text = hoursWorked.ToString();
                    float occupancyRate = hoursWorked / float.Parse(employee.contractHours.ToString()) * 100;
                    firstTable.Cell(cell, 5).Range.Text = occupancyRate.ToString();
                }
                hoursWorked = 0;
            }
            
            //Make document visible
            winword.Visible = true;
            winword.ShowAnimation = true;
        }

        //Method to generate an report of the approved hours per employee
        public void GenerateApprovedHours()
        {
            employeeList = dal.GetAllData();

            //Create an instance for word app  
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

            //Set animation status for word application  
            winword.ShowAnimation = false;

            //Set status for word application is to be visible or not.  
            winword.Visible = false;

            //Create a missing variable for missing value  
            object missing = System.Reflection.Missing.Value;

            //Create a new document  
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            var data = document.Paragraphs.Add();
            document.Content.Text = "Datum: " + DateTime.Now;

            //Add header into the document
            foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
            {
                //Get the header range and add the header details.  
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                headerRange.Font.Size = 18;
                headerRange.Text = "URS ~ Rapportage gewerkte uren per medewerker";
            }

            //Add footer into the document
            foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
            {
                //Get the footer range and add the footer details.  
                Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                footerRange.Font.Size = 10;
                footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                footerRange.Text = "Deze rapportage wordt u aangeboden door het URS-systeem van WeShare. De gegevens in deze rapportage zijn gebaseerd op de beschikbare gegevens van het URS-systeem";
            }

            var logo = document.Paragraphs.Add();
            var shape = document.Application.Selection.InlineShapes.AddPicture(@"D:\URS\Resources\calendar.png");
            shape.Height = 100;
            shape.Width = 100;

            //Fill table with data from database from DAL
            int cell = 1;
            int numberOfRecords = 0;

            foreach(Employee employee in employeeList)
            {
                numberOfRecords += employee.Hours.Count();
            }

            //Get data from the database
            var table = document.Paragraphs.Add();
            Paragraph para = document.Content.Paragraphs.Add(ref missing);
            Table firstTable = document.Tables.Add(para.Range, numberOfRecords + 1, 7, ref missing, ref missing);
            firstTable.Borders.Enable = 1;

            firstTable.Cell(1, 1).Range.Text = "Mede-werker";
            firstTable.Cell(1, 2).Range.Text = "Activiteit-ID";
            firstTable.Cell(1, 3).Range.Text = "Datum";
            firstTable.Cell(1, 4).Range.Text = "Aantal-uren";
            firstTable.Cell(1, 5).Range.Text = "Goed-gekeurd";
            firstTable.Cell(1, 6).Range.Text = "Uurtarief";
            firstTable.Cell(1, 7).Range.Text = "Uitbetalen";

            foreach(Employee employee in employeeList)
            {
                foreach(Hour hour in employee.Hours)
                {
                    cell += 1;
                    float salary = employee.salary * hour.duration;

                    firstTable.Cell(cell, 1).Range.Text = employee.firstName + "- " + employee.lastName;
                    firstTable.Cell(cell, 2).Range.Text = hour.activityID.ToString();
                    firstTable.Cell(cell, 3).Range.Text = hour.date;
                    firstTable.Cell(cell, 4).Range.Text = hour.duration.ToString();
                    firstTable.Cell(cell, 5).Range.Text = hour.approved;
                    firstTable.Cell(cell, 6).Range.Text = employee.salary.ToString();
                    firstTable.Cell(cell, 7).Range.Text = salary.ToString();
                }
            }

            winword.Visible = true;
            winword.ShowAnimation = true;
        }
    }
}
