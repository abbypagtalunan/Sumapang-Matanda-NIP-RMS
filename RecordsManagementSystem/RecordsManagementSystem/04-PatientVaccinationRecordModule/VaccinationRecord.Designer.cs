
namespace RecordsManagementSystem
{
    partial class VaccinationRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelVaccinationRecordTitle = new System.Windows.Forms.Panel();
            this.ShieldIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblVACCINATIONRECORD = new System.Windows.Forms.Label();
            this.lbl_PatientName = new System.Windows.Forms.Label();
            this.lbl_ptntname = new System.Windows.Forms.Label();
            this.panelAddVaccineTitle = new System.Windows.Forms.Panel();
            this.lblError_AddVac = new System.Windows.Forms.Label();
            this.lblError_VacRecord = new System.Windows.Forms.Label();
            this.SyringeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblADDVACCINE = new System.Windows.Forms.Label();
            this.panelNewVaccineInfo = new System.Windows.Forms.Panel();
            this.lbl2nddosedate = new System.Windows.Forms.Label();
            this.lbl1stdosedate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnewvaccine = new System.Windows.Forms.Label();
            this.btnUpdateVaccineRecord = new System.Windows.Forms.Button();
            this.dataGrid_vacRecord = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IconDelRec = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddVaccineRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtb_lotNumber = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClearFields = new System.Windows.Forms.Button();
            this.cmbVaccine = new RecordsManagementSystem.ComboBox2();
            this.datePicker_date2ndDose = new RecordsManagementSystem.DateTimePicker2();
            this.datePicker_date1stDose = new RecordsManagementSystem.DateTimePicker2();
            this.panelVaccinationRecordTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShieldIcon)).BeginInit();
            this.panelAddVaccineTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyringeIcon)).BeginInit();
            this.panelNewVaccineInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_vacRecord)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVaccinationRecordTitle
            // 
            this.panelVaccinationRecordTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelVaccinationRecordTitle.Controls.Add(this.ShieldIcon);
            this.panelVaccinationRecordTitle.Controls.Add(this.lblVACCINATIONRECORD);
            this.panelVaccinationRecordTitle.Location = new System.Drawing.Point(-15, 36);
            this.panelVaccinationRecordTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelVaccinationRecordTitle.Name = "panelVaccinationRecordTitle";
            this.panelVaccinationRecordTitle.Size = new System.Drawing.Size(724, 46);
            this.panelVaccinationRecordTitle.TabIndex = 1;
            // 
            // ShieldIcon
            // 
            this.ShieldIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShieldIcon.ForeColor = System.Drawing.Color.Aqua;
            this.ShieldIcon.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.ShieldIcon.IconColor = System.Drawing.Color.Aqua;
            this.ShieldIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ShieldIcon.IconSize = 39;
            this.ShieldIcon.Location = new System.Drawing.Point(43, 2);
            this.ShieldIcon.Margin = new System.Windows.Forms.Padding(2);
            this.ShieldIcon.Name = "ShieldIcon";
            this.ShieldIcon.Size = new System.Drawing.Size(41, 39);
            this.ShieldIcon.TabIndex = 7;
            this.ShieldIcon.TabStop = false;
            // 
            // lblVACCINATIONRECORD
            // 
            this.lblVACCINATIONRECORD.AutoSize = true;
            this.lblVACCINATIONRECORD.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVACCINATIONRECORD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVACCINATIONRECORD.Location = new System.Drawing.Point(88, 8);
            this.lblVACCINATIONRECORD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVACCINATIONRECORD.Name = "lblVACCINATIONRECORD";
            this.lblVACCINATIONRECORD.Size = new System.Drawing.Size(381, 38);
            this.lblVACCINATIONRECORD.TabIndex = 8;
            this.lblVACCINATIONRECORD.Text = "VACCINATION RECORD";
            // 
            // lbl_PatientName
            // 
            this.lbl_PatientName.AutoSize = true;
            this.lbl_PatientName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PatientName.Font = new System.Drawing.Font("Century Gothic", 16.5F, System.Drawing.FontStyle.Bold);
            this.lbl_PatientName.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_PatientName.Location = new System.Drawing.Point(130, 92);
            this.lbl_PatientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PatientName.Name = "lbl_PatientName";
            this.lbl_PatientName.Size = new System.Drawing.Size(0, 26);
            this.lbl_PatientName.TabIndex = 6;
            // 
            // lbl_ptntname
            // 
            this.lbl_ptntname.AutoSize = true;
            this.lbl_ptntname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ptntname.Font = new System.Drawing.Font("Century Gothic", 16.5F, System.Drawing.FontStyle.Bold);
            this.lbl_ptntname.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_ptntname.Location = new System.Drawing.Point(33, 89);
            this.lbl_ptntname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ptntname.Name = "lbl_ptntname";
            this.lbl_ptntname.Size = new System.Drawing.Size(97, 26);
            this.lbl_ptntname.TabIndex = 5;
            this.lbl_ptntname.Text = "PATIENT:";
            // 
            // panelAddVaccineTitle
            // 
            this.panelAddVaccineTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelAddVaccineTitle.Controls.Add(this.lblError_AddVac);
            this.panelAddVaccineTitle.Controls.Add(this.lblError_VacRecord);
            this.panelAddVaccineTitle.Controls.Add(this.SyringeIcon);
            this.panelAddVaccineTitle.Controls.Add(this.lblADDVACCINE);
            this.panelAddVaccineTitle.Location = new System.Drawing.Point(-15, 330);
            this.panelAddVaccineTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelAddVaccineTitle.Name = "panelAddVaccineTitle";
            this.panelAddVaccineTitle.Size = new System.Drawing.Size(734, 31);
            this.panelAddVaccineTitle.TabIndex = 9;
            // 
            // lblError_AddVac
            // 
            this.lblError_AddVac.AutoSize = true;
            this.lblError_AddVac.BackColor = System.Drawing.Color.Transparent;
            this.lblError_AddVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblError_AddVac.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError_AddVac.Location = new System.Drawing.Point(486, 18);
            this.lblError_AddVac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError_AddVac.Name = "lblError_AddVac";
            this.lblError_AddVac.Size = new System.Drawing.Size(11, 16);
            this.lblError_AddVac.TabIndex = 54;
            this.lblError_AddVac.Text = " ";
            // 
            // lblError_VacRecord
            // 
            this.lblError_VacRecord.AutoSize = true;
            this.lblError_VacRecord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblError_VacRecord.ForeColor = System.Drawing.Color.Red;
            this.lblError_VacRecord.Location = new System.Drawing.Point(486, 33);
            this.lblError_VacRecord.Name = "lblError_VacRecord";
            this.lblError_VacRecord.Size = new System.Drawing.Size(0, 13);
            this.lblError_VacRecord.TabIndex = 18;
            // 
            // SyringeIcon
            // 
            this.SyringeIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SyringeIcon.ForeColor = System.Drawing.Color.Aqua;
            this.SyringeIcon.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.SyringeIcon.IconColor = System.Drawing.Color.Aqua;
            this.SyringeIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SyringeIcon.IconSize = 30;
            this.SyringeIcon.Location = new System.Drawing.Point(45, 2);
            this.SyringeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.SyringeIcon.Name = "SyringeIcon";
            this.SyringeIcon.Size = new System.Drawing.Size(30, 30);
            this.SyringeIcon.TabIndex = 7;
            this.SyringeIcon.TabStop = false;
            // 
            // lblADDVACCINE
            // 
            this.lblADDVACCINE.AutoSize = true;
            this.lblADDVACCINE.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADDVACCINE.ForeColor = System.Drawing.SystemColors.Control;
            this.lblADDVACCINE.Location = new System.Drawing.Point(74, 2);
            this.lblADDVACCINE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblADDVACCINE.Name = "lblADDVACCINE";
            this.lblADDVACCINE.Size = new System.Drawing.Size(313, 32);
            this.lblADDVACCINE.TabIndex = 8;
            this.lblADDVACCINE.Text = "ADD/UPDATE VACCINE";
            // 
            // panelNewVaccineInfo
            // 
            this.panelNewVaccineInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.panelNewVaccineInfo.Controls.Add(this.lbl2nddosedate);
            this.panelNewVaccineInfo.Controls.Add(this.lbl1stdosedate);
            this.panelNewVaccineInfo.Controls.Add(this.label6);
            this.panelNewVaccineInfo.Controls.Add(this.lblnewvaccine);
            this.panelNewVaccineInfo.Location = new System.Drawing.Point(0, 364);
            this.panelNewVaccineInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelNewVaccineInfo.Name = "panelNewVaccineInfo";
            this.panelNewVaccineInfo.Size = new System.Drawing.Size(709, 20);
            this.panelNewVaccineInfo.TabIndex = 10;
            // 
            // lbl2nddosedate
            // 
            this.lbl2nddosedate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2nddosedate.AutoSize = true;
            this.lbl2nddosedate.BackColor = System.Drawing.Color.Transparent;
            this.lbl2nddosedate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2nddosedate.ForeColor = System.Drawing.Color.White;
            this.lbl2nddosedate.Location = new System.Drawing.Point(528, 5);
            this.lbl2nddosedate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2nddosedate.Name = "lbl2nddosedate";
            this.lbl2nddosedate.Size = new System.Drawing.Size(116, 16);
            this.lbl2nddosedate.TabIndex = 11;
            this.lbl2nddosedate.Text = "DATE OF 2ND DOSE";
            this.lbl2nddosedate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1stdosedate
            // 
            this.lbl1stdosedate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1stdosedate.AutoSize = true;
            this.lbl1stdosedate.BackColor = System.Drawing.Color.Transparent;
            this.lbl1stdosedate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stdosedate.ForeColor = System.Drawing.Color.White;
            this.lbl1stdosedate.Location = new System.Drawing.Point(403, 5);
            this.lbl1stdosedate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1stdosedate.Name = "lbl1stdosedate";
            this.lbl1stdosedate.Size = new System.Drawing.Size(111, 16);
            this.lbl1stdosedate.TabIndex = 19;
            this.lbl1stdosedate.Text = "DATE OF 1ST DOSE";
            this.lbl1stdosedate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(283, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "LOT NUMBER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnewvaccine
            // 
            this.lblnewvaccine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnewvaccine.AutoSize = true;
            this.lblnewvaccine.BackColor = System.Drawing.Color.Transparent;
            this.lblnewvaccine.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewvaccine.ForeColor = System.Drawing.Color.White;
            this.lblnewvaccine.Location = new System.Drawing.Point(108, 5);
            this.lblnewvaccine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnewvaccine.Name = "lblnewvaccine";
            this.lblnewvaccine.Size = new System.Drawing.Size(62, 16);
            this.lblnewvaccine.TabIndex = 12;
            this.lblnewvaccine.Text = "VACCINE";
            this.lblnewvaccine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateVaccineRecord
            // 
            this.btnUpdateVaccineRecord.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdateVaccineRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateVaccineRecord.FlatAppearance.BorderSize = 0;
            this.btnUpdateVaccineRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVaccineRecord.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateVaccineRecord.ForeColor = System.Drawing.Color.White;
            this.btnUpdateVaccineRecord.Location = new System.Drawing.Point(494, 429);
            this.btnUpdateVaccineRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateVaccineRecord.Name = "btnUpdateVaccineRecord";
            this.btnUpdateVaccineRecord.Padding = new System.Windows.Forms.Padding(2);
            this.btnUpdateVaccineRecord.Size = new System.Drawing.Size(76, 30);
            this.btnUpdateVaccineRecord.TabIndex = 11;
            this.btnUpdateVaccineRecord.Text = "UPDATE";
            this.btnUpdateVaccineRecord.UseVisualStyleBackColor = false;
            this.btnUpdateVaccineRecord.Click += new System.EventHandler(this.btnUpdateVaccineRecord_Click);
            // 
            // dataGrid_vacRecord
            // 
            this.dataGrid_vacRecord.AllowUserToAddRows = false;
            this.dataGrid_vacRecord.AllowUserToDeleteRows = false;
            this.dataGrid_vacRecord.AllowUserToResizeColumns = false;
            this.dataGrid_vacRecord.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.dataGrid_vacRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_vacRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.dataGrid_vacRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_vacRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_vacRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_vacRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_vacRecord.ColumnHeadersHeight = 30;
            this.dataGrid_vacRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_vacRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconDelRec});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_vacRecord.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_vacRecord.DoubleBuffered = true;
            this.dataGrid_vacRecord.EnableHeadersVisualStyles = false;
            this.dataGrid_vacRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.dataGrid_vacRecord.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.dataGrid_vacRecord.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(205)))));
            this.dataGrid_vacRecord.Location = new System.Drawing.Point(56, 122);
            this.dataGrid_vacRecord.Margin = new System.Windows.Forms.Padding(10);
            this.dataGrid_vacRecord.Name = "dataGrid_vacRecord";
            this.dataGrid_vacRecord.ReadOnly = true;
            this.dataGrid_vacRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_vacRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid_vacRecord.RowHeadersVisible = false;
            this.dataGrid_vacRecord.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            this.dataGrid_vacRecord.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid_vacRecord.RowTemplate.Height = 24;
            this.dataGrid_vacRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_vacRecord.Size = new System.Drawing.Size(594, 201);
            this.dataGrid_vacRecord.TabIndex = 12;
            this.dataGrid_vacRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_vacRecord_CellClick);
            this.dataGrid_vacRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_vacRecord_CellContentClick);
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
            // btnAddVaccineRecord
            // 
            this.btnAddVaccineRecord.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddVaccineRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddVaccineRecord.FlatAppearance.BorderSize = 0;
            this.btnAddVaccineRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVaccineRecord.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddVaccineRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddVaccineRecord.Location = new System.Drawing.Point(414, 429);
            this.btnAddVaccineRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVaccineRecord.Name = "btnAddVaccineRecord";
            this.btnAddVaccineRecord.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddVaccineRecord.Size = new System.Drawing.Size(76, 30);
            this.btnAddVaccineRecord.TabIndex = 13;
            this.btnAddVaccineRecord.Text = "ADD";
            this.btnAddVaccineRecord.UseVisualStyleBackColor = false;
            this.btnAddVaccineRecord.Click += new System.EventHandler(this.btnAddVaccineRecord_Click);
            this.btnAddVaccineRecord.MouseEnter += new System.EventHandler(this.btnAddVaccineRecord_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.datePicker_date2ndDose);
            this.panel1.Controls.Add(this.datePicker_date1stDose);
            this.panel1.Controls.Add(this.txtb_lotNumber);
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 36);
            this.panel1.TabIndex = 33;
            // 
            // txtb_lotNumber
            // 
            this.txtb_lotNumber.BackColor = System.Drawing.Color.DarkCyan;
            this.txtb_lotNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_lotNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_lotNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_lotNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtb_lotNumber.Location = new System.Drawing.Point(241, 5);
            this.txtb_lotNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_lotNumber.Name = "txtb_lotNumber";
            this.txtb_lotNumber.Size = new System.Drawing.Size(146, 23);
            this.txtb_lotNumber.TabIndex = 4;
            this.txtb_lotNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_lotNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_lotNumber_KeyPress);
            this.txtb_lotNumber.Leave += new System.EventHandler(this.txtb_lotNumber_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnClearFields.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearFields.FlatAppearance.BorderSize = 0;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(574, 429);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Padding = new System.Windows.Forms.Padding(2);
            this.btnClearFields.Size = new System.Drawing.Size(76, 30);
            this.btnClearFields.TabIndex = 34;
            this.btnClearFields.Text = "CLEAR";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // cmbVaccine
            // 
            this.cmbVaccine.BackColor = System.Drawing.Color.DarkCyan;
            this.cmbVaccine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cmbVaccine.BorderSize = 0;
            this.cmbVaccine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVaccine.DropDownWidth = 194;
            this.cmbVaccine.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbVaccine.ForeColor = System.Drawing.Color.White;
            this.cmbVaccine.FormattingEnabled = true;
            this.cmbVaccine.ItemHeight = 16;
            this.cmbVaccine.Items.AddRange(new object[] {
            "Bacille Calmette-Guerin (BCG)",
            "Hepatatis B (HBV)",
            "Rotavirus (RV)",
            "Pneumococcal Conjugate (PCV)",
            "Influenza (TIV)",
            "Inactivated Poliovirus (IPV)",
            "Measles",
            "Japanese Encephalitis (JE)",
            "Measles-Mumps-Rubella (MMR)",
            "Varicella",
            "Hepatatis A (HAV)",
            "Human Papillomavirus (HPV)",
            "Tetanus and Diptheria Toxoid (Td)"});
            this.cmbVaccine.Location = new System.Drawing.Point(38, 394);
            this.cmbVaccine.Name = "cmbVaccine";
            this.cmbVaccine.Size = new System.Drawing.Size(194, 24);
            this.cmbVaccine.SkinColor = System.Drawing.Color.DarkCyan;
            this.cmbVaccine.TabIndex = 32;
            this.cmbVaccine.TextColor = System.Drawing.SystemColors.Info;
            this.cmbVaccine.DropDownClosed += new System.EventHandler(this.cmbVaccine_DropDownClosed);
            // 
            // datePicker_date2ndDose
            // 
            this.datePicker_date2ndDose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker_date2ndDose.BorderSize = 0;
            this.datePicker_date2ndDose.CustomFormat = "MM/dd/yyyy";
            this.datePicker_date2ndDose.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datePicker_date2ndDose.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_date2ndDose.Location = new System.Drawing.Point(522, 4);
            this.datePicker_date2ndDose.MaximumSize = new System.Drawing.Size(134, 24);
            this.datePicker_date2ndDose.MinimumSize = new System.Drawing.Size(4, 23);
            this.datePicker_date2ndDose.Name = "datePicker_date2ndDose";
            this.datePicker_date2ndDose.Size = new System.Drawing.Size(134, 24);
            this.datePicker_date2ndDose.SkinColor = System.Drawing.Color.DarkCyan;
            this.datePicker_date2ndDose.TabIndex = 34;
            this.datePicker_date2ndDose.TextColor = System.Drawing.SystemColors.Info;
            this.datePicker_date2ndDose.CloseUp += new System.EventHandler(this.datePicker_date2ndDose_CloseUp);
            // 
            // datePicker_date1stDose
            // 
            this.datePicker_date1stDose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker_date1stDose.BorderSize = 0;
            this.datePicker_date1stDose.CustomFormat = "MM/dd/yyyy";
            this.datePicker_date1stDose.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datePicker_date1stDose.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_date1stDose.Location = new System.Drawing.Point(395, 4);
            this.datePicker_date1stDose.MinimumSize = new System.Drawing.Size(4, 23);
            this.datePicker_date1stDose.Name = "datePicker_date1stDose";
            this.datePicker_date1stDose.Size = new System.Drawing.Size(121, 25);
            this.datePicker_date1stDose.SkinColor = System.Drawing.Color.DarkCyan;
            this.datePicker_date1stDose.TabIndex = 32;
            this.datePicker_date1stDose.TextColor = System.Drawing.SystemColors.Info;
            this.datePicker_date1stDose.CloseUp += new System.EventHandler(this.datePicker_date1stDose_CloseUp);
            // 
            // VaccinationRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RecordsManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cmbVaccine);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddVaccineRecord);
            this.Controls.Add(this.dataGrid_vacRecord);
            this.Controls.Add(this.btnUpdateVaccineRecord);
            this.Controls.Add(this.panelNewVaccineInfo);
            this.Controls.Add(this.panelAddVaccineTitle);
            this.Controls.Add(this.lbl_PatientName);
            this.Controls.Add(this.lbl_ptntname);
            this.Controls.Add(this.panelVaccinationRecordTitle);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VaccinationRecord";
            this.Size = new System.Drawing.Size(709, 618);
            this.Load += new System.EventHandler(this.VaccinationRecord_Load);
            this.panelVaccinationRecordTitle.ResumeLayout(false);
            this.panelVaccinationRecordTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShieldIcon)).EndInit();
            this.panelAddVaccineTitle.ResumeLayout(false);
            this.panelAddVaccineTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyringeIcon)).EndInit();
            this.panelNewVaccineInfo.ResumeLayout(false);
            this.panelNewVaccineInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_vacRecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVaccinationRecordTitle;
        private System.Windows.Forms.Label lblVACCINATIONRECORD;
        private FontAwesome.Sharp.IconPictureBox ShieldIcon;
        private System.Windows.Forms.Label lbl_PatientName;
        private System.Windows.Forms.Label lbl_ptntname;
        private System.Windows.Forms.Panel panelAddVaccineTitle;
        private FontAwesome.Sharp.IconPictureBox SyringeIcon;
        private System.Windows.Forms.Label lblADDVACCINE;
        private System.Windows.Forms.Panel panelNewVaccineInfo;
        private System.Windows.Forms.Label lbl2nddosedate;
        private System.Windows.Forms.Label lbl1stdosedate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnewvaccine;
        private System.Windows.Forms.Button btnUpdateVaccineRecord;
        private System.Windows.Forms.Label lblError_VacRecord;
        private System.Windows.Forms.Label lblError_AddVac;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid_vacRecord;
        private System.Windows.Forms.Button btnAddVaccineRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtb_lotNumber;
        private System.Windows.Forms.DataGridViewImageColumn IconDelRec;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnClearFields;
        private ComboBox2 cmbVaccine;
        private DateTimePicker2 datePicker_date2ndDose;
        private DateTimePicker2 datePicker_date1stDose;
    }
}
