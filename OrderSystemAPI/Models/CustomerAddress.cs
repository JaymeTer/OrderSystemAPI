using System.Text.Json.Serialization;  // Move the using statement here

namespace OrderSystemAPI.Models
{
    public class CustomerAddress
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int AddressID { get; set; }

        //Nav
   
        public Address Address { get; set; }
    }
}
