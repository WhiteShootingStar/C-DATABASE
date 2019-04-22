namespace wind1.Connect
{
    //public class Connector
    //{
    //    static string connectionString = "Data Source=db-mssql;Initial Catalog = s16550; Integrated Security = True";

    //    public ObservableCollection<Student> GetStud()
    //    {
    //        ObservableCollection<Student> stList = new ObservableCollection<Student>();
    //        using (SqlConnection con = new SqlConnection(connectionString))
    //        {

    //            con.Open();

    //            using (SqlCommand command = new SqlCommand("SELECT idStudent,FirstName,LastName,Address,IndexNumber,Name FROM apbd.Student ,apbd.Studies where apbd.Student.IdStudies=apbd.Studies.IdStudies;", con))
    //            using (SqlDataReader reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    int id = int.Parse(reader["idStudent"].ToString());
    //                    string First = reader["FirstName"].ToString();

    //                    string Last = reader["LastName"].ToString();
    //                    string Addr = reader["Address"].ToString();
    //                    string Ind = reader["IndexNumber"].ToString();
    //                    string IdStudies = reader["Name"].ToString();
    //                    Student std = new Student { ID = id, FirstName = First, LastName = Last, Address = Addr, Index = Ind, Studies = IdStudies };
    //                    stList.Add(std);
    //                }
    //            }
    //            con.Close();
    //        }

    //        return stList;

    //    }

    //    public void delStudent(IEnumerable<Student> list)
    //    {
    //        using (SqlConnection con = new SqlConnection(connectionString))
    //        {
    //            con.Open();
    //            SqlTransaction tran = con.BeginTransaction();
    //            foreach (Student st in list)
    //            {
    //                Console.Write(st.ID);
    //                using (SqlCommand command = new SqlCommand("DELETE FROM apbd.Student_Subject  where apbd.Student_Subject.idStudent = @ID", con, tran))
    //                {
    //                    command.Parameters.AddWithValue("@ID", st.ID);
    //                    command.ExecuteNonQuery();
    //                }
    //                using (SqlCommand command = new SqlCommand("DELETE FROM apbd.Student  where IdStudent =@ID", con, tran))
    //                {

    //                    command.Parameters.AddWithValue("@ID", st.ID);
    //                    command.ExecuteNonQuery();
    //                }


    //            }


    //            tran.Commit();
    //            con.Close();
    //        }
    //    }



    //    public IEnumerable<string> getStudies()
    //    {
    //        IList<string> list = new List<string>();
    //        using (SqlConnection con = new SqlConnection(connectionString))
    //        {
    //            con.Open();
    //            using (SqlCommand command = new SqlCommand("Select Name from apbd.Studies", con))
    //            using (var reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    list.Add(reader["Name"].ToString());
    //                }
    //            }

    //            con.Close();
    //        }
    //        return list;
    //    }

    //    public IEnumerable<string> getSubjects()
    //    {
    //        IList<string> list = new List<string>();
    //        using (SqlConnection con = new SqlConnection(connectionString))
    //        {
    //            con.Open();
    //            using (SqlCommand command = new SqlCommand("Select Name from apbd.Subject", con))
    //            using (var reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    list.Add(reader["Name"].ToString());
    //                }
    //            }

    //            con.Close();
    //        }
    //        return list;
    //    }

    //    public void AddStudent(Student student)
    //    {
    //        using (SqlConnection con = new SqlConnection(connectionString))
    //        {
    //            con.Open();
    //            SqlTransaction tran = con.BeginTransaction();


    //            using (SqlCommand command = new SqlCommand("Insert into apbd.Student values (@LASTNAME,@FIRSTNAME,@ADDRESS,@INDEX,@STUDIES)", con, tran))
    //            {
    //                command.Parameters.AddWithValue("@LASTNAME", student.LastName);
    //                command.Parameters.AddWithValue("@FIRSTNAME", student.FirstName);
    //                command.Parameters.AddWithValue("@ADDRESS", "ul.dOMBROWSKA");
    //                command.Parameters.AddWithValue("@INDEX", student.Index);
    //                command.Parameters.AddWithValue("@STUDIES", getStudId(student.Studies, con, tran));
    //                Console.WriteLine(command.ExecuteNonQuery().ToString() + " added student ");

    //            }

    //            Thread.Sleep(2000);

    //            foreach (var subj in student.Subjects)
    //            {

    //                using (SqlCommand command = new SqlCommand("Insert into apbd.Student_Subject values (@STUD,@SUBJ,SYSDATETIME())", con, tran))
    //                {
    //                    command.Parameters.AddWithValue("@STUD", getStudentId(student.LastName, con, tran));
    //                    Console.WriteLine(getStudentId(student.LastName, con, tran));
    //                    command.Parameters.AddWithValue("@SUBJ", getSubjId(subj, con, tran));
    //                    Console.WriteLine(command.ExecuteNonQuery().ToString());
    //                    Thread.Sleep(1000);
    //                }

    //            }

    //            tran.Commit();

    //            con.Close();
    //        }
    //    }


    //    public int getStudId(string name, SqlConnection con, SqlTransaction tran)
    //    {

    //        using (SqlCommand command = new SqlCommand("Select distinct IdStudies from apbd.Studies where Name like @N", con, tran))
    //        {
    //            command.Parameters.AddWithValue("@N", name);
    //            using (var reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {

    //                    return int.Parse(reader["IdStudies"].ToString());

    //                }
    //            }


    //        }
    //        return 1;



    //    }
    //    public int getStudentId(string name, SqlConnection con, SqlTransaction tran)
    //    {

    //        using (SqlCommand command = new SqlCommand("Select  IdStudent from apbd.Student where LastName = @N", con, tran))
    //        {
    //            command.Parameters.AddWithValue("@N", name);
    //            using (var reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    return int.Parse(reader["IdStudent"].ToString());
    //                }

    //            }


    //        }
    //        return 1;



    //    }

    //    public int getSubjId(string name, SqlConnection con, SqlTransaction tran)
    //    {

    //        using (SqlCommand command = new SqlCommand("Select distinct IdSubject from apbd.Subject where Name like @N", con, tran))
    //        {
    //            command.Parameters.AddWithValue("@N", name);
    //            using (var reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {

    //                    return int.Parse(reader["IdSubject"].ToString());
    //                }

    //            }



    //        }

    //        return 1;
    //    }

    //    public void updateStud(Student student)
    //    {
    //        using (SqlConnection con = new SqlConnection(connectionString))
    //        {
    //            con.Open();
    //            SqlTransaction tran = con.BeginTransaction();


    //            using (SqlCommand command = new SqlCommand("UPDATE apbd.Student  set FirstName = @FIRSTNAME, LastName=@LASTNAME, Address = @ADDRESS , IndexNumber =@INDEX ,IdStudies = @Studies where IdStudent = @ID", con, tran))
    //            {
    //                command.Parameters.AddWithValue("@LASTNAME", student.LastName);
    //                command.Parameters.AddWithValue("@FIRSTNAME", student.FirstName);
    //                command.Parameters.AddWithValue("@ADDRESS", "ul.dOMBROWSKA");
    //                command.Parameters.AddWithValue("@INDEX", student.Index);
    //                command.Parameters.AddWithValue("@STUDIES", getStudId(student.Studies, con, tran));
    //                Console.WriteLine(student.ID.ToString());
    //                command.Parameters.AddWithValue("@ID", getStudentId(student.LastName,con,tran));
    //                Console.WriteLine(command.ExecuteNonQuery().ToString() + " updated");

    //            }

    //            Thread.Sleep(2000);

    //            //foreach (var subj in student.Subjects)
    //            //{

    //            //    using (SqlCommand command = new SqlCommand("Insert into apbd.Student_Subject values (@STUD,@SUBJ,SYSDATETIME())", con, tran))
    //            //    {
    //            //        command.Parameters.AddWithValue("@STUD", getStudentId(student.LastName, con, tran));
    //            //        Console.WriteLine(getStudentId(student.LastName, con, tran));
    //            //        command.Parameters.AddWithValue("@SUBJ", getSubjId(subj, con, tran));
    //            //        Console.WriteLine(command.ExecuteNonQuery().ToString());
    //            //        Thread.Sleep(1000);
    //            //    }

    //            //}

    //            tran.Commit();

    //            con.Close();
    //        }




    //    }
    //}
}
