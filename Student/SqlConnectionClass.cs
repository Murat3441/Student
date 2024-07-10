using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class SqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-TV4EI8V\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Trust Server Certificate=True");

    }
}
