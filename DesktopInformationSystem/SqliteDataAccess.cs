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
                var output = cnn.Query<Student>("SELECT Person.*, Student.* FROM Person " +
                                                "INNER JOIN Student " +
                                                "ON Person.Id = Student.Userid;", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Teacher> LoadTeacher()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Teacher>("SELECT Person.*, Teacher.* FROM Person " +
                                                "INNER JOIN Teacher " +
                                                "ON Person.Id = Teacher.Userid;", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Admin> LoadAdmin()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Admin>("SELECT Person.*, Admin.* FROM Person " +
                                                "INNER JOIN Admin " +
                                                "ON Person.Id = Admin.Userid;", new DynamicParameters());
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
                        Telephone = student.Telephone,
                        Role = student.Role.ToString(),
                        Email = student.Email,
                        CurrentSubject1 = student.CurSubj1,
                        CurrentSubject2 = student.CurSubj2,
                        PreviousSubject1 = student.PreSubj1,
                        PreviousSubject2 = student.PreSubj2
                    };

                    cnn.Execute("INSERT INTO Person (Name, Telephone, Role, Email)" +
                                "VALUES (@Name, @Telephone, @Role, @Email);", parameters);

                    cnn.Execute("INSERT INTO `Student` (UserId, CurrentSubject1, CurrentSubject2, PreviousSubject1, PreviousSubject2)" +
                        "VALUES (last_insert_rowid(), @CurrentSubject1, @CurrentSubject2, @PreviousSubject1, @PreviousSubject2);", parameters);

                    transaction.Commit();
                }
            }
        }

    

        public static void SaveTeacher(Teacher teacher)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Name = teacher.Name,
                        Telephone = teacher.Telephone,
                        Role = teacher.Role.ToString(),
                        Email = teacher.Email,
                        Salary = teacher.Salary,
                        Subject1 = teacher.Subject1,
                        Subject2 = teacher.Subject2
                    };

                    cnn.Execute("INSERT INTO Person (Name, Telephone, Role, Email)" +
                                "VALUES (@Name, @Telephone, @Role, @Email);", parameters);

                    cnn.Execute("INSERT INTO `Teacher` (UserId, Salary, Subject1, Subject2)" +
                        "VALUES (last_insert_rowid(), @Salary, @Subject1, @Subject2);", parameters);

                    transaction.Commit();
                }
            }
        }
        public static void SaveAdmin(Admin admin)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Name = admin.Name,
                        Telephone = admin.Telephone,
                        Role = admin.Role.ToString(),
                        Email = admin.Email,
                        Salary = admin.Salary,
                        Position = admin.Position,
                        WorkHour = admin.WorkHours
                    };

                    cnn.Execute("INSERT INTO Person (Name, Telephone, Role, Email)" +
                                "VALUES (@Name, @Telephone, @Role, @Email);", parameters);

                    cnn.Execute("INSERT INTO `Admin` (UserId, Salary, Position, WorkHour)" +
                        "VALUES (last_insert_rowid(), @Salary, @Position, @WorkHour);", parameters);

                    transaction.Commit();
                }
            }
        }

        // Delete methods
        public static void DeleteStudent(Student student)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Id = student.Id,
                        Name = student.Name,
                        Telephone = student.Telephone,
                        Role = student.Role.ToString(),
                        Email = student.Email,
                        CurrentSubject1 = student.CurSubj1,
                        CurrentSubject2 = student.CurSubj2,
                        PreviousSubject1 = student.PreSubj1,
                        PreviousSubject2 = student.PreSubj2
                    };

                    cnn.Execute("DELETE FROM `Student` WHERE UserId = @Id;", parameters);
                    cnn.Execute("DELETE FROM Person WHERE Id = @Id;", parameters);

                    transaction.Commit();
                }
            }
        }

        public static void DeleteTeacher(Teacher teacher)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Id = teacher.Id,
                        Name = teacher.Name,
                        Telephone = teacher.Telephone,
                        Role = teacher.Role.ToString(),
                        Email = teacher.Email,
                        Salary = teacher.Salary,
                        Subject1 = teacher.Subject1,
                        Subject2 = teacher.Subject2
                    };

                    cnn.Execute("DELETE FROM `Teacher` WHERE UserId = @Id;", parameters);
                    cnn.Execute("DELETE FROM `Person` WHERE Id = @Id;", parameters);

                    transaction.Commit();
                }
            }

        }

        public static void DeleteAdmin(Admin admin)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Id = admin.Id,
                        Name = admin.Name,
                        Telephone = admin.Telephone,
                        Role = admin.Role.ToString(),
                        Email = admin.Email,
                        Salary = admin.Salary,
                        Position = admin.Position,
                        WorkHour = admin.WorkHours
                    };

                    cnn.Execute("DELETE FROM `Admin` WHERE UserId = @Id;", parameters);
                    cnn.Execute("DELETE FROM `Person` WHERE Id = @Id;", parameters);

                    transaction.Commit();
                }
            }
        }

        // Update methods
        public static void UpdateStudent(Student student)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Id = student.Id, 
                        Name = student.Name,
                        Telephone = student.Telephone,
                        Role = student.Role.ToString(),
                        Email = student.Email,
                        CurrentSubject1 = student.CurSubj1,
                        CurrentSubject2 = student.CurSubj2,
                        PreviousSubject1 = student.PreSubj1,
                        PreviousSubject2 = student.PreSubj2
                    };

                    cnn.Execute("UPDATE Person SET Name = @Name, Telephone = @Telephone, Role = @Role, Email = @Email WHERE Id = @Id;", parameters);

                    cnn.Execute("UPDATE Student SET CurrentSubject1 = @CurrentSubject1, CurrentSubject2 = @CurrentSubject2, PreviousSubject1 = @PreviousSubject1, PreviousSubject2 = @PreviousSubject2 WHERE UserId = @Id;", parameters);

                    transaction.Commit();
                }
            }
        }
        public static void UpdateTeacher(Teacher teacher)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Id = teacher.Id,
                        Name = teacher.Name,
                        Telephone = teacher.Telephone,
                        Role = teacher.Role.ToString(),
                        Email = teacher.Email,
                        Salary = teacher.Salary,
                        Subject1 = teacher.Subject1,
                        Subject2 = teacher.Subject2
                    };

                    cnn.Execute("UPDATE Person SET Name = @Name, Telephone = @Telephone, Role = @Role, Email = @Email WHERE Id = @Id;", parameters);

                    cnn.Execute("UPDATE Teacher SET Salary = @Salary, Subject1 = @Subject1, Subject2 = @Subject2 WHERE Userid = @Id;", parameters);

                    transaction.Commit();
                }
            }
        }

        public static void UpdateAdmin( Admin admin) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    var parameters = new
                    {
                        Id = admin.Id,
                        Name = admin.Name,
                        Telephone = admin.Telephone,
                        Role = admin.Role.ToString(),
                        Email = admin.Email,
                        Salary = admin.Salary,
                        Position = admin.Position,
                        WorkHour = admin.WorkHours
                    };

                    cnn.Execute("UPDATE Person SET Name = @Name, Telephone = @Telephone, Role = @Role, Email = @Email WHERE Id = @Id;", parameters);

                    cnn.Execute("UPDATE Admin SET Salary = @Salary, Position = @Position, WorkHour = @WorkHour WHERE Userid = @Id;", parameters);

                    transaction.Commit();
                }
            }
        }


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
