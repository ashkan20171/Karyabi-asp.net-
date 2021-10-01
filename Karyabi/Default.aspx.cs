using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Karyabi
{
    public partial class Default : System.Web.UI.Page
    {
        KaryabiDBEntities database = new KaryabiDBEntities();
        public static string Name, Family;
        public static bool State = false;
        public static bool FlagAdmin = false;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            litOnlineUserCount.Text =
                string.Format("تعداد نفرات انلاین {0} تفر", Application["OnlineUserCount"]);
            litSessionId.Text =
                string.Format("SessionId : {0}", Session.SessionID);
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == string.Empty)
            {
                lblErrormessge.InnerHtml = "<span style='color:White'>نام کاربری را وارد کنید</span>";
                return;
            }
            if (txt_password.Text == string.Empty)
            {
                lblErrormessge.InnerHtml = "<span style='color:White'> رمز عبور را وارد کنید</span>";
                return;
            }
            else
            {
                #region ShowInfoCustomers
                string selName = "select * from tbl_Customers where Username='" + txt_username.Text + "' ";
                DataTable dt = new DataTable();
                dt = Function.DoQuery(selName);
                #endregion




                var login = database.tbl_Customers.Where(c => c.Username == txt_username.Text && c.Password == txt_password.Text);
                if (login.Count() > 0)
                {
                    Name = dt.Rows[0]["Name"].ToString();
                    Family = dt.Rows[0]["Family"].ToString();
                    State = Convert.ToBoolean(dt.Rows[0]["State"]);
                    FlagAdmin =Convert.ToBoolean( dt.Rows[0]["FlagAdmin"]);

                    Session["Username"] = txt_username.Text;
                    Response.Redirect("~/UserPanel/CustomerPanel.aspx",false );
                  //  System.Windows.Forms.MessageBox.Show( "خوش امدید" +Name + "*" + Family);
                    lblErrormessge.InnerHtml = "";
                }
                else
                {
                    lblErrormessge.InnerHtml = "<span style='color:Yellow'>نام کاربری یا رمز عبور اشتباه است</span>";
                }
            }

        }
    }
}