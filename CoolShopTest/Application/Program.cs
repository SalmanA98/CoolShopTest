using CoolShopTest.Helper;

namespace CoolShopTest.Application
{
    public static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid number of arguments - Use: dotnet run <file_path> <column_number> <search_key>");
                return;
            }

            var filePath = args[0];
            var columnNumber = int.Parse(args[1]);
            var searchKey = args[2];

            CsvSearchHelper.Search(filePath, columnNumber, searchKey);
        }
    }
}