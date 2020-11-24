using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentRepository
    {
        public List<Student> GetStudents()
        {
            List<Student> studentList = new List<Student>();
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string commandText = "Select * From Students";
                SqlCommand com = new SqlCommand(commandText, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    studentList.Add(new Student(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDecimal(3)));
                }
            }
            return studentList;
        }
        public int InsertStudent(Student s)
        {
            int result;
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string commandText = "Insert Into Students(Name, IndexNumber, AverageMark) VALUES(@Name, @IndexNumber, @AvgMark)";
                SqlCommand com = new SqlCommand(commandText, con);
                com.Parameters.AddWithValue("@Name", s.Name);
                com.Parameters.AddWithValue("@IndexNumber", s.IndexNumber);
                com.Parameters.AddWithValue("@AvgMark", s.AvgMark);
                result = com.ExecuteNonQuery();
            }
            return result;
        }
    }
}
