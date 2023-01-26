using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Example2
{
    public partial class FormWashMachine : Form
    {
        private static string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
        public static String rdBtnPrice;
        public static String checkBtnBrand;
        public static int checkBoxAscending = 0;
        public static int chechBoxDescending = 0;
        public static int chechBoxNews = 0;
        private String search;
        public FormWashMachine(string lblSearch)
        {
            InitializeComponent();
            searchLbl.Text = lblSearch;
        }

        private void FormWashMachine_Load(object sender, EventArgs e)
        {
            panel3.Height = 65;
        }

        private void menuBtn_Click(object sender, EventArgs e)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Контакти")
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Text == "Магазини")
            {
                Shops shops = new Shops();
                shops.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void AEGChckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBtnBrand += "AEG ";
        }

        private void ElectroluxChckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBtnBrand += "Electrolux ";
        }

        private void NEFFChckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBtnBrand += "NEFF ";
        }

        private void radiobtn1_200_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnPrice = "1-200";
        }

        private void radiobtn200_400_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnPrice = "200-400";
        }

        private void radiobtn400_800_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnPrice = "400-800";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Цени Възходящо")
            {
                checkBoxAscending = 1;
            }
            else if (comboBox1.SelectedItem.ToString() == "Цени Низходящо")
            {
                chechBoxDescending = -1;
            }
            else if (comboBox1.SelectedItem.ToString() == "Нови")
            {
                chechBoxNews = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search = srchBox.Text;
            String sqlQuery = null;
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT A.NAME_APPLIANCE,B.NAME_BRAND,P.PRICE \n" +
                "FROM TYPE_OF_APPLIANCES A \n" +
                "INNER JOIN ORDERS O ON O.APPLIANCE_ID_APPLIANCE=A.ID_APPLIANCE \n" +
                "INNER JOIN TYPE_OF_BRANDS B ON O.BRAND_ID_BRAND=B.ID_BRAND \n" +
                "INNER JOIN PRICE P ON O.PRICE_ID_PRICE=P.ID_PRICE \n" +
                "WHERE B.NAME_BRAND='" + search + "' \n";
            cmd.CommandType = CommandType.Text;
            /*
             try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sqlQuery = (string)reader["ID_CONSULTANT"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
             */
        }
    }
}
