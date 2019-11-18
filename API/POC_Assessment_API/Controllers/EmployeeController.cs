using POC_Assessment_API.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net;
using System.Web.Http;

namespace POC_Assessment_API.Controllers
{
    public class EmployeeController : ApiController
    {
        // instance of the database to be used in the API functions
        private pocassesmentEntities db = new pocassesmentEntities();

        // retrieve a list of all the employees
        [System.Web.Http.Route("api/Employee/GetEmployeeList")]
        [System.Web.Http.HttpGet]
        public dynamic GetEmployeeList()
        {
            // stop framework from creating dynamically generated proxy classes of the database instance.
            db.Configuration.ProxyCreationEnabled = false;
            // call private function that will generate the JSON object containing the list of employees
            return GenerateEmployeeList(db.Employees.ToList());
        }

        // this function generates the JSON object that contains a list of employees
        private dynamic GenerateEmployeeList(List<Employee> employees)
        {
            List<dynamic> EmployeeList = new List<dynamic>();
            foreach (Employee employee in employees)
            {
                dynamic empObject = new ExpandoObject();
                empObject.EmpNumber = employee.EmpNumber;
                empObject.EmpName = employee.EmpName;
                empObject.EmpSurname = employee.EmpSurname;
                empObject.EmpDOB = employee.EmpDOB;
                empObject.EmpSalary = employee.EmpSalary;
                empObject.RoleDesc = employee.RoleDesc;
                empObject.ReportingLine = employee.ReportingLine;
                EmployeeList.Add(empObject);
            }
            // the retObject is a JSON object with one property 'Employees' and its value is a list of Employee Object
            dynamic retObject = new ExpandoObject();
            retObject.Employees = EmployeeList;
            return retObject;
        }
    }
}