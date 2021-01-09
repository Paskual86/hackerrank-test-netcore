using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTest.Tests
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }

    public static class EmployeesManagement
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if (IsValid(employees))
            {
                return employees.GroupBy(gb => gb.Company).OrderBy(ob => ob.Key).ToDictionary(gb => gb.Key, gb => (int)Math.Round(gb.ToList().Average(avg=>avg.Age)));
            }
            return result;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if (IsValid(employees))
            {
                return employees.GroupBy(gb => gb.Company).OrderBy(ob=>ob.Key).ToDictionary(gb => gb.Key, gb => gb.ToList().Count());
            }
            return result;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, Employee> result = new Dictionary<string, Employee>();
            if (IsValid(employees))
            {
                result = employees.GroupBy(gb => gb.Company).OrderBy(ob => ob.Key).ToDictionary(gb => gb.Key, result => result.OrderByDescending(ob => ob.Age).FirstOrDefault());
            }
            return result;
        }

        public static bool IsValid(List<Employee> employees)
        {
            return ((employees != null) && (employees.Count > 0));
        }
        public static void Execute() 
        { 
        
        }
    }
}
