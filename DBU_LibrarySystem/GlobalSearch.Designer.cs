namespace DBU_LibrarySystem
{
    partial class GlobalSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button btnBookMgmt;
        private System.Windows.Forms.Button btnMemberMgmt;
        private System.Windows.Forms.Button btnUserMgmt;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSearchNav;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblGlobalSearch;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Panel panelCard;

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
            headerPanel = new System.Windows.Forms.Panel();
            titleLabel = new System.Windows.Forms.Label();
            sidebarPanel = new System.Windows.Forms.Panel();
            btnBookMgmt = new System.Windows.Forms.Button();
            btnMemberMgmt = new System.Windows.Forms.Button();
            btnUserMgmt = new System.Windows.Forms.Button();
            btnBorrowReturn = new System.Windows.Forms.Button();
            btnReports = new System.Windows.Forms.Button();
            btnSearchNav = new System.Windows.Forms.Button();
            mainPanel = new System.Windows.Forms.Panel();
            lblGlobalSearch = new System.Windows.Forms.Label();
            groupSearch = new System.Windows.Forms.GroupBox();
            txtSearch = new System.Windows.Forms.TextBox();
            cmbSearchType = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvResults = new System.Windows.Forms.DataGridView();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = System.Drawing.Color.FromArgb(48, 136, 186);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Height = 56;
            headerPanel.Controls.Add(titleLabel);
            // 
            // titleLabel
            // 
            titleLabel.Text = "DBU Library | Admin Console";
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            titleLabel.Location = new System.Drawing.Point(12, 16);
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = System.Drawing.Color.White;
            sidebarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            sidebarPanel.Location = new System.Drawing.Point(12, 72);
            sidebarPanel.Size = new System.Drawing.Size(200, 360);
            // 
            // nav buttons
            // 
            btnBookMgmt.Text = "Book Management";
            btnBookMgmt.Size = new System.Drawing.Size(176, 36);
            btnBookMgmt.Location = new System.Drawing.Point(12, 12);
            btnMemberMgmt.Text = "Member Management";
            btnMemberMgmt.Size = new System.Drawing.Size(176, 36);
            btnMemberMgmt.Location = new System.Drawing.Point(12, 56);
            btnUserMgmt.Text = "User Management";
            btnUserMgmt.Size = new System.Drawing.Size(176, 36);
            btnUserMgmt.Location = new System.Drawing.Point(12, 100);
            btnBorrowReturn.Text = "Borrow/Return";
            btnBorrowReturn.Size = new System.Drawing.Size(176, 36);
            btnBorrowReturn.Location = new System.Drawing.Point(12, 144);
            btnReports.Text = "Reports";
            btnReports.Size = new System.Drawing.Size(176, 36);
            btnReports.Location = new System.Drawing.Point(12, 188);
            btnSearchNav.Text = "Search";
            btnSearchNav.Size = new System.Drawing.Size(176, 36);
            btnSearchNav.Location = new System.Drawing.Point(12, 232);
            btnSearchNav.BackColor = System.Drawing.Color.FromArgb(64, 143, 186);
            btnSearchNav.ForeColor = System.Drawing.Color.White;
            sidebarPanel.Controls.AddRange(new System.Windows.Forms.Control[] { btnBookMgmt, btnMemberMgmt, btnUserMgmt, btnBorrowReturn, btnReports, btnSearchNav });
            // 
            // mainPanel
            // 
            mainPanel.Location = new System.Drawing.Point(228, 72);
            mainPanel.Size = new System.Drawing.Size(848, 360);
            mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            // content card to mimic the screenshot's white card
            panelCard = new System.Windows.Forms.Panel();
            panelCard.Location = new System.Drawing.Point(12, 8);
            panelCard.Size = new System.Drawing.Size(824, 344);
            panelCard.BackColor = System.Drawing.Color.White;
            panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblGlobalSearch
            // 
            lblGlobalSearch.Text = "Global Search";
            lblGlobalSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGlobalSearch.Location = new System.Drawing.Point(20, 16);
            lblGlobalSearch.AutoSize = true;
            // 
            // groupSearch
            // 
            groupSearch.Text = string.Empty;
            groupSearch.Location = new System.Drawing.Point(20, 52);
            groupSearch.Size = new System.Drawing.Size(784, 84);
            // 
            // txtSearch
            // 
            txtSearch.PlaceholderText = "Search for books or members..";
            txtSearch.Location = new System.Drawing.Point(16, 18);
            txtSearch.Width = 420;
            // 
            // cmbSearchType
            // 
            cmbSearchType.Location = new System.Drawing.Point(452, 18);
            cmbSearchType.Width = 200;
            cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSearchType.Items.AddRange(new object[] { "Books by Title", "Books by Author", "Members by Name" });
            cmbSearchType.SelectedIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Text = "Search";
            btnSearch.Location = new System.Drawing.Point(668, 16);
            btnSearch.Size = new System.Drawing.Size(120, 32);
            btnSearch.BackColor = System.Drawing.Color.FromArgb(48, 136, 186);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            groupSearch.Controls.AddRange(new System.Windows.Forms.Control[] { txtSearch, cmbSearchType, btnSearch });
            // 
            // dgvResults
            // 
            dgvResults.Location = new System.Drawing.Point(20, 148);
            dgvResults.Size = new System.Drawing.Size(784, 176);
            dgvResults.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.AllowUserToAddRows = false;
            dgvResults.ReadOnly = true;
            // 
            // assemble
            // 
            // place the content inside the white card
            panelCard.Controls.AddRange(new System.Windows.Forms.Control[] { lblGlobalSearch, groupSearch, dgvResults });
            mainPanel.Controls.Add(panelCard);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 506);
            this.Controls.Add(headerPanel);
            this.Controls.Add(sidebarPanel);
            this.Controls.Add(mainPanel);
            this.Name = "GlobalSearch";
            this.Text = "GlobalSearch";
            ResumeLayout(false);
        }

        #endregion
    }
}