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
        public MainWIndow()
        {
            InitializeComponent();
            comboBox1.Text = "ALL";
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
    }
}
