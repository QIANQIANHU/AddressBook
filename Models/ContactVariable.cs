namespace AddressBook.Models
{
  public class ContactVariable
  {
    private string _userName;
    private string _phoneNumber;
    private string _address;

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
  }

  // public class ContactList {
  //   public list<Contact> contactList;
  //
  //   void addContact(Contact oneContact) {
  //     contactList.add(oneContact);
  //   }
  //
  //   void deleteContact(Contact on
  // }
}
