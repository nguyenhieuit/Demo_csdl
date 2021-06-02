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
    public partial class WebForm1 : System.Web.UI.Page
    {
        string linklk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KTTMDT\Buoi9_CSDL\demo_csdl\demo_csdl\App_Data\ql1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            load_dsloaiSP();
            load_rdblist();
        }
        public void load_dsloaiSP()
        {
            if (Page.IsPostBack) return;//Load lại trang khi trang chưa đc load
            string sql = "Select * From LoaiSP";
            try{
                SqlDataAdapter da = new SqlDataAdapter(sql, linklk);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rdb_listSP.DataSource = dt;
                this.rdb_listSP.DataTextField = "TenLoai";
                this.rdb_listSP.DataValueField = "MaLoai";
                this.rdb_listSP.DataBind(); 
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
        public void load_rdblist()
        {
            if (Page.IsPostBack) return;//Load lại trang khi trang chưa đc load
            string sql = "Select * From LoaiSP";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, linklk);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rdb_listSP.DataSource = dt;
                this.rdb_listSP.DataTextField = "TenLoai";
                this.rdb_listSP.DataValueField = "MaLoai";
                this.rdb_listSP.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void rdb_listSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            String MaLoai = this.rdb_listSP.SelectedItem.Value;
            Context.Items["ML"] = MaLoai;
            Server.Transfer("sanpham.aspx");
        }
    }
}