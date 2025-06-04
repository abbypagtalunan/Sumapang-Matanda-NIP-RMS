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
    public partial class FormLogIn : Form
    {
        static FormLogIn obj;
        readonly PatientRecordsManagementSystemEntities db;
        private string empCode, password, encryptedPW;

        public FormLogIn()
        {
            InitializeComponent();
            db = new PatientRecordsManagementSystemEntities();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            obj = this;
            this.ActiveControl = lblEmployeeCode;
            txtb_employeeCode.Text = "";
            txtb_password.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ENCRYPTION OF USER PASSWORD
            SHA256 sha = SHA256.Create();
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            encryptedPW = sb.ToString();

            var user = db.UsersTables.FirstOrDefault(u => u.EmpCode == empCode);
            if (encryptedPW != user.EmpPassword)
            {
                errorProvider.SetError(txtb_password, "You have entered your password incorrectly. Please try again.");
                enableDisableButton(btnLogin, "disable");
            }
            else
            {
                MessageBox.Show("Login Successful!");
                this.Close();
                FormDashboard fd = new FormDashboard();
                fd.Show();
            }  
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            //INPUT VALIDATION
            if (string.IsNullOrWhiteSpace(txtb_employeeCode.Text))
            {
                errorProvider.SetError(txtb_employeeCode, "Input required field.");
                enableDisableButton(btnLogin, "disable");
            }

            if (string.IsNullOrWhiteSpace(txtb_password.Text))
            {
                errorProvider.SetError(txtb_password, "Input required field.");
                enableDisableButton(btnLogin, "disable");
            }

            var user = db.UsersTables.FirstOrDefault(u => u.EmpCode == empCode);
            //IF USER DOES NOT EXIST, ALERT TO CREATE AN ACCOUNT
            if (user == null && !string.IsNullOrWhiteSpace(txtb_password.Text) && !string.IsNullOrWhiteSpace(txtb_employeeCode.Text))
            {
                DialogResult dr = MessageBox.Show("Employee code does not exist. Would you like to create an employee acount?", "User employee does not exist.", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SignUp su = new SignUp
                    {
                        Dock = DockStyle.Fill
                    };
                    FormLogIn.Instance.PnlLogIn.Controls.Add(su);
                    FormLogIn.Instance.PnlLogIn.Controls["SignUp"].BringToFront();
                }
                else
                {
                    txtb_employeeCode.Text = "";
                    txtb_employeeCode.Focus();
                    txtb_password.Text = "";
                }
            }
        }

        private void linkLbl_ResetPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TRIGGER RESET PASSWORD FORM PASSING THE USER NAME AND EMPLOYEE CODE
            var user = db.UsersTables.FirstOrDefault(u => u.EmpCode == empCode);
            if(user == null)
            {
                ResetPassword reset = new ResetPassword()
                {
                    Dock = DockStyle.Fill
                };
                FormLogIn.Instance.PnlLogIn.Controls.Add(reset);
                FormLogIn.Instance.PnlLogIn.Controls["ResetPassword"].BringToFront();
            }
            else
            {
                ResetPassword reset = new ResetPassword()
                {
                    Dock = DockStyle.Fill
                };
                FormLogIn.Instance.PnlLogIn.Controls.Add(reset);
                FormLogIn.Instance.PnlLogIn.Controls["ResetPassword"].BringToFront();
            }
        }

        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp
            {
                Dock = DockStyle.Fill
            };
            FormLogIn.Instance.PnlLogIn.Controls.Add(su);
            FormLogIn.Instance.PnlLogIn.Controls["SignUp"].BringToFront();
        }

        //MASK AND UNMASK PASSWORD
        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtb_password.PasswordChar.Equals('●'))
            {
                txtb_password.UseSystemPasswordChar = false;
                btnHide.BringToFront();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (!txtb_password.PasswordChar.Equals('●'))
            {
                txtb_password.UseSystemPasswordChar = true;
                btnView.BringToFront();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn login = new FormLogIn();
            login.Show();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn login = new FormLogIn();
            login.Show();
        }

        private void txtb_employeeCode_Leave(object sender, EventArgs e)
        {
            this.empCode = txtValIsInputEmpty(txtb_employeeCode, empCode);
        }

        private void txtb_password_Leave(object sender, EventArgs e)
        {
            this.password = txtValIsInputEmpty(txtb_password, password);
        }

        private string txtValIsInputEmpty(TextBox txtBox, string data)
        {
            var input = txtBox.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(input))
            {
                errorProvider.SetError(txtBox, "Required field");
                enableDisableButton(btnLogin, "disable");
                txtBox.BackColor = Color.Maroon;
                MessageBox.Show("Input required field.");
                txtBox.BackColor = Color.FromArgb(13, 65, 71);
            }
            else
            {
                enableDisableButton(btnLogin, "enable");
                errorProvider.Clear();
                data = input;
            }
            errorProvider.Clear();
            return data;
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
                    btn.BackColor = Color.FromArgb(50, 194, 205);
                    break;
            }
        }

        public static FormLogIn Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new FormLogIn();
                }
                return obj;
            }
        }

        public Panel PnlLogIn
        {
            get { return PanelLog; }
            set { PanelLog = value; }
        }

        public Button BtnSignUp
        {
            get { return BtnSignUp; }
            set { BtnSignUp = value; }
        }

        public object SystemPasswordChar { get; private set; }
    }
}
