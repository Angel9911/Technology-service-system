using DotNetBrowser;
using DotNetBrowser.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Example2
{
    public partial class Shops : Form
    {

        public Shops()
        {
            InitializeComponent();
        }


        private void Shops_Load(object sender, EventArgs e)
        {
            listBoxCity.Items.Add("Варна");
            listBoxCity.Items.Add("София");
            listBoxCity.Items.Add("Пловдив");
            listBoxCity.Items.Add("Шумен");
            listBoxCity.Items.Add("Бургас");
            listBoxCity.Items.Add("Русе");
            listBoxCity.Items.Add("Добрич");
            listBoxCity.Items.Add("Враца");
            listBoxCity.Items.Add("Плевен");
            webView1.Navigate("https://www.google.com/maps/@42.8673139,25.084981,7.02z");
        }

        private void webView1_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedItem = listBoxCity.Items[listBoxCity.SelectedIndex].ToString();
            //label1.Text = selectedItem;
            if (selectedItem == "Варна")
            {
                webView1.Navigate("https://www.google.com/maps/@43.2145753,27.9005786,12.93z");
            }
            else if (selectedItem == "София")
            {
                webView1.Navigate("https://www.google.com/maps/@42.6954108,23.2539073,12z");
            }
            else if (selectedItem == "Пловдив")
            {
                webView1.Navigate("https://www.google.com/maps/@42.1441156,24.7058549,13z");
            }
            else if (selectedItem == "Шумен")
            {
                webView1.Navigate("https://www.google.com/maps/@43.2729689,26.937075,13.74z");
            }
            else if (selectedItem == "Бургас")
            {
                webView1.Navigate("https://www.google.com/maps/@42.5026452,27.4494743,13.77z");
            }
        }

        private void lblTableView_Click(object sender, EventArgs e)
        {
            ShopsTable shopsTable = new ShopsTable();
            shopsTable.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
