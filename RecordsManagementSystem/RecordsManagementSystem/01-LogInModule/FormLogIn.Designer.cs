
namespace RecordsManagementSystem
{
    partial class FormLogIn
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
            this.components = new System.ComponentModel.Container();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelLog = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.linkLbl_ResetPW = new System.Windows.Forms.LinkLabel();
            this.lblForgotPW = new System.Windows.Forms.Label();
            this.linklblSignUp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.txtb_employeeCode = new System.Windows.Forms.TextBox();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.lblEMPLOYEELOGIN = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::RecordsManagementSystem.Properties.Resources.brgyLogo;
            this.Logo.ErrorImage = null;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(53, 19);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(404, 332);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // PanelLog
            // 
            this.PanelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.PanelLog.Controls.Add(this.btnView);
            this.PanelLog.Controls.Add(this.linkLbl_ResetPW);
            this.PanelLog.Controls.Add(this.lblForgotPW);
            this.PanelLog.Controls.Add(this.linklblSignUp);
            this.PanelLog.Controls.Add(this.label1);
            this.PanelLog.Controls.Add(this.lblPassword);
            this.PanelLog.Controls.Add(this.panel1);
            this.PanelLog.Controls.Add(this.panel2);
            this.PanelLog.Controls.Add(this.btnLogin);
            this.PanelLog.Controls.Add(this.txtb_password);
            this.PanelLog.Controls.Add(this.txtb_employeeCode);
            this.PanelLog.Controls.Add(this.lblEmployeeCode);
            this.PanelLog.Controls.Add(this.lblEMPLOYEELOGIN);
            this.PanelLog.Controls.Add(this.btnHide);
            this.PanelLog.Location = new System.Drawing.Point(454, 68);
            this.PanelLog.Margin = new System.Windows.Forms.Padding(2);
            this.PanelLog.Name = "PanelLog";
            this.PanelLog.Size = new System.Drawing.Size(368, 496);
            this.PanelLog.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.btnView.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnView.Image = global::RecordsManagementSystem.Properties.Resources.view;
            this.btnView.Location = new System.Drawing.Point(296, 267);
            this.btnView.Margin = new System.Windows.Forms.Padding(0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(25, 25);
            this.btnView.TabIndex = 56;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // linkLbl_ResetPW
            // 
            this.linkLbl_ResetPW.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkLbl_ResetPW.AutoSize = true;
            this.linkLbl_ResetPW.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_ResetPW.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLbl_ResetPW.Location = new System.Drawing.Point(179, 302);
            this.linkLbl_ResetPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLbl_ResetPW.Name = "linkLbl_ResetPW";
            this.linkLbl_ResetPW.Size = new System.Drawing.Size(72, 16);
            this.linkLbl_ResetPW.TabIndex = 55;
            this.linkLbl_ResetPW.TabStop = true;
            this.linkLbl_ResetPW.Text = "Reset here.";
            this.linkLbl_ResetPW.VisitedLinkColor = System.Drawing.Color.Teal;
            this.linkLbl_ResetPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_ResetPW_LinkClicked);
            // 
            // lblForgotPW
            // 
            this.lblForgotPW.AutoSize = true;
            this.lblForgotPW.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPW.ForeColor = System.Drawing.SystemColors.Control;
            this.lblForgotPW.Location = new System.Drawing.Point(44, 302);
            this.lblForgotPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPW.Name = "lblForgotPW";
            this.lblForgotPW.Size = new System.Drawing.Size(140, 16);
            this.lblForgotPW.TabIndex = 54;
            this.lblForgotPW.Text = "Forgot your password?";
            // 
            // linklblSignUp
            // 
            this.linklblSignUp.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linklblSignUp.AutoSize = true;
            this.linklblSignUp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linklblSignUp.Location = new System.Drawing.Point(218, 388);
            this.linklblSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblSignUp.Name = "linklblSignUp";
            this.linklblSignUp.Size = new System.Drawing.Size(38, 16);
            this.linklblSignUp.TabIndex = 53;
            this.linklblSignUp.TabStop = true;
            this.linklblSignUp.Text = "here.";
            this.linklblSignUp.VisitedLinkColor = System.Drawing.Color.Teal;
            this.linklblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSignUp_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(106, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Create an account";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(42, 242);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 17);
            this.lblPassword.TabIndex = 51;
            this.lblPassword.Text = "PASSWORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(45, 298);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 2);
            this.panel1.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(45, 206);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 2);
            this.panel2.TabIndex = 49;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(205)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(205)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(126, 345);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 37);
            this.btnLogin.TabIndex = 48;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            // 
            // txtb_password
            // 
            this.txtb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.txtb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_password.ForeColor = System.Drawing.Color.White;
            this.txtb_password.Location = new System.Drawing.Point(45, 275);
            this.txtb_password.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.Size = new System.Drawing.Size(280, 23);
            this.txtb_password.TabIndex = 47;
            this.txtb_password.UseSystemPasswordChar = true;
            this.txtb_password.Leave += new System.EventHandler(this.txtb_password_Leave);
            // 
            // txtb_employeeCode
            // 
            this.txtb_employeeCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.txtb_employeeCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_employeeCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_employeeCode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_employeeCode.ForeColor = System.Drawing.Color.White;
            this.txtb_employeeCode.Location = new System.Drawing.Point(45, 183);
            this.txtb_employeeCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_employeeCode.Name = "txtb_employeeCode";
            this.txtb_employeeCode.Size = new System.Drawing.Size(280, 23);
            this.txtb_employeeCode.TabIndex = 46;
            this.txtb_employeeCode.Leave += new System.EventHandler(this.txtb_employeeCode_Leave);
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCode.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmployeeCode.Location = new System.Drawing.Point(42, 152);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(120, 17);
            this.lblEmployeeCode.TabIndex = 45;
            this.lblEmployeeCode.Text = "EMPLOYEE CODE";
            // 
            // lblEMPLOYEELOGIN
            // 
            this.lblEMPLOYEELOGIN.AutoSize = true;
            this.lblEMPLOYEELOGIN.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMPLOYEELOGIN.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEMPLOYEELOGIN.Location = new System.Drawing.Point(58, 93);
            this.lblEMPLOYEELOGIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEMPLOYEELOGIN.Name = "lblEMPLOYEELOGIN";
            this.lblEMPLOYEELOGIN.Size = new System.Drawing.Size(267, 37);
            this.lblEMPLOYEELOGIN.TabIndex = 44;
            this.lblEMPLOYEELOGIN.Text = "EMPLOYEE LOGIN";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.btnHide.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHide.Image = global::RecordsManagementSystem.Properties.Resources.hide;
            this.btnHide.Location = new System.Drawing.Point(296, 267);
            this.btnHide.Margin = new System.Windows.Forms.Padding(0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(25, 25);
            this.btnHide.TabIndex = 57;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Image = global::RecordsManagementSystem.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(14, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.TabIndex = 58;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RecordsManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 617);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.PanelLog);
            this.Controls.Add(this.Logo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelLog.ResumeLayout(false);
            this.PanelLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel PanelLog;
        private System.Windows.Forms.LinkLabel linklblSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.TextBox txtb_employeeCode;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblEMPLOYEELOGIN;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.LinkLabel linkLbl_ResetPW;
        private System.Windows.Forms.Label lblForgotPW;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnBack;
    }
}