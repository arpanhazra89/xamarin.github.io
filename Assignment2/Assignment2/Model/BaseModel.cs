using System.Collections.Generic;

namespace Assignment2.Model
{
    public class BaseModel
    {
        public BaseModel()
        {
        }
    }

	public class Contact
	{
		public string name { get; set; }
		public string email { get; set; }
        public string mobile { get; set; }
	}

	public class ContactList
	{
		public List<Contact> contacts { get; set; }
	}
}
