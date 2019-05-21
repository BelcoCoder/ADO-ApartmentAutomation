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
    public partial class IForm : Form
    {
        SqlConnection con = new SqlConnection();
        string conString = "Server=.; Database=ApartmanDB; Integrated Security=true;";
        public IForm()
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
            lbAmount.Items.Clear();
            lbApartment.Items.Clear();
            lbDate.Items.Clear();

            string sql = "SELECT * FROM tblGelirler ORDER BY Tarih DESC";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                lbApartment.Items.Add("Daire" + item["DaireNo"]);
                lbDate.Items.Add(item["Tarih"]);
                decimal amount = (decimal)item["Tutar"];
                lbAmount.Items.Add(amount.ToString("C"));
            }
        }

        private void DbSave()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText ="INSERT INTO tblGelirler (DaireNo, Tutar, Tarih) VALUES (@dno, @tutar, @tarih)";
            cmd.Parameters.AddWithValue("dno", nmAp.Value);
            cmd.Parameters.AddWithValue("tutar", nmAm.Value);
            cmd.Parameters.AddWithValue("tarih", dtpDate.Value);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void IForm_Load(object sender, EventArgs e)
        {
            DbRefresh();
        }
    }
}
