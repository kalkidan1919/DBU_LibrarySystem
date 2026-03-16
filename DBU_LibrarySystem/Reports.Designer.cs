namespace DBU_LibrarySystem
{
    partial class Reports
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
            panel1 = new Panel();
            label1 = new Label();
            btnLogout = new Button();
            panelMenu = new Panel();
            btnBooks = new Button();
            btnMembers = new Button();
            btnUsers = new Button();
            btnBorrowReturn = new Button();
            btnReports = new Button();
            btnSearch = new Button();
            panel2 = new Panel();
            label2 = new Label();
            btnInventorySize = new Button();
            btnOverdueList = new Button();
            btnCurrentLoans = new Button();
            label3 = new Label();
            dgvReports = new DataGridView();
            BookID = new DataGridViewTextBoxColumn();
            MemberID = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 95, 150);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 25);
            label1.TabIndex = 1;
            label1.Text = "DBU Library | Admin Console";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(713, 22);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnSearch);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnBorrowReturn);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnMembers);
            panelMenu.Controls.Add(btnBooks);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 60);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 390);
            panelMenu.TabIndex = 1;
            // 
            // btnBooks
            // 
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Location = new Point(41, 18);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(75, 45);
            btnBooks.TabIndex = 0;
            btnBooks.Text = " Book Management";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += button1_Click;
            // 
            // btnMembers
            // 
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Location = new Point(41, 81);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(75, 45);
            btnMembers.TabIndex = 0;
            btnMembers.Text = "Member Management";
            btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Location = new Point(41, 145);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(75, 45);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "User Management";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnBorrowReturn
            // 
            btnBorrowReturn.FlatStyle = FlatStyle.Flat;
            btnBorrowReturn.Location = new Point(41, 207);
            btnBorrowReturn.Name = "btnBorrowReturn";
            btnBorrowReturn.Size = new Size(75, 45);
            btnBorrowReturn.TabIndex = 0;
            btnBorrowReturn.Text = "Borrow/Return";
            btnBorrowReturn.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(41, 273);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(75, 45);
            btnReports.TabIndex = 0;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(41, 333);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 45);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvReports);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnCurrentLoans);
            panel2.Controls.Add(btnOverdueList);
            panel2.Controls.Add(btnInventorySize);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 390);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 28);
            label2.Name = "label2";
            label2.Size = new Size(170, 30);
            label2.TabIndex = 0;
            label2.Text = " Library Reports";
            // 
            // btnInventorySize
            // 
            btnInventorySize.BackColor = Color.FromArgb(45, 110, 163);
            btnInventorySize.FlatStyle = FlatStyle.Flat;
            btnInventorySize.ForeColor = SystemColors.ButtonFace;
            btnInventorySize.Location = new Point(29, 81);
            btnInventorySize.Name = "btnInventorySize";
            btnInventorySize.Size = new Size(75, 23);
            btnInventorySize.TabIndex = 1;
            btnInventorySize.Text = "Inventory Size";
            btnInventorySize.UseVisualStyleBackColor = false;
            // 
            // btnOverdueList
            // 
            btnOverdueList.BackColor = Color.FromArgb(45, 110, 163);
            btnOverdueList.FlatStyle = FlatStyle.Flat;
            btnOverdueList.ForeColor = SystemColors.ButtonFace;
            btnOverdueList.Location = new Point(248, 81);
            btnOverdueList.Name = "btnOverdueList";
            btnOverdueList.Size = new Size(75, 23);
            btnOverdueList.TabIndex = 1;
            btnOverdueList.Text = "Overdue List";
            btnOverdueList.UseVisualStyleBackColor = false;
            // 
            // btnCurrentLoans
            // 
            btnCurrentLoans.BackColor = Color.FromArgb(45, 110, 163);
            btnCurrentLoans.FlatStyle = FlatStyle.Flat;
            btnCurrentLoans.ForeColor = SystemColors.ButtonHighlight;
            btnCurrentLoans.Location = new Point(136, 81);
            btnCurrentLoans.Name = "btnCurrentLoans";
            btnCurrentLoans.Size = new Size(75, 23);
            btnCurrentLoans.TabIndex = 1;
            btnCurrentLoans.Text = "Current Loans";
            btnCurrentLoans.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 110);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 2;
            label3.Text = "Overdue Books List";
            // 
            // dgvReports
            // 
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { BookID, MemberID, DueDate });
            dgvReports.Location = new Point(23, 134);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersVisible = false;
            dgvReports.Size = new Size(566, 253);
            dgvReports.TabIndex = 3;
            // 
            // BookID
            // 
            BookID.HeaderText = "BookID";
            BookID.Name = "BookID";
            // 
            // MemberID
            // 
            MemberID.HeaderText = "MemberID";
            MemberID.Name = "MemberID";
            // 
            // DueDate
            // 
            DueDate.HeaderText = "DueDate";
            DueDate.Name = "DueDate";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Name = "Reports";
            Text = "Reports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogout;
        private Panel panelMenu;
        private Button btnSearch;
        private Button btnReports;
        private Button btnBorrowReturn;
        private Button btnUsers;
        private Button btnMembers;
        private Button btnBooks;
        private Panel panel2;
        private Button btnCurrentLoans;
        private Button btnOverdueList;
        private Button btnInventorySize;
        private Label label2;
        private DataGridView dgvReports;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn MemberID;
        private DataGridViewTextBoxColumn DueDate;
        private Label label3;
    }
}