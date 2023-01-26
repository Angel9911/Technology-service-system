using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Example2
{
    public partial class ShopsTable : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public static string resLocation;
        public static string resAddress;
        public static string restime;
        public static string resConsult;
        public ShopsTable()
        {
            InitializeComponent();
        }

        private void ShopsTable_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = showData();

            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 2;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;


            //workTime.DefaultCellStyle.Format = "HH:mm:ss";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }
        public DataTable showData()
        {
            dataTable = new DataTable();
            string oradb = "User Id=MARKET;Password=a123;Data Source=DESKTOP-O1SSE52/XE";
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText="SELECT O.LOCATION_CITY,O.ADDRESS_OFFICE,O.OPEN,O.CLOSE,OFC.NAME \n"+
                   "FROM OFFICE O \n" +
            "INNER JOIN OFFICE_CONSULTANT OFC ON O.ID_OFFICE = OFC.OFFICE_ID_OFFICE \n";
           /* cmd.CommandText = "SELECT O.LOCATION_CITY,O.ADDRESS_OFFICE,O.OPEN || '-' || O.CLOSE AS WORKTIME,OFC.NAME \n" +
            "FROM OFFICE O \n" +
            "INNER JOIN OFFICE_CONSULTANT OFC ON O.ID_OFFICE = OFC.OFFICE_ID_OFFICE \n";*/
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Shops shops = new Shops();
            shops.Show();
            this.Hide();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;

            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight;

            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r1 = dataGridView1.GetCellDisplayRectangle(2, -1, true);
            int w2 = dataGridView1.GetCellDisplayRectangle(3, -1, true).Width;
            r1.X += 1;

            r1.Y += 2;

            r1.Width = r1.Width + w2 - 2;

            r1.Height = r1.Height / 2 ;



            using (SolidBrush br = new SolidBrush(dataGridView1.ColumnHeadersDefaultCellStyle.BackColor))
            {

                e.Graphics.FillRectangle(br, r1);

            }
            using (SolidBrush br = new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor))
            {

                StringFormat sf = new StringFormat();



                e.Graphics.DrawString("Работно време", dataGridView1.ColumnHeadersDefaultCellStyle.Font, br, r1, sf);

            }

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)

            {

                Rectangle r2 = e.CellBounds;

                r2.Y += e.CellBounds.Height / 2;

                r2.Height = e.CellBounds.Height / 2;



                e.PaintBackground(r2, true);



                e.PaintContent(r2);

                e.Handled = true;

            }
        }
    }
}
