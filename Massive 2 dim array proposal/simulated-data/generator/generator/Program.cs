using System;
using System.IO;
using System.Text;

namespace generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string twoDimArray = GenerateTwoDimArray(100, 100, true);

            string arrayWithIndexes = GenerateArrayWithIndexes(100, 100, true);

            File.WriteAllText(@"c:\temp\twoDimArray.txt", twoDimArray);

            File.WriteAllText(@"c:\temp\arrayWithIndexes.txt", arrayWithIndexes);

            // ------------------

            string twoDimArray2 = GenerateTwoDimArray(100, 100, false);

            string arrayWithIndexes2 = GenerateArrayWithIndexes(100, 100, false);

            File.WriteAllText(@"c:\temp\twoDimArrayNoGuid.txt", twoDimArray2);

            File.WriteAllText(@"c:\temp\arrayWithIndexesNoGuid.txt", arrayWithIndexes2);
        }

        private static string GenerateArrayWithIndexes(int v1, int v2, bool generateGuid)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < v1; i++)
            {
                for (int j = 0; j < v1; j++)
                {
                    string guid = "";
                    if (generateGuid)
                    {
                        guid = Guid.NewGuid().ToString();
                    }

                    sb.AppendLine($"{{{i},{j},'{guid}','{i}{j}{i}{j}'}},");
                }
            }

            return sb.ToString();
        }

        private static string GenerateTwoDimArray(int v1, int v2, bool generateGuid)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < v1; i++)
            {
                sb.AppendLine($"[");
                for (int j = 0; j < v1; j++)
                {
                    string guid = "";
                    if (generateGuid)
                    {
                        guid = Guid.NewGuid().ToString();
                    }

                    sb.AppendLine($"{{'{guid}','{i}{j}{i}{j}'}},");
                }
                sb.AppendLine($"],");
            }

            return sb.ToString();
        }
    }
}
