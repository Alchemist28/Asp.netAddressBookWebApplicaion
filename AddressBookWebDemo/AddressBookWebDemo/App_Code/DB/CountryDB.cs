using System;
using System.Data.SqlClient;
using System.Data;



public class CountryDB
{
    public CountryDB()
    {

    }
    /// <summary>
    /// To perform CRUD operation on Country 
    /// </summary>
    /// <param name="objCountry">Country</param>
    /// <param name="action">ActionType</param>
    public static void ManageCountry(Country objCountry, ActionType action)
    {
        try
        {
            string spName = "spManageCountry";
            SqlParameter pActionType = new SqlParameter("@ActionType", SqlDbType.TinyInt);
            SqlParameter pPKCountryId = new SqlParameter("@PKCountryId", SqlDbType.Int);
            SqlParameter pCountryName = new SqlParameter("@CountryName", SqlDbType.VarChar, 50);
            SqlParameter pZipCodeStart = new SqlParameter("@ZipCodeStart", SqlDbType.BigInt);
            SqlParameter pZipCodeEnd = new SqlParameter("@ZipCodeEnd", SqlDbType.BigInt);
            SqlParameter pIsActive = new SqlParameter("@IsActive", SqlDbType.Bit);
            pActionType.Value = action;
            if (action == ActionType.Add)
                pPKCountryId.Direction = ParameterDirection.Input;
            else
                pPKCountryId.Value = objCountry.PKCountryId;
            if (action == ActionType.Add || action == ActionType.Update)
            {
                pCountryName.Value = objCountry.CountryName;
                pZipCodeStart.Value = objCountry.ZipCodeStart;
                pZipCodeEnd.Value = objCountry.ZipCodeEnd;
                pIsActive.Value = objCountry.IsActive;
            }
            SqlHelper.ExecuteNonQuery(Helper.connectionstring, CommandType.StoredProcedure, spName, pActionType, pPKCountryId, pCountryName, pZipCodeStart, pZipCodeEnd, pIsActive);
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    /// <summary>
    /// To fetch the all the countries
    /// </summary>
    /// <returns>DataSet</returns>
    public static DataSet GetAllCountries()
    {
        try
        {
            string spCountryName = "spGetAllCountries";
            SqlParameter pCountryId = new SqlParameter("@CountryId", SqlDbType.Int);
            pCountryId.Value = -1;
            DataSet ds = SqlHelper.ExecuteDataset(Helper.connectionstring, CommandType.StoredProcedure, spCountryName, pCountryId);
            ds.Tables[0].TableName = "Country";
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }


    }
    /// <summary>
    /// To fetch the Country by countryid
    /// </summary>
    /// <param name="CountryId">int</param>
    /// <returns>Country</returns>
    public static Country GetCountryByPKCoundtryId(int CountryId)
    {
        try
        {
            string spName = "spGetAllCountries";
            SqlParameter pCountryId = new SqlParameter("@CountryId", SqlDbType.Int);
            pCountryId.Value = CountryId;
            SqlDataReader drRow = SqlHelper.ExecuteReader(Helper.connectionstring, CommandType.StoredProcedure, spName, pCountryId);
            Country objCountry = null;
            if (drRow.HasRows)
            {
                drRow.Read();
                objCountry = new Country(drRow.GetInt32(drRow.GetOrdinal("PKCountryId")), drRow["CountryName"].ToString(), Convert.ToInt32(drRow["ZipCodeStart"]), Convert.ToInt32(drRow["ZipCodeEnd"]), (bool)drRow["IsActive"]);

            }
            drRow.Close();
            return objCountry;
        }
        catch (Exception ex)
        {
            throw ex;

        }
    }
    /// <summary>
    /// To verify whether country exist or not
    /// </summary>
    /// <param name="CountryName">string</param>
    /// <param name="PKCountryId">int</param>
    /// <returns></returns>
    public static bool IsCountryExist(string CountryName, int PKCountryId)
    {
        try
        {
            string spName = "spIsCountryExist";
            SqlParameter pCountryName = new SqlParameter("@CountryName", SqlDbType.VarChar, 50);
            SqlParameter pkCountryId = new SqlParameter("@PKCountryID", SqlDbType.Int);
            SqlParameter pflag = new SqlParameter("@flag", SqlDbType.Bit);
            pflag.Direction = ParameterDirection.Output;
            pCountryName.Value = CountryName;
            pkCountryId.Value = PKCountryId;
            SqlHelper.ExecuteNonQuery(Helper.connectionstring, CommandType.StoredProcedure, spName, pCountryName, pkCountryId, pflag);
            return Convert.ToBoolean(pflag.Value);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}




