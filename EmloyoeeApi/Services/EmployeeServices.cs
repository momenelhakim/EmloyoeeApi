using EmloyoeeApi.Models;
using Microsoft.EntityFrameworkCore;
namespace EmloyoeeApi.Services
{
    public class EmployeeServices
    {
        private readonly ApplicationDbContext _context;

        public EmployeeServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetAsync(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

      
        public async Task AddAsync(Employee employee)

        {  
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        
        public async Task DeleteAsync(int id)
        {
            var employee = await GetAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }
    }
}