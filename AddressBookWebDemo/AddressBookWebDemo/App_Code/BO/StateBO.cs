using System;

using System.Data;


public class StateBO
{
    public StateBO()
    { }
    /// <summary>
    /// Add a Single record to State Table
    /// </summary>
    /// <param>Takes State object</param>
    public void InsertState(State objState)
    {
        objState.Validate();
        StateDB.ManageState(objState, ActionType.Add);
    }
    /// <summary>
    /// Add record to state table
    /// </summary>
    /// <param >Takes individual parameters</param>

    public void InsertState(int FKCountryId, String StateName, bool IsActive)
    {
        State objState = new State(-1, FKCountryId, StateName, IsActive);
        objState.Validate();
        StateDB.ManageState(objState, ActionType.Add);
    }
    /// <summary>
    /// Fetch the records into gridview takes from State table
    /// </summary>
    /// <returns>Takes State object</returns>
    public DataSet GetAllStates()
    {
        return StateDB.GetAllStates();
    }
    //public void UpDateState(State objState)
    //{
    //    StateDB.ManageState(objState, ActionType.Add);
    //}
    /// <summary>
    /// Update records into State table
    /// </summary>
    /// <param >Takes individual Parameters</param>

    public void UpdateState(int PKStateId, int FKCountryId, String StateName, bool IsActive)
    {
        State objState = new State(PKStateId, FKCountryId, StateName, IsActive);
        objState.Validate();
        StateDB.ManageState(objState, ActionType.Update);
    }
    /// <summary>
    /// Fetch the records from State table
    /// </summary>
    /// <param>Takes individual objects</param>

    public State GetStateByStateID(int StateId)
    {
        return StateDB.GetStateByPKStateId(StateId);
    }
    /// <summary>
    /// Delete records to State table
    /// </summary>
    /// <param >Takes State objects</param>
    public void DeleteState(int PKStateId)
    {
        State objState = new State(PKStateId, 0, "", false);
        StateDB.ManageState(objState, ActionType.Delete);

    }
    /// <summary>
    /// Bind the Countryname using countryid 
    /// </summary>
    /// <param >Takes CountryId</param>

    public DataSet GetAllStatesByCountryId(int CountryId)
    {
        return StateDB.GetAllStatesByCountryId(CountryId);
    }
    public bool IsStateExist(string StateName, int FKCountryId, int PKStateId)
    {
        return StateDB.IsStateExist(StateName, FKCountryId, PKStateId);
    }
}


