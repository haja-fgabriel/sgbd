using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laborator_1.Database;

namespace Laborator_1
{
    class DatabaseHandler
    {
        public static SqlConnection Connection = new SqlConnection("Data Source=FLORINEL-PC\\SQLEXPRESS;"
            + "Initial Catalog=CarCompanies;Integrated Security=True");
        public SqlDataAdapter Adapter;
        public static DatabaseRepresentation DataSet = new DatabaseRepresentation();
        //public static DataSet DataSet = new DataSet();
        public string TableName { get; set; }

        public void FillTable()
        {
            DataSet.Tables[TableName].Clear();
            Adapter.Fill(DataSet.Tables[TableName]);
        }

        public DatabaseHandler(string tableName)
        {
            //Adapter.TableMappings.Add(tableName, "dbo."+tableName);
            TableName = tableName;

            Adapter = new SqlDataAdapter("SELECT * FROM " + TableName, Connection);
        }

        public void AddNewEntry()
        {
            Connection.Open();
            Adapter.InsertCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void UpdateExistingEntry()
        {
            Connection.Open();
            Adapter.UpdateCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void DeleteEntry()
        {
            Connection.Open();
            Adapter.DeleteCommand.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
