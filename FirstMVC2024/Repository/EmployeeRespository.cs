using FirstMVC2024.Models;

namespace FirstMVC2024.Repository
{
    public class EmployeeRespository : IEmployeeRepositorycs
    {
       static List<Employee> _employees = new List<Employee>();
            static EmployeeRespository()
                 {
            Employee objEmpl1 = new Employee();
            objEmpl1.Id = 1;
            objEmpl1.Name = "Mohan";
            objEmpl1.Salary = 5000;
            objEmpl1.City = "Khurja";

            _employees.Add(objEmpl1);
            _employees.Add(new Employee() {Id = 2 , Name = "Kumar" , Salary = 7990, City = "Bulandhshar"});
            _employees.Add(new Employee() {Id = 3 , Name = "Raghav" , Salary = 8990, City = "Aligarh"});

  }

        public void AddEmployee(Employee emp)
        {
            //emp.Id = _employees.Count > 0 ? _employees.Max(e => e.Id) + 1 : 1;
            _employees.Add(emp);
            //throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _employees.First(value => value.Id == id);
            _employees.Remove(employee);
        }

        public List<Employee> GetEmployee()
        {
          return _employees;
        }
        public Employee GetEmployeeById(int id)
        {
            //Linq = Language Integrated query
            var employee = _employees.First(value => value.Id == id);
            return employee;           
                                                                                              
        }

        public void UpdateEmployee(Employee emp)
        {
            var employee = _employees.First(value => value.Id == emp.Id);
             employee.Name = emp.Name;
            employee.Salary = emp.Salary;
            employee.City = emp.City;

        }
    }
}
