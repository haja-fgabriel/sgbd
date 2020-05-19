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
using System.Configuration;

namespace Laborator_1
{

    public partial class MainForm : Form
    {
        private DatabaseHandler databaseHandler;
        private BindingSource parentBindingSource;
        private BindingSource childBindingSource;

        public MainForm()
        {
            InitializeComponent();
            databaseHandler = new DatabaseHandler(ConfigurationManager.AppSettings, this);

            parentBindingSource = new BindingSource();
            childBindingSource = new BindingSource();
        }

        private void RefreshTables(bool newData = false)
        {
            databaseHandler.FillTables();

            modelsDataGridView.Refresh();
            manufacturersDataGridView.Refresh();

        }

        private void AddEntry()
        {
            try
            {
                databaseHandler.AddNewEntry();
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
                databaseHandler.UpdateExistingEntry();
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
                databaseHandler.DeleteEntry();
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
