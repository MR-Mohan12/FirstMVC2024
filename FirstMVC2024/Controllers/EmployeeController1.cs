using FirstMVC2024.Models;
using FirstMVC2024.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC2024.Controllers
{
    public class EmployeeController1 : Controller
    {

        private readonly IEmployeeRepositorycs _employeeRepositorycs;
        public EmployeeController1( IEmployeeRepositorycs employeeRespository )
        {
            //_employeeRepositorycs = new EmployeeRespository();
            _employeeRepositorycs = employeeRespository;

        }

        // GET: EmployeeController1
        public ActionResult Index()
        {
            List<Employee> employees = _employeeRepositorycs.GetEmployee();
            return View(employees);
        }

        // GET: EmployeeController1/Details/5
        public ActionResult Details(int id)
        {
            var employee = _employeeRepositorycs.GetEmployeeById(id);
            return View(employee);
        }

        // GET: EmployeeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
                _employeeRepositorycs.AddEmployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View();
            }
        }

        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {

            var employee = _employeeRepositorycs.GetEmployeeById(id);
            return View(employee);
          
        }

        // POST: EmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee collection)
        {
            try
            {
                _employeeRepositorycs.UpdateEmployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
