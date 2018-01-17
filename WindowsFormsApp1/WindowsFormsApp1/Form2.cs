using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excel.Application x1Appl = new excel.Application();

            String file = "C:\\Users\\" + Environment.UserName + "\\VSTSPROJECT\\WindowsFormsApp1\\WindowsFormsApp1\\SpreadSheet\\userandpass.xlsx";

            excel.Workbook x1WorkBook = x1Appl.Workbooks.Open(file);

            excel._Worksheet x1WorkSheet = x1WorkBook.Sheets[1];

            excel.Range x1Range = x1WorkSheet.UsedRange;

            int xlRowCnt = 0;

            String Username;
            String Password;
            Boolean available = true;

            for (xlRowCnt = 1; xlRowCnt <= x1Range.Rows.Count; xlRowCnt++)
            {
                Username = (string)(x1Range.Cells[xlRowCnt, 1] as excel.Range).Value2;
              //  Password = (string)(x1Range.Cells[xlRowCnt, 2] as excel.Range).Value2;

                if (Username == textBox1.Text)
                {
                    DialogResult ch;
                    ch = MessageBox.Show("Username Taken Unlucky", "Error", MessageBoxButtons.YesNo);
                    available = false;

                    if (ch == DialogResult.Yes)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        x1WorkBook.Close();
                        x1Appl.Quit();
                        Application.Exit();
                    }
                }
            }

            if (available == true)
            {
                try
                {
                    MessageBox.Show("Username Set", "Wooo");
                    x1WorkBook.Close();
                    x1Appl.Quit();
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
