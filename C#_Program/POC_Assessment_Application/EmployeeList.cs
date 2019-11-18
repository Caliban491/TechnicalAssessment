using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Assessment_Application
{
    // this class contains a list of Employee objects
    class EmployeeList
    {
        private List<Employee> employees;
        public List<Employee> Employees { get => employees; set => employees = value; }
    }
}
