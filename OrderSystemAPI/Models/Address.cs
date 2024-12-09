namespace OrderSystemAPI.Models
{
    public class Address
    {
        public int ID { get; set; }

        public String AddressType { get; set; }
        public string StreetAddress { get; set; }
        public string? StreetAdress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string ZipCode { get; set; }
    }
}
