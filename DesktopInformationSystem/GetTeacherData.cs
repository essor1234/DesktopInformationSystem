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
    public partial class GetTeacherData : Form
    {
        public static List<Teacher> teachers = new List<Teacher>();

        // Variavle for getting teacher to update and mode(between adding and updating)
        private Teacher currentTeacher;
        private string mode;

        public GetTeacherData(string mode, Teacher teacher = null)
        {
            InitializeComponent();

            this.mode = mode;
            this.currentTeacher = teacher;

            if (mode == "Update" && teacher != null)
            {
                // Fill the form with the current student's data

                nameBox.Text = teacher.Name;
                teleBox.Text = teacher.Telephone;
                emailBox.Text = teacher.Email;
                comboBox1.Text = teacher.Subject1;
                comboBox2.Text = teacher.Subject2;
                salaryNum.Text = teacher.Salary.ToString();




            }
        }

        private void GetTeacherData_Load(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Teacher teacher = null;
            // Choosing mode for update or adding
            if (mode == "Update" && currentTeacher != null)
            {
                // If we're updating, we want to modify the existing student
                teacher = currentTeacher;
            }
            else
            {
                // Otherwise, we're adding a new student
                teacher = new Teacher();
                /*teachers.Add(teacher);*/
            }


            // check if namebox consists of letters only
            if (System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[a-zA-Z]+$"))
            {
                teacher.Name = nameBox.Text;
            }
            else
            {
                // Handle the case where the name contains non-letter characters
                MessageBox.Show("Name should consist of letters only.");

            }

            // Get the role student
            teacher.Role = Role.Teacher;

            // Get the phone
            teacher.Telephone = teleBox.Text;

            // Get the email
            teacher.Email = emailBox.Text;

            // Get the salary
            teacher.Salary = (int)salaryNum.Value;

            // Get the previous subject
            teacher.Subject1 = comboBox1.Text;
            teacher.Subject2 = comboBox2.Text;

            // Show a message depending on the mode
            if (mode == "Update")
            {
                SqliteDataAccess.UpdateTeacher(teacher);
                MessageBox.Show("Updated");
            }
            else
            {
                SqliteDataAccess.SaveTeacher(teacher);
                MessageBox.Show("Added");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
