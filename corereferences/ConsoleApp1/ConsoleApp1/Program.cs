using System;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string pattern = @"(\w+)\s(\1)";
                string input = "He said that that was the the correct answer.";
                foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                    Console.WriteLine("Duplicate '{0}' found at positions {1} and {2}.",
                                      match.Groups[1].Value, match.Groups[1].Index, match.Groups[2].Index);
            }
            // ------------------
            {
                string pattern = @"(\d{3})-(\d{3})-(\d{4})";
                string input = "212-555-6666 906-932-1111 415-222-3333 425-888-9999";
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    Console.WriteLine("Area Code:        {0}", match.Groups[1].Value);
                    Console.WriteLine("Telephone number: {0}", match.Groups[2].Value);
                    Console.WriteLine("Telephone number2: {0}", match.Groups[3].Value);
                    Console.WriteLine();
                }
                Console.WriteLine();

            }

            {
                string packageNameMatch = @"([a-zA-Z.]*?)";
                string versionMatch = @"([0-9.]*?)";
                string enforceTypeIsPackage = @"\""type\"": \""package\""";

                string pattern = @"\"""+ packageNameMatch + @"/"+ versionMatch + @"\"": {\s*"+ enforceTypeIsPackage + @",";
                string input = File.ReadAllText(@"C:\Dev\trial\corereferences\ConsoleApp1\ConsoleApp1\obj\project.assets.json");
                MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.Singleline);





                foreach (Match match in matches)
                {
                    string packageName = match.Groups[1].Value;
                    Console.WriteLine("package:        {0}", packageName);
                    Console.WriteLine("version: {0}", match.Groups[2].Value);
                    Console.WriteLine();

                    if (packageName == "ClassLibrary2")
                    {
                        throw new Exception("non pack");
                    }




                }
                Console.WriteLine();

            }






            Console.WriteLine("Hello World!");
        }
    }
}
