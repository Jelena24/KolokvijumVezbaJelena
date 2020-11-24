using BussinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentBussiness sb = new StudentBussiness();
            List<Student> studentList = sb.GetStudents();
            foreach (Student s in studentList)
                listBox1.Items.Add(s.ToString());
        }
    }
}
