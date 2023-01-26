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
    public partial class Form2 : Form
    {
        public static string queryRes;
        public static bool resemail;
        public static bool respass;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void emailText_enter(object sender, EventArgs e)
        {
            if(txtbox_email.Text== "Въведете имейл")
            {
                txtbox_email.Text = "";
                txtbox_email.ForeColor = Color.Black;
            }
        }

        private void emailText_leave(object sender, EventArgs e)
        {
            if (txtbox_email.Text == "")
            {
                txtbox_email.Text = "Въведете имейл";
                txtbox_email.ForeColor = Color.Silver;
            }
            else if (txtbox_email.Text != "")
            {
                resemail = Regex.IsMatch(txtbox_email.Text, "^[A-Za-z0-9]{8,20}@[a-z]{3,10}.(com|bg)$");
                if (!resemail)
                {
                    MessageBox.Show("Invalid Email");
                }
            }
        }

        private void passwordTxt_enter(object sender, EventArgs e)
        {
            if (txtbox_pass.Text == "Въведете парола")
            {
                txtbox_pass.Text = "";
                txtbox_pass.ForeColor = Color.Black;
            }
        }

        private void passwordTxt_leave(object sender, EventArgs e)
        {
            if (txtbox_pass.Text == "")
            {
                txtbox_pass.Text = "Въведете парола";
                txtbox_pass.ForeColor = Color.Silver;
            }
            else if (txtbox_pass.Text != "")
            {
                respass = Regex.IsMatch(txtbox_pass.Text, "^[A-Za-z0-9]{6,20}");
                if (!respass)
                {
                    MessageBox.Show("Invalid Password");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void txtbox_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT C.NAME_CLIENT \n" +
                "FROM CLIENT C \n" +
                "WHERE C.EMAIL_CLIENT='" + txtbox_email.Text + "'";
            cmd.CommandType = CommandType.Text;
            if (respass && resemail)
            {
                try
                {
                    conn.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        queryRes = (string)reader["NAME_CLIENT"];
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
        }
            Form1 f1 = new Form1(queryRes);
            f1.Show();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
