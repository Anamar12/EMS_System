using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_System
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txt_id.Text) ||
                    string.IsNullOrWhiteSpace(firstName_txt.Text) ||
                    string.IsNullOrWhiteSpace(surname_txt.Text) ||
                    string.IsNullOrWhiteSpace(dep_txt.Text) ||
                    string.IsNullOrWhiteSpace(salary_txt.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!int.TryParse(txt_id.Text, out int employeeId))
                {
                    MessageBox.Show("Employee ID must be a valid number.");
                    return;
                }

                if (!int.TryParse(dep_txt.Text, out int departmentId))
                {
                    MessageBox.Show("Department ID must be a valid number.");
                    return;
                }

                if (!double.TryParse(salary_txt.Text, out double salary))
                {
                    MessageBox.Show("Salary must be a valid number.");
                    return;
                }

                string firstName = firstName_txt.Text;
                string surname = surname_txt.Text;

                // Get the connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["EMS_ConnectionString"].ConnectionString;

                // SQL Query for insertion
                string query = @"INSERT INTO Employee (FirstName, LastName, DepartmentID, Salary) 
                 VALUES (@FirstName, @LastName, @DepartmentID, @Salary)";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", surname);
                        cmd.Parameters.AddWithValue("@DepartmentID", departmentId);
                        cmd.Parameters.AddWithValue("@Salary", salary);


                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Notify the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the employee.");
                        }
                    }
                }

                // Clear input fields
                txt_id.Clear();
                firstName_txt.Clear();
                surname_txt.Clear();
                dep_txt.Clear();
                salary_txt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        
    }

        private void delEmp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if Employee ID is provided
                if (string.IsNullOrWhiteSpace(txt_id.Text))
                {
                    MessageBox.Show("Please enter an Employee ID to delete.");
                    return;
                }

                // Capture Employee ID
                int employeeId = Convert.ToInt32(txt_id.Text);

                // Get the connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["EMS_ConnectionString"].ConnectionString;

                // SQL Query for deletion
                string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Notify the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the given ID.");
                        }
                    }
                }

                // Clear input fields
                txt_id.Clear();
                firstName_txt.Clear();
                surname_txt.Clear();
                dep_txt.Clear();
                salary_txt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void viewEmp_txt_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if Employee ID is provided
                if (string.IsNullOrWhiteSpace(txt_id.Text))
                {
                    MessageBox.Show("Please enter an Employee ID to view details.");
                    return;
                }

                // Capture Employee ID
                int employeeId = Convert.ToInt32(txt_id.Text);

                // Get the connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["EMS_ConnectionString"].ConnectionString;

                // SQL Query to fetch employee details
                string query = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If a record is found
                            {
                                // Populate the text fields with employee details
                                firstName_txt.Text = reader["FirstName"].ToString();
                                surname_txt.Text = reader["LastName"].ToString();
                                dep_txt.Text = reader["DepartmentID"].ToString();
                                salary_txt.Text = reader["Salary"].ToString();

                                MessageBox.Show("Employee details loaded successfully!");
                            }
                            else
                            {
                                MessageBox.Show("No employee found with the given ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
