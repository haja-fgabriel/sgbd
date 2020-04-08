using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Laborator_1.Database;

namespace Laborator_1
{ 

    public partial class MainForm : Form
    {
        private DatabaseHandler manufacturersDbHandler;
        private DatabaseHandler modelsDbHandler;
        private BindingSource manufacturersBindingSource;
        private BindingSource modelsBindingSource;


        private void PrepareBindings()
        {
            manufacturersDbHandler.FillTable();
            modelsDbHandler.FillTable();

            manufacturersBindingSource.DataSource = DatabaseHandler.DataSet.Manufacturers;

            modelsBindingSource.DataSource = manufacturersBindingSource;
            modelsBindingSource.DataMember = DatabaseHandler.DataSet.Relations[0].RelationName;

            manufacturersDataGridView.DataSource = manufacturersBindingSource;
            modelsDataGridView.DataSource = modelsBindingSource;

            modelIDTextBox.DataBindings.Add("Text", modelsBindingSource, "MoId");
            companyTextBox.DataBindings.Add("Text", modelsBindingSource, "Company");
            nameTextBox.DataBindings.Add("Text", modelsBindingSource, "Name");
            releaseDatePicker.DataBindings.Add("Value", modelsBindingSource, "ReleaseDate");
            seatsNumberTextBox.DataBindings.Add("Text", modelsBindingSource, "NumberSeats");
            chassisTypeTextBox.DataBindings.Add("Text", modelsBindingSource, "ChassisType");
        }

        public MainForm()
        {
            InitializeComponent();
            manufacturersDbHandler = new DatabaseHandler("Manufacturers");
            modelsDbHandler = new DatabaseHandler("Models");

            manufacturersBindingSource = new BindingSource();
            modelsBindingSource = new BindingSource();

            PrepareBindings();
        }

private void RefreshTables(bool newData = false)
{

    DatabaseRepresentation dataSet = DatabaseHandler.DataSet;
    dataSet.Models.Clear();
    dataSet.Manufacturers.Clear();

    modelsDbHandler.Adapter.Fill(dataSet.Models);
    manufacturersDbHandler.Adapter.Fill(dataSet.Manufacturers);


    modelsDataGridView.Refresh();
    manufacturersDataGridView.Refresh();

}

        private SqlCommand MakeCommand(string command)
        {
            SqlCommand insertCommand = new SqlCommand(command, DatabaseHandler.Connection);
            insertCommand.Parameters.Add("@MoId", SqlDbType.Int).Value = modelIDTextBox.Text;
            if (!insertCommand.CommandText.ToLower().StartsWith("delete"))
            {
                insertCommand.Parameters.Add("@Company", SqlDbType.Int).Value = companyTextBox.Text;
                insertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = nameTextBox.Text;
                insertCommand.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = releaseDatePicker.Value;
                insertCommand.Parameters.Add("@NumberSeats", SqlDbType.Int).Value = seatsNumberTextBox.Text;
                insertCommand.Parameters.Add("@ChassisType", SqlDbType.VarChar).Value = chassisTypeTextBox.Text;
            }

            return insertCommand;

        }

        private void AddEntry()
        {
            try
            {
                modelsDbHandler.Adapter.InsertCommand = MakeCommand("INSERT INTO Models" +
                   "(MoId, Company, Name, ReleaseDate, NumberSeats, ChassisType)" +
                   "VALUES (@MoId, @Company, @Name, @ReleaseDate, @NumberSeats, @ChassisType)");
                modelsDbHandler.AddNewEntry();
                RefreshTables();

                UpdateStatusStrip();
            }
            catch (Exception ex)
            {
                UpdateStatusStrip(true, ex.Message);
            }
        }

        private void UpdateStatusStrip(bool successful = true, string message = "")
        {
            statusStripText.ForeColor = Color.White;
            if (successful)
            {
                statusStrip.BackColor = Color.Blue;
                statusStripText.Text = "Successfully added value";
            }
            else
            {
                statusStrip.BackColor = Color.Red;
                statusStripText.Text = message;
            }
        }

        private void UpdateEntry()
        {
            try
            {
                modelsDbHandler.Adapter.UpdateCommand = MakeCommand("UPDATE Models " +
                        "SET Company=@Company, Name=@Name, ReleaseDate=@ReleaseDate, " +
                       "NumberSeats =@NumberSeats, ChassisType=@ChassisType " +
                       "WHERE MoId=@MoId");
                modelsDbHandler.UpdateExistingEntry();
                RefreshTables();

                UpdateStatusStrip();
            }
            catch (Exception ex)
            {
                UpdateStatusStrip(true, ex.Message);
            }
        }

        private void DeleteEntry()
        {
            try
            {
                modelsDbHandler.Adapter.DeleteCommand = MakeCommand("DELETE FROM Models " +
                    "WHERE MoId=@MoId");
                modelsDbHandler.DeleteEntry();
                RefreshTables();

                statusStrip.BackColor = Color.Blue;
                statusStripText.ForeColor = Color.White;
                statusStripText.Text = "Successfully updated value";
            }
            catch (Exception ex)
            {
                statusStrip.BackColor = Color.Red;
                statusStripText.ForeColor = Color.White;
                statusStripText.Text = "Query failed. Error: " + ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshTables(false);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshTables(false);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshTables(false);
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshTables(false);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateEntry();
        }
        

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteEntry();
        }
    }
}
