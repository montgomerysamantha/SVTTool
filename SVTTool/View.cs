using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SVTTool;

namespace SVTTool
{
    public partial class uiSVTForm : Form
    {
        Presenter p = new Presenter();
        public uiSVTForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            LoadLocalSemesterFile();
            //MessageBox.Show("Read in file");
        }

        private void uiAboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 by Samantha Montgomery and Trent Gierhart");
        }

        private bool LoadLocalSemesterFile()
        {
            uiOpenFileDialog.Filter = "CSV files | *.csv";
            if (uiOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(uiOpenFileDialog.FileName);
                uiLocalTextBox.Text = uiOpenFileDialog.FileName;
                //read in the file line by line
                string time = sr.ReadLine();
                sr.ReadLine();

                List<Course> courses = new List<Course>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    Course c = new Course(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7],
                    arr[8], arr[9], arr[10], arr[11], arr[12], arr[13], arr[14], arr[15],
                    arr[16], arr[17], arr[18], arr[19], arr[20], arr[21], arr[22]);
                    courses.Add(c);
                }
                /* testing code
                foreach (Course test in courses)
                {
                    uiDisplayTextBox.Text += test.ToString() + Environment.NewLine;
                }*/

                sr.Close();
                p.MakeSISSemester(time, courses);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoadSISFile()
        {
            uiOpenFileDialog.Filter = "CSV files | *.csv";
            if (uiOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(uiOpenFileDialog.FileName);
                uiKSISTextBox.Text = uiOpenFileDialog.FileName;
                //read in the file line by line
                string time = sr.ReadLine();
                sr.ReadLine();

                List<Course> courses = new List<Course>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    Course c = new Course(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7],
                    arr[8], arr[9], arr[10], arr[11], arr[12], arr[13], arr[14], arr[15],
                    arr[16], arr[17], arr[18], arr[19], arr[20], arr[21], arr[22]);
                    courses.Add(c);
                }

                sr.Close();
                /* testing code
                foreach (Course test in courses)
                {
                    uiDisplayTextBox.Text += test.ToString() + Environment.NewLine;
                }*/

                p.MakeLocalSemester(time, courses);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void uiReloadButton_Click(object sender, EventArgs e)
        {
            if (uiLocalTextBox.Text != "")
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(uiLocalTextBox.Text);

                //read in the file line by line
                string time = sr.ReadLine();
                sr.ReadLine();

                List<Course> courses = new List<Course>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    Course c = new Course(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7],
                    arr[8], arr[9], arr[10], arr[11], arr[12], arr[13], arr[14], arr[15],
                    arr[16], arr[17], arr[18], arr[19], arr[20], arr[21], arr[22]);
                    courses.Add(c);
                }

                sr.Close();
                p.MakeLocalSemester(time, courses);

                FileInfo f1 = new FileInfo(uiKSISTextBox.Text);

                if (f1.Exists)
                {
                    line = "";
                    sr = new
                    System.IO.StreamReader(uiKSISTextBox.Text);
                    //read in the file line by line
                    time = sr.ReadLine();
                    sr.ReadLine();

                    courses = new List<Course>();
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] arr = line.Split(',');
                        Course c = new Course(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7],
                        arr[8], arr[9], arr[10], arr[11], arr[12], arr[13], arr[14], arr[15],
                        arr[16], arr[17], arr[18], arr[19], arr[20], arr[21], arr[22]);
                        courses.Add(c);
                    }

                    sr.Close();
                    /* testing code
                    foreach (Course test in courses)
                    {
                        uiDisplayTextBox.Text += test.ToString() + Environment.NewLine;
                    }*/

                    p.MakeLocalSemester(time, courses);
                    string verification = p.Verify();
                    uiDisplayTextBox.Text = verification;
                }

                //MessageBox.Show("Reload Successful");
            }
            else
            {
                MessageBox.Show("Please load in a file first before trying to Reload!");
            }
        }

        private void verifySemestersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSISFile();
            string verification = p.Verify();
            uiDisplayTextBox.Text = verification;
        }

        private void uiClearButton_Click(object sender, EventArgs e)
        {
            uiLocalTextBox.Text = "";
            uiKSISTextBox.Text = "";
            uiDisplayTextBox.Text = "";
            p.Clear();
        }
    }
}
