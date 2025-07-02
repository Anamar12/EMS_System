using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_System
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void btn_dispAllEmp_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the Department ID field
                if (string.IsNullOrWhiteSpace(allEmpDep_txt.Text))
                {
                    MessageBox.Show("Please enter a Department ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Capture the Department ID
                int departmentId = Convert.ToInt32(allEmpDep_txt.Text);

                // Get the connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["EMS_ConnectionString"].ConnectionString;

                // SQL Query to fetch all employees in the specified department
                string query = @"SELECT EmployeeID, FirstName, LastName, Salary 
                         FROM Employee 
                         WHERE DepartmentID = @DepartmentID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@DepartmentID", departmentId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there are results
                            if (reader.HasRows)
                            {
                                // Prepare a string to display employee details
                                StringBuilder result = new StringBuilder();

                                result.AppendLine("Employees in Department:");
                                result.AppendLine("------------------------------------------------");

                                while (reader.Read())
                                {
                                    result.AppendLine($"ID: {reader["EmployeeID"]}, Name: {reader["FirstName"]} {reader["LastName"]}, Salary: {reader["Salary"]}");
                                }

                                // Display the result in a message box
                                MessageBox.Show(result.ToString(), "Employee Details");
                            }
                            else
                            {
                                MessageBox.Show("No employees found in the specified department.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Department ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
