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
        public static List<Student> students = new List<Student>();
        public GetStudentData()
        {
            InitializeComponent();
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
            Student student = new Student();
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

            // Add into the database
            students.Add(student);
            MessageBox.Show("Added");


        }

        private void GetStudentData_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
