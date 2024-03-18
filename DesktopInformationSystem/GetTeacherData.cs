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

        public GetTeacherData()
        {
            InitializeComponent();
        }

        private void GetTeacherData_Load(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
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

            // Add into the database
            teachers.Add(teacher);
            MessageBox.Show("Added");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
