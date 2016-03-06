using System;


public class State
{
    private string _Validation = "";
    public void Validate()
    {
        if (!string.IsNullOrEmpty(_Validation))
        {
            throw new ApplicationException(_Validation);
        }
    }
    public State()
    { }
    public State(int PKStateId, int FKCountryId, string StateName, bool IsActive)
    {
        //Assign all parameters for checking properties
        _PKStateId = PKStateId;
        this.FKCountryId = FKCountryId;
        this.StateName = StateName;
        this.IsActive = IsActive;

    }

    private int _PKStateId;
    public int PKStateId
    {
        get
        {
            return _PKStateId;
        }
    }
    private int _FKCountryId;
    public int FKCountryId
    {
        get
        {
            return _FKCountryId;
        }
        set
        {
            _FKCountryId = value;
        }

    }
    private string _StateName;
    public string StateName
    {
        get
        {
            return _StateName;
        }
        set
        {
            //if (value == "")
            //    _Validation += "Please provide a value for StateName" + "\t";
            _StateName = value;
        }
    }
    private bool _IsActive;
    public bool IsActive
    {
        get
        {
            return _IsActive;
        }
        set
        {

            _IsActive = value;
        }
    }

}

