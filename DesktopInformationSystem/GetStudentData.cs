using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    public partial class GetStudentData : Form
    {

        // Create a list to store data
        public static List<Student> students = new List<Student>();

        // Variavle for getting student to update and mode(between adding and updating)
        private Student currentStudent;
        private string mode;

        public GetStudentData(string mode, Student student = null)
        {
            InitializeComponent();
            this.mode = mode;
            this.currentStudent = student;

            if (mode == "Update" && student != null)
            {
                // Fill the form with the current student's data

                nameBox.Text = student.Name;
                teleBox.Text = student.Telephone;
                emailBox.Text = student.Email;
                comboBox1.Text = student.PreSubj1;
                comboBox2.Text = student.PreSubj2;
                comboBox3.Text = student.CurSubj1;
                comboBox4.Text = student.CurSubj2;

                
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = null;

            // Choosing mode for update or adding
            if (mode == "Update" && currentStudent != null)
            {
                // If we're updating, we want to modify the existing student
                student = currentStudent;
            }
            else
            {
                // Otherwise, we're adding a new student
                student = new Student();
                students.Add(student);
            }


            // check if namebox consists of letters only
            if (System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[a-zA-Z]+$"))
            {
                student.Name = nameBox.Text;
            }
            else
            {
                // Handle the case where the name contains non-letter characters
                MessageBox.Show("Name should consist of letters only.");

            }


            // Get the role student
            student.Role = Role.Student;

            // Get the phone
            student.Telephone = teleBox.Text;

            // Get the email
            student.Email = emailBox.Text;

            // Get the previous subject
            student.PreSubj1 = comboBox1.Text;
            student.PreSubj2 = comboBox2.Text;

            // Get the current subject
            student.CurSubj1 = comboBox3.Text;
            student.CurSubj2 = comboBox4.Text;

            // Show a message depending on the mode
            if (mode == "Update")
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Added");
            }


        }

        private void GetStudentData_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
