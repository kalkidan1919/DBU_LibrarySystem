namespace DBU_LibrarySystem
{
    partial class MemberManagement
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Panel panelMenu;
        private Panel panelMain;
        private Panel panel1;

        private Label lblTitle;
        private Label lblConsole;
        private Label lblWelcome;
        private Label lblAdmin;

        private Label lblUserAuth;
        private Label lblNote;
        private Label label1;

        private Button btnLogout;
        private Button btnBook;
        private Button btnMember;
        private Button btnUser;
        private Button btnBorrow;
        private Button btnReports;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnCreateAccount;

        private ComboBox cmbRole;
        private TextBox txtPassword;
        private TextBox txtUsername;

        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Username;
        private ColumnHeader Role;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblConsole = new Label();
            lblWelcome = new Label();
            lblAdmin = new Label();
            btnLogout = new Button();
            panelMenu = new Panel();
            btnBook = new Button();
            btnMember = new Button();
            btnUser = new Button();
            btnBorrow = new Button();
            btnReports = new Button();
            btnSearch = new Button();
            panelMain = new Panel();
            lblUserAuth = new Label();
            lblNote = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnCreateAccount = new Button();
            btnRefresh = new Button();
            listView1 = new ListView();
            ID = new ColumnHeader();
            Username = new ColumnHeader();
            Role = new ColumnHeader();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblConsole);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblAdmin);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DBU Library";
            // 
            // lblConsole
            // 
            lblConsole.ForeColor = Color.White;
            lblConsole.Location = new Point(170, 27);
            lblConsole.Name = "lblConsole";
            lblConsole.Size = new Size(128, 23);
            lblConsole.TabIndex = 1;
            lblConsole.Text = "| Admin Console";
            // 
            // lblWelcome
            // 
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(760, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(74, 23);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome";
            // 
            // lblAdmin
            // 
            lblAdmin.ForeColor = Color.White;
            lblAdmin.Location = new Point(830, 25);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(100, 23);
            lblAdmin.TabIndex = 3;
            lblAdmin.Text = ", Admin";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(940, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.WhiteSmoke;
            panelMenu.Controls.Add(btnBook);
            panelMenu.Controls.Add(btnMember);
            panelMenu.Controls.Add(btnUser);
            panelMenu.Controls.Add(btnBorrow);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnSearch);
            panelMenu.Location = new Point(20, 100);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 293);
            panelMenu.TabIndex = 1;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(20, 20);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(160, 35);
            btnBook.TabIndex = 0;
            btnBook.Text = "Book Management";
            // 
            // btnMember
            // 
            btnMember.Location = new Point(20, 60);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(160, 59);
            btnMember.TabIndex = 1;
            btnMember.Text = "Member Management";
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.SteelBlue;
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(20, 125);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(160, 35);
            btnUser.TabIndex = 2;
            btnUser.Text = "User Management";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(20, 165);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(160, 35);
            btnBorrow.TabIndex = 3;
            btnBorrow.Text = "Borrow / Return";
            // 
            // btnReports
            // 
            btnReports.Location = new Point(20, 205);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(160, 35);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(20, 245);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 35);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Controls.Add(lblUserAuth);
            panelMain.Controls.Add(lblNote);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(btnRefresh);
            panelMain.Controls.Add(listView1);
            panelMain.Location = new Point(250, 100);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 430);
            panelMain.TabIndex = 2;
            // 
            // lblUserAuth
            // 
            lblUserAuth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserAuth.Location = new Point(20, 20);
            lblUserAuth.Name = "lblUserAuth";
            lblUserAuth.Size = new Size(353, 35);
            lblUserAuth.TabIndex = 0;
            lblUserAuth.Text = "User Authentication Management";
            // 
            // lblNote
            // 
            lblNote.Location = new Point(20, 60);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(740, 40);
            lblNote.TabIndex = 1;
            lblNote.Text = "NOTE:- Use this section to create \"Login Accounts\" for students and employees can log in to thier portals. For students, the \"Username must match thrir memner ID\".";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(btnCreateAccount);
            panel1.Location = new Point(20, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 130);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Create Login Account";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(15, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 40);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 2;
            // 
            // cmbRole
            // 
            cmbRole.Items.AddRange(new object[] { "Employee", "Student" });
            cmbRole.Location = new Point(450, 40);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 28);
            cmbRole.TabIndex = 3;
            cmbRole.Text = "Employee";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.SteelBlue;
            btnCreateAccount.Location = new Point(15, 80);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(200, 30);
            btnCreateAccount.TabIndex = 4;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.Location = new Point(20, 260);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(151, 33);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh User List";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Username, Role });
            listView1.Dock = DockStyle.Bottom;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 310);
            listView1.Name = "listView1";
            listView1.Size = new Size(800, 120);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 100;
            // 
            // Username
            // 
            Username.Text = "Username";
            Username.Width = 400;
            // 
            // Role
            // 
            Role.Text = "Role";
            Role.Width = 300;
            // 
            // MemberManagement
            // 
            ClientSize = new Size(1100, 550);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Controls.Add(panelMain);
            Name = "MemberManagement";
            Text = "DBU Library Admin";
            panelHeader.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
    }
}