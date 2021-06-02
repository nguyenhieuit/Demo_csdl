using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace demo_csdl
{
    public partial class sanpham : System.Web.UI.Page
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\Buoi9_CSDL\demo_csdl\demo_csdl\App_Data\ql1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            load_DL();
        }
        public void load_DL()
        {
            if (Page.IsPostBack) return;
            String MaLoai = Context.Items["ML"].ToString();
            SqlConnection cnn = new SqlConnection(link);
            try
            {
                cnn.Open();
                string sql = "Select * From SanPham Where MaLoai='"+MaLoai+"'";
                SqlCommand cmm = new SqlCommand(sql, cnn);
                SqlDataReader read = cmm.ExecuteReader();
                this.GridView1.DataSource = read;
                this.GridView1.DataBind();
                
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            finally { cnn.Close(); }
        }
    }
}