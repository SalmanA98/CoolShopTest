using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using CoolShopTest.Models;

namespace CoolShopTest.Helper
{
    public static class CsvSearchHelper
    {
        public static void Search(string filePath, int columnNumber, string searchKey)
        {
            try
            {
                using var reader = new StreamReader(filePath);
                using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
                var records = csv.GetRecords<CsvRecord>();

                foreach (var record in records)
                {
                    string? valueToSearch = null;
                    switch (columnNumber)
                    {
                        case 0: valueToSearch = record.Id.ToString(); break;
                        case 1: valueToSearch = record.LastName; break;
                        case 2: valueToSearch = record.FirstName; break;
                        case 3: valueToSearch = record.BirthDate; break;
                        default:
                            Console.WriteLine("Invalid column number.");
                            return;
                    }

                    if (valueToSearch != null && valueToSearch.Equals(searchKey, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine($"{record.Id}, {record.LastName}, {record.FirstName}, {record.BirthDate}");
                        return;
                    }
                }

                Console.WriteLine("No matching record found.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}