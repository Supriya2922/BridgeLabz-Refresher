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
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info("Application started");
            for (; ; )
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
                        logger.Info("Database connection established");
                        cmd.CommandType=CommandType.StoredProcedure; 
                        cmd.CommandText= "spAddEmployee";
                      
                        cmd.Parameters.Add(new SqlParameter("@fname", fname));
                        cmd.Parameters.Add(new SqlParameter("@lname", lname));
                        cmd.Parameters.Add(new SqlParameter("@gender", gender));
                        cmd.Parameters.Add(new SqlParameter("@age", age));
                        cmd.Parameters.Add(new SqlParameter("@email", mail));

                        try
                        {

                            int rows = cmd.ExecuteNonQuery();
                            logger.Info("{Rows} row inserted",rows);
                            Console.WriteLine("{0} row inserted", rows);
                        }
                        catch (Exception e)
                        {
                            logger.Error(e, "Query not executed");
                        }
                        finally
                        {
                            sqlConnection.Close();
                           
                        }
                       

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
                        logger.Info("Database connection established");
                        cmd.CommandType = CommandType.StoredProcedure; cmd.CommandText = "spUpdateEmployee";

                        
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        cmd.Parameters.Add(new SqlParameter("@fname", newfname));
                        cmd.Parameters.Add(new SqlParameter("@lname", newlname));
                        cmd.Parameters.Add(new SqlParameter("@gender", newgender));
                        cmd.Parameters.Add(new SqlParameter("@age", newage));
                        cmd.Parameters.Add(new SqlParameter("@email", newmail));
                        try
                        {
                            int row = cmd.ExecuteNonQuery();
                            logger.Info("{Rows} row(s) updated", row);
                            Console.WriteLine("{0} row updated", row);
                        }
                        catch(Exception ex)
                        {
                            logger.Error(ex, "Query not executed");
                        }
                        finally
                        {
                            NLog.LogManager.Shutdown();
                            sqlConnection.Close();
                        }
                       

                       
                        Console.WriteLine("Enter the EmpId to be deleted");
                        break;
                        case 3:
                        Console.WriteLine("Enter employee id to be deleted");
                        int eid=Convert.ToInt32(Console.ReadLine());    
                        sqlConnection.Open();
                        logger.Info("Database connection established");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spDeleteEmployee";
                        
                        cmd.Parameters.Add(new SqlParameter("@id", eid));
                        
                        try
                        {
                            int r = cmd.ExecuteNonQuery();
                            logger.Info("{Rows} row(s) deleted", r);
                            Console.WriteLine("{0} row deleted successfully", r);

                        }
                        catch(Exception ex)
                        {
                            logger.Error(ex, "Query not executed");

                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                        
                        
                        break;
                    case 4:
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spReadRecords";
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

                        logger.Info("Application closed");
                        NLog.LogManager.Shutdown();
                        Environment.Exit(0);
                        break;

                }


            }
        }
    }
}