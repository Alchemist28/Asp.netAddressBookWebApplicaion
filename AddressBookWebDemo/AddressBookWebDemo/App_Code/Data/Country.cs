using System;


public class Country
{
    private string _Validation = "";
    public void Validate()
    {
        if (!String.IsNullOrEmpty(_Validation))
        {
            throw new ApplicationException(_Validation);
        }
    }
    public Country()
    {
    }

    public Country(int PKCountryId, string CountryName, long ZipCodeStart, long ZipcodeEnd, bool IsActive)
    {
        //Assign all parameters for checking properties
        _PKCountryId = PKCountryId;
        this.CountryName = CountryName;
        this.ZipCodeStart = ZipCodeStart;
        this.ZipCodeEnd = ZipcodeEnd;
        this.IsActive = IsActive;
    }
    private int _PKCountryId;
    public int PKCountryId
    {
        get
        {
            return _PKCountryId;
        }

    }
    private string _CountryName;
    public string CountryName
    {
        get
        {
            return _CountryName;
        }
        set
        {
            //if (value == "")
            //   _Validation += "Please provide a Value for CountryName" + "\t";
            _CountryName = value;
        }
    }
    private long _ZipCodeStart;
    public long ZipCodeStart
    {
        get
        {
            return _ZipCodeStart;
        }
        set
        {
            //if (value <= 0)
            //   _Validation += "Please provide a valid ZipCode" + "\t";
            _ZipCodeStart = value;
        }

    }
    private long _ZipCodeEnd;
    public long ZipCodeEnd
    {
        get
        {
            return _ZipCodeEnd;
        }
        set
        {
            //if (value <= 0)
            //    _Validation += "Please provide a valid ZipCode" + "\t";
            _ZipCodeEnd = value;
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

