using CoolShopTest.Helper;

namespace CoolShopTest.Application
{
    public static class Program
    {
        static void Main(string[] args)
        {
            if (CommandLineArgumentsValidation(args))
            {
                var filePath = args[0];
                var columnNumber = Convert.ToInt32(args[1]);
                var searchKey = args[2];

                CsvSearchHelper.Search(filePath, columnNumber, searchKey);
            }
        }

        private static bool CommandLineArgumentsValidation(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid number of arguments - Use: dotnet run <csv_file_path> <column_number> <search_key>");
                return false;
            }

            if (!int.TryParse(args[1], out _))
            {
                Console.WriteLine("Invalid column number");
                return false;
            }


            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Invalid file/file not found");
                return false;
            }

            return true;
        }
    }
}