namespace DBU_LibrarySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txt_Username = new TextBox();
            label3 = new Label();
            txt_Password = new TextBox();
            btn_Login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(536, 38);
            label1.TabIndex = 0;
            label1.Text = "Login into Library Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 134);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Username.Location = new Point(135, 134);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(300, 39);
            txt_Username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 186);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Password.Location = new Point(135, 186);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(300, 39);
            txt_Password.TabIndex = 2;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.MenuHighlight;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = SystemColors.Window;
            btn_Login.Location = new Point(38, 250);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(397, 34);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login to Portal";
            btn_Login.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(578, 444);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "DBU Library System | Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txt_Username;
        private Label label3;
        private TextBox txt_Password;
        private Button btn_Login;
    }
}
