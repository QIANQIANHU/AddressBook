namespace AddressBook.Models
{
  public class ContactVariable
  {
    private string _userName;
    private string _phoneNumber;
    private string _address;
    private int _id;

    private static List<ContactVariable> _contacts = new List<ContactVariable>{};

    public ContactVariable(string userName, string phoneNumber, string address)
    {
      _userName = userName;
      _phoneNumber = phoneNumber;
      _address = address;
      _id = _contacts.Count + 1;
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
