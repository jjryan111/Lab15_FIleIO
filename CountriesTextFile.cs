using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15_File_IO_Countries
{
    class CountriesTextFile
    {
        private Validator i = new Validator();
        private string filepath;
        public CountriesTextFile(string filepath) {
            this.filepath = filepath;

        }
        public List<string> ReadCountries() {
            List<string> countries = new List<string>();
            if (!File.Exists(filepath))
            {
                Console.WriteLine("That file doesn't exist!");
            }
            else
            { 
                string readText = File.ReadAllText(filepath);
                countries.Add(readText);
                Console.WriteLine(readText);
            }
            return countries;
            //StreamReader reader = new StreamReader(filepath);
            //string line = reader.ReadToEnd();
            //Console.WriteLine(line);
            //reader.Close();
        }
        public void WriteCountries(List<string> whatToWrite)
        {
            //    bool isFile = File.Exists(filepath);
            //    Console.WriteLine(isFile);
            //StreamWriter writer = new StreamWriter(filepath);
            if (!File.Exists(filepath))
            {
                
                File.WriteAllLines(filepath, whatToWrite);
            }
            else
            {
                File.AppendAllLines(filepath, whatToWrite);
            }
            //writer.WriteLine(whatToWrite);
            //writer.Close();
        }
        public void MainMenu()
        {
            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("Welcome to the Country App!");
                Console.WriteLine("Here are your options:");
                Console.WriteLine("1) List the Countries");
                Console.WriteLine("2) Add a Country");
                Console.WriteLine("3) Delete a Country");
                Console.WriteLine("4) Exit");
                input = i.GetInput("What would you like to do? ", "That isn't a choice on this list. Try again. ", 1, 4);
                MenuItem(input);
            }
        }
        public void MenuItem(int input)
        {
            switch (input)
            {
                case 1:
                    ReadCountries();
                    break;
                case 2:
                    GetCountriesToWrite();
                    break;
                case 3:
                    DeleteCountry();
                    break;
                default:
                    break;
            }
        }
        public void GetCountriesToWrite()
        {
            List<string> countries = new List<string>();
            string cont = "y";
            string newCountry = "";
            while (cont == "y")
            {
                newCountry = i.GetInput("Enter a Country: ", "You have to enter soemthing. ");
                countries.Add(newCountry);
                cont = i.ynInput("Add another country? ");
            }
            WriteCountries(countries);
        }
        public void DeleteCountry()
        {
            List<string> countries = new List<string>(); 
            string country = "";
            while (country != "q")
            {
                countries = ReadCountries();
                //foreach (string i in countries)
                //{
                //    Console.WriteLine(i);
                //}
                country = i.GetInput("Enter a country name from the list or q to quit? ", "Please enter a country name");
                //Console.WriteLine(country);
                country = country.Trim();

                if (countries.Contains(country))
                {
                    countries.Remove(country);
                }
                else
                {
                    Console.WriteLine("That country isn't in the list.");
                }

            }
        }
    }
    }

