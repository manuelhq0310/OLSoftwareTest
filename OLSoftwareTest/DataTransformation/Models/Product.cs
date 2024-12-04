namespace DataTransformation.Models
{
    public class Product
    {
        public string Code { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int? Stock { get; set; }
        public string ExpirationDate { get; set; }
    }
}
