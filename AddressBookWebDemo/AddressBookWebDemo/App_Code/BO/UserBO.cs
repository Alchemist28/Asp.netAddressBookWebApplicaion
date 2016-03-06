
using System.Data;


public class UserBO
{
    public UserBO()
    { }
    public void InsertUser(User objUser)
    {
        objUser.Validate();
        UserDB.ManageUser(objUser, ActionType.Add);

    }
    public void InsertUser(string UserName, string Password, string FirstName, string LastName, string EmailId, string PhoneNo, bool IsActive)
    {
        User objUser = new User(-1, UserName, Password, FirstName, LastName, EmailId, PhoneNo, IsActive);
        objUser.Validate();
        UserDB.ManageUser(objUser, ActionType.Add);
    }
    public DataSet GetAllUsers()
    {
        return UserDB.GetAllUsers();
    }
    public void UpDateUser(User objUser)
    {
        UserDB.ManageUser(objUser, ActionType.Update);

    }
    public void UpDateUser(int PKUserId, string UserName, string Password, string FirstName, string LastName, string EmailId, string PhoneNo, bool IsActive)
    {
        User objUser = new User(PKUserId, UserName, Password, FirstName, LastName, EmailId, PhoneNo, IsActive);
        objUser.Validate();
        UserDB.ManageUser(objUser, ActionType.Update);
    }
    public void DeleteUser(int PKUserId)
    {
        User objUser = new User(PKUserId, "", "", "", "", "", "", false);
        UserDB.ManageUser(objUser, ActionType.Delete);
    }
    public User GetUserByPKId(int UserId)
    {
        User objUser = new User();
        objUser = UserDB.GetUserByPKUserId(UserId);
        return objUser;
    }
    public int AuthenticateUser(string UserName, string Password)
    {
        return UserDB.AuthenticateUser(UserName, Password);
    }
    public bool IsUserExist(string UserName)
    {
        return UserDB.IsUserExist(UserName);
    }
}

