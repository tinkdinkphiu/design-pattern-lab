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
        private IDatabaseFactory _dbFactory;

        public StudentRepository(IDatabaseFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (DbConnection connection = _dbFactory.CreateConnection())
            {
                connection.Open();

                using (DbCommand command = _dbFactory.CreateCommand())
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
            using (DbConnection connection = _dbFactory.CreateConnection())
            {
                connection.Open();

                using (DbCommand command = _dbFactory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Students (MSSV, FullName, BirthDate, StudentClass) VALUES (@MSSV, @FullName, @BirthDate, @StudentClass)";

                    command.Parameters.Add(_dbFactory.CreateParameter("@MSSV", student.MSSV));
                    command.Parameters.Add(_dbFactory.CreateParameter("@FullName", student.FullName));
                    command.Parameters.Add(_dbFactory.CreateParameter("@BirthDate", student.BirthDate));
                    command.Parameters.Add(_dbFactory.CreateParameter("@StudentClass", student.StudentClass));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStudent(string mssv)
        {
            using (DbConnection connection = _dbFactory.CreateConnection())
            {
                connection.Open();

                using (DbCommand command = _dbFactory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Students WHERE MSSV = @MSSV";

                    command.Parameters.Add(_dbFactory.CreateParameter("@MSSV", mssv));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStudent(Student student)
        {
            using (DbConnection connection = _dbFactory.CreateConnection())
            {
                connection.Open();

                using (DbCommand command = _dbFactory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Students SET FullName = @FullName, BirthDate = @BirthDate, StudentClass = @StudentClass WHERE MSSV = @MSSV";

                    DbParameter paramMSSV = _dbFactory.CreateParameter("@MSSV", student.MSSV);
                    DbParameter paramFullName = _dbFactory.CreateParameter("@FullName", student.FullName);
                    DbParameter paramBirthDate = _dbFactory.CreateParameter("@BirthDate", student.BirthDate);
                    DbParameter paramStudentClass = _dbFactory.CreateParameter("@StudentClass", student.StudentClass);

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
