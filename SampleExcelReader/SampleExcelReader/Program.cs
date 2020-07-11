using Ganss.Excel;
using System;

namespace SampleExcelReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var clients = new ExcelMapper("Clients.xlsx").Fetch<Client>();


            Console.WriteLine("Hello World!");
        }
    }
    class Client
    {
        [Column("Client ID")]
        public int ClientID { get; set; }

        [Column("First Name")]
        public string FirstName { get; set; }

        [Column("Last Name")]
        public string LastName { get; set; }

        [Column("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Column("Status")]
        public string Status { get; set; }
    }
}
