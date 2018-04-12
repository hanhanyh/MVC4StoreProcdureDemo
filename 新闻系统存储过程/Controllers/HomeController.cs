using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using 新闻系统存储过程.Models;
namespace 新闻系统存储过程.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ///分页查询
            string   constr="Data Source=.\\SQLEXPRESS;Initial Catalog=NewsTest1;Integrated Security=True";
            int allpage = 0;
            DataSet ds = new DataSet();
            using(SqlConnection conn=new SqlConnection(constr))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("GetDataByIndex", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add(new SqlParameter("@pageindex", SqlDbType.Int)).Value = 0;//当前页数 0开始
                adapter.SelectCommand.Parameters.Add(new SqlParameter("@pagecount", SqlDbType.Int)).Direction = ParameterDirection.Output;//输出参数，显示总页数
                adapter.Fill(ds);
                allpage = Convert.ToInt32(adapter.SelectCommand.Parameters["@pagecount"].Value) - 1;    //返回总页数
            }
            //["data"] = ds.Tables[0].DefaultView;
            DataTable dt = ds.Tables[0];
            List<NewsInfo> newslist = new List<NewsInfo>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NewsInfo ni = new NewsInfo() { Id = Convert.ToInt32(dt.Rows[i]["ID"]), Name = dt.Rows[i]["Name"].ToString(), Cclass = dt.Rows[i]["Class"].ToString(), Author = dt.Rows[i]["auter"].ToString(), Datetime = dt.Rows[i]["time"].ToString(), Content = dt.Rows[i]["content"].ToString() };
                newslist.Add(ni);
            }
            ViewData["data"] = newslist;
                return View();
        }

    }
}
