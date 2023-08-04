using CsvHelper.Configuration.Attributes;

namespace CoolShopTest.Models
{
    public class CsvRecord
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public string LastName { get; set; }

        [Index(2)]
        public string FirstName { get; set; }

        [Index(3)]
        public string BirthDate { get; set; }
    }
}