using EFcore.Models;

namespace EFcore.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        Employee Update(Employee emp);
        void Insert(Employee emp);
        Employee Delete(Employee emp);
    }
}
