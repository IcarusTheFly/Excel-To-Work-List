using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e) => openExcelFile.ShowDialog();

        private void openExcelFile_FileOk(object sender, CancelEventArgs e)
        {
            tbInput.Text = openExcelFile.FileName;
            btnGenerate.Enabled = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb = excel.Workbooks.Open(openExcelFile.FileName);

            Hashtable content = new Hashtable(); // All the elements here
            //int countData4 = 0;
            //int countData5 = 0;
            //int countNoData = 0;
            //int countTotal = 0;

            foreach (Excel.Worksheet displayWorksheet in wb.Worksheets)
            {
                string[] titleArray = displayWorksheet.Cells[7, 9].Value.Split('\n');
                string title;
                if (titleArray.Count() > 1)
                {
                    title = titleArray[1];
                }
                else
                {
                    title = titleArray[0];
                }

                for (int i = 7; i < 35; i++)
                {
                    if (displayWorksheet.Cells[i, 2].Value == null || Convert.ToString(displayWorksheet.Cells[i, 2].Value).Trim() == "")
                    {
                        break;
                    }

                    //countTotal++;

                    if (displayWorksheet.Cells[i, 4].Borders[Excel.XlBordersIndex.xlDiagonalDown].LineStyle == 1)
                    {
                        //countData4++;
                    }
                    else if (displayWorksheet.Cells[i, 5].Borders[Excel.XlBordersIndex.xlDiagonalDown].LineStyle == 1)
                    {
                        if (!content.ContainsKey("Negative"))
                        {
                            content["Negative"] = new List<string>(); // will create our list for elements with data 5
                        }
                        ((List<string>)content["Negative"]).Add(titleArray[2] + " - " + displayWorksheet.Cells[i, 2].Value + " - " + displayWorksheet.Cells[i, 3].Value);
                        //countData5++;
                    }
                    else
                    {
                        //countNoData++;
                    }

                    if (displayWorksheet.Cells[i, 4].Borders[Excel.XlBordersIndex.xlDiagonalDown].LineStyle == 1)
                    {
                        if (!content.ContainsKey(title))
                        {
                            content[title] = new List<string>(); // will create our list
                        }
                        ((List<string>)content[title]).Add(displayWorksheet.Cells[i, 2].Value + " - " + displayWorksheet.Cells[i, 3].Value);
                    }
                }
            }

            // We have all the data at this point

            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add();

            List<int> listIndexTitles = new List<int>();
            int titleIndex = 1;
            foreach (DictionaryEntry d in content)
            {
                titleIndex++;
                listIndexTitles.Add(titleIndex);
                doc.Content.Text += d.Key;

                foreach (string s in (List<string>)d.Value)
                {
                    titleIndex++;
                    doc.Content.Text += s;
                }
            }

            foreach (int i in listIndexTitles)
            {
                Word.Range rng = doc.Paragraphs[i].Range;
                rng.Font.Size = 14;
                rng.Font.Bold = 1;
            }

            app.Visible = true;
            // TO-DO: Add functionality to save the file in the specified directory
            // doc.Save();
        }
    }
}