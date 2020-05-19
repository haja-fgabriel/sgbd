﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;

namespace Laborator_1
{
    class DatabaseHandler
    {
        #region Declarations
        private string parentTableName;
        private string childTableName;
        private string[] childColumnNames;
        private string[] childColumnTypes;
        private string[] parentColumnNames;
        private string parentPrimaryKeyColumnName;
        private string childForeignKeyColumnName;
        private string childForeignKeyRefTableName;
        private string childForeignKeyRefColumnName;

        private DataColumn childForeignKeyColumn;
        private DataColumn childForeignKeyRefColumn;

        private string childInsertCommand;
        private string childUpdateCommand;
        private string childDeleteCommand;

        private List<Control> inputs;
        private List<Label> labels;

        public static SqlConnection Connection = new SqlConnection(ConfigurationManager
            .ConnectionStrings["GenericConnectionString"].ConnectionString);

        public SqlDataAdapter childAdapter;
        public SqlDataAdapter parentAdapter;
        public static DataSet DataSet = new DataSet();

        private BindingSource parentBindingSource;
        private BindingSource childBindingSource;

        private MainForm form;

        #endregion

        public DatabaseHandler(NameValueCollection properties, MainForm form)
        {
            this.form = form;

            parentTableName = properties["parentTableName"];
            childTableName = properties["childTableName"];
            parentColumnNames = properties["parentColumnNames"].Split(',');
            childColumnNames = properties["childColumnNames"].Split(',');
            childColumnTypes = properties["childColumnTypes"].Split(',');

            parentPrimaryKeyColumnName = properties["parentPrimaryKeyColumnName"];
            childForeignKeyColumnName = properties["childForeignKeyColumnName"];
            childForeignKeyRefTableName = properties["childForeignKeyRefTableName"];
            childForeignKeyRefColumnName = properties["childForeignKeyRefColumnName"];

            childUpdateCommand = properties["childUpdateCommand"];
            childDeleteCommand = properties["childDeleteCommand"];
            childInsertCommand = properties["childInsertCommand"];

            CreateTables();
            CreateColumns();

            parentBindingSource = new BindingSource();
            childBindingSource = new BindingSource();

            // TODO uncomment when finishing generic addition of fields
            // AddFieldsInForm();
            //form.manufacturersDataGridView.DataSource = parentBindingSource;
            //form.modelsDataGridView.DataSource = childBindingSource;

            inputs = new List<Control>();
            labels = new List<Label>();
            
            // TODO fix foreign key constraint error when deleting
            DataSet.Relations.Add("genericRelation", childForeignKeyRefColumn, childForeignKeyColumn);

            childAdapter = new SqlDataAdapter("SELECT * FROM " + childTableName, Connection);
            parentAdapter = new SqlDataAdapter("SELECT * FROM " + parentTableName, Connection);

            Temp_PrepareBindings();
        }

        public void FillTables()
        {
            DataSet.Tables[parentTableName].Clear();
            parentAdapter.Fill(DataSet.Tables[parentTableName]);
            DataSet.Tables[childTableName].Clear();
            childAdapter.Fill(DataSet.Tables[childTableName]);
        }

        private void CreateTables()
        {
            DataSet.Tables.Add(childTableName);
            DataSet.Tables.Add(parentTableName);
        }

        #region Temporary functions
        // TODO eventually create a separate class containing the generated textboxes
        private SqlCommand MakeCommand(string command)
        {
            SqlCommand insertCommand = new SqlCommand(command, DatabaseHandler.Connection);
            insertCommand.Parameters.Add("@MoId", SqlDbType.Int).Value = form.modelIDTextBox.Text;
            if (!insertCommand.CommandText.ToLower().StartsWith("delete"))
            {
                insertCommand.Parameters.Add("@Company", SqlDbType.Int).Value = form.companyTextBox.Text;
                insertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = form.nameTextBox.Text;
                insertCommand.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = form.releaseDatePicker.Value;
                insertCommand.Parameters.Add("@NumberSeats", SqlDbType.Int).Value = form.seatsNumberTextBox.Text;
                insertCommand.Parameters.Add("@ChassisType", SqlDbType.VarChar).Value = form.chassisTypeTextBox.Text;
            }

            return insertCommand;
        }
        
        private void Temp_PrepareBindings()
        {
            FillTables();

            parentBindingSource.DataSource = DatabaseHandler.DataSet.Tables["Manufacturers"];

            childBindingSource.DataSource = parentBindingSource;
            childBindingSource.DataMember = "genericRelation";

            form.manufacturersDataGridView.DataSource = parentBindingSource;
            form.modelsDataGridView.DataSource = childBindingSource;

            form.modelIDTextBox.DataBindings.Add("Text", childBindingSource, "MoId");
            form.companyTextBox.DataBindings.Add("Text", childBindingSource, "Company");
            form.nameTextBox.DataBindings.Add("Text", childBindingSource, "Name");
            form.releaseDatePicker.DataBindings.Add("Value", childBindingSource, "ReleaseDate");
            form.seatsNumberTextBox.DataBindings.Add("Text", childBindingSource, "NumberSeats");
            form.chassisTypeTextBox.DataBindings.Add("Text", childBindingSource, "ChassisType");
        }

        #endregion

        private void AddFieldsInForm()
        {
            // TODO complete function
            for (int i = 0; i < childColumnNames.Length; i++)
            {
                Label l = new Label();
                l.Text = childColumnNames[i];
                inputs.Add(new TextBox());
                form.modelsInputPanel.Controls.Add(inputs[i], 1, i);
                form.modelsInputPanel.Controls.Add(l, 0, i);
                inputs[i].DataBindings.Add("Text", childBindingSource, childColumnNames[i]);
            }
        }

        private void MakeCommands()
        {
        }

        private void CreateColumns()
        {
            foreach (string name in childColumnNames)
            {
                if (name != childForeignKeyColumnName)
                {
                    DataSet.Tables[childTableName].Columns.Add(name);
                }
                else
                {
                    childForeignKeyColumn = new DataColumn(name);
                    DataSet.Tables[childTableName].Columns.Add(childForeignKeyColumn);
                }
            }

            foreach (string name in parentColumnNames)
            {
                if (name != childForeignKeyRefColumnName)
                {
                    DataSet.Tables[parentTableName].Columns.Add(name);
                }
                else
                {
                    childForeignKeyRefColumn = new DataColumn(childForeignKeyRefColumnName);
                    DataSet.Tables[parentTableName].Columns.Add(childForeignKeyRefColumn);
                }
            }
        }

        public void AddNewEntry()
        {
            // TODO replace with generic command creator methods
            childAdapter.InsertCommand = MakeCommand(childInsertCommand);
            Connection.Open();
            childAdapter.InsertCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void UpdateExistingEntry()
        {
            childAdapter.UpdateCommand = MakeCommand(childUpdateCommand);
            Connection.Open();
            childAdapter.UpdateCommand.ExecuteNonQuery();
            Connection.Close();
        }

        public void DeleteEntry()
        {
            childAdapter.DeleteCommand = MakeCommand(childDeleteCommand);
            Connection.Open();
            childAdapter.DeleteCommand.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
