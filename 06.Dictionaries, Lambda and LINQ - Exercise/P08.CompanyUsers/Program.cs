namespace P08.CompanyUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string[] input = command.Split(" -> ").ToArray();
                string company = input[0];
                string employeeID = input[1];

                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers.Add(company, new List<string>());
                }
                if (companyUsers.ContainsKey(company))
                {
                    if (!companyUsers[company].Contains(employeeID))
                    {
                        companyUsers[company].Add(employeeID);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var employee in companyUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine(employee.Key);

                foreach (var item in employee.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}