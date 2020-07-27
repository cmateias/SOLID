namespace SOLID.DependencyInversionPrinciple.Without
{
    public class EmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // TODO Get employee details from DB
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