using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmzBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botStart_Click(object sender, EventArgs e)
        {




            //new Classes.AmazonProductPage.AmazonProductInfo().Open();
            //new FindedItems().Show();
            //new Classes.AmazonProductPage.ExcellDataTransfer().Execute();

            Thread thread1 = new Thread(new ThreadStart(ProgramStart));
            thread1.Start();
            //new Classes.Other.ReadFile().Read();           

        }
        private void ProgramStart()
        {
            string minPrice = minPriceNumaramatic.Value.ToString().Replace(',', '.');
            string maxPrice = maxPriceNumaramatic.Value.ToString().Replace(',', '.');
            string puan = puanNumaramatik.Value.ToString().Replace(',', '.');
            try
            {
                new Classes.AmazonSearchPage.SearchPage().Open(UrlTextBox.Text, SkuTextBox.Text, minPrice, maxPrice, puan);
            }
            catch (Exception e)
            {

                new Classes.Other.WriteFile().Error(e);
            }
        }

        private void yapistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IDataObject dObj = Clipboard.GetDataObject();
            if (dObj.GetDataPresent(DataFormats.Text))
            {
                UrlTextBox.Text = dObj.GetData(DataFormats.Text).ToString();
            }
        }
    }
}
