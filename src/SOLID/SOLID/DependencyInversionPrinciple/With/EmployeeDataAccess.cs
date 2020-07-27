namespace SOLID.DependencyInversionPrinciple.With
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // TODO Get employee details from db
            var emp = new Employee
            {
                ID = id,
                Name = "Employee Name",
                Department = "HR",
                Salary = 10000
            };
            return emp;
        }
    }
}