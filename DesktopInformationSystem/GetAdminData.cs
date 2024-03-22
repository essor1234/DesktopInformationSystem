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

        // Variavle for getting student to update and mode(between adding and updating)
        private Admin currentAdmin;
        private string mode;

        public GetAdminData(string mode, Admin admin = null)
        {
            InitializeComponent();
            this.mode = mode;
            this.currentAdmin = admin;

            if (mode == "Update" && admin != null)
            {
                // Fill the form with the current student's data

                nameBox.Text = admin.Name;
                teleBox.Text = admin.Telephone;
                emailBox.Text = admin.Email;
                positionCombo.Text = admin.Position;
                salaryNum.Text = Convert.ToString(admin.Salary);
                workBox.Text = Convert.ToString(admin.WorkHours);


            }



        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Admin admin = null;

            // Choosing mode for update or adding
            if (mode == "Update" && currentAdmin != null)
            {
                // If we're updating, we want to modify the existing student
                admin = currentAdmin;
            }
            else
            {
                // Otherwise, we're adding a new student
                admin = new Admin();
                /*admins.Add(admin);*/
            }

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

            // Show a message depending on the mode
            if (mode == "Update")
            {
                SqliteDataAccess.UpdateAdmin(admin);
                MessageBox.Show("Updated");
            }
            else
            {
                SqliteDataAccess.SaveAdmin(admin);
                MessageBox.Show("Added");
            }
        }
    }
}
