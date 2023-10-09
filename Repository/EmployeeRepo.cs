using EFcore.Models;

namespace EFcore.Repository
{
    public class EmployeeRepo : IEmployeeRepository
    {
        private readonly AppDbContext _context ;

        public EmployeeRepo(AppDbContext context)
        {
            _context=context;
        }
       
        public void Insert(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> empList = _context.Employees.ToList();
            return empList;
        }

        
        public Employee GetById(int id)
        {
            Employee std = _context.Employees.Find(id);
            return std;
        }


        public Employee Update(Employee emp)
        {
            _context.Employees.Update(emp);
            _context.SaveChanges();
            return emp;
        }
        public Employee Delete(Employee emp)
        {
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return emp;
        }
    }
}
