using System;

namespace Order.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public static int IdCounter { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public CustomerDto(string firstName, string lastName, string emailAddress, string address, string phoneNumber)
        {
            Id = IdCounter++;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
