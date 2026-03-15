using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class BorrowReturn : Form
    {
        public BorrowReturn()
        {
            InitializeComponent();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBorrowMemberId.Text))
            {
                MessageBox.Show("Please enter Member ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBorrowMemberId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBorrowBookId.Text))
            {
                MessageBox.Show("Please enter Book ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBorrowBookId.Focus();
                return;
            }

            // TODO: integrate with library backend to create issue record
            MessageBox.Show($"Book '{txtBorrowBookId.Text}' issued to member '{txtBorrowMemberId.Text}' on {dtpBorrowDate.Value:d}.", "Issue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // clear inputs
            txtBorrowMemberId.Text = string.Empty;
            txtBorrowBookId.Text = string.Empty;
            dtpBorrowDate.Value = DateTime.Now;
        }

        private void btnProcessReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReturnMemberId.Text))
            {
                MessageBox.Show("Please enter Member ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReturnMemberId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReturnBookId.Text))
            {
                MessageBox.Show("Please enter Book ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReturnBookId.Focus();
                return;
            }

            // TODO: integrate with library backend to process return and fines
            MessageBox.Show($"Book '{txtReturnBookId.Text}' returned by member '{txtReturnMemberId.Text}' on {dtpReturnDate.Value:d}.", "Return Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtReturnMemberId.Text = string.Empty;
            txtReturnBookId.Text = string.Empty;
            dtpReturnDate.Value = DateTime.Now;
        }
    }
}
