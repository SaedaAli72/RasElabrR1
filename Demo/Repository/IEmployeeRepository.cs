using Demo.Models;

namespace Demo.Repository
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public void Add(Employee obj);
        public void Update(Employee obj);
        public void Delete(int id);
        public void Save();

    }
}
