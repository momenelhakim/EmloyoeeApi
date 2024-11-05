using EmloyoeeApi.Models;

namespace EmloyoeeApi.Services
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync(int pageNumber, int pageSize);
        Task<Employee> GetAsync(int id);
        Task AddAsync(Employee employee);
        Task<Employee> UpdateAsync(Employee employee);
        Task<Employee> DeleteAsync(int id);
    }

}
