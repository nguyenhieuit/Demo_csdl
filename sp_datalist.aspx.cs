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
    public partial class sp_datalist : System.Web.UI.Page
    {
        string link = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\Buoi9_CSDL\demo_csdl\demo_csdl\App_Data\ql1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            loadsp();
        }
        public void loadsp()
        {
            if (Page.IsPostBack) return;
            SqlConnection cnn = new SqlConnection(link);
            try
            {
                cnn.Open();
                string sql = "Select *From SanPham";
                SqlCommand cmm = new SqlCommand(sql, cnn);
                SqlDataReader read = cmm.ExecuteReader();
                this.DataList1.DataSource = read;
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}