using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Student
    {
        public Student(int id, string name, string indexNumber, decimal avgMark)
        {
            Id = id;
            Name = name;
            IndexNumber = indexNumber;
            AvgMark = avgMark;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexNumber { get; set; }
        public decimal AvgMark { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {IndexNumber} - {AvgMark}";
        }
    }
}
