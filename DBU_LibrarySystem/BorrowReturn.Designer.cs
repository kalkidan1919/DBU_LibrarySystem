namespace DBU_LibrarySystem
{
    partial class BorrowReturn
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
            headerPanel = new Panel();
            titleLabel = new Label();
            sidebarPanel = new Panel();
            btnBookMgmt = new Button();
            btnMemberMgmt = new Button();
            btnUserMgmt = new Button();
            btnBorrowReturn = new Button();
            btnReports = new Button();
            btnSearch = new Button();
            mainPanel = new Panel();
            lblCirculationServices = new Label();
            groupBorrow = new GroupBox();
            txtBorrowMemberId = new TextBox();
            txtBorrowBookId = new TextBox();
            dtpBorrowDate = new DateTimePicker();
            btnIssueBook = new Button();
            groupReturn = new GroupBox();
            txtReturnMemberId = new TextBox();
            txtReturnBookId = new TextBox();
            dtpReturnDate = new DateTimePicker();
            btnProcessReturn = new Button();
            headerPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            groupBorrow.SuspendLayout();
            groupReturn.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(48, 136, 186);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1098, 56);
            headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(12, 16);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(100, 23);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "DBU Library | Admin Console";
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.White;
            sidebarPanel.BorderStyle = BorderStyle.FixedSingle;
            sidebarPanel.Controls.Add(btnBookMgmt);
            sidebarPanel.Controls.Add(btnMemberMgmt);
            sidebarPanel.Controls.Add(btnUserMgmt);
            sidebarPanel.Controls.Add(btnBorrowReturn);
            sidebarPanel.Controls.Add(btnReports);
            sidebarPanel.Controls.Add(btnSearch);
            sidebarPanel.Location = new Point(12, 72);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(201, 351);
            sidebarPanel.TabIndex = 1;
            // 
            // btnBookMgmt
            // 
            btnBookMgmt.Location = new Point(12, 12);
            btnBookMgmt.Name = "btnBookMgmt";
            btnBookMgmt.Size = new Size(176, 36);
            btnBookMgmt.TabIndex = 0;
            btnBookMgmt.Text = "Book Management";
            // 
            // btnMemberMgmt
            // 
            btnMemberMgmt.Location = new Point(12, 56);
            btnMemberMgmt.Name = "btnMemberMgmt";
            btnMemberMgmt.Size = new Size(176, 36);
            btnMemberMgmt.TabIndex = 1;
            btnMemberMgmt.Text = "Member Management";
            // 
            // btnUserMgmt
            // 
            btnUserMgmt.Location = new Point(12, 100);
            btnUserMgmt.Name = "btnUserMgmt";
            btnUserMgmt.Size = new Size(176, 36);
            btnUserMgmt.TabIndex = 2;
            btnUserMgmt.Text = "User Management";
            // 
            // btnBorrowReturn
            // 
            btnBorrowReturn.BackColor = Color.FromArgb(64, 143, 186);
            btnBorrowReturn.ForeColor = Color.White;
            btnBorrowReturn.Location = new Point(12, 144);
            btnBorrowReturn.Name = "btnBorrowReturn";
            btnBorrowReturn.Size = new Size(176, 36);
            btnBorrowReturn.TabIndex = 3;
            btnBorrowReturn.Text = "Borrow/Return";
            btnBorrowReturn.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(12, 188);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(176, 36);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 232);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(176, 36);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.Controls.Add(lblCirculationServices);
            mainPanel.Controls.Add(groupBorrow);
            mainPanel.Controls.Add(groupReturn);
            mainPanel.Location = new Point(228, 72);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(848, 360);
            mainPanel.TabIndex = 2;
            // 
            // lblCirculationServices
            // 
            lblCirculationServices.AutoSize = true;
            lblCirculationServices.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCirculationServices.Location = new Point(12, 12);
            lblCirculationServices.Name = "lblCirculationServices";
            lblCirculationServices.Size = new Size(186, 25);
            lblCirculationServices.TabIndex = 0;
            lblCirculationServices.Text = "Circulation Services";
            // 
            // groupBorrow
            // 
            groupBorrow.Controls.Add(txtBorrowMemberId);
            groupBorrow.Controls.Add(txtBorrowBookId);
            groupBorrow.Controls.Add(dtpBorrowDate);
            groupBorrow.Controls.Add(btnIssueBook);
            groupBorrow.Location = new Point(12, 48);
            groupBorrow.Name = "groupBorrow";
            groupBorrow.Size = new Size(404, 260);
            groupBorrow.TabIndex = 1;
            groupBorrow.TabStop = false;
            groupBorrow.Text = "Borrow Book";
            // 
            // txtBorrowMemberId
            // 
            txtBorrowMemberId.Location = new Point(16, 28);
            txtBorrowMemberId.Name = "txtBorrowMemberId";
            txtBorrowMemberId.PlaceholderText = "Member ID";
            txtBorrowMemberId.Size = new Size(360, 23);
            txtBorrowMemberId.TabIndex = 0;
            // 
            // txtBorrowBookId
            // 
            txtBorrowBookId.Location = new Point(16, 68);
            txtBorrowBookId.Name = "txtBorrowBookId";
            txtBorrowBookId.PlaceholderText = "Book ID";
            txtBorrowBookId.Size = new Size(360, 23);
            txtBorrowBookId.TabIndex = 1;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Format = DateTimePickerFormat.Short;
            dtpBorrowDate.Location = new Point(16, 108);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(200, 23);
            dtpBorrowDate.TabIndex = 2;
            // 
            // btnIssueBook
            // 
            btnIssueBook.BackColor = Color.FromArgb(48, 136, 186);
            btnIssueBook.FlatStyle = FlatStyle.Flat;
            btnIssueBook.ForeColor = Color.White;
            btnIssueBook.Location = new Point(16, 152);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(360, 36);
            btnIssueBook.TabIndex = 3;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = false;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // groupReturn
            // 
            groupReturn.Controls.Add(txtReturnMemberId);
            groupReturn.Controls.Add(txtReturnBookId);
            groupReturn.Controls.Add(dtpReturnDate);
            groupReturn.Controls.Add(btnProcessReturn);
            groupReturn.Location = new Point(428, 48);
            groupReturn.Name = "groupReturn";
            groupReturn.Size = new Size(404, 260);
            groupReturn.TabIndex = 2;
            groupReturn.TabStop = false;
            groupReturn.Text = "Return Book";
            // 
            // txtReturnMemberId
            // 
            txtReturnMemberId.Location = new Point(16, 28);
            txtReturnMemberId.Name = "txtReturnMemberId";
            txtReturnMemberId.PlaceholderText = "Member ID";
            txtReturnMemberId.Size = new Size(360, 23);
            txtReturnMemberId.TabIndex = 0;
            // 
            // txtReturnBookId
            // 
            txtReturnBookId.Location = new Point(16, 68);
            txtReturnBookId.Name = "txtReturnBookId";
            txtReturnBookId.PlaceholderText = "Book ID";
            txtReturnBookId.Size = new Size(360, 23);
            txtReturnBookId.TabIndex = 1;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(16, 108);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(200, 23);
            dtpReturnDate.TabIndex = 2;
            // 
            // btnProcessReturn
            // 
            btnProcessReturn.BackColor = Color.FromArgb(48, 136, 186);
            btnProcessReturn.FlatStyle = FlatStyle.Flat;
            btnProcessReturn.ForeColor = Color.White;
            btnProcessReturn.Location = new Point(16, 152);
            btnProcessReturn.Name = "btnProcessReturn";
            btnProcessReturn.Size = new Size(360, 36);
            btnProcessReturn.TabIndex = 3;
            btnProcessReturn.Text = "Process Return";
            btnProcessReturn.UseVisualStyleBackColor = false;
            btnProcessReturn.Click += btnProcessReturn_Click;
            // 
            // BorrowReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 506);
            Controls.Add(headerPanel);
            Controls.Add(sidebarPanel);
            Controls.Add(mainPanel);
            Name = "BorrowReturn";
            Text = "BorrowReturn";
            headerPanel.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            groupBorrow.ResumeLayout(false);
            groupBorrow.PerformLayout();
            groupReturn.ResumeLayout(false);
            groupReturn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button btnBookMgmt;
        private System.Windows.Forms.Button btnMemberMgmt;
        private System.Windows.Forms.Button btnUserMgmt;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblCirculationServices;
        private System.Windows.Forms.GroupBox groupBorrow;
        private System.Windows.Forms.TextBox txtBorrowMemberId;
        private System.Windows.Forms.TextBox txtBorrowBookId;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.GroupBox groupReturn;
        private System.Windows.Forms.TextBox txtReturnMemberId;
        private System.Windows.Forms.TextBox txtReturnBookId;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btnProcessReturn;
    }
}