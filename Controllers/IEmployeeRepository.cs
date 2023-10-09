using EFcore.Models;

namespace EFcore.Controllers
{
    public interface IEmployeeRepository<T>
    {
        void Delete(Employee s);
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Insert(Employee e);
        void Update(Employee s);
    }
}