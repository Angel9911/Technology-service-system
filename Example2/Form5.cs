using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form5 : Form
    {
        private static string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
        private string name_client;
        private string email_client;
        private string phone_client;
        private string city_client;
        private int id_client;
        private int id_consult;
        private int id_office;
        public static bool resphone;
        public static bool resName;
        public static bool resCity;
        public static bool resemail;
        public Form5()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void emailText_enter(object sender, EventArgs e)
        {
            if (emailTxt.Text == "Въведете имейл")
            {
                emailTxt.Text = "";
                emailTxt.ForeColor = Color.Black;
            }

        }
        private void emailText_leave(object sender, EventArgs e)
        {
            if (emailTxt.Text == "")
            {
                emailTxt.Text = "Въведете имейл";
                emailTxt.ForeColor = Color.Silver;
            }
            else if (emailTxt.Text != "")
            {
                resemail = Regex.IsMatch(emailTxt.Text, "^[A-Za-z0-9]{8,20}@[a-z]{3,10}.(com|bg)$");
                if (!resemail)
                {
                    MessageBox.Show("Invalid Email");
                }
            }
        }

        private void phoneTxt_enter(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "Въведете телефон")
            {
                phoneTxt.Text = "";
                phoneTxt.ForeColor = Color.Black;
            }
        }

        private void phoneTxt_leave(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "")
            {
                phoneTxt.Text = "Въведете телефон";
                phoneTxt.ForeColor = Color.Silver;
            }
            else if (phoneTxt.Text != "")
            {
                resphone = Regex.IsMatch(nameTxt.Text, "[0-9]{10}");
                if (!resphone)
                {
                    MessageBox.Show("Invalid Phone");
                }
            }
        }

        private void city_enter(object sender, EventArgs e)
        {
            if (cityTxt.Text == "Въведете град")
            {
                cityTxt.Text = "";
                cityTxt.ForeColor = Color.Black;
            }
        }

        private void city_leave(object sender, EventArgs e)
        {
            if (cityTxt.Text == "")
            {
                cityTxt.Text = "Въведете град";
                cityTxt.ForeColor = Color.Silver;
            }
            resCity = Regex.IsMatch(cityTxt.Text, "^[A-Z][a-z]{5,10}$");
            if (!resCity)
            {
                MessageBox.Show("Invalid City");
            }
        }

        private void nameTxt_enter(object sender, EventArgs e)
        {
            if (nameTxt.Text == "Въведете име")
            {
                nameTxt.Text = "";
                nameTxt.ForeColor = Color.Black;
            }
        }

        private void nameTxt_leave(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameTxt.Text = "Въведете име";
                nameTxt.ForeColor = Color.Silver;
            }
            else if (nameTxt.Text != "")
            {
                resName = Regex.IsMatch(nameTxt.Text, "^[A-Z][a-z]{3,19}$");
                if (!resName)
                {
                    MessageBox.Show("Invalid Name");
                }
            }
        }
        public int selectIdOfClient(String name,String email)
        {
            int id_client;
            String sqlQuery = null;
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT C.ID_CLIENT \n" +
                    "FROM CLIENT C" +
                    "WHERE C.NAME_CLIENT='" + name + "'AND C.EMAIL_CLIENT='" + email + "'";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sqlQuery = (string)reader["ID_CLIENT"];
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
            id_client = Int32.Parse(sqlQuery);
            return id_client;
        }
        public int selectIdOfOffice(string city)
        {
            int id_office=0;
          //  String sqlQuery = null;
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT C.ID_OFFICE \n" +
                    "FROM OFFICE C \n" +
                    "WHERE C.LOCATION_CITY='" + city + "';";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_office = (int)reader["ID_OFFICE"];
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
            //id_consult = Int32.Parse(sqlQuery);
            return id_office;
        }
        public int selectIdOfConsultant(int idOffice)
        {
            int id_consult = 0;
            //  String sqlQuery = null;
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT C.ID_CONSULTANT \n" +
                    "FROM OFFICE_CONSULTANT C \n" +
                    "WHERE C.OFFICE_ID_OFFICE='" + idOffice + "';";
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id_consult = (int)reader["ID_CONSULTANT"];
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
            //id_consult = Int32.Parse(sqlQuery);
            return id_consult;
        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            string message;
            message = MessageTxt.Text;
            name_client = nameTxt.Text;
            phone_client = phoneTxt.Text;
            email_client = emailTxt.Text;
            city_client = cityTxt.Text;
            OracleConnection conn = new OracleConnection(oradb);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                if (resName && resphone && resemail && resCity)
                {
                    id_client = selectIdOfClient(name_client, email_client);
                    id_office = selectIdOfOffice(city_client);
                    id_consult = selectIdOfConsultant(id_office);
                    cmd.CommandText = "insert into info_contacts values('" + 1 + "','" + message + "','" + id_client + "','" + id_consult + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
