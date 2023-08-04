# CoolShopTest
Introduction: A script to search and retrieve a row by inputting the filename, column and search key. 
The program uses third-party library - CsvHelper.

To run the script, do the following steps:
1. Clone the repository
2. Open the location in CMD
3. Run command: dotnet build
4. Run command: dotnet run <csv_file_path.csv> <column_number> <search_key>

An example csv file is provided inside the project called csvFile.csv, to run use command:
dotnet run ./csvFile.csv 2 alberto
