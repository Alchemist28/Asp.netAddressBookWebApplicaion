using System;

using System.Data;
using System.Data.SqlClient;
//using AddressBook1.Data;


public class AddressbookDB
{
    public AddressbookDB()
    { }
    /// <summary>
    /// To perform the CRUD operations on Address
    /// </summary>
    /// <param name="objAddressbook">Addressbbok</param>
    /// <param name="action">ActionType</param>
    public static void ManageAddress(Addressbook objAddressbook, ActionType action)
    {
        try
        {
            string spName = "spManageAddress";
            SqlParameter pActionType = new SqlParameter("@ActionType", SqlDbType.TinyInt);
            SqlParameter pPKAddressId = new SqlParameter("@PKAddressId", SqlDbType.Int);
            SqlParameter pFKStateId = new SqlParameter("@FKStateId", SqlDbType.Int);
            SqlParameter pFKUserId = new SqlParameter("@FKUserId", SqlDbType.Int);
            SqlParameter pFirstName = new SqlParameter("@FirstName", SqlDbType.VarChar, 50);
            SqlParameter pLastName = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
            SqlParameter pEmailId = new SqlParameter("@EmailId", SqlDbType.VarChar, 50);
            SqlParameter pPhoneNo = new SqlParameter("@PhoneNo", SqlDbType.VarChar, 50);
            SqlParameter pAddress1 = new SqlParameter("@Address1", SqlDbType.VarChar, 50);
            SqlParameter pAddress2 = new SqlParameter("@Address2", SqlDbType.VarChar, 50);
            SqlParameter pStreet = new SqlParameter("@Street", SqlDbType.VarChar, 50);
            SqlParameter pCity = new SqlParameter("@City", SqlDbType.VarChar, 50);
            SqlParameter pZipCode = new SqlParameter("@ZipCode", SqlDbType.BigInt, 50);
            SqlParameter pIsActive = new SqlParameter("@IsActive", SqlDbType.Bit);
            pActionType.Value = action;
            if (action == ActionType.Add)
                pPKAddressId.Direction = ParameterDirection.Input;
            else
                pPKAddressId.Value = objAddressbook.PKAddressId;
            if (action == ActionType.Add || action == ActionType.Update)
            {
                pFKStateId.Value = objAddressbook.FKStateId;
                pFKUserId.Value = objAddressbook.FKUserId;
                pFirstName.Value = objAddressbook.FirstName;
                pLastName.Value = objAddressbook.LastName;
                pEmailId.Value = objAddressbook.EmailId;
                pPhoneNo.Value = objAddressbook.PhoneNo;
                pAddress1.Value = objAddressbook.Address1;
                pAddress2.Value = objAddressbook.Address2;
                pStreet.Value = objAddressbook.Street;
                pCity.Value = objAddressbook.City;
                pZipCode.Value = objAddressbook.ZipCode;
                pIsActive.Value = objAddressbook.IsActive;
            }
            SqlHelper.ExecuteNonQuery(Helper.connectionstring, CommandType.StoredProcedure, spName, pActionType, pPKAddressId, pFKStateId, pFKUserId, pFirstName, pLastName, pEmailId, pPhoneNo, pAddress1, pAddress2, pStreet, pCity, pZipCode, pIsActive);
        }
        catch (Exception ex)
        {
            throw ex;
        }


    }
    /// <summary>
    /// To fetch the all addresses
    /// </summary>
    /// <returns>DataSet</returns>
    public static DataSet GetAllAddresses()
    {
        try
        {
            string spName = "spGetAllAddressByUserId";
            SqlParameter pPKUserId = new SqlParameter("@PKUserId", SqlDbType.Int);
            if (Helper.CurrentUserRole == "User")
                pPKUserId.Value = Helper.CurrentUserID;
            else
                pPKUserId.Value = -1;
            DataSet ds = SqlHelper.ExecuteDataset(Helper.connectionstring, CommandType.StoredProcedure, spName, pPKUserId);
            ds.Tables[0].TableName = "Addressbook";
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    public static DataSet GetFilteredAddressbook(string pkCountryId, string pkStateId, bool isActive)
    {
        try
        {
            string spName = "spGetFilteredAddressbook";
            SqlParameter pPKCountryID = new SqlParameter("@PKCountryID", SqlDbType.Int);
            pPKCountryID.Value = pkCountryId == "-99" ? null : pkCountryId;
            SqlParameter pPKStateID = new SqlParameter("@PKStateID", SqlDbType.Int);
            pPKStateID.Value = pkStateId == "-99" ? null : pkStateId;
            SqlParameter pIsActive = new SqlParameter("@IsActive", SqlDbType.Bit);
            pIsActive.Value = isActive;
            DataSet ds = SqlHelper.ExecuteDataset(Helper.connectionstring, CommandType.StoredProcedure, spName, pPKCountryID, pPKStateID, pIsActive);
            ds.Tables[0].TableName = "Addressbook";
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// To fetch the Address by AddressId
    /// </summary>
    /// <param name="PKUserId">int</param>
    /// <returns>Addressbook</returns>
    public static Addressbook GetAddGetAddressByAddressId(int PKAddressId)
    {
        try
        {
            string spName = "spGetAllAddressById";
            SqlParameter pPKAddressId = new SqlParameter("@PKAddressId", SqlDbType.Int);
            pPKAddressId.Value = PKAddressId;
            SqlDataReader drRow = SqlHelper.ExecuteReader(Helper.connectionstring, CommandType.StoredProcedure, spName, pPKAddressId);
            Addressbook objAddbook = null;
            string Lname = "";
            if (drRow.HasRows)
            {
                drRow.Read();
                int pkid = drRow.GetInt32(drRow.GetOrdinal("PKAddressId"));
                string statename = drRow.GetString(drRow.GetOrdinal("StateName"));
                int stateid = drRow.GetInt32(drRow.GetOrdinal("FKStateId"));
                int UserId = drRow.GetInt32(drRow.GetOrdinal("FKUserId"));
                string Fname = drRow.GetString(drRow.GetOrdinal("FirstName"));
                Lname = drRow.IsDBNull(drRow.GetOrdinal("LastName")) ? "" : drRow.GetString(drRow.GetOrdinal("LastName"));
                string EId = drRow.GetString(drRow.GetOrdinal("EmailId"));
                string Pno = drRow.GetString(drRow.GetOrdinal("PhoneNo"));
                string Add1 = drRow.GetString(drRow.GetOrdinal("Address1"));
                string Add2 = drRow.GetString(drRow.GetOrdinal("Address2"));
                string st = drRow.GetString(drRow.GetOrdinal("Street"));
                string ct = drRow.GetString(drRow.GetOrdinal("City"));
                long zpcode = drRow.GetInt64(drRow.GetOrdinal("ZipCode"));
                bool Isact = Convert.ToBoolean(drRow["IsActive"]);
                int fkCountryId = drRow.GetInt32(drRow.GetOrdinal("FKCountryId"));
                objAddbook = new Addressbook(pkid, statename, stateid, fkCountryId, UserId, Fname, Lname, EId, Pno, Add1, Add2, st, ct, zpcode, Isact);

            }
            drRow.Close();
            return objAddbook;
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
}


