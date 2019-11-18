using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Globalization;

namespace POC_Assessment_Application
{
    public partial class Form1 : Form
    {
        // after loading the list of Employees from the remote API, these arrays are populated with the relevant Employees
        List<Employee> managers = new List<Employee>();
        List<Employee> employees = new List<Employee>();
        List<Employee> trainees = new List<Employee>();
        List<Employee> allEmployees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // when the main form loads (this form namely 'Form1') it will immediately request a list of Employees from the remote API service
            GetEmployeeList("http://pocassessmentapi.co.za//api/Employee/GetEmployeeList");
        }

        // this function implements an asynchronous request to a remote API to retrieve a list of Employees
        async void GetEmployeeList(string apiURL)
        {
            try
            {
                // the 'using' function is used here, and subsequently, to automatically release memory when the operation is finished
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(apiURL))
                    {
                        using (HttpContent content = response.Content)
                        {
                            // here we store the returned value from the API as a string
                            string rawJSON = await content.ReadAsStringAsync();
                            EmployeeList empList = new EmployeeList();

                            // here we convert the raw JSON string into a JSON object and store it in an instance of the EmployeeList class.
                            empList = JsonConvert.DeserializeObject<EmployeeList>(rawJSON);

                            // stripping the time stamp from the dates
                            foreach (Employee u in empList.Employees)
                            {
                                u.EmpDOB = u.EmpDOB.Substring(0, 10);
                            }

                            // here we loop through the list of Employee and sort them into arrays depending on their Role in the company
                            foreach (Employee x in empList.Employees)
                            {
                                if (x.RoleDesc == "Manager")
                                {
                                    managers.Add(x);
                                    allEmployees.Add(x);
                                }
                                if (x.RoleDesc == "Employee")
                                {
                                    employees.Add(x);
                                    allEmployees.Add(x);
                                }
                                if (x.RoleDesc == "Trainee")
                                {
                                    trainees.Add(x);
                                    allEmployees.Add(x);
                                }
                            }
                        }
                    }
                }
                lblStatus.Text = "DATA RETRIEVED FROM API!";
                lblStatus.BackColor = Color.Green;
                pnlHome.BackColor = Color.Green;
                btnSearch.Enabled = true;
                btnDisplay.Enabled = true;
                btnDOB.Enabled = true;
                btnRank.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Something went wrong whilst loading data from the API");
            }        
        }


        // when the Display Tree Structure button is clicked a data tree view is populated and displayed to the user
        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            // showing the data tree view on the interface
            ShowInterface(1);

            // counters used in population of data tree view
            int manCounter = 0;
            int empCounter;

            treeViewEmployees.Nodes.Clear();
            treeViewEmployees.Nodes.Add("Corporate Structure");

            // populate the data tree view
            // this foreach algorithm populates the managers, employees under them, and trainees under the latter
            foreach (Employee x in managers)
            {
                treeViewEmployees.Nodes[0].Nodes.Add("Manager " + x.EmpNumber.ToString() + " " + x.EmpName + " " + x.EmpSurname + "      " + x.EmpDOB + "      " + x.EmpSalary.ToString("C2",CultureInfo.CreateSpecificCulture("en-ZA")));

                //populate the Employees under the current Manager
                empCounter = 0;
                foreach (Employee y in employees)
                {
                    if (y.ReportingLine == x.EmpNumber)
                    {
                        treeViewEmployees.Nodes[0].Nodes[manCounter].Nodes.Add("Employee " + y.EmpNumber.ToString() + " " + y.EmpName + " " + y.EmpSurname + "      " + y.EmpDOB + "      " + y.EmpSalary.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));

                        //populate the Trainees under the current Employee
                        foreach (Employee z in trainees)
                        {
                            if (z.ReportingLine == y.EmpNumber)
                            {
                                treeViewEmployees.Nodes[0].Nodes[manCounter].Nodes[empCounter].Nodes.Add("Trainee " + z.EmpNumber.ToString() + " " + z.EmpName + " " + z.EmpSurname + "      " + z.EmpDOB + "      " + z.EmpSalary.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));
                            }
                        }
                        empCounter++;
                    }                    
                }
                manCounter++;
            }

            treeViewStats.Nodes.Clear();
            treeViewStats.Nodes.Add("Statistics");
            treeViewStats.Nodes[0].Nodes.Add("Manager Count: " + managers.Count);
            treeViewStats.Nodes[0].Nodes.Add("Employee Count: " + employees.Count);
            treeViewStats.Nodes[0].Nodes.Add("Trainee Count: " + trainees.Count);
            treeViewStats.Nodes[0].Nodes.Add("Total Count: " + (managers.Count + employees.Count + trainees.Count));

            treeViewEmployees.ExpandAll();
            treeViewStats.ExpandAll();
        }

        // function called when a menu item is clicked. Operations to show and hide relevant intefaces 
        private void ShowInterface(int x)
        {
            if(x==1)
            {
                treeViewEmployees.Visible = true;
                treeViewStats.Visible = true;
                expCS.Visible = true;
                collCS.Visible = true;
                rankingTable.Visible = false;
                dobInterface.Visible = false;
                pnlSearching.Visible = false;
                pnlHome.Visible = false;
            }
            else if(x==2)
            {
                treeViewEmployees.Visible = false;
                treeViewStats.Visible = false;
                expCS.Visible = false;
                collCS.Visible = false;
                rankingTable.Visible = false;
                dobInterface.Visible = false;
                pnlSearching.Visible = true;
                pnlHome.Visible = false;
                cmbFilter.SelectedIndex = 0;
                resultsBox.Items.Clear();
                PerformSearch();
            }
            else if(x==3)
            {
                treeViewEmployees.Visible = false;
                treeViewStats.Visible = false;
                expCS.Visible = false;
                collCS.Visible = false;
                rankingTable.Visible = false;
                dobInterface.Visible = true;
                pnlSearching.Visible = false;
                pnlHome.Visible = false;
            }
            else
            {
                treeViewEmployees.Visible = false;
                treeViewStats.Visible = false;
                expCS.Visible = false;
                collCS.Visible = false;
                rankingTable.Visible = true;
                dobInterface.Visible = false;
                pnlSearching.Visible = false;
                pnlHome.Visible = false;
            }
        }

        // when the Rank Earnings button is clicked, 3 list boxes are populated to display the highest earning ranking, grouper per role
        private void BtnRank_Click(object sender, EventArgs e)
        {
            // show rank earnings interface
            ShowInterface(4);

            managerListBox.Items.Clear();
            employeeListBox.Items.Clear();
            traineeListBox.Items.Clear();
            highestListBox.Items.Clear();
            statsListBox.Items.Clear();

            // variables to store totals
            double totalEarnings = 0;
            double totalManagerEarnings = 0;
            double totalEmployeeEarnings = 0;
            double totalTraineeEarnings = 0;

            // populate headings
            managerListBox.Items.Add("MANAGERS:");
            employeeListBox.Items.Add("EMPLOYEES:");
            traineeListBox.Items.Add("TRAINEES:");
            highestListBox.Items.Add("HIGHEST EARNER:");
            statsListBox.Items.Add("BASICS STATS:");

            // populate sorted arrays
            List<Employee> sortedManagers = managers.OrderByDescending(o=>o.EmpSalary).ToList();
            List<Employee> sortedEmployees = employees.OrderByDescending(o => o.EmpSalary).ToList();
            List<Employee> sortedTrainees = trainees.OrderByDescending(o => o.EmpSalary).ToList();

            // display rankings
            foreach (Employee x in sortedManagers)
            {
                managerListBox.Items.Add(x.EmpName + "\t Salary: " + x.EmpSalary.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));

                // add salary to total for managers
                totalManagerEarnings += x.EmpSalary;
            }
            foreach (Employee y in sortedEmployees)
            {
                employeeListBox.Items.Add(y.EmpName + "\t Salary: " + y.EmpSalary.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));

                // add salary to total for employees
                totalEmployeeEarnings += y.EmpSalary;
            }
            foreach (Employee z in sortedTrainees)
            {
                traineeListBox.Items.Add(z.EmpName + "\t Salary: " + z.EmpSalary.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));

                // add salary to total for trainees
                totalTraineeEarnings += z.EmpSalary;
            }

            // getting the highest earner
            Employee richest = sortedManagers[0];
            if(sortedEmployees[0].EmpSalary > richest.EmpSalary)
            {
                richest = sortedEmployees[0];
            } else if(sortedTrainees[0].EmpSalary > richest.EmpSalary)
            {
                richest = sortedTrainees[0];
            }

            // populate highest earner information
            highestListBox.Items.Add("Full Name: " + richest.EmpName + " " + richest.EmpSurname);
            highestListBox.Items.Add("Position: " + richest.RoleDesc);
            highestListBox.Items.Add("Salary: " + richest.EmpSalary.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));
            highestListBox.Items.Add("Date of Birth: " + richest.EmpDOB);

            // populate basic stats
            totalEarnings = totalManagerEarnings + totalEmployeeEarnings + totalTraineeEarnings;
            statsListBox.Items.Add("Total Manager Earnings: " + totalManagerEarnings.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));
            statsListBox.Items.Add("Total Employee Earnings: " + totalEmployeeEarnings.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));
            statsListBox.Items.Add("Total Trainee Earnings: " + totalTraineeEarnings.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));
            statsListBox.Items.Add("Total Earnings: " + totalEarnings.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")));
        }

        // button used to expand the data tree view showing the corporate structure
        private void ExpCS_Click(object sender, EventArgs e)
        {
            treeViewEmployees.ExpandAll();
        }

        // button used to collapse the data tree view showing the corporate structure
        private void CollCS_Click(object sender, EventArgs e)
        {
            treeViewEmployees.CollapseAll();
        }

        // button clicked to show inteface allowing for employee identification based on a date.
        private void BtnDOB_Click(object sender, EventArgs e)
        {
            // show interface to generate range of employees based on date of birth
            ShowInterface(3);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // show employee search interface
            ShowInterface(2);
        }

        // button clicked to get a list of employees before/after a specified date
        private void BtnGetList_Click(object sender, EventArgs e)
        {
            // list to store results
            List<Employee> results = new List<Employee>();

            resultListBox.Items.Clear();

            // processing the selected date
            int selYear = datePicker.Value.Year;
            int selMonth = datePicker.Value.Month;
            int selDay = datePicker.Value.Day;
            DateTime selDate = new DateTime(selYear, selMonth, selDay, 0, 0, 0);

            // declaring the variables used to make the comparison for each iteration of the following foreach loop
            string currYear;
            string currMonth;
            string currDay;
            DateTime currDate;
            int compValue;
            
            // now comparing the selected date to each date of birth and generating a list of results
            foreach(Employee x in allEmployees)
            {
                currYear = x.EmpDOB.Substring(0, 4);
                currMonth = x.EmpDOB.Substring(5, 2);
                currDay = x.EmpDOB.Substring(8, 2);
                currDate = new DateTime(System.Convert.ToInt32(currYear), System.Convert.ToInt32(currMonth), System.Convert.ToInt32(currDay), 0, 0, 0);

                compValue = DateTime.Compare(currDate, selDate);

                if(rbtnAfter.Checked==true)
                {
                    if (compValue > 0)
                    {
                        results.Add(x);
                    }
                }
                else
                {
                    if (compValue < 0)
                    {
                        results.Add(x);
                    }
                }
            }

            // populate results in list box
            resultListBox.Items.Add("RESULTS:");
            foreach (Employee y in results)
            {
                resultListBox.Items.Add(y.EmpName + "\t" + y.EmpSurname + "\t" + y.EmpDOB + "   No:" + y.EmpNumber);
            }

            if(results.Count==0)
            {
                resultListBox.Items.Add("No Results Found!");
            }
        }

        // when the selected index in the combo box is changed, the search function is called to repopulate the relevant results
        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        // when the text in the text box is changed, the search function is called to repopulate the relevant results
        private void TbNameSurname_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        // when the value in the numeric edit is changed, the search function is called to repopulate the relevant results
        private void NudEmpNo_ValueChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        // search function that is called whenever the search criteria changes in either the text box, numeric edit or the index of the combo box changes
        private void PerformSearch()
        {
            bool stringSearch = true;
            resultsBox.Items.Clear();
            if (rbtnEmpNum.Checked)
            {
                stringSearch = false;
            }

            switch (cmbFilter.SelectedIndex)
            {
                case 0:
                    foreach (Employee x in allEmployees)
                    {
                        if (stringSearch)
                        {
                            if (x.EmpName.Contains(tbNameSurname.Text) || x.EmpSurname.Contains(tbNameSurname.Text))
                            {
                                resultsBox.Items.Add(x.EmpName + "\t" + x.EmpSurname + "\t" + x.EmpDOB + "   No:" + x.EmpNumber);
                            }
                        }
                        else
                        {
                            if (x.EmpNumber == nudEmpNo.Value)
                            {
                                resultsBox.Items.Add(x.EmpName + "\t" + x.EmpSurname + "\t" + x.EmpDOB + "   No:" + x.EmpNumber);
                            }
                        }
                    }
                    break;
                case 1:
                    foreach (Employee x in managers)
                    {
                        if (stringSearch)
                        {
                            if (x.EmpName.Contains(tbNameSurname.Text) || x.EmpSurname.Contains(tbNameSurname.Text))
                            {
                                resultsBox.Items.Add(x.EmpName + "\t" + x.EmpSurname + "\t" + x.EmpDOB + "   No:" + x.EmpNumber);
                            }
                        }
                        else
                        {
                            if (x.EmpNumber == nudEmpNo.Value)
                            {
                                resultsBox.Items.Add(x.EmpName + "\t" + x.EmpSurname + "\t" + x.EmpDOB + "   No:" + x.EmpNumber);
                            }
                        }
                    }
                    break;
                case 2:
                    foreach (Employee x in employees)
                    {
                        if (stringSearch)
                        {
                            if (x.EmpName.Contains(tbNameSurname.Text) || x.EmpSurname.Contains(tbNameSurname.Text))
                            {
                                resultsBox.Items.Add(x.EmpName + "\t" + x.EmpSurname + "\t" + x.EmpDOB + "   No:" + x.EmpNumber);
                            }
                        }
                        else
                        {
                            if (x.EmpNumber == nudEmpNo.Value)
                            {
                                resultsBox.Items.Add(x.EmpName + "\t" + x.EmpSurname + "\t" + x.EmpDOB + "   No:" + x.EmpNumber);
                            }
                        }
                    }
                    break;
                case 3:
                    foreach (Employee x in trainees)
                    {
                        if (stringSearch)
                        {
                            if (x.EmpName.Contains(tbNameSurname.Text) || x.EmpSurname.Contains(tbNameSurname.Text))
                            {
                                resultsBox.Items.Add(x.EmpName + "\t" + x.EmpSurname + "\t" + x.EmpDOB + "   No:" + x.EmpNumber);
                            }
                        }
                        else
                        {
                            if (x.EmpNumber == nudEmpNo.Value)
                            {
                                resultsBox.Items.Add(x.EmpName + "\t" + x.EmpSurname + "\t" + x.EmpDOB + "   No:" + x.EmpNumber);
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            if(resultsBox.Items.Count==0)
            {
                resultsBox.Items.Add("No Results Found!");
            }
        }

        private void RbtnEmpNum_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnEmpNum.Checked)
            {
                nudEmpNo.Enabled = true;
                tbNameSurname.Enabled = false;
            }
            nudEmpNo.Value = 1;
            tbNameSurname.Text = "";
            PerformSearch();
        }

        private void RbtnName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnName.Checked)
            {
                nudEmpNo.Enabled = false;
                tbNameSurname.Enabled = true;
            }
            nudEmpNo.Value = 1;
            tbNameSurname.Text = "";
            PerformSearch();
        }

        private void PnlSearching_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ResultsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RankingTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}