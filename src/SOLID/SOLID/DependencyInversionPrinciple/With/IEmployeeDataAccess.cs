namespace SOLID.DependencyInversionPrinciple.With
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}