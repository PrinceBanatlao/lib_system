using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace lib_system
{
    class MySqlConnector
    {

        string mysqlCon = "server=127.0.0.1;user=root;database=library_db;password=";
        MySqlConnection con = new MySqlConnection();


        /*  public DataTable FetchBooks()
          {

              DataTable result = new DataTable();

              try
              {

                  using (MySqlConnection connection = new MySqlConnection(connectionString))
                  {
                      connection.Open();


                      string query = "SELECT * FROM tbl_books";


                      using (MySqlCommand command = new MySqlCommand(query, connection))
                      {

                          using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                          {
                              adapter.Fill(result);
                          }
                      }
                  }
              }
              catch (Exception ex)
              {

                  Console.WriteLine("Error: " + ex.Message);
              }


              return result;
          }*/
    }
}
