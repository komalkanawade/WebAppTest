using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTest
{
    public partial class WebForm2 : System.Web.UI.Page
    {
       
        private static DataTable EmployeeTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize the DataTable structure.
                if (EmployeeTable == null)
                {
                    EmployeeTable = new DataTable();
                    EmployeeTable.Columns.Add("EmployeeCode", typeof(int));
                    EmployeeTable.Columns.Add("EmployeeName", typeof(string));
                    EmployeeTable.Columns.Add("DateOfBirth", typeof(string));
                    EmployeeTable.Columns.Add("Gender", typeof(string));
                    EmployeeTable.Columns.Add("Department", typeof(string));
                    EmployeeTable.Columns.Add("Designation", typeof(string));
                    EmployeeTable.Columns.Add("BasicSalary", typeof(double));
                    EmployeeTable.Columns.Add("DearnessAllowance", typeof(double));
                    EmployeeTable.Columns.Add("ConveyanceAllowance", typeof(double));
                    EmployeeTable.Columns.Add("HouseRentAllowance", typeof(double));
                    EmployeeTable.Columns.Add("PT", typeof(double));
                    EmployeeTable.Columns.Add("TotalSalary", typeof(double));
                }

                gvEmployee.DataSource = EmployeeTable;
                gvEmployee.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get input values
            int employeeCode = Convert.ToInt32(txtEmployeeCode.Text);
            string employeeName = txtEmployeeName.Text;
            string dateOfBirth = txtDateOfBirth.Text;
            string gender = rbMale.Checked ? "Male" : "Female";
            string department = txtDepartment.Text;
            string designation = txtDesignation.Text;
            double basicSalary = Convert.ToDouble(txtBasicSalary.Text);

            // Calculate allowances
            double dearnessAllowance = basicSalary * 0.40;
            double conveyanceAllowance = Math.Min(dearnessAllowance * 0.10, 250);
            double houseRentAllowance = Math.Max(basicSalary * 0.25, 1500);

            // Calculate gross salary (used for PT calculation)
            double grossSalary = basicSalary + dearnessAllowance + conveyanceAllowance + houseRentAllowance;

            // Calculate Professional Tax (PT)
            double pt = 0;
            if (grossSalary <= 3000)
                pt = 100;
            else if (grossSalary > 3000 && grossSalary <= 6000)
                pt = 150;
            else
                pt = 200;

            // Calculate Total Salary
            double totalSalary = basicSalary + dearnessAllowance + conveyanceAllowance + houseRentAllowance - pt;

            // Add data to the DataTable
            DataRow row = EmployeeTable.NewRow();
            row["EmployeeCode"] = employeeCode;
            row["EmployeeName"] = employeeName;
            row["DateOfBirth"] = dateOfBirth;
            row["Gender"] = gender;
            row["Department"] = department;
            row["Designation"] = designation;
            row["BasicSalary"] = basicSalary;
            row["DearnessAllowance"] = dearnessAllowance;
            row["ConveyanceAllowance"] = conveyanceAllowance;
            row["HouseRentAllowance"] = houseRentAllowance;
            row["PT"] = pt;
            row["TotalSalary"] = totalSalary;

            EmployeeTable.Rows.Add(row);

            // Bind the updated data to the GridView
            gvEmployee.DataSource = EmployeeTable;
            gvEmployee.DataBind();

            // Clear the input fields for a new entry
            ClearFields();
        }

        private void ClearFields()
        {
            txtEmployeeCode.Text = "";
            txtEmployeeName.Text = "";
            txtDateOfBirth.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtDepartment.Text = "";
            txtDesignation.Text = "";
            txtBasicSalary.Text = "";
        }
    }
}
