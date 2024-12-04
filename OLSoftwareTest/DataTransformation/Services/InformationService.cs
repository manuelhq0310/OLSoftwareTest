using DataTransformation.Helpers;
using DataTransformation.Models;

namespace DataTransformation.Services
{
    public class InformationService
    {
        public List<Person> ReadClientsCsv(string filePath)
        {
            List<Person> response = new List<Person>();

            var lines = File.ReadAllLines(filePath);

            foreach (string line in lines.Skip(1))
            {
                string[] values = line.Split(',');

                if (values.Length == 6)
                {
                    Person person = new Person()
                    {
                        IdentificationType = values[0],
                        IdentificationNumber = values[1],
                        Name = values[2],
                        Address = values[3],
                        Phone = values[4],
                        BirthDate = Converters.TimestampToDate(values[5]),
                    };
                    response.Add(person);
                }

            }

            return response;
        }

        public List<Product> ReadProductsCsv(string filePath)
        {
            List<Product> response = new List<Product>();

            var lines = File.ReadAllLines(filePath);

            foreach (string line in lines.Skip(1))
            {
                string[] values = line.Split(',');

                if (values.Length == 5)
                {
                    Product product = new Product()
                    {
                        Code = values[0],
                        ProductName = values[1],
                        Description = values[2],
                        Stock = !string.IsNullOrEmpty(values[3]) ? int.Parse(values[3]) : null,
                        ExpirationDate = Converters.TimestampToDate(values[4]),
                    };
                    response.Add(product);
                }

            }

            return response;
        }
    }
}
