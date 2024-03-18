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
    public partial class MainWIndow : Form
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Admin> admins;

        public MainWIndow()
        {
            InitializeComponent();
            comboBox1.Text = "ALL";
            this.students = GetStudentData.students;
            this.teachers = GetTeacherData.teachers;
            this.admins = GetAdminData.admins;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            GetStudentData studentWin = new GetStudentData();
            studentWin.ShowDialog();
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            GetTeacherData teacherWin = new GetTeacherData();
            teacherWin.ShowDialog();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            GetAdminData adminWin = new GetAdminData();
            adminWin.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (var student in students)
            {
                var cellValues = student.GetDisplayText();
                dataGridView1.Rows.Add(cellValues);
            }

            foreach (var teacher in teachers)
            {
                var cellValues = teacher.GetDisplayText();
                dataGridView1.Rows.Add(cellValues);
            }

            foreach (var admin in admins)
            {
                var cellValues = admin.GetDisplayText();
                dataGridView1.Rows.Add(cellValues);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
