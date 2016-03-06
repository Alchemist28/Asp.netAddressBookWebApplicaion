using System;
using System.Collections.Generic;

using System.Text;
using System.Data;



public class AddressbookBO
{
    public AddressbookBO()
    { }
    public DataSet GetAllAddress()
    {

        return AddressbookDB.GetAllAddresses();
    }

    /// <summary>
    /// Adds a single  record to Addressbook table
    /// </summary>
    /// <param name="objAddbook">Addressbook</param>
    public void InsertAddressbook(Addressbook objAddbook)
    {
        objAddbook.Validate();
        AddressbookDB.ManageAddress(objAddbook, ActionType.Add);
    }
    /// <summary>
    /// To insert the Address
    /// </summary>
    /// <param name="FKStateId">int</param>
    /// <param name="FKUserId">int</param>
    /// <param name="FirstName">string</param>
    /// <param name="LastName">string</param>
    /// <param name="EmailId">string</param>
    /// <param name="PhoneNo">string</param>
    /// <param name="Address1">string</param>
    /// <param name="Address2">string</param>
    /// <param name="City">string</param>
    /// <param name="Street">string</param>
    /// <param name="ZipCode">long</param>
    /// <param name="IsActive">bool</param>
    public void InsertAddressbook(int FKStateId, int FKUserId, string FirstName, string LastName, string EmailId, string PhoneNo, string Address1, string Address2, string City, string Street, long ZipCode, bool IsActive)
    {
        Addressbook objAddbook = new Addressbook(-1, FKStateId, FKUserId, FirstName, LastName, EmailId, PhoneNo, Address1, Address2, Street, City, ZipCode, IsActive);
        objAddbook.Validate();
        AddressbookDB.ManageAddress(objAddbook, ActionType.Add);
    }
    /// <summary>
    /// To update the Address
    /// </summary>
    /// <param name="PKAddressId">int</param>
    /// <param name="FKStateId">int</param>
    /// <param name="FKUserId">int</param>
    /// <param name="FirstName">string</param>
    /// <param name="LastName">string</param>
    /// <param name="EmailId">string</param>
    /// <param name="PhoneNo">string</param>
    /// <param name="Address1">string</param>
    /// <param name="Address2">string</param>
    /// <param name="City">string</param>
    /// <param name="Street">string</param>
    /// <param name="ZipCode">long</param>
    /// <param name="IsActive">bool</param>

    public void UpdateAddressbook(int PKAddressId, int FKStateId, int FKUserId, string FirstName, string LastName, string EmailId, string PhoneNo, string Address1, string Address2, string City, string Street, long ZipCode, bool IsActive)
    {
        Addressbook objAddbook = new Addressbook(PKAddressId, FKStateId, FKUserId, FirstName, LastName, EmailId, PhoneNo, Address1, Address2, Street, City, ZipCode, IsActive);
        objAddbook.Validate();
        AddressbookDB.ManageAddress(objAddbook, ActionType.Update);
    }
    /// <summary>
    /// To fetch the Address record by AddressId
    /// </summary>
    /// <param name="PKAddressId">int</param>
    /// <returns>Addressbook</returns>
    public Addressbook GetAddressByAddressId(int PKAddressId)
    {
        return AddressbookDB.GetAddGetAddressByAddressId(PKAddressId);
    }
    /// <summary>
    /// To delete the Addressbook
    /// </summary>
    /// <param name="PKAddressId">int</param>
    public void DeleteAddressbook(int PKAddressId)
    {
        Addressbook objAddbook = new Addressbook(PKAddressId, 0, 0, "", "", "", "", "", "", "", "", 0, false);
        AddressbookDB.ManageAddress(objAddbook, ActionType.Delete);
    }

    public DataSet GetFilteredAddressbook(string pkCountryId, string pkStateId, string isActive)
    {
        bool ia;
        ia = isActive == "1" ? true : false;
        return AddressbookDB.GetFilteredAddressbook(pkCountryId, pkStateId, ia);
    }
}
