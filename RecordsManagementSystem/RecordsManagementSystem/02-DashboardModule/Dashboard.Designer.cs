
namespace RecordsManagementSystem
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTotalPatient = new System.Windows.Forms.Panel();
            this.totalPatientsIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblNumTotalPatient = new System.Windows.Forms.Label();
            this.lblTotalPatient = new System.Windows.Forms.Label();
            this.panelTotalDoses = new System.Windows.Forms.Panel();
            this.totalDosesIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblNumTotalDoses = new System.Windows.Forms.Label();
            this.lblTotalDoses = new System.Windows.Forms.Label();
            this.panelIncoming2ndDose = new System.Windows.Forms.Panel();
            this.SecondDoseIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblNumIncoming2ndDose = new System.Windows.Forms.Label();
            this.lblIncoming2ndDose = new System.Windows.Forms.Label();
            this.LabelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGrid_dashboard = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IconVacRec = new System.Windows.Forms.DataGridViewImageColumn();
            this.IconInfoVac = new System.Windows.Forms.DataGridViewImageColumn();
            this.IconDelRec = new System.Windows.Forms.DataGridViewImageColumn();
            this.patientRecordsManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientRecordsManagementSystemDataSet = new RecordsManagementSystem.PatientRecordsManagementSystemDataSet();
            this.ptntDeleteRecord = new System.Windows.Forms.DataGridViewImageColumn();
            this.ptntInfoRecord = new System.Windows.Forms.DataGridViewImageColumn();
            this.ptntVacRecord = new System.Windows.Forms.DataGridViewImageColumn();
            this.ptntInfoRecordsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ptntInfoRecordsTableTableAdapter = new RecordsManagementSystem.PatientRecordsManagementSystemDataSetTableAdapters.PtntInfoRecordsTableTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.panelTotalPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPatientsIcon)).BeginInit();
            this.panelTotalDoses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalDosesIcon)).BeginInit();
            this.panelIncoming2ndDose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDoseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptntInfoRecordsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTotalPatient
            // 
            this.panelTotalPatient.BackColor = System.Drawing.Color.Black;
            this.panelTotalPatient.Controls.Add(this.totalPatientsIcon);
            this.panelTotalPatient.Controls.Add(this.lblNumTotalPatient);
            this.panelTotalPatient.Controls.Add(this.lblTotalPatient);
            this.panelTotalPatient.Location = new System.Drawing.Point(40, 11);
            this.panelTotalPatient.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotalPatient.Name = "panelTotalPatient";
            this.panelTotalPatient.Size = new System.Drawing.Size(193, 95);
            this.panelTotalPatient.TabIndex = 3;
            // 
            // totalPatientsIcon
            // 
            this.totalPatientsIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalPatientsIcon.ForeColor = System.Drawing.Color.Aqua;
            this.totalPatientsIcon.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.totalPatientsIcon.IconColor = System.Drawing.Color.Aqua;
            this.totalPatientsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.totalPatientsIcon.IconSize = 39;
            this.totalPatientsIcon.Location = new System.Drawing.Point(18, 6);
            this.totalPatientsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.totalPatientsIcon.Name = "totalPatientsIcon";
            this.totalPatientsIcon.Size = new System.Drawing.Size(41, 39);
            this.totalPatientsIcon.TabIndex = 6;
            this.totalPatientsIcon.TabStop = false;
            // 
            // lblNumTotalPatient
            // 
            this.lblNumTotalPatient.AutoSize = true;
            this.lblNumTotalPatient.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTotalPatient.ForeColor = System.Drawing.Color.White;
            this.lblNumTotalPatient.Location = new System.Drawing.Point(13, 58);
            this.lblNumTotalPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTotalPatient.Name = "lblNumTotalPatient";
            this.lblNumTotalPatient.Size = new System.Drawing.Size(30, 32);
            this.lblNumTotalPatient.TabIndex = 1;
            this.lblNumTotalPatient.Text = "0";
            // 
            // lblTotalPatient
            // 
            this.lblTotalPatient.AutoSize = true;
            this.lblTotalPatient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatient.ForeColor = System.Drawing.Color.White;
            this.lblTotalPatient.Location = new System.Drawing.Point(15, 43);
            this.lblTotalPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPatient.Name = "lblTotalPatient";
            this.lblTotalPatient.Size = new System.Drawing.Size(117, 18);
            this.lblTotalPatient.TabIndex = 0;
            this.lblTotalPatient.Text = "TOTAL PATIENTS";
            // 
            // panelTotalDoses
            // 
            this.panelTotalDoses.BackColor = System.Drawing.Color.Black;
            this.panelTotalDoses.Controls.Add(this.totalDosesIcon);
            this.panelTotalDoses.Controls.Add(this.lblNumTotalDoses);
            this.panelTotalDoses.Controls.Add(this.lblTotalDoses);
            this.panelTotalDoses.Location = new System.Drawing.Point(256, 11);
            this.panelTotalDoses.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotalDoses.Name = "panelTotalDoses";
            this.panelTotalDoses.Size = new System.Drawing.Size(193, 95);
            this.panelTotalDoses.TabIndex = 8;
            // 
            // totalDosesIcon
            // 
            this.totalDosesIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalDosesIcon.ForeColor = System.Drawing.Color.Aqua;
            this.totalDosesIcon.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.totalDosesIcon.IconColor = System.Drawing.Color.Aqua;
            this.totalDosesIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.totalDosesIcon.IconSize = 39;
            this.totalDosesIcon.Location = new System.Drawing.Point(18, 6);
            this.totalDosesIcon.Margin = new System.Windows.Forms.Padding(2);
            this.totalDosesIcon.Name = "totalDosesIcon";
            this.totalDosesIcon.Size = new System.Drawing.Size(41, 39);
            this.totalDosesIcon.TabIndex = 6;
            this.totalDosesIcon.TabStop = false;
            // 
            // lblNumTotalDoses
            // 
            this.lblNumTotalDoses.AutoSize = true;
            this.lblNumTotalDoses.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTotalDoses.ForeColor = System.Drawing.Color.White;
            this.lblNumTotalDoses.Location = new System.Drawing.Point(13, 58);
            this.lblNumTotalDoses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTotalDoses.Name = "lblNumTotalDoses";
            this.lblNumTotalDoses.Size = new System.Drawing.Size(30, 32);
            this.lblNumTotalDoses.TabIndex = 1;
            this.lblNumTotalDoses.Text = "0";
            // 
            // lblTotalDoses
            // 
            this.lblTotalDoses.AutoSize = true;
            this.lblTotalDoses.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoses.ForeColor = System.Drawing.Color.White;
            this.lblTotalDoses.Location = new System.Drawing.Point(5, 43);
            this.lblTotalDoses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDoses.Name = "lblTotalDoses";
            this.lblTotalDoses.Size = new System.Drawing.Size(186, 18);
            this.lblTotalDoses.TabIndex = 0;
            this.lblTotalDoses.Text = "VACCINE ADMINISTERED";
            // 
            // panelIncoming2ndDose
            // 
            this.panelIncoming2ndDose.BackColor = System.Drawing.Color.Black;
            this.panelIncoming2ndDose.Controls.Add(this.SecondDoseIcon);
            this.panelIncoming2ndDose.Controls.Add(this.lblNumIncoming2ndDose);
            this.panelIncoming2ndDose.Controls.Add(this.lblIncoming2ndDose);
            this.panelIncoming2ndDose.Location = new System.Drawing.Point(470, 11);
            this.panelIncoming2ndDose.Margin = new System.Windows.Forms.Padding(2);
            this.panelIncoming2ndDose.Name = "panelIncoming2ndDose";
            this.panelIncoming2ndDose.Size = new System.Drawing.Size(193, 95);
            this.panelIncoming2ndDose.TabIndex = 9;
            // 
            // SecondDoseIcon
            // 
            this.SecondDoseIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecondDoseIcon.ForeColor = System.Drawing.Color.Aqua;
            this.SecondDoseIcon.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.SecondDoseIcon.IconColor = System.Drawing.Color.Aqua;
            this.SecondDoseIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SecondDoseIcon.IconSize = 39;
            this.SecondDoseIcon.Location = new System.Drawing.Point(18, 6);
            this.SecondDoseIcon.Margin = new System.Windows.Forms.Padding(2);
            this.SecondDoseIcon.Name = "SecondDoseIcon";
            this.SecondDoseIcon.Size = new System.Drawing.Size(41, 39);
            this.SecondDoseIcon.TabIndex = 6;
            this.SecondDoseIcon.TabStop = false;
            // 
            // lblNumIncoming2ndDose
            // 
            this.lblNumIncoming2ndDose.AutoSize = true;
            this.lblNumIncoming2ndDose.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumIncoming2ndDose.ForeColor = System.Drawing.Color.White;
            this.lblNumIncoming2ndDose.Location = new System.Drawing.Point(13, 58);
            this.lblNumIncoming2ndDose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumIncoming2ndDose.Name = "lblNumIncoming2ndDose";
            this.lblNumIncoming2ndDose.Size = new System.Drawing.Size(30, 32);
            this.lblNumIncoming2ndDose.TabIndex = 1;
            this.lblNumIncoming2ndDose.Text = "0";
            // 
            // lblIncoming2ndDose
            // 
            this.lblIncoming2ndDose.AutoSize = true;
            this.lblIncoming2ndDose.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncoming2ndDose.ForeColor = System.Drawing.Color.White;
            this.lblIncoming2ndDose.Location = new System.Drawing.Point(15, 43);
            this.lblIncoming2ndDose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncoming2ndDose.Name = "lblIncoming2ndDose";
            this.lblIncoming2ndDose.Size = new System.Drawing.Size(168, 18);
            this.lblIncoming2ndDose.TabIndex = 0;
            this.lblIncoming2ndDose.Text = "INCOMING 2ND DOSE";
            // 
            // LabelToolTip
            // 
            this.LabelToolTip.AutomaticDelay = 0;
            this.LabelToolTip.BackColor = System.Drawing.Color.DarkCyan;
            this.LabelToolTip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // dataGrid_dashboard
            // 
            this.dataGrid_dashboard.AllowUserToAddRows = false;
            this.dataGrid_dashboard.AllowUserToDeleteRows = false;
            this.dataGrid_dashboard.AllowUserToResizeColumns = false;
            this.dataGrid_dashboard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dataGrid_dashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_dashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.dataGrid_dashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_dashboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_dashboard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_dashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_dashboard.ColumnHeadersHeight = 30;
            this.dataGrid_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_dashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconVacRec,
            this.IconInfoVac,
            this.IconDelRec});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_dashboard.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_dashboard.DoubleBuffered = true;
            this.dataGrid_dashboard.EnableHeadersVisualStyles = false;
            this.dataGrid_dashboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.dataGrid_dashboard.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.dataGrid_dashboard.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(205)))));
            this.dataGrid_dashboard.Location = new System.Drawing.Point(40, 118);
            this.dataGrid_dashboard.Margin = new System.Windows.Forms.Padding(10);
            this.dataGrid_dashboard.Name = "dataGrid_dashboard";
            this.dataGrid_dashboard.ReadOnly = true;
            this.dataGrid_dashboard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_dashboard.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_dashboard.RowHeadersVisible = false;
            this.dataGrid_dashboard.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            this.dataGrid_dashboard.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_dashboard.RowTemplate.Height = 24;
            this.dataGrid_dashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_dashboard.Size = new System.Drawing.Size(623, 343);
            this.dataGrid_dashboard.TabIndex = 11;
            this.dataGrid_dashboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_dashboard_CellContentClick);
            this.dataGrid_dashboard.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid_dashboard_CellFormatting);
            // 
            // IconVacRec
            // 
            this.IconVacRec.HeaderText = "";
            this.IconVacRec.Image = global::RecordsManagementSystem.Properties.Resources.syringe;
            this.IconVacRec.Name = "IconVacRec";
            this.IconVacRec.ReadOnly = true;
            this.IconVacRec.ToolTipText = "View Vaccine Record";
            this.IconVacRec.Width = 213;
            // 
            // IconInfoVac
            // 
            this.IconInfoVac.HeaderText = "";
            this.IconInfoVac.Image = global::RecordsManagementSystem.Properties.Resources.record;
            this.IconInfoVac.Name = "IconInfoVac";
            this.IconInfoVac.ReadOnly = true;
            this.IconInfoVac.ToolTipText = "View Information Record";
            this.IconInfoVac.Width = 212;
            // 
            // IconDelRec
            // 
            this.IconDelRec.HeaderText = "";
            this.IconDelRec.Image = global::RecordsManagementSystem.Properties.Resources.delete;
            this.IconDelRec.Name = "IconDelRec";
            this.IconDelRec.ReadOnly = true;
            this.IconDelRec.ToolTipText = "Delete Record";
            this.IconDelRec.Width = 213;
            // 
            // patientRecordsManagementSystemDataSetBindingSource
            // 
            this.patientRecordsManagementSystemDataSetBindingSource.DataSource = this.patientRecordsManagementSystemDataSet;
            this.patientRecordsManagementSystemDataSetBindingSource.Position = 0;
            // 
            // patientRecordsManagementSystemDataSet
            // 
            this.patientRecordsManagementSystemDataSet.DataSetName = "PatientRecordsManagementSystemDataSet";
            this.patientRecordsManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ptntDeleteRecord
            // 
            this.ptntDeleteRecord.HeaderText = "";
            this.ptntDeleteRecord.Image = global::RecordsManagementSystem.Properties.Resources.delete;
            this.ptntDeleteRecord.Name = "ptntDeleteRecord";
            this.ptntDeleteRecord.Width = 20;
            // 
            // ptntInfoRecord
            // 
            this.ptntInfoRecord.HeaderText = "";
            this.ptntInfoRecord.Image = global::RecordsManagementSystem.Properties.Resources.record;
            this.ptntInfoRecord.Name = "ptntInfoRecord";
            this.ptntInfoRecord.Width = 20;
            // 
            // ptntVacRecord
            // 
            this.ptntVacRecord.HeaderText = "";
            this.ptntVacRecord.Image = global::RecordsManagementSystem.Properties.Resources.syringe;
            this.ptntVacRecord.Name = "ptntVacRecord";
            this.ptntVacRecord.Width = 20;
            // 
            // ptntInfoRecordsTableBindingSource
            // 
            this.ptntInfoRecordsTableBindingSource.DataMember = "PtntInfoRecordsTable";
            this.ptntInfoRecordsTableBindingSource.DataSource = this.patientRecordsManagementSystemDataSetBindingSource;
            // 
            // ptntInfoRecordsTableTableAdapter
            // 
            this.ptntInfoRecordsTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRefreshGrid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefreshGrid.FlatAppearance.BorderSize = 0;
            this.btnRefreshGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshGrid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshGrid.ForeColor = System.Drawing.Color.White;
            this.btnRefreshGrid.Location = new System.Drawing.Point(587, 466);
            this.btnRefreshGrid.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(76, 30);
            this.btnRefreshGrid.TabIndex = 14;
            this.btnRefreshGrid.Text = "REFRESH";
            this.btnRefreshGrid.UseVisualStyleBackColor = false;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 2000;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RecordsManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnRefreshGrid);
            this.Controls.Add(this.dataGrid_dashboard);
            this.Controls.Add(this.panelIncoming2ndDose);
            this.Controls.Add(this.panelTotalDoses);
            this.Controls.Add(this.panelTotalPatient);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(709, 618);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelTotalPatient.ResumeLayout(false);
            this.panelTotalPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPatientsIcon)).EndInit();
            this.panelTotalDoses.ResumeLayout(false);
            this.panelTotalDoses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalDosesIcon)).EndInit();
            this.panelIncoming2ndDose.ResumeLayout(false);
            this.panelIncoming2ndDose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDoseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptntInfoRecordsTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalPatient;
        private FontAwesome.Sharp.IconPictureBox totalPatientsIcon;
        public System.Windows.Forms.Label lblNumTotalPatient;
        private System.Windows.Forms.Label lblTotalPatient;
        private System.Windows.Forms.Panel panelTotalDoses;
        private FontAwesome.Sharp.IconPictureBox totalDosesIcon;
        public System.Windows.Forms.Label lblNumTotalDoses;
        private System.Windows.Forms.Label lblTotalDoses;
        private System.Windows.Forms.Panel panelIncoming2ndDose;
        private FontAwesome.Sharp.IconPictureBox SecondDoseIcon;
        public System.Windows.Forms.Label lblNumIncoming2ndDose;
        private System.Windows.Forms.Label lblIncoming2ndDose;
        private System.Windows.Forms.ToolTip LabelToolTip;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid_dashboard;
        private System.Windows.Forms.DataGridViewImageColumn ptntVacRecord;
        private System.Windows.Forms.DataGridViewImageColumn ptntInfoRecord;
        private System.Windows.Forms.DataGridViewImageColumn ptntDeleteRecord;
        private PatientRecordsManagementSystemDataSet patientRecordsManagementSystemDataSet;
        private System.Windows.Forms.BindingSource patientRecordsManagementSystemDataSetBindingSource;
        private System.Windows.Forms.BindingSource ptntInfoRecordsTableBindingSource;
        private PatientRecordsManagementSystemDataSetTableAdapters.PtntInfoRecordsTableTableAdapter ptntInfoRecordsTableTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewImageColumn IconVacRec;
        private System.Windows.Forms.DataGridViewImageColumn IconInfoVac;
        private System.Windows.Forms.DataGridViewImageColumn IconDelRec;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.Timer timerRefresh;
    }
}
