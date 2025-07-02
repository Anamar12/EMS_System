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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btn_repSal_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["EMS_ConnectionString"].ConnectionString;

                // SQL query to calculate total salary per department
                string query = @"
            SELECT 
                d.DepartmentName, 
                SUM(e.Salary) AS TotalSalary
            FROM Employee e
            INNER JOIN Department d ON e.DepartmentID = d.DepartmentID
            GROUP BY d.DepartmentName";

                // Create a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Create the command and execute the query
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Display the salary report
                            StringBuilder salaryReport = new StringBuilder();
                            salaryReport.AppendLine("Department Salary Report:");

                            while (reader.Read())
                            {
                                string departmentName = reader["DepartmentName"].ToString();
                                decimal totalSalary = Convert.ToDecimal(reader["TotalSalary"]);
                                salaryReport.AppendLine($"{departmentName}: {totalSalary:C}");
                            }

                            // Show the result in a MessageBox
                            MessageBox.Show(salaryReport.ToString(), "Department Salary Report");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["EMS_ConnectionString"].ConnectionString;

                // SQL query to calculate gender ratio
                string query = @"
            SELECT 
                Gender, 
                COUNT(*) AS Total 
            FROM Employee
            GROUP BY Gender";

                // Create a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Create the command and execute the query
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Display the gender ratio
                            StringBuilder genderReport = new StringBuilder();   
                            genderReport.AppendLine("Gender Ratio Report:");

                            while (reader.Read())
                            {
                                string gender = reader["Gender"].ToString();
                                int total = Convert.ToInt32(reader["Total"]);
                                genderReport.AppendLine($"{gender}: {total}");
                            }

                            // Show the result in a MessageBox
                            MessageBox.Show(genderReport.ToString(), "Gender Ratio Report");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
