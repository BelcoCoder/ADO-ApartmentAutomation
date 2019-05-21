using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ADO_ApartmentOtomation
{
    public partial class EForm : Form
    {
        SqlConnection con = new SqlConnection();
        string conString = "Server=.; Database=ApartmanDB; Integrated Security=true;";
        public EForm()
        {
            con.ConnectionString = conString;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DbRefresh();
            DbSave();
        }

        private void DbRefresh()
        {
            lbExpense.Items.Clear();
            lbDate.Items.Clear();
            lbAmount.Items.Clear();

            string sql = "SELECT * FROM tblGiderler ORDER BY Tarih DESC";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                lbExpense.Items.Add(item["GiderTipi"]);
                lbDate.Items.Add(item["Tarih"]);
                lbAmount.Items.Add(item["Tutar"]);
            }
        }

        private void DbSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO tblGiderler (Tutar, GiderTipi, Tarih) VALUES(@tutar, @tip, @tarih)";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("tutar", nmAmount.Value);
            string expenses = "";
            foreach (var item in clb1.CheckedItems)
                expenses += ", " + item;
            expenses = expenses.Remove(0, 2);

            cmd.Parameters.AddWithValue("tip", expenses);
            cmd.Parameters.AddWithValue("tarih", dtpDate.Value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void EForm_Load(object sender, EventArgs e)
        {
            DbRefresh();
        }
    }
}
