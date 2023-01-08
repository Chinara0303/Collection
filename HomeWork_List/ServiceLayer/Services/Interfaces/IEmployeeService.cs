
namespace ServiceLayer.Services.Interfaces
{
    public interface IEmployeeService
    {
        int GetEmployeesCountByFiltered(DateTime startDate, DateTime lastDate);
    }
}
