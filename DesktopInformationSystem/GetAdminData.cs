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
                this.Text = "Update Admin Data";


            }

            else if (mode == "More")
            {
                nameBox.Enabled = false;
                teleBox.Enabled = false;
                emailBox.Enabled = false;
                positionCombo.Enabled = false;
                salaryNum.Enabled = false;
                workBox.Enabled = false;
                confirmBtn.Visible = false;

                nameBox.Text = admin.Name;
                teleBox.Text = admin.Telephone;
                emailBox.Text = admin.Email;
                positionCombo.Text = admin.Position;
                salaryNum.Text = Convert.ToString(admin.Salary);
                workBox.Text = Convert.ToString(admin.WorkHours);
                this.Text = "More Admin Data";

            }
            else
            {
                nameBox.Enabled = true;
                teleBox.Enabled = true;
                emailBox.Enabled = true;
                positionCombo.Enabled = true;
                salaryNum.Enabled = true;
                workBox.Enabled = true;
                confirmBtn.Visible = true;
                this.Text = "Adding Admin Data";

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
            if (System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[a-zA-Z ]+$"))
            {
                admin.Name = nameBox.Text;
            }
            else
            {
                // Handle the case where the name contains non-letter characters
                MessageBox.Show("Name should consist of letters only.");
                return;
            }

            // Get the role student
            admin.Role = Role.Administration;

            // Get the phone
            /*use regex for phone number here*/
            //if (!string.IsNullOrEmpty(teleBox.Text))
            //{
            //    admin.Telephone = teleBox.Text;
            //}
            //else
            //{
            //    MessageBox.Show("Please enter a telephone number.");
            //    return;
            //}
            /*Check phone empty*/
            if (string.IsNullOrEmpty(teleBox.Text))
            {

                MessageBox.Show("Please enter a telephone number.");
                return;
            }

            /*Check phone is number*/
            if (!System.Text.RegularExpressions.Regex.IsMatch(teleBox.Text, @"^\d{9,11}$"))
            {
                MessageBox.Show("Please enter a valid phone number with 9 to 11 nummber digits.");
                return;
            }


            admin.Telephone = teleBox.Text;




            // Get the email
            if (!string.IsNullOrEmpty(emailBox.Text))
            {
                admin.Email = emailBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter an email.");
                return;
            }

            // Get the salary
            admin.Salary = (int)salaryNum.Value;

            // Get the position
            if (!string.IsNullOrEmpty(positionCombo.Text))
            {
                admin.Position = positionCombo.Text;
            }
            else
            {
                MessageBox.Show("Please select a position.");
                return;
            }

            // Get working hours
            int workHours;
            if (int.TryParse(workBox.Text, out workHours) && workHours >= 0)
            {
                admin.WorkHours = workHours;
            }
            else
            {
                MessageBox.Show("Hours should contain natural number only");
                return;
            }





            // Show a message depending on the mode
            //if (mode == "Update")
            //{
            //    SqliteDataAccess.UpdateAdmin(admin);
            //    MessageBox.Show("Updated");
            //}
            //else
            //{
            //    SqliteDataAccess.SaveAdmin(admin);
            //    MessageBox.Show("Added");
            //}

            // Show a message depending on the mode
            if (mode == "Update")
            {

                bool result = SqliteDataAccess.UpdateAdmin(admin);
                if (!result)
                {
                    MessageBox.Show("This phone number is already in use. Please enter a different phone number.");
                }
                else
                {
                    MessageBox.Show("Updated");
                }
            }
            else
            {
                bool result = SqliteDataAccess.SaveAdmin(admin);
                if (!result)
                {
                    MessageBox.Show("This phone number is already in use. Please enter a different phone number.");
                }
                else
                {
                    MessageBox.Show("Added");
                }
            }

        }

    }
}
