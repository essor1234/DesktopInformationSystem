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
        private string id = string.Empty;
        private string name = string.Empty;
        private string telephone = string.Empty;
        private string email = string.Empty;
        private Role role;
        // for auto increase Id
        private static int nextId = 1;

        public string Id 
        {
            get { return id; }
            private set { id = value; } 
        }

        // method to increase id

        public Person() 
        {
            Id = nextId.ToString();
            nextId++;
        }

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
            return new string[] { Id, Name, Telephone.ToString(), Email, Role.ToString() };
        }


    }

    public class Student : Person
    {
        private string CurrentSubject1;
        private string CurrentSubject2;
        private string PreviousSubject1;
        private string PreviousSubject2;

        public string CurSubj1
        {
            get { return CurrentSubject1; }
            set { CurrentSubject1 = value; }
        }

        public string CurSubj2
        {
            get { return CurrentSubject2; }
            set { CurrentSubject2 = value; }
        }

        public string PreSubj1
        {
            get { return PreviousSubject1; }
            set { PreviousSubject1 = value; }
        }

        public string PreSubj2
        {
            get { return PreviousSubject2; }
            set { PreviousSubject2 = value; }
        }

        // polymorphism
        
        public override string[] GetDisplayText()
        {
            // getting based data from the parent class

            string[] baseDisplayText = base.GetDisplayText();
            // Return with more data for each specific child class
            return baseDisplayText.Concat(new string[] { CurSubj1, CurSubj2, PreSubj1, PreSubj2 }).ToArray();
        }



    }

    public class Admin : Person
    {
        private int salary;
        private string position;
        private int workHour;

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
            get { return workHour; }
            set { workHour = value; }
        }

        

        public override string[] GetDisplayText()
        {
            // getting based data from the parent class

            string[] baseDisplayText = base.GetDisplayText();
            // Return with more data for each specific child class

            return baseDisplayText.Concat(new string[] { Salary.ToString(), Position, WorkHours.ToString() }).ToArray();
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
            // getting based data from the parent class
            string[] baseDisplayText = base.GetDisplayText();
            // Return with more data for each specific child class

            return baseDisplayText.Concat(new string[] { Salary.ToString(), Subject1, Subject2 }).ToArray();
        }
    }

}
