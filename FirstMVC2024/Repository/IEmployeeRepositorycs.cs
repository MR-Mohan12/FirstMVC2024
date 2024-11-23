using FirstMVC2024.Models;

namespace FirstMVC2024.Repository
{
    public interface IEmployeeRepositorycs
    {
        List<Employee> GetEmployee(); 
        Employee GetEmployeeById(int id);
        void AddEmployee (Employee emp);
        void UpdateEmployee (Employee emp);
        void DeleteEmployee (int id);
    }
    

}
