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
                comboBox4.Text = student.PreSubj1;
                comboBox3.Text = student.PreSubj2;
                comboBox1.Text = student.CurSubj1;
                comboBox2.Text = student.CurSubj2;
                this.Text = "Update Student data";

                
            }


            else if (mode == "More")
            {
                nameBox.Enabled = false;
                teleBox.Enabled = false;
                emailBox.Enabled = false;
                comboBox4.Enabled = false;
                comboBox3.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                confirmBtn.Visible= false;

                nameBox.Text = student.Name;
                teleBox.Text = student.Telephone;
                emailBox.Text = student.Email;
                comboBox4.Text = student.PreSubj1;
                comboBox3.Text = student.PreSubj2;
                comboBox1.Text = student.CurSubj1;
                comboBox2.Text = student.CurSubj2;
                this.Text = "Student More Information";

            }
            else
            {
                nameBox.Enabled = true;
                teleBox.Enabled = true;
                emailBox.Enabled = true;
                comboBox4.Enabled = true;
                comboBox3.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                confirmBtn.Visible = true;
                this.Text = "Adding Student Data";


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
                /*students.Add(student);*/
            }

            // check if namebox consists of letters only
            if (System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[a-zA-Z ]+$"))
            {
                student.Name = nameBox.Text;
            }
            else
            {
                // Handle the case where the name contains non-letter characters
                MessageBox.Show("Name should consist of letters only.");
                return;
            }

            // Get the role student
            student.Role = Role.Student;

            // Get the phone
            //if (!string.IsNullOrEmpty(teleBox.Text))
            //{
            //    student.Telephone = teleBox.Text;
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


            student.Telephone = teleBox.Text;

            // Get the email
            if (!string.IsNullOrEmpty(emailBox.Text))
            {
                student.Email = emailBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter an email.");
                return;
            }

            // Get the previous subject
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text))
            {
                student.PreSubj1 = comboBox1.Text;
                student.PreSubj2 = comboBox2.Text;
            }
            else
            {
                MessageBox.Show("Please select the previous subjects.");
                return;
            }

            // Get the current subject
            if (!string.IsNullOrEmpty(comboBox3.Text) && !string.IsNullOrEmpty(comboBox4.Text))
            {
                student.CurSubj1 = comboBox3.Text;
                student.CurSubj2 = comboBox4.Text;
            }
            else
            {
                MessageBox.Show("Please select the current subjects.");
                return;
            }

            // Show a message depending on the mode
            if (mode == "Update")
            {
                SqliteDataAccess.UpdateStudent(student);
                MessageBox.Show("Updated");
            }
            else
            {
                SqliteDataAccess.SaveStudent(student);
                MessageBox.Show("Added");
            }
        }


        private void GetStudentData_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
