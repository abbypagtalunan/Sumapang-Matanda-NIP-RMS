using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsManagementSystem
{
    public partial class VaccinationRecord : UserControl
    {
        readonly PatientRecordsManagementSystemEntities db;
        private string slctdVaccine, vacLotNumber, slctdDate1stDose, slctdDate2ndDose;
        readonly private int ptntVacID, ptntInfoID;

        public VaccinationRecord()
        {
            InitializeComponent();
            db = new PatientRecordsManagementSystemEntities();
        }

        public VaccinationRecord(PtntInfoRecordsTable ptntRecord)
        {
            InitializeComponent();
            db = new PatientRecordsManagementSystemEntities();

            this.ActiveControl = null;
            lbl_ptntname.Text = lbl_ptntname.Text + " " + ptntRecord.PtntGivenName + " " + ptntRecord.PtntMidName + " " + ptntRecord.PtntSurname;
            ptntInfoID = ptntRecord.PtntID;
            ptntVacID = ptntInfoID;
        }

        private void VaccinationRecord_Load(object sender, EventArgs e)
        {
            var vaccineUnits = db.VaccineUnits.ToList();
            cmbVaccine.DisplayMember = "VaccineName";
            cmbVaccine.ValueMember = "VaccineID";
            cmbVaccine.DataSource = vaccineUnits;
            populateGrid();
            resetFields();
            dataGrid_vacRecord.ClearSelection();
            lbl1stdosedate.Focus();
        }

        private void dataGrid_vacRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearErrorProvider();
            cmbVaccine.SkinColor = Color.DarkCyan;
            cmbVaccine.TextColor = Color.White;
            this.ActiveControl = null;
            enableDisableButton(btnAddVaccineRecord, "disable");
            enableDisableButton(btnUpdateVaccineRecord, "enable");
            //SHOW DATA IN CELL CLICK
            dataGrid_vacRecord.CurrentRow.Selected = true;
            cmbVaccine.Enabled = false;
            cmbVaccine.Text = dataGrid_vacRecord.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtb_lotNumber.Text = dataGrid_vacRecord.Rows[e.RowIndex].Cells[3].Value.ToString();
            datePicker_date1stDose.Text = dataGrid_vacRecord.Rows[e.RowIndex].Cells[4].Value.ToString();
            datePicker_date2ndDose.Text = dataGrid_vacRecord.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void btnAddVaccineRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var ptntVacRecord = new PtntVaccineRecordsTable
                {
                    PtntVacID = ptntVacID,
                    VaccineID = (int)cmbVaccine.SelectedValue,
                    VacLotNumber = vacLotNumber,
                    Date1stDose = slctdDate1stDose,
                    Date2ndDose = slctdDate2ndDose
                };
                db.PtntVaccineRecordsTables.Add(ptntVacRecord);
                db.SaveChanges();
                MessageBox.Show("Patient Vaccine Record is Added.");
                enableDisableButton(btnAddVaccineRecord, "disable");
                populateGrid();
                resetFields();
            }
            catch (Exception)
            {
                MessageBox.Show("Patient Vaccine Record already has an existing record.");
                resetFields();
            }
}

        private void btnAddVaccineRecord_MouseEnter(object sender, EventArgs e)
        {
            validateControls();
        }

        private void btnUpdateVaccineRecord_Click(object sender, EventArgs e)
        {
            var ptntVacRecord = db.PtntVaccineRecordsTables.FirstOrDefault(vac => vac.VaccineID == (int)cmbVaccine.SelectedValue);
            ptntVacRecord.VaccineID = (int)cmbVaccine.SelectedValue;
            ptntVacRecord.VacLotNumber = txtb_lotNumber.Text;
            ptntVacRecord.Date1stDose = datePicker_date1stDose.Text.ToString();
            ptntVacRecord.Date2ndDose = datePicker_date2ndDose.Text.ToString();

            try
            {
                db.SaveChanges();
                enableDisableButton(btnAddVaccineRecord, "disable");
                MessageBox.Show("Patient Vaccination Record is Updated.");
                populateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Patient record does not match. Record update failed.");
            }
        }

        private void dataGrid_vacRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //GETS SELECTED ROW ID AND COMPARES IF SELECTED ROW ID IS == TO VACID IN THE DATABASE
                var ptntVacRecord = db.PtntVaccineRecordsTables.FirstOrDefault(vac => vac.VaccineID == (int)cmbVaccine.SelectedValue);
                MessageBoxButtons btns = MessageBoxButtons.OKCancel;
                DialogResult dialogResult = MessageBox.Show("Are you sure to permanently delete this record?", "Patient Record Deletion", btns);
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        db.PtntVaccineRecordsTables.Remove(ptntVacRecord);
                        db.SaveChanges();
                        MessageBox.Show("Patient vaccination record was deleted permanently.", "Patient Vaccination Record Deletion Success");
                        populateGrid();
                        resetFields();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The system failed to delete the record.", "Patient Vaccination Record Deletion Failed");
                    }
                }
            }
        }

        private void populateGrid()
        {
            //SHOW ONLY RECORDS THAT MATCH WITH PTNTINFOID AND PTNTVACID            
            var ptntVac = db.PtntVaccineRecordsTables.Where(v => v.PtntVacID == ptntInfoID)
                .Select(ptntVacRec => new {
                    ID = ptntVacRec.PtntVacID,
                    VACCINE = ptntVacRec.VaccineUnit.VaccineName,
                    LOT = ptntVacRec.VacLotNumber,
                    DOSE1 = ptntVacRec.Date1stDose,
                    DOSE2 = ptntVacRec.Date2ndDose,
                }).ToList();
            dataGrid_vacRecord.DataSource = ptntVac;

            //INDEX COLUMN COUNT OF ICONS IS 0,1,2, SET TO 10 (RIGHT END)
            dataGrid_vacRecord.Columns[0].DisplayIndex = 5;

            dataGrid_vacRecord.Columns[1].Visible = false;
            dataGrid_vacRecord.Columns[2].HeaderText = "VACCINE";
            dataGrid_vacRecord.Columns[3].HeaderText = "LOT NUMBER";
            dataGrid_vacRecord.Columns[4].HeaderText = "DATE OF 1ST DOSE";
            dataGrid_vacRecord.Columns[5].HeaderText = "DATE OF 2ND DOSE";

            dataGrid_vacRecord.Columns[0].Width = 35;
            dataGrid_vacRecord.Columns[2].Width = 300;
            dataGrid_vacRecord.Columns[3].Width = 140;
            dataGrid_vacRecord.Columns[4].Width = 158;
            dataGrid_vacRecord.Columns[5].Width = 158;
        }

        private void validateControls()
        {
            if (datePicker_date1stDose.Text == DateTime.Today.ToString("MM/dd/yyyy"))
            {
                enableDisableButton(btnAddVaccineRecord, "disable");
                errorProvider.SetError(datePicker_date1stDose, "Date is still default. Click the calendar to choose a date.");
            }
            else
            {
                enableDisableButton(btnAddVaccineRecord, "enable");
                errorProvider.Clear();
            }

            if (datePicker_date2ndDose.Text == DateTime.Today.ToString("MM/dd/yyyy"))
            {
                enableDisableButton(btnAddVaccineRecord, "disable");
                errorProvider.SetError(datePicker_date2ndDose, "Date is still default. Click the calendar to choose a date.");
            }
            else
            {
                enableDisableButton(btnAddVaccineRecord, "enable");
                errorProvider.Clear();
            }

            if (string.IsNullOrWhiteSpace(cmbVaccine.Text))
            {
                enableDisableButton(btnAddVaccineRecord, "disable");
                errorProvider.SetError(cmbVaccine, "Select vaccine");
            }

            if (string.IsNullOrWhiteSpace(txtb_lotNumber.Text))
            {
                enableDisableButton(btnAddVaccineRecord, "disable");
                errorProvider.SetError(txtb_lotNumber, "Required field");
            }
        }

        private void resetFields()
        {
            clearErrorProvider();
            cmbVaccine.SelectedItem = null;
            cmbVaccine.Enabled = true;
            txtb_lotNumber.Text = " ";
            datePicker_date1stDose.Value = DateTime.Today;
            datePicker_date2ndDose.Value = DateTime.Today;
            enableDisableButton(btnUpdateVaccineRecord, "disable");
            enableDisableButton(btnAddVaccineRecord, "enable");
        }

        private void clearErrorProvider()
        {
            Control[] controls = { cmbVaccine, txtb_lotNumber, datePicker_date1stDose, datePicker_date2ndDose };
            foreach (Control c in controls)
            {
                errorProvider.SetError(c, string.Empty);
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

        private void cmbVaccine_DropDownClosed(object sender, EventArgs e)
        {
            this.slctdVaccine = cmbValSelected(cmbVaccine, slctdVaccine);
        }

        private void txtb_lotNumber_Leave(object sender, EventArgs e)
        {
            this.vacLotNumber = txtValIsInputEmpty(txtb_lotNumber, vacLotNumber);
        }

        private void txtb_lotNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            LotNumValidation(txtb_lotNumber, e);
        }

        private void datePicker_date1stDose_CloseUp(object sender, EventArgs e)
        {
            this.slctdDate1stDose = dateValidation(datePicker_date1stDose, slctdDate1stDose);
            MessageBoxButtons btns2 = MessageBoxButtons.YesNo;
            DialogResult dialogResult2 = MessageBox.Show("Does this record have an administered 2nd dose?", "Vaccine Date Schedule Notice", btns2);
            if (dialogResult2 == DialogResult.Yes)
            {
                MessageBox.Show("Please continue to input the date of second dose.");
            }
            else
            {
                MessageBox.Show("Please schedule the date of 2nd dose.");
            }
        }

        private void datePicker_date2ndDose_CloseUp(object sender, EventArgs e)
        {
            this.slctdDate2ndDose = dateValidation(datePicker_date2ndDose, slctdDate2ndDose);
            this.slctdDate2ndDose = dateVal2ndDose(datePicker_date1stDose, datePicker_date2ndDose, slctdDate2ndDose);
        }

        //VALIDATION METHODS AUTHOR MADE
        //TEXTBOX
        protected string txtValIsInputEmpty(TextBox txtBox, string data)
        {
            var input = txtBox.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(input))
            {
                errorProvider.SetError(txtBox, "Required field");
                enableDisableButton(btnAddVaccineRecord, "disable");
                txtBox.BackColor = Color.Maroon;
                MessageBox.Show("Input required field.");
                txtBox.BackColor = Color.DarkCyan;
                txtBox.Focus();
            }
            else
            {
                enableDisableButton(btnAddVaccineRecord, "enable");
                errorProvider.SetError(txtBox, "");
                data = input;
            }
            return data;
        }

        //ALPHABET AND NUMBERS ONLY
        protected void LotNumValidation(TextBox txtBox, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals(Keys.Space))
            {
                errorProvider.SetError(txtBox, "");
                txtBox.BackColor = Color.DarkCyan;
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                errorProvider.SetError(txtBox, "Symbols are not allowed");
                txtBox.BackColor = Color.Maroon;
                txtBox.Focus();
            }
        }

        //COMBOBOX
        protected string cmbValSelected(ComboBox cmbBox, string data)
        {
            string slctdItem = cmbBox.Text;
            if (string.IsNullOrEmpty(slctdItem))
            {
                MessageBox.Show("Click the box and select the vaccine.", "Vaccine not selected.");
                errorProvider.SetError(cmbBox, "Provide the vaccine required.");
                cmbBox.Focus();
            }
            else
            {
                errorProvider.SetError(cmbBox, "");
                enableDisableButton(btnAddVaccineRecord, "enable");
                data = slctdItem;
            }
            return data;
        }

        //DATE TIME PICKER
        protected string dateValidation(DateTimePicker datePicker, string date)
        {
            var defaultDate = DateTime.Today.ToString("MM/dd/yyyy");
            var inputDate = datePicker.Text.ToString();

            if (!defaultDate.Equals(inputDate))
            {
                MessageBox.Show("Your selelected date is " + inputDate, "Date Entered Validation");
                errorProvider.SetError(datePicker, "");
            }
            else
            {
                MessageBoxButtons btns = MessageBoxButtons.YesNo;
                DialogResult dialogResult = MessageBox.Show("Are you sure you inputted this correctly?", "Default value for date is used", btns);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Your selelected date is " + inputDate, "Date Entered Validation");
                    enableDisableButton(btnAddVaccineRecord, "enable");
                    return inputDate; 
                }
                else
                {
                    errorProvider.SetError(datePicker, "Date is still default");
                    datePicker.Focus();
                    datePicker.BackColor = Color.Maroon;
                    enableDisableButton(btnAddVaccineRecord, "disable");
                }
            }
            return inputDate;
        }

        //validates 2nd dose date selected whether it is earlier than the 1st dose
        protected string dateVal2ndDose(DateTimePicker datePicker1, DateTimePicker datePicker2, string date2)
        {
            if (Convert.ToDateTime(datePicker2.Value) < Convert.ToDateTime(datePicker1.Value))
            {
                MessageBox.Show("Date for second dose may be selected incorrectly. 2nd dose must not be earlier than the 1st dose.", "Invalid date selection.");
                errorProvider.SetError(datePicker2, "Date invalid");
                enableDisableButton(btnAddVaccineRecord, "disable");
                datePicker1.Focus();
                datePicker2.BackColor = Color.Maroon;
            }
            else if (Convert.ToDateTime(datePicker2.Value) == Convert.ToDateTime(datePicker1.Value))
            {
                MessageBox.Show("Date for second dose may be selected incorrectly. Dates cannot be the same.", "Invalid date selection.");
                errorProvider.SetError(datePicker2, "Date invalid");
                enableDisableButton(btnAddVaccineRecord, "disable");
                datePicker1.Focus();
                datePicker2.BackColor = Color.Maroon;
            }
            else
            {
                errorProvider.SetError(datePicker2, "");
                MessageBox.Show(datePicker2.Text.ToString(), "Date Entered Validation");
                enableDisableButton(btnAddVaccineRecord, "enable");
                date2 = datePicker2.Text.ToString();
                return date2;
            }
            return date2;
        }
    }
}
