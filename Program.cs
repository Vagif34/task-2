using System;

namespace home_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "mart";
            switch (month)
            {
                case "yanvar":
                case "mart":
                case "dekabr":
                case "iyul":
                    
                    Console.WriteLine("31 gunden ibaretdir");
                    break;
                case "aprel":
                case "iyun":
                    case "noyabr"
                    case "sentyabr":
                    Console.WriteLine("30 gunden ibaretdir");
                    break;
                case "fevral":
                    Console.WriteLine("28 gunden ibaretdir");
                    break;

            }
        }
    }
}
