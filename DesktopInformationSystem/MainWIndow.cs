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

        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Admin> admins = new List<Admin>();




        public MainWIndow()
        {
            InitializeComponent();
            displayBox.Text = "ALL";
/*            this.students = GetStudentData.students;
 *            
*/            this.teachers = GetTeacherData.teachers;
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

                string id = "null";

                // Check if the cells are not null before trying to access their values
                if (item.Cells["Role"].Value != null && item.Cells["Id"].Value != null)
                {
                    id = item.Cells["Id"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please choose a person to delete");
                }


                // Find the student with this Id
                Student student = students.Find(s => s.Id == id);
                if (student != null)
                {
                    // Call the DeleteStudent function
                    SqliteDataAccess.DeleteStudent(student);

                    // Remove from the corresponding list
                    students.Remove(student);
                }
                else
                {
                    // If not found in students, check in teachers
                    Teacher teacher = teachers.Find(t => t.Id == id);
                    if (teacher != null)
                    {
                        // Call the DeleteTeacher function (you need to implement this)
                        SqliteDataAccess.DeleteTeacher(teacher);

                        // Remove from the corresponding list
                        teachers.Remove(teacher);
                    }
                    else
                    {
                        // If not found in teachers, check in admins
                        Admin admin = admins.Find(a => a.Id == id);
                        if (admin != null)
                        {
                            // Call the DeleteAdmin function (you need to implement this)
                            SqliteDataAccess.DeleteAdmin(admin);

                            // Remove from the corresponding list
                            admins.Remove(admin);
                        }
                    }
                }
                if (item.Cells["Role"].Value != null && item.Cells["Id"].Value != null)
                {
                    // Remove from the grid view
                    dataGridView1.Rows.RemoveAt(item.Index);
                }

                    
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
            // Check mode to access
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

            // Get data from database
            students = SqliteDataAccess.LoadStudent();
            teachers = SqliteDataAccess.LoadTeacher();
            admins = SqliteDataAccess.LoadAdmin();

            

            RemoveAdditionalColumns();


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

        /*private void displayRole(String role)
        {
            // Get data from database
            students = SqliteDataAccess.LoadStudent();
            teachers = SqliteDataAccess.LoadTeacher();
            admins = SqliteDataAccess.LoadAdmin();



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
        }*/

        private void displayRole(String role)
        {
            // Get data from database
            students = SqliteDataAccess.LoadStudent();
            teachers = SqliteDataAccess.LoadTeacher();
            admins = SqliteDataAccess.LoadAdmin();

            dataGridView1.Rows.Clear(); // Clear existing rows
            dataGridView1.Columns.Clear(); // Clear existing columns

            // Add columns for the base properties
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Telephone", "Telephone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Role", "Role");

            if (role.Equals("Teacher"))
            {
                // Remove any existing additional columns
                RemoveAdditionalColumns();

                // Add additional columns for Teacher properties
                dataGridView1.Columns.Add("Salary", "Salary");
                dataGridView1.Columns.Add("Subject1", "Subject1");
                dataGridView1.Columns.Add("Subject2", "Subject2");

                foreach (var teacher in teachers)
                {
                    // Add data into grid veiw columns
                    dataGridView1.Rows.Add(teacher.GetDisplayText().Concat(new string[] { teacher.Salary.ToString(), teacher.Subject1, teacher.Subject2 }).ToArray());
                }
            }
            else if (role.Equals("Student"))
            {
                // Remove any existing additional columns
                RemoveAdditionalColumns();

                // Add additional columns for Student properties
                dataGridView1.Columns.Add("CurSubj1", "CurSubj1");
                dataGridView1.Columns.Add("CurSubj2", "CurSubj2");
                dataGridView1.Columns.Add("PreSubj1", "PreSubj1");
                dataGridView1.Columns.Add("PreSubj2", "PreSubj2");

                foreach (var student in students)
                {
                    // Add data into grid veiw columns
                    dataGridView1.Rows.Add(student.GetDisplayText().Concat(new string[] { student.CurSubj1, student.CurSubj2, student.PreSubj1, student.PreSubj2 }).ToArray());
                }
            }
            else if (role.Equals("Admin"))
            {
                // Remove any existing additional columns
                RemoveAdditionalColumns();

                // Add additional columns for Admin properties
                dataGridView1.Columns.Add("Salary", "Salary");
                dataGridView1.Columns.Add("Position", "Position");
                dataGridView1.Columns.Add("WorkHours", "WorkHours");

                foreach (var admin in admins)
                {
                    // Add data into grid veiw columns
                    dataGridView1.Rows.Add(admin.GetDisplayText().Concat(new string[] { admin.Salary.ToString(), admin.Position, admin.WorkHours.ToString() }).ToArray());
                }
            
            
            }
            else
            {
                MessageBox.Show("Please choose an appropriate Role");
            }
        }

        private void RemoveAdditionalColumns()
        {
            // Remove any existing additional columns
            while (dataGridView1.Columns.Count > 5)
            {
                dataGridView1.Columns.RemoveAt(5);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string role = "null";
                string id = "null";

                // Check if the cells are not null before trying to access their values
                if (item.Cells["Role"].Value != null && item.Cells["Id"].Value != null)
                {
                    role = item.Cells["Role"].Value.ToString();
                    id = item.Cells["Id"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please choose a person to edit");
                }




                // Find the item to update
                Person personToUpdate = null;
                switch (role)
                {
                    case "Student":
                        personToUpdate = students.FirstOrDefault(s => s.Id == id);
                        if (personToUpdate != null)
                        {
                            // Call update method
                            GetStudentData form = new GetStudentData("Update", (Student)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
                    case "Teacher":
                        personToUpdate = teachers.FirstOrDefault(t => t.Id == id);
                        if (personToUpdate != null)
                        {
                            // Call update method

                            GetTeacherData form = new GetTeacherData("Update", (Teacher)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
                    case "Administration":
                        personToUpdate = admins.FirstOrDefault(a => a.Id == id);
                        if (personToUpdate != null)
                        {
                            // Call update method
                            GetAdminData form = new GetAdminData("Update", (Admin)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
        }   }  }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string role = "null";
                string id = "null";

                // Check if the cells are not null before trying to access their values
                if (item.Cells["Role"].Value != null && item.Cells["Id"].Value != null)
                {
                    role = item.Cells["Role"].Value.ToString();
                    id = item.Cells["Id"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please choose a person to show");
                }





                // Find the item to update
                Person personToUpdate = null;
                switch (role)
                {
                    case "Student":
                        personToUpdate = students.FirstOrDefault(s => s.Id == id);
                        if (personToUpdate != null)
                        {
                            GetStudentData form = new GetStudentData("More", (Student)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
                    case "Teacher":
                        personToUpdate = teachers.FirstOrDefault(t => t.Id == id);
                        if (personToUpdate != null)
                        {
                            GetTeacherData form = new GetTeacherData("More", (Teacher)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
                    case "Administration":
                        personToUpdate = admins.FirstOrDefault(a => a.Id == id);
                        if (personToUpdate != null)
                        {
                            GetAdminData form = new GetAdminData("More", (Admin)personToUpdate);
                            form.ShowDialog();
                        }
                        break;
                }
            }
        
    }
    }
}
