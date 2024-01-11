using System;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Application.Models;
using System.Data;

namespace Application.Models{
    public class Database{
        static SqlConnection sqlconnection=new SqlConnection("Data Source=INDUJAJ\\SQLEXPRESS;Initial Catalog=TravelReimbrusement;Integrated Security=True");

        static public string LoginEmployee(User user)
        {
                
                sqlconnection.Open();
                SqlCommand command=new SqlCommand("Employees_Table",sqlconnection); 
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name",user.Name);
                command.Parameters.AddWithValue("@EmailId",user.EmailId);
                command.Parameters.AddWithValue("@Password", user.userPassword);
                int Count=Convert.ToInt32(command.ExecuteScalar());
                sqlconnection.Close();
                if(Count==1)
                {
                  return "success";         
                }
                
                  return "fails";
                
                     
    }
    
     static public string LoginManager(User user)
        {
                
                sqlconnection.Open();
                SqlCommand command=new SqlCommand("Admin_Table",sqlconnection); 
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name",user.Name);
                command.Parameters.AddWithValue("@EmailId",user.EmailId);
                command.Parameters.AddWithValue("@Password", user.userPassword);
                int Count=Convert.ToInt32(command.ExecuteScalar());
                sqlconnection.Close();
                if(Count==1)
                {
                  return "success";         
                }
                
                  return "fails";
                
                     
    }
   
}
}