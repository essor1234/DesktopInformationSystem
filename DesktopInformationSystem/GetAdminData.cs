using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopInformationSystem
{
    public partial class GetAdminData : Form
    {
        public static List<Admin> admins = new List<Admin>();

        public GetAdminData()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            // check if namebox consists of letters only
            if (System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[a-zA-Z]+$"))
            {
                admin.Name = nameBox.Text;
            }
            else
            {
                // Handle the case where the name contains non-letter characters
                MessageBox.Show("Name should consist of letters only.");

            }

            // Get the role student
            admin.Role = Role.Administration;

            // Get the phone
            admin.Telephone = teleBox.Text;

            // Get the email
            admin.Email = emailBox.Text;

            // Get the salary
            admin.Salary = (int)salaryNum.Value;

            // Get the position
            admin.Position = positionCombo.Text;

            // Get working hours
            int workHours;
            if (int.TryParse(workBox.Text, out workHours))
            {
                admin.WorkHours = workHours;
            }
            else
            {
                MessageBox.Show("Hours should contain natural number only");

            }

            // Add into the database
            admins.Add(admin);
            MessageBox.Show("Added");
        }
    }
}
