using Demo.Models;

namespace Demo.Repository
{
    public interface IDepartmentRepository
    {
        public List<Department> GetAll();
        public Department GetById(int id);
        public void Add(Department obj);
        public void Update(Department obj);
        public void Delete(int id);
        public void Save();




        }
}
