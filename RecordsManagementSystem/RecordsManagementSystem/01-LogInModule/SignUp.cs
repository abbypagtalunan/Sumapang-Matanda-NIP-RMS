using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsManagementSystem
{
    public partial class SignUp : UserControl
    {
        readonly PatientRecordsManagementSystemEntities db;
        private string empName, empCode, empPW, pwRetype;
        private string encryptedPW;

        public SignUp()
        {
            InitializeComponent();
            db = new PatientRecordsManagementSystemEntities();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            SHA256 sha = SHA256.Create();
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(empPW));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            encryptedPW = sb.ToString();
            //ADD TO DATABASE
            var user = new UsersTable
                {
                    EmpName = empName,
                    EmpCode = empCode,
                    EmpPassword = encryptedPW,
                };
                db.UsersTables.Add(user);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Account Created!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Account Failed to create.");
                }
                this.Hide();
        }

        private void validatePassword()
        {
            if (empPW.Equals(pwRetype))
            {
                txtb_password.BackColor = Color.FromArgb(13, 65, 71);
                txtb_retypePassword.BackColor = Color.FromArgb(13, 65, 71);
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(txtb_password, "Fields does not match");
                errorProvider.SetError(txtb_retypePassword, "Fields does not match");
            }
        }

        private void btnCreateAcc_MouseEnter(object sender, EventArgs e)
        {
            //INPUT VALIDATION
            TextBox[] textbox = {txtb_employeeName, txtb_employeeCode, txtb_password, txtb_retypePassword};

            foreach (TextBox t in textbox)
            {
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    enableDisableButton(btnCreateAcc, "disable");
                    errorProvider.SetError(t, "Required field.");
                }
            }

            if (!string.IsNullOrWhiteSpace(txtb_password.Text) && !string.IsNullOrWhiteSpace(txtb_retypePassword.Text))
            {
                validatePassword();
            }
        }

        private void txtb_employeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_employeeName, e);
        }

        private void txtb_employeeName_Leave(object sender, EventArgs e)
        {
            this.empName = txtValIsInputEmpty(txtb_employeeName, empName);
        }

        private void txtb_employeeCode_Leave(object sender, EventArgs e)
        {
            this.empCode = txtValIsInputEmpty(txtb_employeeCode, empCode);
        }

        private void txtb_password_Leave(object sender, EventArgs e)
        {
            this.empPW = txtValIsInputEmpty(txtb_password, empPW);
        }

        private void txtb_retypePassword_Leave(object sender, EventArgs e)
        {
            this.pwRetype = txtValIsInputEmpty(txtb_retypePassword, pwRetype);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            hidePassword(btnView, txtb_password);
        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            hidePassword(btnView2, txtb_retypePassword);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            viewPassword(btnHide, txtb_password);
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            viewPassword(btnHide2, txtb_retypePassword);
        }

        //MASK AND UNMASK PASSWORD
        private void viewPassword(Button btnToFront, TextBox txtBox)
        {
            if (txtBox.PasswordChar.Equals('●'))
            {
                txtBox.UseSystemPasswordChar = false;
                btnToFront.BringToFront();
            }
        }

        private void hidePassword(Button btnToFront, TextBox txtBox)
        {
            if (!txtBox.PasswordChar.Equals('●'))
            {
                txtBox.UseSystemPasswordChar = true;
                btnToFront.BringToFront();
            }
        }

        private void enableDisableButton(Button btn, string action)
        {
            switch (action)
            {
                case "disable":
                    btn.Enabled = false;
                    btn.BackColor = Color.DarkSlateGray;
                    break;
                case "enable":
                    btn.Enabled = true;
                    btn.BackColor = Color.DarkTurquoise;
                    break;
            }
        }

        private string txtValIsInputEmpty(TextBox txtBox, string data)
        {
            var input = txtBox.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(input))
            {
                errorProvider.SetError(txtBox, "Required field");
                enableDisableButton(btnCreateAcc, "disable");
                txtBox.BackColor = Color.Maroon;
                MessageBox.Show("Input required field.");
                txtBox.BackColor = Color.FromArgb(13, 65, 71);
            }
            else
            {
                txtBox.BackColor = Color.FromArgb(13, 65, 71);
                enableDisableButton(btnCreateAcc, "enable");
                errorProvider.Clear();
                data = input;
            }
            errorProvider.Clear();
            return data;
        }

        protected void txtValDisallowNumbers(TextBox txtBox, KeyPressEventArgs e)
        {

            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals(Keys.Space) && !char.IsWhiteSpace(e.KeyChar))
            {
                if (char.IsDigit(e.KeyChar))
                {
                    errorProvider.SetError(txtBox, "Numeric values not allowed");
                    txtBox.BackColor = Color.Maroon;
                    txtBox.Focus();
                }
                else if (char.IsSymbol(e.KeyChar))
                {
                    errorProvider.SetError(txtBox, "Symbols are not allowed");
                    txtBox.BackColor = Color.Maroon;
                    txtBox.Focus();
                }
            }
            else
            {
                errorProvider.Clear();
                txtBox.BackColor = Color.FromArgb(13, 65, 71);
            }
        }
    }
}
