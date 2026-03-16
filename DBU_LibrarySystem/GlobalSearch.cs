using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class GlobalSearch : Form
    {
        public GlobalSearch()
        {
            InitializeComponent();
            SeedSampleData();
            txtSearch.KeyDown += TxtSearch_KeyDown;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = txtSearch.Text?.Trim();
            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a search term.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            dgvResults.Columns.Clear();
            dgvResults.Rows.Clear();

            var type = cmbSearchType.SelectedItem?.ToString();
            if (type == "Books by Title")
            {
                dgvResults.Columns.Add("isbn", "ISBN");
                dgvResults.Columns.Add("title", "Title");
                dgvResults.Columns.Add("author", "Author");
                var matches = books.FindAll(b => b.Title?.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
                foreach (var b in matches)
                    dgvResults.Rows.Add(b.ISBN, b.Title, b.Author);
            }
            else if (type == "Books by Author")
            {
                dgvResults.Columns.Add("isbn", "ISBN");
                dgvResults.Columns.Add("title", "Title");
                dgvResults.Columns.Add("author", "Author");
                var matches = books.FindAll(b => b.Author?.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
                foreach (var b in matches)
                    dgvResults.Rows.Add(b.ISBN, b.Title, b.Author);
            }
            else if (type == "Members by Name")
            {
                dgvResults.Columns.Add("memberid", "Member ID");
                dgvResults.Columns.Add("name", "Name");
                dgvResults.Columns.Add("email", "Email");
                var matches = members.FindAll(m => m.Name?.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
                foreach (var m in matches)
                    dgvResults.Rows.Add(m.MemberId, m.Name, m.Email);
            }
            else
            {
                MessageBox.Show("Unknown search type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnSearch_Click(this, EventArgs.Empty);
            }
        }

        private class Book
        {
            public string ISBN { get; set; } = string.Empty;
            public string Title { get; set; } = string.Empty;
            public string Author { get; set; } = string.Empty;
        }

        private class Member
        {
            public string MemberId { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
        }

        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        private void SeedSampleData()
        {
            books.Add(new Book { ISBN = "978-1", Title = "C# Programming", Author = "Alice" });
            books.Add(new Book { ISBN = "978-2", Title = "Advanced C#", Author = "Bob" });
            books.Add(new Book { ISBN = "978-3", Title = "Learn .NET", Author = "Carol" });

            members.Add(new Member { MemberId = "M001", Name = "John Doe", Email = "john@example.com" });
            members.Add(new Member { MemberId = "M002", Name = "Jane Smith", Email = "jane@example.com" });
        }
    }
}
