using Ado;
using Microsoft.Data.SqlClient;
using System.Data;


namespace ado2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var con = DbConnectionSingleton.Instance.GetConnection();

            int x;
            do
            {
                Console.WriteLine("Please choose the operation that you want to do :\n" +
                                  "                                                    1. Show Students\n" +
                                  "                                                    2. Manage Students\n" +
                                  "                                                    3. Insert Student\n" +
                                  "                                                    4. Exit\n");
                x = int.Parse(Console.ReadLine()!);
                Console.WriteLine();
                switch (x)
                {
                    case 1:
                        {
                            string query = @"Select name,age ,address,deptId from students";
                            SqlCommand command = new(query, con);
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                Students student = new Students();

                                student.Name = reader.GetString(0);
                                student.Age = reader.GetInt32(1);
                                student.Address = reader.GetString(2);
                                student.DeptId = reader.GetInt32(3);
                                Console.WriteLine(student);
                            }
                            Console.WriteLine("\n");
                            reader.Close();
                            break;
                        }
                    case 2:
                        {
                            string query = @"Select id,name,age,address,deptId from students";
                            using (SqlCommand command = new(query, con))
                            {
                                SqlDataReader reader = command.ExecuteReader();
                                List<Students> students = new List<Students>();
                                while (reader.Read())
                                {
                                    Students student = new Students();
                                    student.Id = reader.GetInt32(0);
                                    student.Name = reader.GetString(1);
                                    student.Age = reader.GetInt32(2);
                                    student.Address = reader.GetString(3);
                                    student.DeptId = reader.GetInt32(4);
                                    students.Add(student);
                                    Console.WriteLine($"student_Id:{student.Id} \t,Student Name: {student.Name} \t,Student Age: {student.Age} \t,Address:{student.Address} \t  ,Department_Id: {student.DeptId}");
                                }
                                Console.WriteLine("\n");
                                reader.Close();

                                Console.WriteLine("chooce the opration that you want to do:\n" +
                                                  "                                         1.Update Student\n" +
                                                  "                                         2.Delete Student");
                                int.TryParse(Console.ReadLine(), out int y);
                                switch (y)
                                {
                                    case 1:
                                        {

                                            // safer, readable multiline query using a verbatim string
                                            string query1 = @"
                                                                UPDATE Students
                                                                SET Name = @name,
                                                                Age = @age,
                                                                Address = @address,                                                    
                                                                deptId = @deptId
                                                                WHERE id = @id";
                                            if (con.State == ConnectionState.Open) con.Close();
                                            using (SqlCommand command1 = new(query1, con))
                                            {
                                                Console.WriteLine("Please enter id for student that you want to update ");
                                                int.TryParse(Console.ReadLine(), out int z);
                                                foreach (var item in students)
                                                {
                                                    if (z == item.Id)
                                                    {
                                                        Students s = item;
                                                        Console.WriteLine("You will edit:\n" +
                                                                          "               1.Name\n" +
                                                                          "               2.Age\n" +
                                                                          "               3.Address\n" +
                                                                          "               4.departement_Id\n");
                                                        int.TryParse(Console.ReadLine(), out int d);
                                                        switch (d)
                                                        {
                                                            case 1:
                                                                {
                                                                    Console.WriteLine("Enter the new Name");
                                                                    s.Name = Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    Console.WriteLine("Enter the new Age");
                                                                    s.Age = int.Parse(Console.ReadLine()!);
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    Console.WriteLine("Enter the new Address ");
                                                                    s.Address = Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 4:
                                                                {
                                                                    Console.WriteLine("Enter the new Department_ID");
                                                                    s.DeptId = int.Parse(Console.ReadLine()!);
                                                                    break;
                                                                }
                                                            default: { break; }
                                                        }

                                                        command1.Parameters.AddWithValue("@id", s.Id);
                                                        command1.Parameters.AddWithValue("@name", s.Name);
                                                        command1.Parameters.AddWithValue("@age", s.Age);
                                                        command1.Parameters.AddWithValue("@address", s.Address);
                                                        command1.Parameters.AddWithValue("@deptId", s.DeptId);

                                                        if (con.State == ConnectionState.Closed) con.Open();
                                                        var resualt = command1.ExecuteNonQuery();
                                                        Console.WriteLine($"{resualt} Rows affected\n");
                                                        break;
                                                    }
                                                }
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            using (SqlCommand command2 = new(@"Delete from students where id=@id", con))
                                            {
                                                Console.WriteLine("Please enter id for student that you want to Delete it. ");
                                                int.TryParse(Console.ReadLine(), out int w);
                                                foreach (var item in students)
                                                {
                                                    if (w == item.Id)
                                                    {
                                                        command2.Parameters.AddWithValue("@id", w);
                                                        var resualt = command2.ExecuteNonQuery();
                                                        Console.WriteLine($"{resualt} Rows affected\n");
                                                        break;
                                                    }
                                                }

                                            }
                                            break;
                                        }
                                    default: { break; }
                                }


                                break;
                            }
                        }
                    case 3:
                        {
                            string query3 = @"insert into students(name,age,address,deptId)
                                              values(@name,@age,@address,@deptId)";
                            if (con.State == ConnectionState.Open) con.Close();
                            using (SqlCommand command3 = new(query3, con))
                            {
                                Console.WriteLine("enter student name");
                                command3.Parameters.AddWithValue("@name", Console.ReadLine());
                                Console.WriteLine("enter student age");
                                command3.Parameters.AddWithValue("@age", int.Parse(Console.ReadLine()!));
                                Console.WriteLine("enter student address");
                                command3.Parameters.AddWithValue("@address", Console.ReadLine());
                                Console.WriteLine("enter department_id");
                                command3.Parameters.AddWithValue("@deptId", int.Parse(Console.ReadLine()!));
                                if (con.State == ConnectionState.Closed) con.Open();
                                var resualt = command3.ExecuteNonQuery();
                                Console.WriteLine($"{resualt} Rows Affected\n");
                                break;
                            }
                        }
                    default: { break; }
                }



            } while (x == 1 || x == 2 || x == 3);
            con.Close();
        }
    }
}
