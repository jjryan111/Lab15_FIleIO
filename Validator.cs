using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_File_IO_Countries
{
    public class Validator
    {
        public Validator() { }

        public string ynInput(string question)
        // Gets a y or n.
        {

            string input = "";
            while (true)
            {
                Console.Write(question);
                input = Console.ReadLine();
                input = input.ToLower();
                input = input.Trim();
                try
                {
                    if (input != "y" && input != "n")
                    {
                        throw new System.ArgumentException();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (System.ArgumentException)
                {
                    Console.WriteLine("Please answer y or n. ");
                }
            }
            return input;
        }

        public int GetInput(string question, string error, int bottomNum, int topNum)
        {
            int exitNum = 0;
            while (true)
            {
                Console.Write(question);

                try
                {
                    exitNum = int.Parse(Console.ReadLine());
                        if (exitNum < bottomNum || exitNum > topNum)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                catch (Exception)
                {
                    Console.WriteLine(error);
                }
            }
            return exitNum;
        }
        public string GetInput(string question, string error)
        {
            string input = "";
            while (true)
            {
                Console.Write(question);
                input = Console.ReadLine();
                input = input.Trim();

                try
                {
                    if (input == "")
                    {
                        throw new System.ArgumentException();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (System.ArgumentException)
                {
                    Console.WriteLine(error);
                }
            }
            return input;
        }
    }
}
