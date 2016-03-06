using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AddressBookWebDemo
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                string un = HttpContext.Current.User.Identity.Name;
                if (un.Split('^').Length > 1)
                {
                    HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(User.Identity, new string[] { Helper.CurrentUserRole });
                }
            }
        }
    }
}