using EmloyoeeApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
namespace EmloyoeeApi.Services
{
   
        public class EmployeeServices
        {
            private readonly IEmployeeRepository _employeeRepository;

            public EmployeeServices(IEmployeeRepository employeeRepository)
            {
                _employeeRepository = employeeRepository;
            }

            public async Task<List<Employee>> GetAllAsync(int pageNumber, int pageSize)
            {
                return await _employeeRepository.GetAllAsync(pageNumber, pageSize);
            }

            public async Task<Employee> GetAsync(int id)
            {
                return await _employeeRepository.GetAsync(id);
            }

            public async Task AddAsync(Employee employee)
            {
                await _employeeRepository.AddAsync(employee);
            }

            public async Task<Employee> UpdateAsync(int id, Employee employee)
            {
                if (id != employee.Id)
                {
                    return null;
                }

                return await _employeeRepository.UpdateAsync(employee);
            }

            public async Task<Employee> DeleteAsync(int id)
            {
                return await _employeeRepository.DeleteAsync(id);
            }
        }

    }

