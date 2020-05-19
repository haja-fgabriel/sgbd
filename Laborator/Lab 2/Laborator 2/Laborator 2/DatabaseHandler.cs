using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace Laborator_1
{
    class DatabaseHandler : IObserver
    {
        #region Declarations
        private string parentTableName;
        private string[] parentColumnNames;
        private string parentPrimaryKeyColumnName;

        private string childTableName;
        private string[] childColumnNames;

        private string[] childCommandParameterNames;
        private string[] childCommandParameterTypes;

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
        public DataSet dataSet;

        private BindingSource parentBindingSource;
        private BindingSource childBindingSource;

        private MainForm form;
        private int rowHeight = 28;

        #endregion

        public DatabaseHandler(NameValueCollection properties, MainForm form)
        {
            this.form = form;

            parentTableName = properties["parentTableName"];
            childTableName = properties["childTableName"];
            parentColumnNames = properties["parentColumnNames"].Split(',');
            childColumnNames = properties["childColumnNames"].Split(',');
            childCommandParameterNames = properties["childCommandParameterNames"].Split(',');
            childCommandParameterTypes = properties["childCommandParameterTypes"].Split(',');

            parentPrimaryKeyColumnName = properties["parentPrimaryKeyColumnName"];
            childForeignKeyColumnName = properties["childForeignKeyColumnName"];
            childForeignKeyRefTableName = properties["childForeignKeyRefTableName"];
            childForeignKeyRefColumnName = properties["childForeignKeyRefColumnName"];

            childUpdateCommand = properties["childUpdateCommand"];
            childDeleteCommand = properties["childDeleteCommand"];
            childInsertCommand = properties["childInsertCommand"];

            dataSet = new DataSet();
            CreateTables();
            CreateColumns();

            // TODO fix foreign key constraint error when deleting
            dataSet.Relations.Add("genericRelation", childForeignKeyRefColumn, childForeignKeyColumn);

            childAdapter = new SqlDataAdapter("SELECT * FROM " + childTableName, Connection);
            parentAdapter = new SqlDataAdapter("SELECT * FROM " + parentTableName, Connection);

            AddFieldsInForm();

            childBindingSource = new BindingSource();
            parentBindingSource = new BindingSource();
            PrepareNewBindings();
        }

        public void FillTables()
        {
            dataSet.Tables[parentTableName].Clear();
            dataSet.Tables[childTableName].Clear();
            parentAdapter.Fill(dataSet.Tables[parentTableName]);
            childAdapter.Fill(dataSet.Tables[childTableName]);
        }

        private void CreateTables()
        {
            dataSet.Tables.Add(childTableName);
            dataSet.Tables.Add(parentTableName);
        }


        private void AddFieldsInForm()
        {
            // TODO be careful with its design
            // TODO complete function

            inputs = new List<Control>();
            labels = new List<Label>();

            form.genericInputPanel.RowCount = childColumnNames.Length;
            form.genericInputPanel.ColumnCount = 2;
            form.genericInputPanel.Size = new Size(form.genericInputPanel.Size.Width, rowHeight * childColumnNames.Length);

            for (int i = 0; i < childColumnNames.Length; i++)
            {
                Label l = new Label();

                l.Text = childColumnNames[i];

                if (childCommandParameterTypes[i] != "Date")
                {
                    inputs.Add(new TextBox());
                }
                else
                {
                    inputs.Add(new DateTimePicker());
                }

                form.genericInputPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, Convert.ToSingle(rowHeight)));
                form.genericInputPanel.Controls.Add(inputs[i], 1, i);
                form.genericInputPanel.Controls.Add(l, 0, i);

            }
        }
        
        private void CreateColumns()
        {
            foreach (string name in childColumnNames)
            {
                if (name != childForeignKeyColumnName)
                {
                    dataSet.Tables[childTableName].Columns.Add(name);
                }
                else
                {
                    childForeignKeyColumn = new DataColumn(name);
                    dataSet.Tables[childTableName].Columns.Add(childForeignKeyColumn);
                }
            }

            foreach (string name in parentColumnNames)
            {
                if (name != childForeignKeyRefColumnName)
                {
                    dataSet.Tables[parentTableName].Columns.Add(name);
                }
                else
                {
                    childForeignKeyRefColumn = new DataColumn(childForeignKeyRefColumnName);
                    dataSet.Tables[parentTableName].Columns.Add(childForeignKeyRefColumn);
                }
            }
        }

        public void AddNewEntry()
        {
            // TODO replace with generic command creator methods
            childAdapter.InsertCommand = MakeCommand(childInsertCommand);
            try
            {
                Connection.Open();
                childAdapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
            RefreshTables();
        }

        public void UpdateExistingEntry()
        {
            childAdapter.UpdateCommand = MakeCommand(childUpdateCommand);
            try
            {
                Connection.Open();
                childAdapter.UpdateCommand.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
            RefreshTables();
        }

        public void DeleteEntry()
        {
            childAdapter.DeleteCommand = MakeCommand(childDeleteCommand);
            try
            {
                Connection.Open();
                childAdapter.DeleteCommand.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
            RefreshTables();
        }

        private SqlDbType GetParameterType(string type)
        {
            return (SqlDbType)Enum.Parse(typeof(SqlDbType), type);
        }

        private SqlCommand MakeCommand(string command)
        {
            SqlCommand insertCommand = new SqlCommand(command, DatabaseHandler.Connection);

            for (int i = 0; i < childColumnNames.Length; i++)
            {
                string param = childCommandParameterNames[i];
                string type = childCommandParameterTypes[i];
                if (!command.Contains(param))
                {
                    continue;
                }
                object content;
                if (inputs[i] is DateTimePicker)
                {
                    content = ((DateTimePicker)inputs[i]).Value;
                }
                else
                {
                    content = inputs[i].Text;
                }
                insertCommand.Parameters.Add(param, GetParameterType(type)).Value = content;
            }

            return insertCommand;
        }

        private void PrepareNewBindings()
        {
            // Making new binding sources to cancel current bindings
            BindingSource newChildBindingSource = new BindingSource();
            BindingSource newParentBindingSource = new BindingSource();

            childBindingSource.ResetBindings(false);
            parentBindingSource.ResetBindings(false);

            form.childDataGridView.DataSource = null;
            form.parentDataGridView.DataSource = null;

            dataSet.Tables[childTableName].Clear();
            dataSet.Tables[parentTableName].Clear();

            parentAdapter.Fill(dataSet.Tables[parentTableName]);
            childAdapter.Fill(dataSet.Tables[childTableName]);


            newParentBindingSource.DataSource = dataSet.Tables[parentTableName];
            newChildBindingSource.DataSource = newParentBindingSource;
            newChildBindingSource.DataMember = "genericRelation";

            form.parentDataGridView.DataSource = newParentBindingSource;
            form.childDataGridView.DataSource = newChildBindingSource;

            for (int i = 0; i < childColumnNames.Length; i++)
            {

                string propertyToModify;
                if (childCommandParameterTypes[i] != "Date")
                {
                    propertyToModify = "Text";
                }
                else
                {
                    propertyToModify = "Value";
                }

                inputs[i].DataBindings.Clear();
                inputs[i].DataBindings.Add(propertyToModify, newChildBindingSource, childColumnNames[i]);
            }

            childBindingSource = newChildBindingSource;
            parentBindingSource = newParentBindingSource;
        }

        public void RefreshTables()
        {
            PrepareNewBindings();
            form.childDataGridView.Refresh();
            form.parentDataGridView.Refresh();
        }

    }
}
