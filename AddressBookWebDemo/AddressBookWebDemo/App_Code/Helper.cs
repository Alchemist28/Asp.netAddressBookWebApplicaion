using System;
using System.Web;

/// <summary>
/// Summary description for Helper
/// </summary>
public class Helper
{
    public Helper()
    { }
    public static string connectionstring
    {
        get
        {

            return System.Configuration.ConfigurationManager.ConnectionStrings["AddressBookconnectionstring"].ConnectionString;
        }

    }
    public static void ShowAlert(System.Web.UI.Page page, string message)
    {
        page.ClientScript.RegisterStartupScript(page.GetType(), DateTime.Now.ToString(), "alert(\"" + message + "\");", true);
    }
    public static string Connectionstring
    {
        get
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["RPHSConnectionString"].ConnectionString;
        }
    }
    public static string CurrentUserID
    {
        get
        {
            return HttpContext.Current.User.Identity.Name.Split('^')[0];
        }
    }
    public static string CurrentUserRole
    {
        get
        {
            return HttpContext.Current.User.Identity.Name.Split('^')[2];
        }
    }
    public static string CurrentUserName
    {
        get
        {
            return HttpContext.Current.User.Identity.Name.Split('^')[1];
        }
    }


}
public enum ActionType
{
    Add = 1,
    Update,
    Delete
}
