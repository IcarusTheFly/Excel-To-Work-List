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
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Open(openExcelFile.FileName);

            Hashtable content = new Hashtable();
            foreach (Microsoft.Office.Interop.Excel.Worksheet displayWorksheet in wb.Worksheets)
            {
                for (int i = 7; i < 35; i++)
                {
                    if (displayWorksheet.Cells[i, 2].Value == null) {
                        break;
                    }

                    if (displayWorksheet.Cells[i, 4].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlDiagonalDown].LineStyle != 1)
                    {
                        if (!content.ContainsKey(displayWorksheet.Cells[7, 9].Value))
                        {
                            content[displayWorksheet.Cells[7, 9].Value] = new List<string>(); // All the elements here
                        }
                        content[displayWorksheet.Cells[7, 9].Value].Add(displayWorksheet.Cells[i, 2].Value + " - " + displayWorksheet.Cells[i, 3].Value);
                    }
                }
            }
        }
    }
}