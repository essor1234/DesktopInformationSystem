﻿using System;
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

            if (mode == "More")
            {
                nameBox.Enabled = false;
                teleBox.Enabled = false;
                emailBox.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                salaryNum.Enabled = false;
                confirmBtn.Visible = false;


                nameBox.Text = teacher.Name;
                teleBox.Text = teacher.Telephone;
                emailBox.Text = teacher.Email;
                comboBox1.Text = teacher.Subject1;
                comboBox2.Text = teacher.Subject2;
                salaryNum.Text = teacher.Salary.ToString();
            }
            else
            {
                nameBox.Enabled = true;
                teleBox.Enabled = true;
                emailBox.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                salaryNum.Enabled = true;
                confirmBtn.Visible = true;
                confirmBtn.Visible = true;
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
                // If we're updating, we want to modify the existing teacher
                teacher = currentTeacher;
            }
            else
            {
                // Otherwise, we're adding a new teacher
                teacher = new Teacher();
            }

            // check if namebox consists of letters only
            if (System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[a-zA-Z ]+$"))
            {
                teacher.Name = nameBox.Text;
            }
            else
            {
                // Handle the case where the name contains non-letter characters
                MessageBox.Show("Name should consist of letters only.");
                return;
            }

            // Get the role teacher
            teacher.Role = Role.Teacher;

            // Get the phone
            if (!string.IsNullOrEmpty(teleBox.Text))
            {
                teacher.Telephone = teleBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter a telephone number.");
                return;
            }

            // Get the email
            if (!string.IsNullOrEmpty(emailBox.Text))
            {
                teacher.Email = emailBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter an email.");
                return;
            }

            // Get the salary
            teacher.Salary = (int)salaryNum.Value;

            // Get the subjects
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text))
            {
                teacher.Subject1 = comboBox1.Text;
                teacher.Subject2 = comboBox2.Text;
            }
            else
            {
                MessageBox.Show("Please select the subjects.");
                return;
            }

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
