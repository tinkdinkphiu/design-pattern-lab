using database_factory;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class StudentRepository
    {
        private IDatabaseFactory factory;

        public StudentRepository(IDatabaseFactory factory)
        {
            this.factory = factory;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (DbConnection connection = factory.CreateConnection())
            {
                connection.Open();

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT MSSV, FullName, BirthDate, StudentClass FROM Students";

                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                MSSV = reader["MSSV"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                BirthDate = DateTime.Parse(reader["BirthDate"].ToString()),
                                StudentClass = reader["StudentClass"].ToString()
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }

        public void AddStudent(Student student)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.Open();

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Students (MSSV, FullName, BirthDate, StudentClass) VALUES (@MSSV, @FullName, @BirthDate, @StudentClass)";

                    command.Parameters.Add(factory.CreateParameter("@MSSV", student.MSSV));
                    command.Parameters.Add(factory.CreateParameter("@FullName", student.FullName));
                    command.Parameters.Add(factory.CreateParameter("@BirthDate", student.BirthDate));
                    command.Parameters.Add(factory.CreateParameter("@StudentClass", student.StudentClass));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStudent(string mssv)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.Open();

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Students WHERE MSSV = @MSSV";

                    command.Parameters.Add(factory.CreateParameter("@MSSV", mssv));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStudent(Student student)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.Open();

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Students SET FullName = @FullName, BirthDate = @BirthDate, StudentClass = @StudentClass WHERE MSSV = @MSSV";

                    DbParameter paramMSSV = factory.CreateParameter("@MSSV", student.MSSV);
                    DbParameter paramFullName = factory.CreateParameter("@FullName", student.FullName);
                    DbParameter paramBirthDate = factory.CreateParameter("@BirthDate", student.BirthDate);
                    DbParameter paramStudentClass = factory.CreateParameter("@StudentClass", student.StudentClass);

                    command.Parameters.Add(paramMSSV);
                    command.Parameters.Add(paramFullName);
                    command.Parameters.Add(paramBirthDate);
                    command.Parameters.Add(paramStudentClass);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
