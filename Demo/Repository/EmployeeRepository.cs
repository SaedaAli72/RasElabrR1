using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ITIContext context;

        public EmployeeRepository(ITIContext context)
        {
            this.context = context;
        }
        public void Add(Employee obj)
        {
            context.Add(obj);
        }

        public void Delete(int id)
        {
            Employee employee = GetById(id);
            context.Remove(employee);
        }

        public List<Employee> GetAll()
        {
            return context.Employees.Include(e => e.Department).ToList();
        }

        public Employee GetById(int id)
        {
            return context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Employee obj)
        {
            context.Update(obj);
        }
    }
}
