using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_List.Controller
{
    public class EmployeeController
    {
        public void GetEmployeesCountByFiltered()
        {
            EmployeeService employeeService = new EmployeeService();

            Console.WriteLine("Enter start date");
        FirstDate: string startDateStr = Console.ReadLine();
            DateTime startDate;
            bool IsParseFirstDate=DateTime.TryParse(startDateStr, out startDate);
            if (!IsParseFirstDate)
            {
                Console.WriteLine("Enter a valid date");
                goto FirstDate;
            }

            Console.WriteLine("Enter last date");
        LastDate: string lastDateStr = Console.ReadLine();
            DateTime lastDate;
            bool IsParseLastDate = DateTime.TryParse(lastDateStr, out lastDate);
            if (!IsParseLastDate)
            {
                Console.WriteLine("Enter a valid date");
                goto LastDate;
            }
            var res = employeeService.GetEmployeesCountByFiltered(startDate, lastDate);
            Console.WriteLine(res);
        }
    }
}
