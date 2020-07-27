﻿namespace SOLID.DependencyInversionPrinciple.With
{
    public class EmployeeBusinessLogic
    {
        private readonly IEmployeeDataAccess _EmployeeDataAccess;

        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}