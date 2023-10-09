using EFcore.Models;
using EFcore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EFcore.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository _repo ;
        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            IEnumerable<Employee> empList = _repo.GetAll();
            return View(empList);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            Employee emp = _repo.GetById(id);
            return View(emp);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]

        public ActionResult Create(Employee e)
        {
            _repo.Insert(e);
            TempData["success_on_create"] = $"A record with id {e.id} is Added Successfully!";
            return RedirectToAction("Index");
        }

        // GET: StudentController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee emp = _repo.GetById(id);
            return View(emp);
        }

        // POST: StudentController/Edit/5
        [HttpPost]

        public ActionResult Edit(Employee s)
        {
            _repo.Update(s);
            TempData["success_on_edit"] = $"Record with Id {s.id} is updated Successfully!";
            return RedirectToAction("Index");
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee std = _repo.GetById(id);
            return View(std);
        }

        // POST: StudentController/Delete/5
        [HttpPost]

        public ActionResult Delete(Employee s)
        {
            _repo.Delete(s);
            TempData["success_on_delete"] = $"Record with Id {s.id} is deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
