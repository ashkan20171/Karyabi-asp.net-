using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Karyabi.UserPanel
{
    public partial class CustomerPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Username"]==null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                if (Default.State == false && Default.FlagAdmin == false)
                {
                    lblState.InnerHtml = " وضعیت تایید : <span style='color:Red'>تایید نشده</span>";
                }
                else if(Default.State==true && Default.FlagAdmin==false)
                {
                    lblState.InnerHtml = " وضعیت تایید : <span style='color:Red'>تایید نشده</span>";
                }
                else if (Default.State == true && Default.FlagAdmin==true)
                {
                    lblState.InnerHtml = " وضعیت تایید : <span style='color:Green'>تایید شده</span>";
                }
                    

                lblusername.InnerHtml=" کاربر جاری : <span style='color:Blue'>" + Session["Username"].ToString() + "</span>";
                lblFullName.InnerHtml = "خوش امدید : <span style='color:Red'>" +Default.Name + " " +Default.Family + "</span>";
             
            }
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Remove("Username");
            Session.Abandon();
            Response.Redirect("~/Default.aspx");
        }
    }
}