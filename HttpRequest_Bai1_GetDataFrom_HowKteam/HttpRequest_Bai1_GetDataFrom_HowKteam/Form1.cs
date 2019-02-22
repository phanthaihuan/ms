using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace HttpRequest_Bai1_GetDataFrom_HowKteam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            string html = http.Get("https://www.tuoitre.vn").ToString();
            MessageBox.Show(html);
        }
    }
}
