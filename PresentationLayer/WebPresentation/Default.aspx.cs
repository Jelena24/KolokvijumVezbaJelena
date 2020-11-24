using BussinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPresentation
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            StudentBussiness sb = new StudentBussiness();
            List<Student> studentList = sb.GetStudents();
            foreach (Student s in studentList)
                ListBox1.Items.Add(s.ToString());
        }
    }
}