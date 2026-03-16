namespace DBU_LibrarySystem
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnBookManagement;
        private System.Windows.Forms.Button btnMemberManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnBorrowReturnNav;
        private System.Windows.Forms.Button btnReportsNav;
        private System.Windows.Forms.Button btnSearchNav;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnCurrentLoans;
        private System.Windows.Forms.Button btnOverdueList;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.DataGridView dgvOverdue;

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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnCurrentLoans = new System.Windows.Forms.Button();
            this.btnOverdueList = new System.Windows.Forms.Button();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnLogout);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Text = "DBU Library | Admin Console";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Location = new System.Drawing.Point(620, 20);
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(800, 15);
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.Text = "Logout";
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 1;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Width = 200;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            // navigation buttons
            this.btnBookManagement = new System.Windows.Forms.Button();
            this.btnMemberManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnBorrowReturnNav = new System.Windows.Forms.Button();
            this.btnReportsNav = new System.Windows.Forms.Button();
            this.btnSearchNav = new System.Windows.Forms.Button();

            // common nav style
            System.Drawing.Size navSize = new System.Drawing.Size(180, 48);
            System.Windows.Forms.Padding navPadding = new System.Windows.Forms.Padding(12, 0, 0, 0);

            // btnBookManagement
            this.btnBookManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookManagement.Height = navSize.Height;
            this.btnBookManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookManagement.FlatAppearance.BorderSize = 0;
            this.btnBookManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManagement.Padding = navPadding;
            this.btnBookManagement.Text = "Book Management";
            // btnMemberManagement
            this.btnMemberManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberManagement.Height = navSize.Height;
            this.btnMemberManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberManagement.FlatAppearance.BorderSize = 0;
            this.btnMemberManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberManagement.Padding = navPadding;
            this.btnMemberManagement.Text = "Member Management";
            // btnUserManagement
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.Height = navSize.Height;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Padding = navPadding;
            this.btnUserManagement.Text = "User Management";
            // btnBorrowReturnNav
            this.btnBorrowReturnNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowReturnNav.Height = navSize.Height;
            this.btnBorrowReturnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowReturnNav.FlatAppearance.BorderSize = 0;
            this.btnBorrowReturnNav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowReturnNav.Padding = navPadding;
            this.btnBorrowReturnNav.Text = "Borrow/Return";
            // btnReportsNav (selected)
            this.btnReportsNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportsNav.Height = navSize.Height;
            this.btnReportsNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportsNav.FlatAppearance.BorderSize = 0;
            this.btnReportsNav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportsNav.Padding = navPadding;
            this.btnReportsNav.Text = "Reports";
            this.btnReportsNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.btnReportsNav.ForeColor = System.Drawing.Color.White;
            // btnSearchNav (bottom)
            this.btnSearchNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchNav.Height = navSize.Height;
            this.btnSearchNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchNav.FlatAppearance.BorderSize = 0;
            this.btnSearchNav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchNav.Padding = navPadding;
            this.btnSearchNav.Text = "Search";

            // add nav buttons in order
            this.panelLeft.Controls.Add(this.btnSearchNav);
            this.panelLeft.Controls.Add(this.btnReportsNav);
            this.panelLeft.Controls.Add(this.btnBorrowReturnNav);
            this.panelLeft.Controls.Add(this.btnUserManagement);
            this.panelLeft.Controls.Add(this.btnMemberManagement);
            this.panelLeft.Controls.Add(this.btnBookManagement);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblSectionTitle);
            this.panelMain.Controls.Add(this.btnInventory);
            this.panelMain.Controls.Add(this.btnCurrentLoans);
            this.panelMain.Controls.Add(this.btnOverdueList);
            this.panelMain.Controls.Add(this.dgvOverdue);
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSectionTitle.Location = new System.Drawing.Point(10, 10);
            this.lblSectionTitle.Text = "Library Reports";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(10, 50);
            this.btnInventory.Size = new System.Drawing.Size(120, 30);
            this.btnInventory.Text = "Inventory Size";
            // 
            // btnCurrentLoans
            // 
            this.btnCurrentLoans.Location = new System.Drawing.Point(140, 50);
            this.btnCurrentLoans.Size = new System.Drawing.Size(120, 30);
            this.btnCurrentLoans.Text = "Current Loans";
            // 
            // btnOverdueList
            // 
            this.btnOverdueList.Location = new System.Drawing.Point(270, 50);
            this.btnOverdueList.Size = new System.Drawing.Size(120, 30);
            this.btnOverdueList.Text = "Overdue List";
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.Location = new System.Drawing.Point(10, 100);
            this.dgvOverdue.Size = new System.Drawing.Size(560, 300);
            this.dgvOverdue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOverdue.AllowUserToAddRows = false;
            this.dgvOverdue.AllowUserToDeleteRows = false;
            this.dgvOverdue.ReadOnly = true;
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // Add columns
            this.dgvOverdue.Columns.Add("BookID", "Book ID");
            this.dgvOverdue.Columns.Add("MemberID", "Member ID");
            this.dgvOverdue.Columns.Add("DueDate", "Due Date");
            // sample rows
            this.dgvOverdue.Rows.Add(new object[] { "1", "2", "2026-01-27" });
            this.dgvOverdue.Rows.Add(new object[] { "3", "1501713", "2026-01-28" });
            this.dgvOverdue.Rows.Add(new object[] { "4", "2", "2026-02-18" });
            // 
            // Reports (form)
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}