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
    public partial class FormAirCon : Form
    {
        private static string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
        public static String rdBtnPrice;
        public static String checkBtnBrand;
        public static int checkBoxAscending = 0;
        public static int chechBoxDescending = 0;
        public static int chechBoxNews = 0;
        private String search;
        private int id_Client;
        private int id_App;
        private int id_Office;
        private int id_Brand;
        private int id_Delivery;
        private int id_Price;
        public FormAirCon(string lblSearch)
        {
            InitializeComponent();
            searchLbl.Text = lblSearch;
        }

        private void FormAirCon_Load(object sender, EventArgs e)
        {
            panel3.Height = 65;
            comboBox1.Items.Add("Цени Възходящо");
            comboBox1.Items.Add("Цени Низходящо");
            comboBox1.Items.Add("Нови");
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

        private void BoschChckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBtnBrand += "Bosch ";
        }

        private void InventChckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBtnBrand += "Inventor ";
        }

        private void PanasonicChckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBtnBrand += "Panasonic ";
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
        private int getIdFromClient(string NameClient) // id client za poruchki
        {
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT C.ID_CLIENT \n" +
                "FROM CLIENT C \n" +
                "WHERE C.NAME_CLIENT='" + NameClient + "';";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_Client = (int)reader["ID_CLIENT"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                conn.Close();
            }
            return id_Client;
        }
        private int getIdFromAppliance(string NameAppliance)// id appliance za poruchki
        {
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT A.ID_APPLIANCE \n" +
                "FROM TYPE_OF_APPLIANCES A \n" +
                "A.NAME_APPLIANCE='" + NameAppliance + "'";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_App = (int)reader["ID_APPLIANCE"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return id_App;
        }
        private int getIdFromBrand(string NameBrand)// id brand za poruchki
        {
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT B.ID_BRAND \n" +
                "FROM TYPE_OF_BRANDS B \n" +
                "B.NAME_BRAND='" + NameBrand + "'";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_Brand = (int)reader["ID_BRAND"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return id_Brand;
        }
        private int getIdFromOffice(string city, string address)// id office za poruchki
        {
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT O.ID_OFFICE \n" +
                "FROM OFFICE O \n" +
                "O.LOCATION_CITY='" + city + "' AND O.ADDRESS_OFFICE='" + address + "'";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_Office = (int)reader["ID_OFFICE"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return id_Office;
        }
        private int getIdFromPrice(double price)// id price za orders
        {
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT P.ID_PRICE \n" +
                "FROM PRICE P \n" +
                "P.PRICE='" + price + "';";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_Price = (int)reader["ID_PRICE"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return id_Price;
        }
        private int getIdFromDelivery(string deliv_to, string date)// date? ? ? Tuka trqbva da se vidi da se dobavi i eventualno id na client pri poruchkata zashtoto
                                                                   // moje da ima dve poruchki s edin i sushti grad i data
        {
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT D.ID_DELIVERY \n" +
                "FROM DELIVERY D \n" +
                "D.DELIVERY_TO='" + deliv_to + "' AND D.DATE_SENDING='" + date + "'";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_Delivery = (int)reader["ID_DELIVERY"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return id_Delivery;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            search = srchBox.Text;
            string query_appliance = null;
            string query_brand = null;
            string query_price = null;
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
                    query_appliance = (string)reader["NAME_APPLIANCE"];
                    query_brand = (string)reader["NAME_BRAND"];
                    query_price = (string)reader["PRICE"];
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

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            // tova of form4 shte se vzeme
        }
    }
}
