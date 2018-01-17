using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public String loggedName;
        public Form1()
        {
            InitializeComponent();
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
                 Boolean valid = false;
                 int max = x1Range.Rows.Count + 1;

                for (xlRowCnt = 1; xlRowCnt <= x1Range.Rows.Count; xlRowCnt++)
                {
                    Username = (string)(x1Range.Cells[xlRowCnt, 1] as excel.Range).Value2;
                    Password = (string)(x1Range.Cells[xlRowCnt, 2] as excel.Range).Value2;

                    if (Username == textBox1.Text && Password == textBox2.Text)
                    {
                    MessageBox.Show("Login Successful", "Success");
                    loggedName = textBox1.Text;
                    Form3 f3 = new Form3(loggedName);
                    f3.Show();
                    valid = true;
                    this.Hide();
                    xlRowCnt = max;
       
                    }
                        else
                        {
                        }
                }

            if (valid == false)
            {
                MessageBox.Show("Login UnSuccessful", "Fail");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            x1WorkBook.Close();
            x1Appl.Quit();
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
