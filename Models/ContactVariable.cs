using System.Collections.Generic;

namespace AddressBook.Models
{
  public class ContactVariable
  {
    private string _userName;
    private string _phoneNumber;
    private string _address;
    private int _id;

    private static List<ContactVariable> _contacts = new List<ContactVariable>();

    public ContactVariable(string userName, string phoneNumber, string address)
    {
      _userName = userName;
      _phoneNumber = phoneNumber;
      _address = address;
      _contacts.Add(this);
      _id = _contacts.Count;
    }

    public string GetUserName()
    {
      return _userName;
    }

    public void SetUserName(string newUserName)
    {
      _userName = newUserName;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }

    public static List<ContactVariable> GetAll()
    {
      return _contacts;
    }
    public static void ClearAll()
    {
      _contacts.Clear();
    }

  }
}
