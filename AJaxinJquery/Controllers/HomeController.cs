using AJaxinJquery.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJaxinJquery.Controllers
{
    public class HomeController : Controller
    {
        public SqlConnection con = new SqlConnection("data source=JAYSON\\SQLEXPRESS; database=ASPNETsecurity; integrated security=SSPI; MultipleActiveResultSets=True");
        SqlCommand cmd = new SqlCommand();
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult JqAJAX(Student st)
        {
            con.Open();
         
            if(st.CheckedID == true)
            {
                cmd.CommandText = "update  Datalist Set  Title='"+st.ID+"' Where Title ='1001'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();

            }else if (st.CheckedName == true)
            {
                cmd.CommandText = "update  Datalist Set  Picture='" + st.Name + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();
            }else  if (st.CheckedAge == true)
            {
                cmd.CommandText = "update  Datalist Set  Vip_Number='" + st.Age + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                con.Close();
            }else
            {

                return Json(new
                {
                    msg = "Nothing update in database"
                });

            }

            return Json(new
            {
                msg = "Successfully added " + st.Name + " into DataBase"
            });



        }
    }
}