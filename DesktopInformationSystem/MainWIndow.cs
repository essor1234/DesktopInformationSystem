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
            displayBox.Text = "ALL";
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
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                // Get the Id of the selected item
                string id = item.Cells["Id"].Value.ToString();

                // Remove from the corresponding list
                if (students.RemoveAll(s => s.Id == id) == 0)
                {
                    if (teachers.RemoveAll(t => t.Id == id) == 0)
                    {
                        admins.RemoveAll(a => a.Id == id);
                    }
                }

                // Remove from the grid view
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            GetStudentData studentWin = new GetStudentData("Add");
            studentWin.ShowDialog();
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            GetTeacherData teacherWin = new GetTeacherData("Add");
            teacherWin.ShowDialog();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            GetAdminData adminWin = new GetAdminData("Add");
            adminWin.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string displayOption = displayBox.Text;

            if (displayOption.Equals("ALL"))
            {
                displayAll();
            }else if (displayOption.Equals("TEACHER"))
            {
                displayRole("Teacher");
            }
            else if (displayOption.Equals("STUDENT"))
            {
                displayRole("Student");
            }
            else if (displayOption.Equals("ADMIN"))
            {
                displayRole("Admin");
            }

            /*foreach (var student in students)
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
            }*/

        }

        private void displayAll()
        {
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

        private void displayRole(String role)
        {
            if (role.Equals("Teacher"))
            {
                foreach (var teacher in teachers)
                {
                    var cellValues = teacher.GetDisplayText();
                    dataGridView1.Rows.Add(cellValues);
                }


            }
            else if (role.Equals("Student"))
            {
                foreach (var student in students)
                {
                    var cellValues = student.GetDisplayText();
                    dataGridView1.Rows.Add(cellValues);
                }

            } else if (role.Equals("Admin"))
            {
                foreach (var admin in admins)
                {
                    var cellValues = admin.GetDisplayText();
                    dataGridView1.Rows.Add(cellValues);
                }
            }else
            {
                MessageBox.Show("Please choose a appropriate Role");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                // Get the Id and Role of the selected item
                string role = item.Cells["Role"].Value.ToString();
                string id = item.Cells["Id"].Value.ToString();

                // Find the item to update
                Person personToUpdate = null;
                switch (role)
                {
                    case "Student":
                        personToUpdate = students.FirstOrDefault(s => s.Id == id);
                        if (personToUpdate != null)
                        {
                            GetStudentData form = new GetStudentData("Update", (Student)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
                    case "Teacher":
                        personToUpdate = teachers.FirstOrDefault(t => t.Id == id);
                        if (personToUpdate != null)
                        {
                            GetTeacherData form = new GetTeacherData("Update", (Teacher)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
                    case "Administration":
                        personToUpdate = admins.FirstOrDefault(a => a.Id == id);
                        if (personToUpdate != null)
                        {
                            GetAdminData form = new GetAdminData("Update", (Admin)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
                }   }   }
    }
}
