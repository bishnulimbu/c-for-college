using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWithDbCrud
{
    public class DataAccess
    {
        private string conString = "Server=localhost;Database=student;Trusted_Connection=True;";
        ////data scource,ra catalog needed.
        private SqlConnection con = new SqlConnection();
        public bool AddStudent(Student s)
        {
            //insert incoming object into the table and return operation status
            return true;

        }
        public List<Student> GetStudentList()
        {
            List<Student> list = new list<Student>();
            return list;
        }
        public bool AddStudent(Student s)
        {

        }


    }

}
