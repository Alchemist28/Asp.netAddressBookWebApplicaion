using System;
using System.Collections.Generic;

using System.Web;
using System.Data;
using System.Data.SqlClient;



public class CountryBO
{
    public CountryBO()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    /// <summary>
    /// Add a single record to Country Table
    /// </summary>
    /// <param>Takes Country object</param>

    public void InsertCountry(Country objCountry)
    {
        objCountry.Validate();
        CountryDB.ManageCountry(objCountry, ActionType.Add);

    }
    /// <summary>
    /// To insert the Country by passing the individual fields
    /// </summary>
    /// <param name="CountryName">string</param>
    /// <param name="ZipCodeStart">long</param>
    /// <param name="ZipCodeEnd">long</param>
    /// <param name="IsActive">bool</param>
    public void InsertCountry(string CountryName, long ZipCodeStart, long ZipCodeEnd, bool IsActive)
    {
        Country objCountry = new Country(-1, CountryName, ZipCodeStart, ZipCodeEnd, IsActive);
        objCountry.Validate();
        CountryDB.ManageCountry(objCountry, ActionType.Add);
    }
    /// <summary>
    /// To update the country
    /// </summary>
    /// <param name="objCountry">Country object</param>
    public void UpDateCountry(Country objCountry)
    {
        //objCountry.Validate();
        CountryDB.ManageCountry(objCountry, ActionType.Update);
    }
    /// <summary>
    /// To update Country by passing the individual parameteres
    /// </summary>
    /// <param name="PKCountyId">int</param>
    /// <param name="CountryName">string</param>
    /// <param name="ZipCodeStart">long</param>
    /// <param name="ZipCodeEnd">long</param>
    /// <param name="IsActive">bool</param>
    public void UpDateCountry(int PKCountyId, string CountryName, int ZipCodeStart, int ZipCodeEnd, bool IsActive)
    {
        Country objCountry = new Country(PKCountyId, CountryName, ZipCodeStart, ZipCodeEnd, IsActive);
        objCountry.Validate();
        CountryDB.ManageCountry(objCountry, ActionType.Update);
    }
    /// <summary>
    /// To delete the country
    /// </summary>
    /// <param name="PKCountryId">int</param>
    public void DeletCountry(int PKCountryId)
    {
        Country objCountry = new Country(PKCountryId, "", 0, 0, false);
        CountryDB.ManageCountry(objCountry, ActionType.Delete);

    }
    /// <summary>
    /// To fetch all the Countries
    /// </summary>
    /// <returns>DataSet</returns>
    public DataSet GetAllCountries()
    {
        return CountryDB.GetAllCountries();
    }
    /// <summary>
    /// To fetch the Country by CountryId
    /// </summary>
    /// <param name="CountryId">int</param>
    /// <returns>Country</returns>
    public Country GetCountryByPKId(int CountryId)
    {
        Country objCountry = new Country();
        objCountry = CountryDB.GetCountryByPKCoundtryId(CountryId);
        return objCountry;

    }
    /// <summary>
    /// To verify whether the Country exist or not
    /// </summary>
    /// <param name="CountryName">string</param>
    /// <param name="PKCountryId">int</param>
    /// <returns></returns>
    public bool IsCountryExist(string CountryName, int PKCountryId)
    {
        return CountryDB.IsCountryExist(CountryName, PKCountryId);
    }

}

