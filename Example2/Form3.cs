using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Configuration;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace Example2
{
    public partial class Form3 : Form
    {
        public static bool resemail;
        public static bool respass;
        public static bool resphone;
        public static bool resName;
        public static bool resCity;
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void emailTxt_enter(object sender, EventArgs e)
        {
            if (emailTxt.Text == "Въведете имейл")
            {
                emailTxt.Text = "";
                emailTxt.ForeColor = Color.Black;
            }
        }

        private void emailTxt_leave(object sender, EventArgs e)
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

        private void passTxt_enter(object sender, EventArgs e)
        {
            if (passTxt.Text == "Въведете парола")
            {
                passTxt.Text = "";
                passTxt.ForeColor = Color.Black;
            }
        }

        private void passTxt_leave(object sender, EventArgs e)
        {
            if (passTxt.Text == "")
            {
                passTxt.Text = "Въведете парола";
                passTxt.ForeColor = Color.Silver;
            }
            else if (passTxt.Text != "")
            {
                 respass = Regex.IsMatch(passTxt.Text,"^[A-Za-z0-9]{6,20}");
                if (!respass)
                {
                    MessageBox.Show("Invalid Password");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            //string data2 = "Data Source=(LocalDB)MSSQLLocalDB;";
            OracleConnection conn = new OracleConnection(oradb); // C#
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                if (resName && resemail && resCity && respass && resphone)
                {
                    cmd.CommandText = "insert into client values('" + 1 + "','" + nameTxt.Text + "','" + phoneTxt.Text + "','" + emailTxt.Text + "','" + passTxt.Text + "','" + cityTxt.Text + "')";
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }
                nameTxt.Text = "";
                phoneTxt.Text = "";
                emailTxt.Text = "";
                passTxt.Text = "";
                cityTxt.Text = "";
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cityTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void nameTxt_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
