using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
    class Solution_690
    {
        Dictionary<int, Employee> list;
        public int GetImportance(IList<Employee> employees, int id)
        {
            list = employees.ToDictionary(z => z.id);
            var first = employees.First(x => x.id == id);
           return first.importance + Helper( first.subordinates);

        }

        public int Helper(IList<int> employees)
        {
            if (employees.Count <= 0) return 0;
            int result = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                var employee = list[employees[i]];
                result = result + Helper(employee.subordinates) + employee.importance;
            }

            return result;
        }
    }
}
