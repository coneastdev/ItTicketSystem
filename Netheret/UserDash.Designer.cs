namespace Netheret
{
    partial class UserDash
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
            tabControl1 = new TabControl();
            tabPageCreateTicket = new TabPage();
            btnSubmitIssue = new Button();
            txtArea = new TextBox();
            txtLocation = new TextBox();
            lblArea = new Label();
            lblLocation = new Label();
            lblIssueDescription = new Label();
            txtIssueDescription = new RichTextBox();
            cbImpact = new ComboBox();
            lblImpact = new Label();
            cbSeverity = new ComboBox();
            lblSeverity = new Label();
            lblIssueType = new Label();
            cbIssueType = new ComboBox();
            tabPageViewTickets = new TabPage();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox3 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            lbTickets = new ListBox();
            tabControl1.SuspendLayout();
            tabPageCreateTicket.SuspendLayout();
            tabPageViewTickets.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCreateTicket);
            tabControl1.Controls.Add(tabPageViewTickets);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 489);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCreateTicket
            // 
            tabPageCreateTicket.Controls.Add(btnSubmitIssue);
            tabPageCreateTicket.Controls.Add(txtArea);
            tabPageCreateTicket.Controls.Add(txtLocation);
            tabPageCreateTicket.Controls.Add(lblArea);
            tabPageCreateTicket.Controls.Add(lblLocation);
            tabPageCreateTicket.Controls.Add(lblIssueDescription);
            tabPageCreateTicket.Controls.Add(txtIssueDescription);
            tabPageCreateTicket.Controls.Add(cbImpact);
            tabPageCreateTicket.Controls.Add(lblImpact);
            tabPageCreateTicket.Controls.Add(cbSeverity);
            tabPageCreateTicket.Controls.Add(lblSeverity);
            tabPageCreateTicket.Controls.Add(lblIssueType);
            tabPageCreateTicket.Controls.Add(cbIssueType);
            tabPageCreateTicket.Location = new Point(4, 24);
            tabPageCreateTicket.Name = "tabPageCreateTicket";
            tabPageCreateTicket.Padding = new Padding(3);
            tabPageCreateTicket.Size = new Size(768, 461);
            tabPageCreateTicket.TabIndex = 0;
            tabPageCreateTicket.Text = "Create Ticket";
            tabPageCreateTicket.UseVisualStyleBackColor = true;
            // 
            // btnSubmitIssue
            // 
            btnSubmitIssue.Location = new Point(10, 421);
            btnSubmitIssue.Name = "btnSubmitIssue";
            btnSubmitIssue.Size = new Size(75, 23);
            btnSubmitIssue.TabIndex = 12;
            btnSubmitIssue.Text = "submit";
            btnSubmitIssue.UseVisualStyleBackColor = true;
            btnSubmitIssue.Click += btnSubmitIssue_Click;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(3, 381);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(284, 23);
            txtArea.TabIndex = 11;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(6, 318);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(284, 23);
            txtLocation.TabIndex = 10;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(6, 363);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(162, 15);
            lblArea.TabIndex = 9;
            lblArea.Text = "Affected Area Inside Location";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(6, 299);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(53, 15);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Location";
            // 
            // lblIssueDescription
            // 
            lblIssueDescription.AutoSize = true;
            lblIssueDescription.Location = new Point(6, 176);
            lblIssueDescription.Name = "lblIssueDescription";
            lblIssueDescription.Size = new Size(96, 15);
            lblIssueDescription.TabIndex = 7;
            lblIssueDescription.Text = "Issue Description";
            // 
            // txtIssueDescription
            // 
            txtIssueDescription.Location = new Point(6, 194);
            txtIssueDescription.Name = "txtIssueDescription";
            txtIssueDescription.Size = new Size(529, 102);
            txtIssueDescription.TabIndex = 6;
            txtIssueDescription.Text = "";
            // 
            // cbImpact
            // 
            cbImpact.AutoCompleteCustomSource.AddRange(new string[] { "very low - impacts one person", "low - impacts a few people", "medium - impacts a team of people", "high - impacts a depeartment of people", "urgent - impacts a majority of people" });
            cbImpact.FormattingEnabled = true;
            cbImpact.Items.AddRange(new object[] { "very low - affects a few people", "low - affects some people", "medium - affects an entire team worth of people", "high - affects an entire department worth of people", "urgent - affects the majourity of people" });
            cbImpact.Location = new Point(6, 138);
            cbImpact.Name = "cbImpact";
            cbImpact.Size = new Size(212, 23);
            cbImpact.TabIndex = 5;
            // 
            // lblImpact
            // 
            lblImpact.AutoSize = true;
            lblImpact.Location = new Point(6, 120);
            lblImpact.Name = "lblImpact";
            lblImpact.Size = new Size(44, 15);
            lblImpact.TabIndex = 4;
            lblImpact.Text = "Impact";
            // 
            // cbSeverity
            // 
            cbSeverity.AutoCompleteCustomSource.AddRange(new string[] { "very low - no effect on operations", "low - minor effect on operations", "medium - substantal effect on operations", "high- severe effect on operations", "urgent - complate stop to operations" });
            cbSeverity.FormattingEnabled = true;
            cbSeverity.Items.AddRange(new object[] { "very low - no impact to work", "low - small impact to work", "medium - moderate impact to work", "high - large impact to work", "urgent - work cannot be done" });
            cbSeverity.Location = new Point(6, 83);
            cbSeverity.Name = "cbSeverity";
            cbSeverity.Size = new Size(212, 23);
            cbSeverity.TabIndex = 3;
            // 
            // lblSeverity
            // 
            lblSeverity.AutoSize = true;
            lblSeverity.Location = new Point(6, 65);
            lblSeverity.Name = "lblSeverity";
            lblSeverity.Size = new Size(48, 15);
            lblSeverity.TabIndex = 2;
            lblSeverity.Text = "Severity";
            // 
            // lblIssueType
            // 
            lblIssueType.AutoSize = true;
            lblIssueType.Location = new Point(6, 12);
            lblIssueType.Name = "lblIssueType";
            lblIssueType.Size = new Size(61, 15);
            lblIssueType.TabIndex = 1;
            lblIssueType.Text = "Issue Type";
            // 
            // cbIssueType
            // 
            cbIssueType.AutoCompleteCustomSource.AddRange(new string[] { "Faulty Computer", "Issue with Software", "Data Recovery", "Other" });
            cbIssueType.FormattingEnabled = true;
            cbIssueType.Items.AddRange(new object[] { "Faulty computer", "Software Issue", "Data recovery", "Login issue", "Network issue", "Other" });
            cbIssueType.Location = new Point(6, 30);
            cbIssueType.Name = "cbIssueType";
            cbIssueType.Size = new Size(212, 23);
            cbIssueType.TabIndex = 0;
            // 
            // tabPageViewTickets
            // 
            tabPageViewTickets.Controls.Add(button1);
            tabPageViewTickets.Controls.Add(label9);
            tabPageViewTickets.Controls.Add(label8);
            tabPageViewTickets.Controls.Add(comboBox5);
            tabPageViewTickets.Controls.Add(comboBox4);
            tabPageViewTickets.Controls.Add(textBox3);
            tabPageViewTickets.Controls.Add(label7);
            tabPageViewTickets.Controls.Add(button2);
            tabPageViewTickets.Controls.Add(lbTickets);
            tabPageViewTickets.Location = new Point(4, 24);
            tabPageViewTickets.Name = "tabPageViewTickets";
            tabPageViewTickets.Padding = new Padding(3);
            tabPageViewTickets.Size = new Size(768, 461);
            tabPageViewTickets.TabIndex = 1;
            tabPageViewTickets.Text = "View Tickets";
            tabPageViewTickets.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(548, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(323, 4);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 7;
            label9.Text = "Sort";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(173, 3);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 6;
            label8.Text = "Status";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "New-Old", "Old-New", "A-z", "z-A" });
            comboBox5.Location = new Point(323, 22);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(138, 23);
            comboBox5.TabIndex = 5;
            comboBox5.Text = "New-Old";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            comboBox4.Location = new Point(173, 22);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(144, 23);
            comboBox4.TabIndex = 4;
            comboBox4.Text = "All";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 3);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 2;
            label7.Text = "Keyword";
            // 
            // button2
            // 
            button2.Location = new Point(467, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbTickets
            // 
            lbTickets.FormattingEnabled = true;
            lbTickets.HorizontalScrollbar = true;
            lbTickets.IntegralHeight = false;
            lbTickets.Location = new Point(6, 61);
            lbTickets.Name = "lbTickets";
            lbTickets.Size = new Size(756, 394);
            lbTickets.TabIndex = 0;
            // 
            // UserDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(tabControl1);
            Name = "UserDash";
            Text = "Dashboard";
            tabControl1.ResumeLayout(false);
            tabPageCreateTicket.ResumeLayout(false);
            tabPageCreateTicket.PerformLayout();
            tabPageViewTickets.ResumeLayout(false);
            tabPageViewTickets.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCreateTicket;
        private TabPage tabPageViewTickets;
        private ComboBox cbImpact;
        private Label lblImpact;
        private ComboBox cbSeverity;
        private Label lblSeverity;
        private Label lblIssueType;
        private ComboBox cbIssueType;
        private RichTextBox txtIssueDescription;
        private Label lblLocation;
        private Label lblIssueDescription;
        private Button btnSubmitIssue;
        private TextBox txtArea;
        private TextBox txtLocation;
        private Label lblArea;
        private Button button2;
        private ListBox lbTickets;
        private Label label8;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private TextBox textBox3;
        private Label label7;
        private Label label9;
        private Button button1;
    }
}