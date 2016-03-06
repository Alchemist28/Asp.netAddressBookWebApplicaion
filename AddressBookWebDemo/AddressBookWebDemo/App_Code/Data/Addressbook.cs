using System;


public class Addressbook
{
    private string _Validation = "";
    public void Validate()
    {
        if (!String.IsNullOrEmpty(_Validation))
        {
            throw new ApplicationException(_Validation);
        }
    }
    public Addressbook()
    {
    }

    public Addressbook(int PKAddressId, string stateName, int FKStateId, int FKUserId, string FirstName, string LastName, string EmailId, string PhoneNo, string Address1, string Address2, string Street, string City, long ZipCode, bool IsActive)
    {
        //Assign all parameters for checking properties
        _PKAddressId = PKAddressId;
        this.FKStateId = FKStateId;
        this.StateName = stateName;
        this.FKUserId = FKUserId;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.EmailId = EmailId;
        this.PhoneNo = PhoneNo;
        this.Address1 = Address1;
        this.Address2 = Address2;
        this.Street = Street;
        this.City = City;
        this.ZipCode = ZipCode;
        this.IsActive = IsActive;
    }
    public Addressbook(int PKAddressId, string stateName, int FKStateId, int FKCountryId, int FKUserId, string FirstName, string LastName, string EmailId, string PhoneNo, string Address1, string Address2, string Street, string City, long ZipCode, bool IsActive)
    {
        _PKAddressId = PKAddressId;
        this.FKStateId = FKStateId;
        this.StateName = stateName;
        this.FKUserId = FKUserId;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.EmailId = EmailId;
        this.PhoneNo = PhoneNo;
        this.Address1 = Address1;
        this.Address2 = Address2;
        this.Street = Street;
        this.City = City;
        this.ZipCode = ZipCode;
        this.IsActive = IsActive;
        this.FKCountryID = FKCountryId;
    }

    public Addressbook(int PKAddressId, int FKStateId, int FKUserId, string FirstName, string LastName, string EmailId, string PhoneNo, string Address1, string Address2, string Street, string City, long ZipCode, bool IsActive)
    {
        _PKAddressId = PKAddressId;
        this.FKStateId = FKStateId;
        this.FKUserId = FKUserId;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.EmailId = EmailId;
        this.PhoneNo = PhoneNo;
        this.Address1 = Address1;
        this.Address2 = Address2;
        this.Street = Street;
        this.City = City;
        this.ZipCode = ZipCode;
        this.IsActive = IsActive;
    }



    private int _PKAddressId;
    public int PKAddressId
    {
        get
        {
            return _PKAddressId;
        }
    }
    private int _FKStateId;
    public int FKStateId
    {
        get
        {
            return _FKStateId;
        }
        set
        {
            _FKStateId = value;
        }
    }
    public int _FKCountryID;
    public int FKCountryID
    {
        get
        {
            return _FKCountryID;
        }
        set
        {
            _FKCountryID = value;
        }
    }
    private int _FKUserId;
    public int FKUserId
    {
        get
        {
            return _FKUserId;
        }
        set
        {
            _FKUserId = value;
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
            if (value == "")
            {
                //_Validation += "Please provide a value for FirstNmae" + "\t";
                _StateName = value;
            }
            else
                _StateName = value;

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
            if (value == "")
            {
                //_Validation += "Please provide a value for FirstNmae" + "\t";
                _FirstName = value;
            }
            else
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
            if (value == "")
            {
                //_Validation += "Please provide a value for FirstNmae" + "\t";
                _LastName = value;
            }
            else
            {
                _LastName = value;
            }
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
            if (value == "")
            {
                //_Validation += "Please provide a value for EmailId" + "\t";
                _EmailId = value;
            }
            else
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
            if (value == "")
            {
                //_Validation += "Please provide a value for PhoneNo" + "\t";
                _PhoneNo = value;
            }
            else
                _PhoneNo = value;
        }
    }
    private string _Address1;
    public string Address1
    {
        get
        {
            return _Address1;
        }
        set
        {
            if (value == "")
            {
                //_Validation += "Please provide a value for Address1" + "\t";
                _Address1 = value;
            }
            else
                _Address1 = value;
        }
    }
    private string _Address2;
    public string Address2
    {
        get
        {
            return _Address2;
        }
        set
        {
            if (value == "")
            {
                //_Validation += "Please provide a value for Address1" + "\t";
                _Address2 = value;
            }
            else
                _Address2 = value;

        }
    }
    private string _Street;
    public string Street
    {
        get
        {
            return _Street;
        }
        set
        {
            if (value == "")
            {
                //_Validation += "Please provide a value for Street" + "\t";
                _Address1 = value;
            }
            else
                _Street = value;
        }
    }
    private string _City;
    public string City
    {
        get
        {
            return _City;
        }
        set
        {
            if (value == "")
            {
                //_Validation += "please provide a value for City" + "\t";
                _City = value;
            }
            else
                _City = value;
        }
    }
    private long _ZipCode;
    public long ZipCode
    {
        get
        {
            return _ZipCode;
        }
        set
        {
            if (value <= 0)
            {
                //_Validation += "Please provide a value for ZipCode" + "\t";
                _ZipCode = value;

            }
            else
                _ZipCode = value;
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

