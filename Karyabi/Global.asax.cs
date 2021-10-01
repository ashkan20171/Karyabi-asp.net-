using System;

namespace Karyabi
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineUserCount"] = 0;
            Application.UnLock();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineUserCount"] = Convert.ToInt64(Application["OnlineUserCount"]) + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineUserCount"] = Convert.ToInt64(Application["OnlineUserCount"]) -1;
            Application.UnLock();

            object objUserId = Session["UserId"];
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}