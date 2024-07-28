//
public class DataAccessLayer
{
    const string conString = "";
    SqlConnection conn = null;
    SqlCommand cmd = null'
    SqlDataReader reader = null;
    public DataAccessLayer()
    {
        conn = new SqlConnection(conString);
        cmd = new SqlCommand();
        cmd.Connection = conn;
    }
    public List<Student> GetAllStudents()
    {
        List<Student> list = new List<Student>();
        conn.Open();
        cmd.CommandText = "select * from Student";
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Student s = new Student();
            s.id = Convert.ToInt32(reader["id"]);
            s.name = Convert.ToString(reader["name"]);
            s.address = Convert.ToString(reader["address"]);
            s.phone = Convert.ToString(reader["phone"]);
        }
        return new List<Student>();
    }
    public bool Register(Student s)
    {
        return false;
    }
    public bool Edit(Student s, int oldId)
    {
        return false;
    }
    public bool (Student s, int oldId){
  return false;
}
}
