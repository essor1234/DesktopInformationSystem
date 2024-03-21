using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopInformationSystem
{
    public class SqliteDataAccess
    {
        // Loading Methods
        public static List<Student> LoadStudent()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Student>("SELECT User.Id, User.Name, User.Phone, User.Role, User.Email, Student.CurrentSubject1, Student.CurrentSubject2, Student.PreviousSubject1, Student.PreviousSubject2 FROM User " +
                                        "INNER JOIN Student " +
                                        "ON User.Id = Student.UserId;", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Teacher> LoadTeacher()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Teacher>("SELECT User.*, Teacher.* FROM User " +
                                                "INNER JOIN Teacher " +
                                                "ON User.Id = Teacher.Userid;", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Admin> LoadAdmin()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Admin>("SELECT User.*, Admin.* FROM User " +
                                                "INNER JOIN Admin " +
                                                "ON User.Id = Admin.Userid;", new DynamicParameters());
                return output.ToList();
            }
        }

        // Save methods
        public static void SaveStudent(Student student)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Name = student.Name,
                        Phone = student.Telephone,
                        Role = student.Role.ToString(),
                        Email = student.Email,
                        CurrentSubject1 = student.CurSubj1,
                        CurrentSubject2 = student.CurSubj2,
                        PreviousSubject1 = student.PreSubj1,
                        PreviousSubject2 = student.PreSubj2
                    };

                    cnn.Execute("INSERT INTO User (Name, Phone, Role, Email)" +
                                "VALUES (@Name, @Phone, @Role, @Email);", parameters);

                    cnn.Execute("INSERT INTO `Student` (UserId, CurrentSubject1, CurrentSubject2, PreviousSubject1, PreviousSubject2)" +
                        "VALUES (last_insert_rowid(), @CurrentSubject1, @CurrentSubject2, @PreviousSubject1, @PreviousSubject2);", parameters);

                    transaction.Commit();
                }
            }
        }

    

    public static void SaveTeacher(Teacher teacher)
        {

        }
        public static void SaveAdmin(Admin admin)
        {

        }

        // Delete methods
        public static void DeleteStudent(Student student)
        {

        }

        public static void DeleteTeacher(Student teacher)
        {

        }

        public static void DeleteAdmin(Admin admin)
        {

        }

        // Update methods
        public static void UpdateStudent(Student student)
        {

        }

        public static void UpdateTeacher(Teacher teacher)
        {

        }

        public static void UpdateAdmin( Admin admin) { 
        }


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
