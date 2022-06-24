using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace qlbthuoc
{
    public partial class frmKH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public frmKH()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmKH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5GJIHLS\\SQLEXPRESS;Initial Catalog=QLNTDA;" +
                "Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from tblKH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            GrdData.DataSource = dt;
        }
    }
}
