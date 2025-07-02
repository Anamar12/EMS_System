using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EMS_System
{
    public partial class EMS_Form : Form
    {
        private List<fulltime_staff> fts_list = new List<fulltime_staff>();
        private List<parttime_staff> pts_list = new List<parttime_staff>();

        public EMS_Form()
        {
            InitializeComponent();
        }


        private void emp_button_Click(object sender, EventArgs e)
        {
            // Open Employee form
            Employee employeeForm = new Employee();
            employeeForm.Show();
        }

        private void dep_btn_Click(object sender, EventArgs e)
        {
            // Open Department form
            Department departmentForm = new Department();
            departmentForm.Show();

        }

        private void rep_btn_Click(object sender, EventArgs e)
        {
            // Open Reports form
            Reports reportsForm = new Reports();
            reportsForm.Show();
        }
    }
}
