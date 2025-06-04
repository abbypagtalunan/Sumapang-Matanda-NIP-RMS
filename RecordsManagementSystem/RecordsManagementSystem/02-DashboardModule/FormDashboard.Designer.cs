
namespace RecordsManagementSystem
{
    partial class FormDashboard
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonLogout = new FontAwesome.Sharp.IconButton();
            this.iconButtonPatient = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.panelMenu.Controls.Add(this.iconButtonLogout);
            this.panelMenu.Controls.Add(this.iconButtonPatient);
            this.panelMenu.Controls.Add(this.iconButtonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 759);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonLogout
            // 
            this.iconButtonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonLogout.FlatAppearance.BorderSize = 0;
            this.iconButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButtonLogout.IconColor = System.Drawing.Color.White;
            this.iconButtonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogout.IconSize = 32;
            this.iconButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogout.Location = new System.Drawing.Point(0, 304);
            this.iconButtonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonLogout.Name = "iconButtonLogout";
            this.iconButtonLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonLogout.Size = new System.Drawing.Size(250, 60);
            this.iconButtonLogout.TabIndex = 3;
            this.iconButtonLogout.Text = "Log Out";
            this.iconButtonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogout.UseVisualStyleBackColor = true;
            this.iconButtonLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // iconButtonPatient
            // 
            this.iconButtonPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonPatient.FlatAppearance.BorderSize = 0;
            this.iconButtonPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPatient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPatient.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconButtonPatient.IconColor = System.Drawing.Color.White;
            this.iconButtonPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPatient.IconSize = 32;
            this.iconButtonPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPatient.Location = new System.Drawing.Point(0, 244);
            this.iconButtonPatient.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonPatient.Name = "iconButtonPatient";
            this.iconButtonPatient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonPatient.Size = new System.Drawing.Size(250, 60);
            this.iconButtonPatient.TabIndex = 2;
            this.iconButtonPatient.Text = "Add Patient";
            this.iconButtonPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPatient.UseVisualStyleBackColor = true;
            this.iconButtonPatient.Click += new System.EventHandler(this.iconButtonPatient_Click);
            // 
            // iconButtonDashboard
            // 
            this.iconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboard.FlatAppearance.BorderSize = 0;
            this.iconButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButtonDashboard.IconColor = System.Drawing.Color.White;
            this.iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDashboard.IconSize = 32;
            this.iconButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 184);
            this.iconButtonDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonDashboard.Size = new System.Drawing.Size(250, 60);
            this.iconButtonDashboard.TabIndex = 1;
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashboard.UseVisualStyleBackColor = true;
            this.iconButtonDashboard.Click += new System.EventHandler(this.iconButtonDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(250, 184);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::RecordsManagementSystem.Properties.Resources.brgyLogo;
            this.btnHome.Location = new System.Drawing.Point(13, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(224, 172);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDashboard.Location = new System.Drawing.Point(250, 0);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(943, 759);
            this.PanelDashboard.TabIndex = 1;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 759);
            this.Controls.Add(this.PanelDashboard);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.Text = "Records Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashboard_FormClosing);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private FontAwesome.Sharp.IconButton iconButtonPatient;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel PanelDashboard;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
    }
}

