<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAppTest.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee Entry</h2>
            <table>
                <tr>
                    <td>Employee Code:</td>
                    <td><asp:TextBox ID="txtEmployeeCode" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Employee Name:</td>
                    <td><asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Date of Birth:</td>
                    <td><asp:TextBox ID="txtDateOfBirth" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" Text="Male" />
                        <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" />
                    </td>
                </tr>
                <tr>
                    <td>Department:</td>
                    <td><asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Designation:</td>
                    <td><asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Basic Salary:</td>
                    <td><asp:TextBox ID="txtBasicSalary" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>

            <h3>Employee List</h3>
            <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="EmployeeCode" HeaderText="Employee Code" />
                    <asp:BoundField DataField="EmployeeName" HeaderText="Employee Name" />
                    <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:BoundField DataField="Department" HeaderText="Department" />
                    <asp:BoundField DataField="Designation" HeaderText="Designation" />
                    <asp:BoundField DataField="BasicSalary" HeaderText="Basic Salary" />
                    <asp:BoundField DataField="DearnessAllowance" HeaderText="Dearness Allowance" />
                    <asp:BoundField DataField="ConveyanceAllowance" HeaderText="Conveyance Allowance" />
                    <asp:BoundField DataField="HouseRentAllowance" HeaderText="House Rent Allowance" />
                    <asp:BoundField DataField="PT" HeaderText="Professional Tax (PT)" />
                    <asp:BoundField DataField="TotalSalary" HeaderText="Total Salary" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
