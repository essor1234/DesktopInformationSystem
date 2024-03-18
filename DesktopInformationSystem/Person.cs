using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    public enum Role
    {
        Teacher,
        Student,
        Administration
    }
    public class Person
    {
        // private datas
        private string name = string.Empty;
        private string telephone = string.Empty;
        private string email = string.Empty;
        private Role role;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

        // Polimorphism
        public virtual string[] GetDisplayText()
        {
            return new string[] { Name, Telephone, Email, Role.ToString() };
        }
    }

    public class Student : Person
    {
        private string curSubj1;
        private string curSubj2;
        private string preSubj1;
        private string preSubj2;

        public string CurSubj1
        {
            get { return curSubj1; }
            set { curSubj1 = value; }
        }

        public string CurSubj2
        {
            get { return curSubj2; }
            set { curSubj2 = value; }
        }

        public string PreSubj1
        {
            get { return preSubj1; }
            set { preSubj1 = value; }
        }

        public string PreSubj2
        {
            get { return preSubj2; }
            set { preSubj2 = value; }
        }

        // polymorphism
        public override string[] GetDisplayText()
        {
            return base.GetDisplayText();
        }

        
    }

    public class Admin : Person
    {
        private int salary;
        private string position;
        private int workHours;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int WorkHours
        {
            get { return workHours; }
            set { workHours = value; }
        }

        public override string[] GetDisplayText()
        {
            return base.GetDisplayText();
        }
    }

    public class Teacher : Person
    {
        private int salary;
        private string subject1;
        private string subject2;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Subject1
        {
            get { return subject1; }
            set { subject1 = value; }
        }

        public string Subject2
        {
            get { return subject2; }
            set { subject2 = value; }
        }

        public override string[] GetDisplayText()
        {
            return base.GetDisplayText();
        }
    }

}
