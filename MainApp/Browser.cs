using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Darwin.WindowsForm
{
    public partial class Browser : Form
    {
        string _url = "";
        public Browser(string url)
        {
            _url = url;
            InitializeComponent();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(_url);
            webBrowser1.Show();
        }
    }
}
