using FirstMVC2024.Context;
using FirstMVC2024.Models;

namespace FirstMVC2024.Repository
{
    public class SqlEmployeeRepository : IEmployeeRepositorycs
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public SqlEmployeeRepository(EmployeeDbContext employeeDbContext)
        {
             _employeeDbContext = employeeDbContext;
        }
        public void AddEmployee(Employee emp)
        {
            //throw new NotImplementedException();
           _employeeDbContext.Employees.Add(emp);
            _employeeDbContext.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            //throw new NotImplementedException();
            var employee = _employeeDbContext.Employees.First(value => value.Id == id);
                 _employeeDbContext.Employees.Remove(employee);
            _employeeDbContext.SaveChanges();
        }

        public List<Employee> GetEmployee()
        {
            //throw new NotImplementedException();
            return _employeeDbContext.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {

            var employee = _employeeDbContext.Employees.First(value => value.Id == id);
            return employee;
            //throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee emp)
        {
            //throw new NotImplementedException();
            var employee = _employeeDbContext.Employees.First(value => value.Id == emp.Id);
            employee.Name = emp.Name;
            employee.Salary = emp.Salary;
            employee.City = emp.City;
            _employeeDbContext.Employees.Update(employee);
            _employeeDbContext.SaveChanges();
        }
    }
}
