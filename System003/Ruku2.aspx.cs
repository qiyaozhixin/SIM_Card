using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Ruku2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["quanxian"]) == "")
            {
                Response.Write("<script>window.alert('违规操作！');location.href='Default.aspx';</script>");
            }
            Button13.Visible = false;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            bool fileIsValid = false;
            //如果确认了上传文件，则判断文件类型是否符合要求
            if (this.FileUpload1.HasFile)
            {
                //获取上传文件的后缀
                String fileExtension = System.IO.Path.GetExtension(this.FileUpload1.FileName).ToLower();
                String[] restrictExtension = { ".xls", ".xlsx" };
                //判断文件类型是否符合要求
                for (int i = 0; i < restrictExtension.Length; i++)
                {
                    if (fileExtension == restrictExtension[i])
                    {
                        fileIsValid = true;
                    }
                }
                //如果文件类型符合要求,调用SaveAs方法实现上传,并显示相关信息
                if (fileIsValid == true)
                {
                    try
                    {
                        this.FileUpload1.SaveAs(Server.MapPath("~/Uploadfiles/") + FileUpload1.FileName);
                        string filepath = Server.MapPath("~/Uploadfiles/") + FileUpload1.FileName;
                        DataSet ds = ExcelDataSource(filepath, ExcelSheetName(filepath)[0].ToString());
                        GridView1.DataSource = ds;
                        GridView1.DataBind();
                        Button13.Visible = true;
                        Response.Write("<script>window.alert('上传成功，请确认电话卡信息！');</script>");
                    }
                    catch 
                    {
                        Response.Write("<script>window.alert('无法上传文件！');location.href='Ruku2.aspx';</script>");
                    }
                }
                else
                {
                    Response.Write("<script>window.alert('只能够上传后缀为.xls,.xlsx的文件！');location.href='Ruku2.aspx';</script>");
                }
            }
            else
            {
                Response.Write("<script>window.alert('还没有选择文件！');</script>");
            }
        }


        public DataSet ExcelDataSource(string filepath, string sheetname)
        {
            string strConn;
            strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filepath + ";Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConn);
            OleDbDataAdapter oada = new OleDbDataAdapter("select * from [" + sheetname + "]", strConn);
            DataSet ds = new DataSet();
            oada.Fill(ds);
            conn.Close();
            return ds;
        }

        public ArrayList ExcelSheetName(string filepath)
        {
            ArrayList al = new ArrayList();
            string strConn;
            strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filepath + ";Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable sheetNames = conn.GetOleDbSchemaTable
            (System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            conn.Close();
            foreach (DataRow dr in sheetNames.Rows)
            {
                al.Add(dr[2]);
            }
            return al;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {          
            try
            {
                for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                {
                    string iccid_ruku = GridView1.Rows[i].Cells[0].Text;
                    string pukma_ruku = GridView1.Rows[i].Cells[1].Text;
                    SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象                                                                                                                          //创建SqlCommand对象
                    SqlCommand sqlcmd = new SqlCommand("insert into aspnet_Cardtest(ICCID,当前库位,PUK码,卡状态) values ('" + iccid_ruku + "','" + Session["dangqiandenglu"] + "','" + pukma_ruku + "','0');", sqlcon);
                    if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
                    {
                        sqlcon.Open();                              //打开数据库连接
                    }
                    //使用ExecuteReader方法的返回值创建SqlDataReader对象
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    sqldr.Close();//关闭SqlDataReader对象
                    sqlcon.Close();//关闭数据库连接
                    Response.Write("<script>window.alert('导入成功！');location.href='Ruku2.aspx';</script>");
                }
            }
            catch
            {
                Response.Write("<script>window.alert('导入失败，文件中存在已经被导入的电话卡！');</script>");
            }
        }
    }
}