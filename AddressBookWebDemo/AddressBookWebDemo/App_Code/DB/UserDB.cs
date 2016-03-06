using System;

using System.Data.SqlClient;
using System.Data;


public class UserDB
{
    public UserDB()
    { }
    /// <summary>
    /// Insert the records into UserTable
    /// </summary>
    /// <param >Takes User parameters</param>

    public static void ManageUser(User objUser, ActionType action)
    {
        try
        {
            string spName = "spManageUser";
            SqlParameter pActionType = new SqlParameter("@ActionType", SqlDbType.TinyInt);
            SqlParameter pPKUserId = new SqlParameter("@PKUserId", SqlDbType.Int);
            SqlParameter pUserName = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            SqlParameter pFirstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
            SqlParameter pLastName = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
            SqlParameter pEmailId = new SqlParameter("@EmailId", SqlDbType.VarChar, 50);
            SqlParameter pPhoneNo = new SqlParameter("@PhoneNo", SqlDbType.VarChar, 50);
            SqlParameter pIsActive = new SqlParameter("@IsActive", SqlDbType.Bit);
            pActionType.Value = action;
            if (action == ActionType.Add)
                pPKUserId.Direction = ParameterDirection.Input;
            else
                pPKUserId.Value = objUser.PKUserId;
            if (action == ActionType.Add || action == ActionType.Update)
            {
                pUserName.Value = objUser.UserName;
                pPassword.Value = objUser.Password;
                pFirstName.Value = objUser.FirstName;
                pLastName.Value = objUser.LastName;
                pEmailId.Value = objUser.EmailId;
                pPhoneNo.Value = objUser.PhoneNo;
                pIsActive.Value = objUser.IsActive;
            }
            SqlHelper.ExecuteNonQuery(Helper.connectionstring, CommandType.StoredProcedure, spName, pActionType, pPKUserId, pUserName, pPassword, pFirstName, pLastName, pEmailId, pPhoneNo, pIsActive);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// Fetch the records from usertable into gridview control
    /// </summary>
    /// <returns>Takes UserObject</returns>
    public static DataSet GetAllUsers()
    {
        try
        {
            string spUserName = "spGetAllUsers";
            SqlParameter pUserId = new SqlParameter("@UserId", SqlDbType.Int);
            pUserId.Value = -1;
            DataSet ds = SqlHelper.ExecuteDataset(Helper.connectionstring, CommandType.StoredProcedure, spUserName, pUserId);
            ds.Tables[0].TableName = "Userdetails";
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// Update the records into UserTable
    /// </summary>
    /// <param >Takes User objects</param>
    /// <returns></returns>
    public static User GetUserByPKUserId(int UserId)
    {
        try
        {
            string spName = "spGetAllUsers";
            SqlParameter pUserId = new SqlParameter("@UserId", SqlDbType.Int);
            pUserId.Value = UserId;
            SqlDataReader drRow = SqlHelper.ExecuteReader(Helper.connectionstring, CommandType.StoredProcedure, spName, pUserId);
            User objUser = null;
            if (drRow.HasRows)
            {
                drRow.Read();
                objUser = new User(drRow.GetInt32(drRow.GetOrdinal("PKUserId")), drRow["UserName"].ToString(), drRow["Password"].ToString(), drRow["FirstName"].ToString(), drRow["LastName"].ToString(), drRow["EmailId"].ToString(), drRow["PhoneNo"].ToString(), (bool)drRow["IsActive"]);
            }
            drRow.Close();
            return objUser;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// Authenticate username and password to the user table
    /// </summary>
    /// <param >takes UserId and Password parameters</param>

    public static int AuthenticateUser(string UserName, string Password)
    {
        try
        {
            string spName = "spAuthenticateUser";
            SqlParameter pPKUserId = new SqlParameter("@PKUserId", SqlDbType.Int);
            SqlParameter pUserName = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            pPKUserId.Direction = ParameterDirection.Output;
            pUserName.Value = UserName;
            pPassword.Value = Password;
            SqlHelper.ExecuteNonQuery(Helper.connectionstring, CommandType.StoredProcedure, spName, pUserName, pPassword, pPKUserId);
            return Convert.ToInt32(pPKUserId.Value);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static bool IsUserExist(string UserName)
    {
        try
        {
            string spName = "spIsUserExist";
            SqlParameter pUserName = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            SqlParameter pFlag = new SqlParameter("@flag", SqlDbType.Bit);
            pFlag.Direction = ParameterDirection.Output;
            pUserName.Value = UserName;
            SqlHelper.ExecuteNonQuery(Helper.connectionstring, CommandType.StoredProcedure, spName, pUserName, pFlag);
            return Convert.ToBoolean(pFlag.Value);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}


