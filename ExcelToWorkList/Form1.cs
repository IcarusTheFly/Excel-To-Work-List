using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Windows.Forms;

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

            /*var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Open(btnChoose2.Text);*/
        }
    }
}
