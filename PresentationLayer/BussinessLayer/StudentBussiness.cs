using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class StudentBussiness
    {
       public StudentRepository sr;

        public StudentBussiness()
        {
            this.sr = new StudentRepository();
        }
        public List<Student> GetStudents()
        {
            return this.sr.GetStudents();
        }
        public List<Student> getPastAvg(int AvgPassed)
        {
            return this.sr.GetStudents().Where(x => x.AvgMark > AvgPassed).ToList();
        }
        public bool InsertStudent(Student s)
        {
            int result = this.sr.InsertStudent(s);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
