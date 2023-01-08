using DomainLayer.Models;
using HomeWork_List.Controller;

#region Implicit operator for Celsius
double degree = 1;
Celsius celsius = new(degree);
Kelvin kelvin = celsius;
//Console.WriteLine(kelvin.Degree);
#endregion
#region Author
AuthorController authorController = new AuthorController();
//authorController.GetAuthorFullNameByFilteredAge();
#endregion
#region Employee
EmployeeController employeeController = new EmployeeController();
//employeeController.GetEmployeesCountByFiltered();
#endregion

