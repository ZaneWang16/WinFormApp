using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace ExpenseTracker
{
    /// <summary>
    /// Handles database operations for the Expense Tracker application.
    /// </summary>
    public class DatabaseHandler
    {
        // Connection string to the database.
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rabbit\Documents\ExpenseDb.mdf;Integrated Security=True;Connect Timeout=30";

        // Retrieves a user from the database based on username and password.
        public User GetUser(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "Select * From UserTable Where UserName=@UserName and UserPassword=@UserPassword";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@UserPassword", password);

                        con.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        var user = (from IDataRecord r in reader
                                    select new User { UserName = (string)r["UserName"] }).FirstOrDefault();

                        con.Close();

                        return user;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log or handle SQL exception
                // User could log the error message to a file or display it to the user
                Console.WriteLine(ex.Message);
                return null;  // Return null or handle the exception as appropriate for the application
            }
            catch (Exception ex)
            {
                // Log or handle other exceptions
                Console.WriteLine(ex.Message);
                return null;  // Return null or handle the exception as appropriate for the application
            }
        }

        // Retrieves expenses from the database, optionally filtered by category.
        public DataTable GetExpenses(string category = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = category == null ? "SELECT * FROM ExpenseTable" :
                                                 "SELECT * FROM ExpenseTable WHERE ExpenseCategory = @ExpenseCategory";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    if (category != null)
                        command.Parameters.AddWithValue("@ExpenseCategory", category);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // Adds an expense to the database.
        public bool AddExpense(string expenseName, string expenseAmount, string expenseCategory, DateTime expenseDate, string expenseComment, string expenseUser)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Define the SQL query to insert a new record into ExpenseTable with the provided parameters.
                    string query = "INSERT INTO ExpenseTable (ExpenseName, ExpenseAmount, ExpenseCategory, ExpenseDate, ExpenseComment, ExpenseUser) " +
                                   "VALUES (@ExpenseName, @ExpenseAmount, @ExpenseCategory, @ExpenseDate, @ExpenseComment, @ExpenseUser)";
                    // Create a new SQL command with the defined query and the open SQL connection.
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@ExpenseName", expenseName);
                        command.Parameters.AddWithValue("@ExpenseAmount", expenseAmount);
                        command.Parameters.AddWithValue("@ExpenseCategory", expenseCategory);
                        command.Parameters.AddWithValue("@ExpenseDate", expenseDate);
                        command.Parameters.AddWithValue("@ExpenseComment", expenseComment);
                        command.Parameters.AddWithValue("@ExpenseUser", expenseUser);
                        // Execute the SQL command and get the number of rows affected.
                        int rowsAffected = command.ExecuteNonQuery();

                        con.Close();

                        return rowsAffected > 0;  // Return true if at least one row was inserted
                    }
                }
            }
            catch (SqlException ex) // Catch any SQL exceptions
            {
                Console.WriteLine(ex.Message);
                return false;  // Return false on error
            }
            catch (Exception ex)// Catch any other exceptions
            {
                Console.WriteLine(ex.Message);
                return false;  // Return false on error
            }
        }

        // Method to get the highest expense amount for a specific user
        public decimal GetMaxExpense(string user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Select max(ExpenseAmount) From ExpenseTable Where ExpenseUser = @User";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@User", user);
                    object result = command.ExecuteScalar();
                    // Check for DBNull before converting to decimal
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
        }

        // Method to get the lowest expense amount for a specific user
        public decimal GetMinExpense(string user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Select min(ExpenseAmount) From ExpenseTable Where ExpenseUser = @User";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@User", user);
                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
        }

        // Method to get the sum and count of expenses for a specific user
        public (double sum, int count) GetSumAndCount(string user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string querySum = "Select sum(ExpenseAmount) From ExpenseTable Where ExpenseUser = @User";
                string queryCount = "Select count(*) From ExpenseTable Where ExpenseUser = @User";

                using (SqlCommand commandSum = new SqlCommand(querySum, con))
                using (SqlCommand commandCount = new SqlCommand(queryCount, con))
                {
                    commandSum.Parameters.AddWithValue("@User", user);
                    commandCount.Parameters.AddWithValue("@User", user);

                    object sumResult = commandSum.ExecuteScalar();
                    object countResult = commandCount.ExecuteScalar();
                    // Check for DBNull before converting to double and int
                    double sum = sumResult != DBNull.Value ? Convert.ToDouble(sumResult) : 0;
                    int count = countResult != DBNull.Value ? Convert.ToInt32(countResult) : 0;

                    return (sum, count);
                }
            }
        }

        // Method to get the total expense for a specific user
        public decimal GetTotExpense(string user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Select sum(ExpenseAmount) From ExpenseTable Where ExpenseUser = @User";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@User", user);
                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
        }

        // Method to get the category of the highest expense for a specific user
        public string GetHighestExpenseCategory(string user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Define the SQL query to select the ExpenseCategory
                // from ExpenseTable where the ExpenseAmount is maximum and the ExpenseUser matches the provided user.
                string query = @"
            SELECT ExpenseCategory 
            FROM ExpenseTable 
            WHERE ExpenseAmount = (
                SELECT MAX(ExpenseAmount) 
                FROM ExpenseTable 
                WHERE ExpenseUser = @User
            )
            AND ExpenseUser = @User";  // Ensure the category returned belongs to the specified user
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@User", user);
                    // Execute the SQL command and get the first column of the first row in the result set,
                    // or a null reference if the result set is empty.
                    object result = command.ExecuteScalar();
                    // Return the result as a string if it's not null or DBNull, otherwise return null.
                    return result != null && result != DBNull.Value ? result.ToString() : null;
                }
            }
        }

        // Method to get the category of the lowest expense for a specific user
        public string GetLowestExpenseCategory(string user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Define the SQL query to select the ExpenseCategory
                // from ExpenseTable where the ExpenseAmount is minimum and the ExpenseUser matches the provided user.
                string query = @"
            SELECT ExpenseCategory 
            FROM ExpenseTable 
            WHERE ExpenseAmount = (
                SELECT MIN(ExpenseAmount) 
                FROM ExpenseTable 
                WHERE ExpenseUser = @User
            )
            AND ExpenseUser = @User";  // Ensure the category returned belongs to the specified user
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@User", user);
                    // Execute the SQL command and get the first column of the first row in the result set,
                    // or a null reference if the result set is empty.
                    object result = command.ExecuteScalar();
                    // Return the result as a string if it's not null or DBNull, otherwise return null.
                    return result != null && result != DBNull.Value ? result.ToString() : null;
                }
            }
        }

        // Method to get the total expense for a specific user and category
        public decimal GetTotalExpenseByCategory(string user, string category)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
            SELECT SUM(ExpenseAmount) 
            FROM ExpenseTable 
            WHERE ExpenseUser = @User 
            AND ExpenseCategory = @Category";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@Category", category);
                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
        }

        // Retrieves all users from the database.
        public DataTable GetUsers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Select * From UserTable";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // Adds a user to the database.
        public bool AddUser(string userName, DateTime userDOB, string userPhone, string userPassword, string userAddress)
        {
            using (SqlConnection con = new SqlConnection(connectionString))// Create a new SQL connection using the provided connection string
            {
                con.Open();
                // Define the SQL query to insert a new record into UserTable with the provided parameters.
                string query = "INSERT into UserTable (UserName, UserDOB, UserPhone, UserPassword, UserAddress) VALUES(@UN, @UD, @UP, @UPA, @UA)";
                using (SqlCommand cmd = new SqlCommand(query, con))// Create a new SQL command with the defined query and the open SQL connection.
                {
                    cmd.Parameters.AddWithValue("@UN", userName);
                    cmd.Parameters.AddWithValue("@UD", userDOB.Date);
                    cmd.Parameters.AddWithValue("@UP", userPhone);
                    cmd.Parameters.AddWithValue("@UPA", userPassword);
                    cmd.Parameters.AddWithValue("@UA", userAddress);
                    // Execute the SQL command and get the number of rows affected.
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;  // Return true if at least one row was inserted
                }
            }
        }

        // Retrieves expenses for a specified user from the database.
        public DataTable GetExpensesForUser(string user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Define the SQL query to select all records from ExpenseTable where the ExpenseUser matches the provided user.
                string query = "Select * From ExpenseTable Where ExpenseUser = @User";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add the user parameter to the SQL command.
                    command.Parameters.AddWithValue("@User", user);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;// Return the filled data table.
                }
            }
        }

        // Retrieves expenses for a specified user and category from the database.
        public DataTable GetExpensesForUserByCategory(string user, string category)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Select * From ExpenseTable Where ExpenseUser = @User and ExpenseCategory = @Category";
                // Create a new SQL command with the defined query and the open SQL connection.
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@Category", category);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;// Return the filled data table.
                }
            }
        }

    }



}

