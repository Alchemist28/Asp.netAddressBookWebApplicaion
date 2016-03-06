using System;

public class User
{
    private string _Validation = "";
    public void Validate()
    {
        if (!String.IsNullOrEmpty(_Validation))
        {
            throw new ApplicationException(_Validation);
        }
    }
    public User()
    { }
    public User(int PKUserId, string UserName, string Password, string FirstName, string LastName, string EmailId, string PhoneNo, bool IsActive)
    {
        //Assign all properties for checking properties
        _PKUserId = PKUserId;
        this.UserName = UserName;
        this.Password = Password;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.EmailId = EmailId;
        this.PhoneNo = PhoneNo;
        this.IsActive = IsActive;
    }
    private int _PKUserId;
    public int PKUserId
    {
        get
        {
            return _PKUserId;
        }
    }
    private string _UserName;
    public string UserName
    {
        get
        {
            return _UserName;
        }
        set
        {
            //if (value == "")
            //    _Validation += "Please provide a value for UserName" + "\t";
            _UserName = value;
        }
    }
    private string _Password;
    public string Password
    {
        get
        {
            return _Password;
        }
        set
        {
            //if (value == "")
            //    _Validation += "Please provide a value for Password" + "\t";
            _Password = value;
        }
    }
    private string _FirstName;
    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            //if (value == "")
            //    _Validation += "Please provide a value for FirstName" + "\t";
            _FirstName = value;
        }
    }
    private string _LastName;
    public string LastName
    {
        get
        {
            return _LastName;
        }
        set
        {

            _LastName = value;
        }
    }
    private string _EmailId;
    public string EmailId
    {
        get
        {
            return _EmailId;
        }
        set
        {
            //if (value == "")
            //    _Validation += "Please provide a value for EmailId" + "\t";
            _EmailId = value;
        }

    }
    private string _PhoneNo;
    public string PhoneNo
    {
        get
        {
            return _PhoneNo;
        }
        set
        {
            //if (value == "")
            //    _Validation += "Please provide a value for Phone" + "\t";
            _PhoneNo = value;
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

