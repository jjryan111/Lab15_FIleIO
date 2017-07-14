using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab15_File_IO_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\RYanJa01\Documents\Visual Studio 2017\Projects\Lab15_File_IO_Countries\Lab15_File_IO_Countries\Countries.txt";
            CountriesTextFile n = new CountriesTextFile(filepath);
            n.MainMenu();
        }
    }
}
