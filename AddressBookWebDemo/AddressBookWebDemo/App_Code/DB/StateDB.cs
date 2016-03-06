using System;

using System.Data.SqlClient;
using System.Data;

public class StateDB
{
    public StateDB()
    {

    }
    /// <summary>
    /// To perform CRUD operations on State
    /// </summary>
    /// <param name="objState">State</param>
    /// <param name="action">ActionType</param>
    public static void ManageState(State objState, ActionType action)
    {
        try
        {
            string spName = "spManageState";
            SqlParameter pActionType = new SqlParameter("@ActionType", SqlDbType.TinyInt);
            SqlParameter pPKStateId = new SqlParameter("@PKStateId", SqlDbType.Int);
            SqlParameter pFKCountryId = new SqlParameter("@FKCountryId", SqlDbType.Int);
            SqlParameter pStateName = new SqlParameter("@StateName", SqlDbType.VarChar, 50);
            SqlParameter pIsActive = new SqlParameter("@IsActive", SqlDbType.Bit);
            pActionType.Value = action;
            if (action == ActionType.Add)
                pPKStateId.Direction = ParameterDirection.Input;
            else
                pPKStateId.Value = objState.PKStateId;
            if (action == ActionType.Add || action == ActionType.Update)
            {
                pFKCountryId.Value = objState.FKCountryId;
                pStateName.Value = objState.StateName;
                pIsActive.Value = objState.IsActive;
            }
            SqlHelper.ExecuteNonQuery(Helper.connectionstring, CommandType.StoredProcedure, spName, pActionType, pPKStateId, pFKCountryId, pStateName, pIsActive);
        }
        catch (Exception ex)
        {
            throw ex;

        }
    }
    /// <summary>
    /// To fetch all the states
    /// </summary>
    /// <returns>Dataset</returns>
    public static DataSet GetAllStates()
    {
        try
        {
            string spStateName = "spGetAllStates";
            SqlParameter pStateId = new SqlParameter("@StateId", SqlDbType.Int);
            pStateId.Value = -1;
            DataSet ds = SqlHelper.ExecuteDataset(Helper.connectionstring, CommandType.StoredProcedure, spStateName, pStateId);
            ds.Tables[0].TableName = "State";
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// To update the State
    /// </summary>
    /// <param name="StateId">int</param>
    /// <returns>State Object</returns>
    public static State GetStateByPKStateId(int StateId)
    {
        try
        {
            string spName = "spGetAllStates";
            SqlParameter pStateId = new SqlParameter("@StateId", SqlDbType.Int);
            pStateId.Value = StateId;
            SqlDataReader drRow = SqlHelper.ExecuteReader(Helper.connectionstring, CommandType.StoredProcedure, spName, pStateId);
            State objState = null;
            if (drRow.HasRows)
            {
                drRow.Read();
                objState = new State(drRow.GetInt32(drRow.GetOrdinal("PKStateId")), drRow.GetInt32(drRow.GetOrdinal("FKCountryId")), drRow["StateName"].ToString(), Convert.ToBoolean(drRow["IsActive"]));
            }
            drRow.Close();
            return objState;
        }
        catch (Exception ex)
        {
            throw ex;

        }
    }
    /// <summary>
    /// To get all the States By Country Id
    /// </summary>
    /// <param name="PKCountryId">int</param>
    /// <returns>Dataset</returns>

    public static DataSet GetAllStatesByCountryId(int PKCountryId)
    {
        try
        {
            string spStateName = "spGetStatesBycountryId";
            SqlParameter pCountryId = new SqlParameter("@PKCountryId", SqlDbType.Int);
            pCountryId.Value = PKCountryId;
            DataSet ds = SqlHelper.ExecuteDataset(Helper.connectionstring, CommandType.StoredProcedure, spStateName, pCountryId);
            ds.Tables[0].TableName = "State";
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;

        }
    }
    /// <summary>
    /// To verify whether state exist in country
    /// </summary>
    /// <param name="StateName">string</param>
    /// <param name="FKCountryId">int</param>
    /// <param name="PKStateId">int</param>
    /// <returns></returns>
    public static bool IsStateExist(string StateName, int FKCountryId, int PKStateId)
    {
        try
        {
            string spName = "spIsStateExist";
            SqlParameter pStateName = new SqlParameter("@StateName", SqlDbType.VarChar, 50);
            SqlParameter pFKCountryId = new SqlParameter("@FKCountryId", SqlDbType.Int);
            SqlParameter pPKStateId = new SqlParameter("@PKStateId", SqlDbType.Int);
            SqlParameter pflag = new SqlParameter("@flag", SqlDbType.Bit);
            pflag.Direction = ParameterDirection.Output;
            pStateName.Value = StateName;
            pFKCountryId.Value = FKCountryId;
            pPKStateId.Value = PKStateId;
            SqlHelper.ExecuteNonQuery(Helper.connectionstring, CommandType.StoredProcedure, spName, pStateName, pFKCountryId, pPKStateId, pflag);
            return Convert.ToBoolean(pflag.Value);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
