using System;

namespace Order.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public static int IdCounter { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string firstName, string lastName, string emailAddress, string address, string phoneNumber)
        {
            Id = IdCounter++;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public Customer(int id, string firstName, string lastName, string emailAddress, string address, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
