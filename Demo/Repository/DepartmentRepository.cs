using Demo.Models;

namespace Demo.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ITIContext context;

        public DepartmentRepository(ITIContext context)
        {
            this.context = context;
        }

        public List<Department> GetAll()
        {
          return  context.departments.ToList();
        }
        public Department GetById(int id)
        {
            return context.departments.FirstOrDefault(d => d.Id == id);
        }
        public void Add(Department obj)
        {
            context.Add(obj);
        }
        public void Update(Department obj) { 
            context.Update(obj);
        }
        public void Delete(int id) {
            Department department = GetById(id);
            context.Remove(department);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
