using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Assessment_Application
{
    // this class represents an Employee and all the related data fields
    class Employee
    {
        int empNumber;
        string empName;
        string empSurname;
        string empDOB;
        double empSalary;
        string roleDesc;
        int reportingLine;

        public int ReportingLine { get => reportingLine; set => reportingLine = value; }
        public int EmpNumber { get => empNumber; set => empNumber = value; }
        public string EmpName { get => empName; set => empName = value; }
        public string EmpSurname { get => empSurname; set => empSurname = value; }
        public string EmpDOB { get => empDOB; set => empDOB = value; }
        public double EmpSalary { get => empSalary; set => empSalary = value; }
        public string RoleDesc { get => roleDesc; set => roleDesc = value; }
    }
}
