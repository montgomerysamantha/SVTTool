using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVTTool;

namespace SVTTool
{
    public partial class uiSVTForm : Form
    {
        public uiSVTForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            uiOpenFileDialog.Filter = "CSV files | *.csv";
            if (uiOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(uiOpenFileDialog.FileName);
                //read in the file line by line
                StringBuilder sb = new StringBuilder();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.Append(line);
                }
                uiDisplayTextBox.Text = null;
                uiDisplayTextBox.Text = sb.ToString();
                sr.Close();
                MessageBox.Show("Read in file");
            }
        }
    }
}
