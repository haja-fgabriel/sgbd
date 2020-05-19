namespace Laborator_1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manufacturersGroupBox = new System.Windows.Forms.GroupBox();
            this.manufacturersDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.modelsInputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.releaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.chassisTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.modelIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seatsNumberTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripText = new System.Windows.Forms.ToolStripStatusLabel();
            this.modelsGroupBox = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.modelsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manufacturersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersDataGridView)).BeginInit();
            this.modelsInputPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.modelsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataGridView)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // manufacturersGroupBox
            // 
            this.manufacturersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manufacturersGroupBox.Controls.Add(this.manufacturersDataGridView);
            this.manufacturersGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.manufacturersGroupBox.Location = new System.Drawing.Point(0, 3);
            this.manufacturersGroupBox.Name = "manufacturersGroupBox";
            this.manufacturersGroupBox.Size = new System.Drawing.Size(350, 504);
            this.manufacturersGroupBox.TabIndex = 1;
            this.manufacturersGroupBox.TabStop = false;
            this.manufacturersGroupBox.Text = "Manufacturers";
            // 
            // manufacturersDataGridView
            // 
            this.manufacturersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manufacturersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturersDataGridView.Location = new System.Drawing.Point(6, 21);
            this.manufacturersDataGridView.Name = "manufacturersDataGridView";
            this.manufacturersDataGridView.RowTemplate.Height = 24;
            this.manufacturersDataGridView.Size = new System.Drawing.Size(339, 477);
            this.manufacturersDataGridView.TabIndex = 0;
            this.manufacturersDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.Location = new System.Drawing.Point(503, 210);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.Location = new System.Drawing.Point(423, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modelsInputPanel
            // 
            this.modelsInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modelsInputPanel.ColumnCount = 2;
            this.modelsInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.52542F));
            this.modelsInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.47458F));
            this.modelsInputPanel.Controls.Add(this.releaseDatePicker, 1, 3);
            this.modelsInputPanel.Controls.Add(this.chassisTypeTextBox, 1, 5);
            this.modelsInputPanel.Controls.Add(this.label5, 0, 5);
            this.modelsInputPanel.Controls.Add(this.nameTextBox, 1, 2);
            this.modelsInputPanel.Controls.Add(this.label2, 0, 2);
            this.modelsInputPanel.Controls.Add(this.companyTextBox, 1, 1);
            this.modelsInputPanel.Controls.Add(this.modelIDTextBox, 1, 0);
            this.modelsInputPanel.Controls.Add(this.label1, 0, 0);
            this.modelsInputPanel.Controls.Add(this.nameLabel, 0, 1);
            this.modelsInputPanel.Controls.Add(this.label3, 0, 3);
            this.modelsInputPanel.Controls.Add(this.label4, 0, 4);
            this.modelsInputPanel.Controls.Add(this.seatsNumberTextBox, 1, 4);
            this.modelsInputPanel.Location = new System.Drawing.Point(423, 21);
            this.modelsInputPanel.Name = "modelsInputPanel";
            this.modelsInputPanel.RowCount = 6;
            this.modelsInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.modelsInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.modelsInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.modelsInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.modelsInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.modelsInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.modelsInputPanel.Size = new System.Drawing.Size(236, 183);
            this.modelsInputPanel.TabIndex = 1;
            // 
            // releaseDatePicker
            // 
            this.releaseDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseDatePicker.Location = new System.Drawing.Point(100, 95);
            this.releaseDatePicker.Name = "releaseDatePicker";
            this.releaseDatePicker.Size = new System.Drawing.Size(133, 27);
            this.releaseDatePicker.TabIndex = 5;
            // 
            // chassisTypeTextBox
            // 
            this.chassisTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chassisTypeTextBox.Location = new System.Drawing.Point(100, 156);
            this.chassisTypeTextBox.Name = "chassisTypeTextBox";
            this.chassisTypeTextBox.Size = new System.Drawing.Size(133, 27);
            this.chassisTypeTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chassis type";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(100, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(133, 27);
            this.nameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyTextBox.Location = new System.Drawing.Point(100, 33);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(133, 27);
            this.companyTextBox.TabIndex = 3;
            // 
            // modelIDTextBox
            // 
            this.modelIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelIDTextBox.Location = new System.Drawing.Point(100, 3);
            this.modelIDTextBox.Name = "modelIDTextBox";
            this.modelIDTextBox.Size = new System.Drawing.Size(133, 27);
            this.modelIDTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model ID";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameLabel.Location = new System.Drawing.Point(3, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Company ID";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Release date";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "No. of seats";
            // 
            // seatsNumberTextBox
            // 
            this.seatsNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatsNumberTextBox.Location = new System.Drawing.Point(100, 126);
            this.seatsNumberTextBox.Name = "seatsNumberTextBox";
            this.seatsNumberTextBox.Size = new System.Drawing.Size(133, 27);
            this.seatsNumberTextBox.TabIndex = 9;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.Location = new System.Drawing.Point(423, 260);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(236, 28);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripText});
            this.statusStrip.Location = new System.Drawing.Point(0, 513);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1024, 28);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripText
            // 
            this.statusStripText.ActiveLinkColor = System.Drawing.Color.Red;
            this.statusStripText.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripText.Name = "statusStripText";
            this.statusStripText.Size = new System.Drawing.Size(50, 23);
            this.statusStripText.Text = "Ready";
            this.statusStripText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // modelsGroupBox
            // 
            this.modelsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelsGroupBox.Controls.Add(this.updateButton);
            this.modelsGroupBox.Controls.Add(this.deleteButton);
            this.modelsGroupBox.Controls.Add(this.refreshButton);
            this.modelsGroupBox.Controls.Add(this.modelsDataGridView);
            this.modelsGroupBox.Controls.Add(this.addButton);
            this.modelsGroupBox.Controls.Add(this.modelsInputPanel);
            this.modelsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modelsGroupBox.Location = new System.Drawing.Point(356, 3);
            this.modelsGroupBox.Name = "modelsGroupBox";
            this.modelsGroupBox.Size = new System.Drawing.Size(659, 504);
            this.modelsGroupBox.TabIndex = 3;
            this.modelsGroupBox.TabStop = false;
            this.modelsGroupBox.Text = "Models";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateButton.Location = new System.Drawing.Point(584, 210);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 30);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // modelsDataGridView
            // 
            this.modelsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsDataGridView.Location = new System.Drawing.Point(6, 21);
            this.modelsDataGridView.Name = "modelsDataGridView";
            this.modelsDataGridView.RowTemplate.Height = 24;
            this.modelsDataGridView.Size = new System.Drawing.Size(411, 477);
            this.modelsDataGridView.TabIndex = 0;
            // 
            // mainLayout
            // 
            this.mainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.statusStrip, 0, 1);
            this.mainLayout.Controls.Add(this.panel1, 0, 0);
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.8244F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.175601F));
            this.mainLayout.Size = new System.Drawing.Size(1024, 541);
            this.mainLayout.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.modelsGroupBox);
            this.panel1.Controls.Add(this.manufacturersGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 507);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 542);
            this.Controls.Add(this.mainLayout);
            this.Name = "MainForm";
            this.Text = "CarCompanies";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.manufacturersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersDataGridView)).EndInit();
            this.modelsInputPanel.ResumeLayout(false);
            this.modelsInputPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.modelsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataGridView)).EndInit();
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView manufacturersDataGridView;
        public System.Windows.Forms.GroupBox manufacturersGroupBox;
        public System.Windows.Forms.Button refreshButton;
        public System.Windows.Forms.TableLayoutPanel modelsInputPanel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.TextBox modelIDTextBox;
        public System.Windows.Forms.TextBox companyTextBox;
        public System.Windows.Forms.Button addButton;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel statusStripText;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.GroupBox modelsGroupBox;
        public System.Windows.Forms.DataGridView modelsDataGridView;
        public System.Windows.Forms.TextBox chassisTypeTextBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox seatsNumberTextBox;
        public System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.DateTimePicker releaseDatePicker;
        public System.Windows.Forms.TableLayoutPanel mainLayout;
        public System.Windows.Forms.Panel panel1;
    }
}

