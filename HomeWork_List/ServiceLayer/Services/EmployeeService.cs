using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public int GetEmployeesCountByFiltered(DateTime startDate,DateTime lastDate)
        {
            var empList = GetEmployees();
            int count = 0;
            foreach (var employee in empList) 
            {
                if (employee.Birthday > startDate && employee.Birthday < lastDate && employee.Salary > 2000)
                {
                    count++;
                }
            }
            return count;
        }
        private List<Employee> GetEmployees()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee()
            {
                Name = "Chinara",
                Surname = "Ibadova",
                Birthday = new DateTime(2000, 09, 08),
                Salary = 1950
            });
            empList.Add(new Employee()
            {
                Name = "Konul",
                Surname = "Ibrahimova",
                Birthday = new DateTime(1997, 09, 08),
                Salary = 2100
            });
            empList.Add(new Employee()
            {
                Name = "Roya",
                Surname = "Meherremova",
                Birthday = new DateTime(1997, 09, 08),
                Salary = 2000
            });
            empList.Add(new Employee()
            {
                Name = "Gullu",
                Surname = "Ibrahimova",
                Birthday = new DateTime(1992, 07, 29),
                Salary = 1500
            });
            return empList;
        }
    }
}
