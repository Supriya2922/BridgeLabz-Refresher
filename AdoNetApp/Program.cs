using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace AdoNetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {for (; ; )
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Display");
                Console.WriteLine("5.Exit");
                int ch=Convert.ToInt32(Console.ReadLine());

                //Connection
                String connString;
                connString = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connString);
                //Command object
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = sqlConnection;

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Employee first name:");
                        String fname=Console.ReadLine();
                        Console.WriteLine("Enter Employee last name:");
                        String lname = Console.ReadLine();
                        Console.WriteLine("Enter Gender:");
                        String gender=Console.ReadLine();
                        Console.WriteLine("Enter Age:");
                        int age=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter email");
                        String mail=Console.ReadLine();
                        sqlConnection.Open();
                        cmd.CommandText = "insert into EmployeeTable(fName,lName,Gender,Age,Email) values(@fname,@lname,@gender,@age,@email)";
                        cmd.Parameters.AddWithValue("@fname", fname);
                        cmd.Parameters.AddWithValue("@lname", lname);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@email", mail);
                        int rows = cmd.ExecuteNonQuery();
                        sqlConnection.Close();

                        Console.WriteLine("{0} row inserted", rows);
                        break;
                    case 2:
                        Console.WriteLine("Enter the id of the Employee:");
                        int id=Convert.ToInt32(Console.ReadLine()); 
                        Console.WriteLine("Enter new first name:");
                        String newfname = Console.ReadLine();
                        Console.WriteLine("Enter new last name:");
                        String newlname = Console.ReadLine();
                        Console.WriteLine("Enter new Gender:");
                        String newgender = Console.ReadLine();
                        Console.WriteLine("Enter new Age:");
                        int newage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new email");
                        String newmail = Console.ReadLine();

                        sqlConnection.Open();
                        cmd.CommandText = "update EmployeeTable set fName=@fname,lName=@lname,Gender=@gender,Age=@age,Email=@email where EmpID=@id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@fname", newfname);
                        cmd.Parameters.AddWithValue("@lname", newlname);
                        cmd.Parameters.AddWithValue("@gender", newgender);
                        cmd.Parameters.AddWithValue("@age", newage);
                        cmd.Parameters.AddWithValue("@email", newmail);
                        int row = cmd.ExecuteNonQuery();
                        sqlConnection.Close();

                        Console.WriteLine("{0} row updated", row);
                        break;
                        case 3:
                        Console.WriteLine("Enter the EmpId to be deleted");
                        int eid=Convert.ToInt32(Console.ReadLine());    
                        sqlConnection.Open();
                        cmd.CommandText = "delete from EmployeeTable where EmpID=@id";
                        cmd.Parameters.AddWithValue("@id", eid);
                        int r = cmd.ExecuteNonQuery();
                        sqlConnection.Close();
                        if (r > 0)
                            Console.WriteLine("{0} row deleted successfully", r);
                        else
                            Console.WriteLine("Deletion unsuccessful");
                        break;
                    case 4:
                        cmd.CommandText = "select * from EmployeeTable";
                        DataTable tb= new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tb);
                       
                        if (tb.Rows.Count > 0)
                        {
                            foreach(DataRow ro in tb.Rows)
                            {
                                Console.WriteLine($"{ro[0]} {ro[1]}      {ro[2]}  {ro[3]}   {ro[4]}    {ro[5]}");
                            }
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                }


            }
        }
    }
}