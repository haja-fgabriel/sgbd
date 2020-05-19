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

        public MainForm()
        {
            InitializeComponent();
            databaseHandler = new DatabaseHandler(ConfigurationManager.AppSettings, this);
        }

        

        private void AddEntry()
        {
            try
            {
                databaseHandler.AddNewEntry();
                UpdateStatusStrip();
            }
            catch (Exception ex)
            {
                UpdateStatusStrip(false, ex.Message);
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

                UpdateStatusStrip();
            }
            catch (Exception ex)
            {
                UpdateStatusStrip(false, ex.Message);
            }
        }

        private void DeleteEntry()
        {
            try
            {
                databaseHandler.DeleteEntry();

                UpdateStatusStrip();
            }
            catch (Exception ex)
            {
                UpdateStatusStrip(false, ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
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
