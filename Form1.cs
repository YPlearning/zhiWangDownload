using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhiWangDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            string pattern = "&dflag=nhdown&d";
            string replacement = "&dflag=pdfdown&d";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            textBoxOutput.Text = result;
            webBrowserGet.Navigate(result);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
        }
    }
}
