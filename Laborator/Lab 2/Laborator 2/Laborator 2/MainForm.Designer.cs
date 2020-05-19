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
            this.refreshButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripText = new System.Windows.Forms.ToolStripStatusLabel();
            this.modelsGroupBox = new System.Windows.Forms.GroupBox();
            this.controlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.genericInputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.modelsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manufacturersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersDataGridView)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.modelsGroupBox.SuspendLayout();
            this.controlLayout.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.manufacturersGroupBox.Location = new System.Drawing.Point(0, 2);
            this.manufacturersGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufacturersGroupBox.Name = "manufacturersGroupBox";
            this.manufacturersGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufacturersGroupBox.Size = new System.Drawing.Size(349, 507);
            this.manufacturersGroupBox.TabIndex = 1;
            this.manufacturersGroupBox.TabStop = false;
            this.manufacturersGroupBox.Text = "Manufacturers";
            // 
            // manufacturersDataGridView
            // 
            this.manufacturersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.manufacturersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturersDataGridView.Location = new System.Drawing.Point(5, 21);
            this.manufacturersDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufacturersDataGridView.Name = "manufacturersDataGridView";
            this.manufacturersDataGridView.RowTemplate.Height = 24;
            this.manufacturersDataGridView.Size = new System.Drawing.Size(339, 480);
            this.manufacturersDataGridView.TabIndex = 0;
            this.manufacturersDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.Location = new System.Drawing.Point(80, 2);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.addButton.Location = new System.Drawing.Point(0, 2);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.Location = new System.Drawing.Point(0, 53);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip.Size = new System.Drawing.Size(1024, 29);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripText
            // 
            this.statusStripText.ActiveLinkColor = System.Drawing.Color.Red;
            this.statusStripText.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripText.Name = "statusStripText";
            this.statusStripText.Size = new System.Drawing.Size(50, 24);
            this.statusStripText.Text = "Ready";
            this.statusStripText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // modelsGroupBox
            // 
            this.modelsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelsGroupBox.Controls.Add(this.genericInputPanel);
            this.modelsGroupBox.Controls.Add(this.controlLayout);
            this.modelsGroupBox.Controls.Add(this.modelsDataGridView);
            this.modelsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modelsGroupBox.Location = new System.Drawing.Point(356, 2);
            this.modelsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelsGroupBox.Name = "modelsGroupBox";
            this.modelsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelsGroupBox.Size = new System.Drawing.Size(658, 507);
            this.modelsGroupBox.TabIndex = 3;
            this.modelsGroupBox.TabStop = false;
            this.modelsGroupBox.Text = "Models";
            // 
            // controlLayout
            // 
            this.controlLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlLayout.ColumnCount = 1;
            this.controlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlLayout.Controls.Add(this.panel2, 0, 1);
            this.controlLayout.Controls.Add(this.panel3, 0, 0);
            this.controlLayout.Location = new System.Drawing.Point(419, 21);
            this.controlLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlLayout.Name = "controlLayout";
            this.controlLayout.RowCount = 2;
            this.controlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.92243F));
            this.controlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07757F));
            this.controlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlLayout.Size = new System.Drawing.Size(239, 480);
            this.controlLayout.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 92);
            this.panel2.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateButton.Location = new System.Drawing.Point(161, 2);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 30);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 388);
            this.panel3.TabIndex = 1;
            // 
            // genericInputPanel
            // 
            this.genericInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genericInputPanel.ColumnCount = 2;
            this.genericInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.genericInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.genericInputPanel.Location = new System.Drawing.Point(422, 21);
            this.genericInputPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genericInputPanel.Name = "genericInputPanel";
            this.genericInputPanel.RowCount = 2;
            this.genericInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.genericInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.genericInputPanel.Size = new System.Drawing.Size(233, 100);
            this.genericInputPanel.TabIndex = 2;
            // 
            // modelsDataGridView
            // 
            this.modelsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsDataGridView.Location = new System.Drawing.Point(5, 21);
            this.modelsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelsDataGridView.Name = "modelsDataGridView";
            this.modelsDataGridView.RowTemplate.Height = 24;
            this.modelsDataGridView.Size = new System.Drawing.Size(410, 480);
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
            this.mainLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.8244F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.175601F));
            this.mainLayout.Size = new System.Drawing.Size(1024, 542);
            this.mainLayout.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.modelsGroupBox);
            this.panel1.Controls.Add(this.manufacturersGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 509);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 542);
            this.Controls.Add(this.mainLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Generic DB management";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.manufacturersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersDataGridView)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.modelsGroupBox.ResumeLayout(false);
            this.controlLayout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        public System.Windows.Forms.Button addButton;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel statusStripText;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.GroupBox modelsGroupBox;
        public System.Windows.Forms.DataGridView modelsDataGridView;
        public System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.TableLayoutPanel mainLayout;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel controlLayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TableLayoutPanel genericInputPanel;
    }
}

