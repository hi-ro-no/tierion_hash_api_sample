using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tierion_hash_api_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string url = "https://hashapi.tierion.com/v1/hashitems";

            System.Net.WebClient wc = new System.Net.WebClient();

            wc.Headers.Add("Authorization: Bearer " + this.txtBoxAccessToken.Text);

            System.Collections.Specialized.NameValueCollection ps = new System.Collections.Specialized.NameValueCollection();
            ps.Add("hash", this.txtBoxHash.Text);

            byte[] resData = wc.UploadValues(url, ps);
            wc.Dispose();

            string resText = System.Text.Encoding.UTF8.GetString(resData);
            this.txtBoxResponse.Text = resText;
        }

        private void btnSubmitReceipt_Click(object sender, EventArgs e)
        {
            string url = "https://hashapi.tierion.com/v1/receipts/" + this.txtBoxReceipt.Text;

            System.Net.WebClient wc = new System.Net.WebClient();

            wc.Headers.Add("Authorization: Bearer " + this.txtBoxAccessToken.Text);
            
            byte[] resData = wc.DownloadData(url);
            wc.Dispose();

            string resText = System.Text.Encoding.UTF8.GetString(resData);
            this.txtBoxResponseReceipt.Text = resText;
        }
    }
}
