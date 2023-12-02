using System;
using System.Collections.Generic;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> error_lines = new List<string>();
            string line;

            int sum = 0;
            int tempnum = 0;

            while ((line = Console.ReadLine()) != null)
            {
                error_lines.Add(line);
            }

            foreach (string error_line in error_lines)
            {

                for (int i = 0; i < error_line.Length; i++)
                {

                    if (char.IsNumber(error_line[i]))
                    {
                        tempnum = Convert.ToChar(Convert.ToString(error_line[i]));
                        break;
                    }

                }

                for (int i = error_line.Length - 1; i >= 0; i--)
                {
                
                    if (char.IsNumber(error_line[i]))
                    {
                        tempnum = tempnum * 10 + Convert.ToChar(Convert.ToString(error_line[i]));
                        break;
                    }
                
                }

                sum += Convert.ToInt16(Convert.ToString(tempnum));
                tempnum = 0;

                Console.WriteLine(sum);
            }
        }
    }
}