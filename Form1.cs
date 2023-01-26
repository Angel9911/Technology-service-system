using Example2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        private  int indexmenu;
        public static String btnHladilnici;
        public static String btnPhones;
        public static String btnTV;
        public static String btnAirC;
        public static String btnWash;
        public Form1(string lblNameClient)
        {
            InitializeComponent();
            lblname.Show();
            clientName.Show();
            clientName.Text = lblNameClient;
        }
        public Form1()
        {
            InitializeComponent();
            lblname.Hide();
            clientName.Hide();
         }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            panel3.Height = 65;
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 252)
            {
                panel3.Height = 65;

            }
            else
            {
                panel3.Height = 252;
            }
        }

        private void Btn_hladilnici_Click(object sender, EventArgs e)
        {
            btnHladilnici = "Хладилници";
            Form4 f4 = new Form4(btnHladilnici);
            f4.Show();
            this.Hide();
            
        }

        private void btn_Phone_Click(object sender, EventArgs e)
        {
            btnPhones = "Телефони";
            FormPhones f5 = new FormPhones(btnPhones);
            f5.Show();
            this.Hide();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void OnMouseHoverBtn(object sender, EventArgs e)
        {
            btnLog.BackColor = SystemColors.Highlight;
        }

        private void OnMouseLeaveBtn(object sender, EventArgs e)
        {
            btnLog.BackColor = SystemColors.ButtonFace;
        }

        private void OnSearchLeaveBtn(object sender, EventArgs e)
        {
            srchBtn.BackColor = SystemColors.ButtonFace;
        }

        private void OnSearchHoverBtn(object sender, EventArgs e)
        {
            srchBtn.BackColor = SystemColors.Highlight;

        }

        private void ContactMenu_Click(object sender, EventArgs e)
        {
            /* Form5 f5 = new Form5();
             f5.Show();
             this.Hide();
             Shops shops = new Shops();
             shops.Show();
            indexmenu = ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender);
            clientName.Text = indexmenu.ToString();
            Form5 f5 = new Form5();
            f5.Show();*/
        }
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text== "Контакти")
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else if(e.ClickedItem.Text== "Магазини")
            {
                Shops shops = new Shops();
                shops.Show();
                this.Hide();
            }
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            /*
            Shops shops = new Shops();
            Form5 f5 = new Form5();
            String str;
            str=((toolStripMenuItem1)sender).Text;
            foreach(ToolStripItem item in menuStrip1.Items)
            {
                ((item)sender).Text=
            }*/
        }

        private void btn_Tv_Click_1(object sender, EventArgs e)
        {
            btnTV = "Телевизори";
            FormTV formTV = new FormTV(btnTV);
            formTV.Show();
            this.Hide();
        }

        private void btn_AirC_Click(object sender, EventArgs e)
        {
            btnAirC = "Климатици";
            FormAirCon fa = new FormAirCon(btnAirC);
            fa.Show();
            this.Hide();
        }

        private void btn_Laundry_Click(object sender, EventArgs e)
        {
            btnWash = "Перални";
            FormWashMachine f = new FormWashMachine(btnWash);
            f.Show();
            this.Hide();
        }
    }
  }
