using Microsoft.IdentityModel.Protocols.Configuration;
using System.ComponentModel.DataAnnotations;

namespace OrderSystemAPI.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]

        public DateTime Birthdate { get; set; }
        public ICollection<PeoplePhone> PhonePhones { get; set; }
        public ICollection<CustomerAddress> CustomerAddress { get; set; }//pulls Adress



    }

    public class PeoplePhone
    {
        public int ID { get; set; }
        public int PeopleID { get; set; }
        public int PhoneNumberID { get; set; }

        public PhoneNumber PhoneNumber { get; set; }





    }

    public class PhoneNumber
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }

     

    }
}
