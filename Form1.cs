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

            //RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command\");
            //string s = key.GetValue("").ToString();
            //textBoxOutput.Text = s;
            //s就是你的默认浏览器，不过后面带了参数，把它截去，不过需要注意的是：不同的浏览器后面的参数不一样！
            //"D:\Program Files (x86)\Google\Chrome\Application\chrome.exe" -- "%1"
            //System.Diagnostics.Process.Start("C:\\Program Files\\Internet Explorer\\iexplore.exe", "http://blog.csdn.net/testcs_dn");
            //System.Diagnostics.Process.Start("explorer.exe", result);
            //System.Diagnostics.Process.Start("explorer.exe", "https://kns.cnki.net/kcms/download.aspx?filename=rpHOBFDSV1EOvgEZhZkeN9EWtlEchFUVzQmTvYWQ3JlUOhzKJFXOEV1LwMEUZVkNiVGRzc0R2lXSpNHdlB1UJhEZ2smTmFUTppHZLFWO2ZTU4R3cKNUU4ZFNU5Weyp0cJBlUVdXZ2lFUkJmNBVkdLhHcCJ1N3FnS&dflag=pdfdown&dflag=cajdown&tablename=CMFDTEMP&uid=WEEvREcwSlJHSldSdmVqMDh6a1dpb1d5VG9CSzlSZmxyeTlWM1J4U2lWaz0=$9A4hF_YAuvQ5obgVAqNKPCYcEjKensW4IQMovwHtwkF4VYPoHbKxJw!!");

        }
    }
}
