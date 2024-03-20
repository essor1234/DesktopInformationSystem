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
                var output = cnn.Query<Student>("SELECT User.*, Student.* FROM User " +
                                                "INNER JOIN Student " +
                                                "ON User.Id = Student.Userid;", new DynamicParameters());
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
