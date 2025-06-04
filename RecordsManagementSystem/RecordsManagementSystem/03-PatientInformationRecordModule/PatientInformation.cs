using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace RecordsManagementSystem
{
    public partial class PatientInformation : UserControl 
    {
        readonly PatientRecordsManagementSystemEntities db;
        //PATIENT INFORMATION
        private string ptntGivenName, ptntMidName, ptntSurname, ageUnit, ptntBirthdate, ptntBirthplace, 
               addrHouseNum, addrSubdBrgy, addrCityProv,
               ptntGender;
        private int ptntAge, ptntWeight;
        //GUARDIAN INFORMATION
        private string fthrGivName, fthrMidName, fthrSurname,
               mthrGivName, mthrMidName, mthrSurname,
               grdnGivName, grdnMidName, grdnSurname;

        public PatientInformation()
        {
            InitializeComponent();
            clearDataFields();
            db = new PatientRecordsManagementSystemEntities();
        }

        //CONSTRUCTOR FOR TRIGGERING PATIENT INFO FORM WITH EXISTING RECORD
        public PatientInformation(PtntInfoRecordsTable ptntRecord)
        {
            InitializeComponent();
            db = new PatientRecordsManagementSystemEntities();
            displayExistingData(ptntRecord);
            enableDisableButton(btnAddPatient, "disable");
        }

        private void displayExistingData(PtntInfoRecordsTable ptntRecord)
        {
            lbl_PtntID.Text = ptntRecord.PtntID.ToString();
            txtb_ptntGivenName.Text = ptntRecord.PtntGivenName;
            txtb_ptntMidName.Text = ptntRecord.PtntMidName;
            txtb_ptntSurname.Text = ptntRecord.PtntSurname;
            txtb_ptntAge.Text = ptntRecord.PtntAge.ToString() + ptntRecord.AgeUnit;
            cmb_ptntGender.Text = ptntRecord.PtntGender.ToString();
            txtb_ptntWeight.Text = ptntRecord.PtntWeight + " KG";
            datePicker_ptntBirthdate.Value = DateTime.ParseExact(ptntRecord.PtntBirthdate.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            txtb_ptntBirthplace.Text = ptntRecord.PtntBirthplace;
            txtb_AddrHouseNum.Text = ptntRecord.AddrHouseNum;
            txtb_AddrSubdBrgy.Text = ptntRecord.AddrSubdBrgy;
            txtb_AddrCityProv.Text = ptntRecord.AddrCityProv;
            txtb_fthrGivName.Text = ptntRecord.FthrGivName;
            txtb_fthrMidName.Text = ptntRecord.FthrMidName;
            txtb_fthrSurname.Text = ptntRecord.FthrSurname;
            txtb_mthrGivName.Text = ptntRecord.MthrGivName;
            txtb_mthrMidName.Text = ptntRecord.MthrMidName;
            txtb_mthrSurname.Text = ptntRecord.MthrSurname;
            txtb_grdnGivName.Text = ptntRecord.GrdnGivName;
            txtb_grdnMidName.Text = ptntRecord.GrdnMidName;
            txtb_grdnSurname.Text = ptntRecord.GrdnSurname;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            //GET INPUT FROM INPUT CONTROLS AND SET TO DATABASE COLUMNS
            var ptntRecord = new PtntInfoRecordsTable
            {
                PtntGivenName = ptntGivenName,
                PtntMidName = ptntMidName,
                PtntSurname = ptntSurname,
                PtntAge = ptntAge,
                AgeUnit = ageUnit,
                PtntGender = ptntGender,
                PtntWeight = ptntWeight,
                PtntBirthdate = ptntBirthdate,
                PtntBirthplace = ptntBirthplace,
                AddrHouseNum = addrHouseNum,
                AddrSubdBrgy = addrSubdBrgy,
                AddrCityProv = addrCityProv,
                FthrGivName = fthrGivName,
                FthrMidName = fthrMidName,
                FthrSurname = fthrSurname,
                MthrGivName = mthrGivName,
                MthrMidName = mthrMidName,
                MthrSurname = mthrSurname,
                GrdnGivName = grdnGivName,
                GrdnMidName = grdnMidName,
                GrdnSurname = grdnSurname
            };

            //ADD FIELDS TO DATABASE
            db.PtntInfoRecordsTables.Add(ptntRecord);
            enableDisableButton(btnAddPatient, "disable");
            try
            {
                db.SaveChanges();
                displayExistingData(ptntRecord);
                MessageBox.Show("Patient Information Record is Added.");
            }
            catch (Exception)
            {
                MessageBox.Show("Patient Information failed to submit.");
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(lbl_PtntID.Text);
            var ptntRecord = db.PtntInfoRecordsTables.FirstOrDefault(ptnt => ptnt.PtntID == id);
                ptntRecord.PtntGivenName = txtb_ptntGivenName.Text;
                ptntRecord.PtntMidName = txtb_ptntMidName.Text;
                ptntRecord.PtntSurname = txtb_ptntSurname.Text;
                ptntRecord.PtntAge = returnAgeWeight(txtb_ptntAge);
                ptntRecord.PtntGender = cmb_ptntGender.Text.ToUpper();
                ptntRecord.PtntWeight = returnAgeWeight(txtb_ptntWeight);
                ptntRecord.PtntBirthdate = datePicker_ptntBirthdate.Text.ToString();
                ptntRecord.PtntBirthplace = txtb_ptntBirthplace.Text;
                ptntRecord.AddrHouseNum = txtb_AddrHouseNum.Text;
                ptntRecord.AddrSubdBrgy = txtb_AddrSubdBrgy.Text;
                ptntRecord.AddrCityProv = txtb_AddrCityProv.Text;
                ptntRecord.FthrGivName = txtb_fthrGivName.Text;
                ptntRecord.FthrMidName = txtb_fthrMidName.Text;
                ptntRecord.FthrSurname = txtb_fthrSurname.Text;
                ptntRecord.MthrGivName = txtb_mthrGivName.Text;
                ptntRecord.MthrMidName = txtb_mthrMidName.Text;
                ptntRecord.MthrSurname = txtb_mthrSurname.Text;
                ptntRecord.GrdnGivName = txtb_grdnGivName.Text;
                ptntRecord.GrdnMidName = txtb_grdnMidName.Text;
                ptntRecord.GrdnSurname = txtb_grdnSurname.Text;
            try
            {
                db.SaveChanges();
                MessageBox.Show("Patient Information Record is Updated.");
                enableDisableButton(btnAddPatient, "disable");
            }
            catch (Exception)
            {
                MessageBox.Show("Patient Information failed to Update. Try Again.");
            }
        }

        private void btnAddPatient_MouseEnter(object sender, EventArgs e)
        {
            validateControls();
        }

        private void validateControls()
        {
            Control[] controls = { txtb_ptntGivenName, txtb_ptntMidName, txtb_ptntMidName, txtb_ptntSurname, txtb_ptntAge, txtb_ptntWeight, cmb_ptntGender, datePicker_ptntBirthdate, txtb_ptntBirthplace, txtb_AddrCityProv, txtb_AddrHouseNum, txtb_AddrSubdBrgy};

            foreach (Control c in controls)
            {
                if (c.Text == " ")
                {
                    enableDisableButton(btnAddPatient, "disable");
                    errorProvider.SetError(c, "Required field.");
                }
            }

            var defaultDate = DateTime.Today.ToString("MM/dd/yyyy");
            var inputDate = datePicker_ptntBirthdate.Text;
            if (defaultDate == inputDate)
            {
                enableDisableButton(btnAddPatient, "disable");
                errorProvider.SetError(datePicker_ptntBirthdate, "Date is still default. Click the calendar to choose a date.");
            }

            if (string.IsNullOrWhiteSpace(cmb_ptntGender.Text))
            {
                enableDisableButton(btnAddPatient, "disable");
                errorProvider.SetError(cmb_ptntGender, "Select gender");
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
        public void clearDataFields()
        {
            Control[] controls = { txtb_ptntGivenName, txtb_ptntMidName, txtb_ptntMidName, txtb_ptntSurname, txtb_ptntAge, txtb_ptntWeight, cmb_ptntGender, txtb_ptntBirthplace, txtb_ptntBirthplace, txtb_AddrHouseNum, txtb_AddrSubdBrgy, txtb_AddrCityProv, txtb_fthrGivName, txtb_fthrMidName, txtb_fthrSurname, txtb_mthrGivName, txtb_mthrMidName, txtb_mthrSurname, txtb_grdnGivName, txtb_grdnMidName, txtb_grdnSurname };

            foreach (Control c in controls)
            {
                c.Text = " ";
            }
            cmb_ptntGender.SelectedItem = null;
            datePicker_ptntBirthdate.Value = DateTime.Today;
            enableDisableButton(btnUpdateInfo, "disable");
        }

        private int returnAgeWeight(TextBox textbox)
        {
            //Since age and weight are concatenated with strings in display, this method extracts int from the string
            string txt = textbox.Text;
            string storeInt = "";

            for (int i = 0; i < txt.Length; i++)
            {
                if (Char.IsDigit(txt[i]))
                    storeInt += txt[i];
            }
            return Int32.Parse(storeInt);
        }

        //CONTROL AND INPUT VALIDATION METHODS: PATIENT BASIC INFORMATION
        private void txtb_ptntGivenName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_ptntGivenName, e);
        }

        private void txtb_ptntGivenName_Leave(object sender, EventArgs e)
        {
            this.ptntGivenName = txtValIsInputEmpty(txtb_ptntGivenName, ptntGivenName);
        }

        private void txtb_ptntMidName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_ptntMidName, e);
        }

        private void txtb_ptntMidName_Leave(object sender, EventArgs e)
        {
            this.ptntMidName = txtValIsInputEmpty(txtb_ptntMidName, ptntMidName);
        }

        private void txtb_ptntSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_ptntSurname, e);
        }

        private void txtb_ptntSurname_Leave(object sender, EventArgs e)
        {
            this.ptntSurname = txtValIsInputEmpty(txtb_ptntSurname, ptntSurname);
        }

        //PATIENT BASIC INFORMATION LINE 2
        private void txtb_ptntAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitValControlInput(txtb_ptntAge, e);
        }

        private void txtb_ptntAge_Leave(object sender, EventArgs e)
        {
            this.ptntAge = digitValInputEmpty(txtb_ptntAge, ptntAge, "Age");
        }

        private void cmb_ptntGender_DropDownClosed(object sender, EventArgs e)
        {
            this.ptntGender = cmbValSelected(cmb_ptntGender, ptntGender);
        }

        private void txtb_ptntWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            digitValControlInput(txtb_ptntWeight, e);
        }

        private void txtb_ptntWeight_Leave(object sender, EventArgs e)
        {
            this.ptntWeight = digitValInputEmpty(txtb_ptntWeight, ptntWeight, "Weight");
        }

        private void datePicker_ptntBirthdate_CloseUp(object sender, EventArgs e)
        {
            this.ptntBirthdate = dateValidation(datePicker_ptntBirthdate);
        }

        private void txtb_ptntBirthplace_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValAddress(txtb_ptntBirthplace, e);
        }

        private void txtb_ptntBirthplace_Leave(object sender, EventArgs e)
        {
            this.ptntBirthplace = txtValIsInputEmpty(txtb_ptntBirthplace, ptntBirthplace);
        }

        //CONTROL AND INPUT VALIDATION METHODS: PATIENT ADDRESS DATA
        private void txtb_AddrHouseNum_Leave(object sender, EventArgs e)
        {
            this.addrHouseNum = txtValIsInputEmpty(txtb_AddrHouseNum, addrHouseNum);
        }

        private void txtb_AddrHouseNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValAddress(txtb_AddrHouseNum, e);
        }

        private void txtb_AddrSubdBrgy_Leave(object sender, EventArgs e)
        {
            this.addrSubdBrgy = txtValIsInputEmpty(txtb_AddrSubdBrgy, addrSubdBrgy);
        }

        private void txtb_AddrSubdBrgy_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValAddress(txtb_AddrSubdBrgy, e);
        }

        private void txtb_AddrCityProv_Leave(object sender, EventArgs e)
        {
            this.addrCityProv = txtValIsInputEmpty(txtb_AddrCityProv, addrCityProv);
        }

        private void txtb_AddrCityProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValAddress(txtb_AddrCityProv, e);
        }

        //PARENT/GUARDIAN INFORMATION
        //FATHER INFORMATION
        private void txtb_fthrGivName_Leave(object sender, EventArgs e)
        {
            this.fthrGivName = txtValIsInputEmpty(txtb_fthrGivName, fthrGivName);
        }

        private void txtb_fthrGivName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_fthrGivName, e);
        }

        private void txtb_fthrMidName_Leave(object sender, EventArgs e)
        {
            this.fthrMidName = txtValIsInputEmpty(txtb_fthrMidName, fthrMidName);
        }

        private void txtb_fthrMidName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_fthrMidName, e);
        }

        private void txtb_fthrSurname_Leave(object sender, EventArgs e)
        {
            this.fthrSurname = txtValIsInputEmpty(txtb_fthrSurname, fthrSurname);
        }

        private void txtb_fthrSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_fthrSurname, e);
        }

        //MOTHER INFORMATION

        private void txtb_mthrGivName_Leave(object sender, EventArgs e)
        {
            this.mthrGivName = txtValIsInputEmpty(txtb_mthrGivName, mthrGivName);
        }

        private void txtb_mthrGivName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_mthrGivName, e);
        }

        private void PatientInformation_Load(object sender, EventArgs e)
        {
            cmb_ptntGender.SelectedItem = null;
        }

        private void txtb_mthrMidName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_mthrMidName, e);
        }

        private void txtb_mthrMidName_Leave(object sender, EventArgs e)
        {
            this.mthrMidName = txtValIsInputEmpty(txtb_mthrMidName, mthrMidName);
        }

        private void txtb_mthrSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_mthrSurname, e);
        }

        private void txtb_mthrSurname_Leave(object sender, EventArgs e)
        {
            this.mthrSurname = txtValIsInputEmpty(txtb_mthrSurname, mthrSurname);
        }

        //GUARDIAN INFO
        private void txtb_grdnGivName_Leave(object sender, EventArgs e)
        {
            this.grdnGivName = txtValIsInputEmpty(txtb_grdnGivName, grdnGivName);
        }

        private void txtb_grdnGivName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_grdnGivName, e);
        }

        private void txtb_grdnMidName_Leave(object sender, EventArgs e)
        {
            this.grdnMidName = txtValIsInputEmpty(txtb_grdnMidName, grdnMidName);
        }

        private void txtb_grdnMidName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_grdnMidName, e);
        }

        private void txtb_grdnSurname_Leave(object sender, EventArgs e)
        {
            this.grdnSurname = txtValIsInputEmpty(txtb_grdnSurname, grdnSurname);
        }

        private void txtb_grdnSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValDisallowNumbers(txtb_grdnMidName, e);
        }

        //VALIDATION METHODS AUTHOR MADE
        //TEXTBOX
        protected string txtValIsInputEmpty(TextBox txtBox, string data)
        {
            var input = txtBox.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(input))
            {
                errorProvider.SetError(txtBox, "Required field");
                enableDisableButton(btnAddPatient, "disable");
                txtBox.BackColor = Color.Maroon;
                MessageBox.Show("Input required field.");
                txtBox.BackColor = Color.DarkCyan;
                txtBox.Focus();
            }
            else
            {
                enableDisableButton(btnAddPatient, "enable");
                errorProvider.Clear();
                data = input;
            }
            errorProvider.Clear();
            return data;
        }

        //ALHAPBET ONLY
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
                txtBox.BackColor = Color.DarkCyan;
            }
        }

        //ALPHABET AND NUMBERS ONLY
        protected void txtValAddress(TextBox txtBox, KeyPressEventArgs e)
        {

            if (char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider.Clear();
                txtBox.BackColor = Color.DarkCyan;
            }
            else if (!e.KeyChar.Equals(Keys.OemPeriod) && !e.KeyChar.Equals(Keys.Oemcomma) && char.IsSymbol(e.KeyChar))
            {
                errorProvider.SetError(txtBox, "Symbols are not allowed");
                txtBox.BackColor = Color.Maroon;
                txtBox.Focus();
            } else if (Control.ModifierKeys == Keys.Shift)
            {
                errorProvider.SetError(txtBox, "Symbols are not allowed");
                txtBox.BackColor = Color.Maroon;
                txtBox.Focus();
            }
            else
            {
                errorProvider.Clear();
                txtBox.BackColor = Color.DarkCyan;
            }
        }

        //ALLOW NUMERIC VALUES ONLY
        //for every keypressed, alphanumeric chars is disabled, lets user type in onlu numeric characters
        protected void digitValControlInput(TextBox txtBox, KeyPressEventArgs e)
        {

            //error, pati bckspace nacocount sa length
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider.SetError(txtBox, "Enter Numeric Values Only.");
                txtBox.BackColor = Color.Maroon;
                txtBox.Focus();
            }
            else
            {
                errorProvider.Clear();
                txtBox.BackColor = Color.DarkCyan;
            }

            if (txtBox.TextLength == txtBox.MaxLength)
            {
                MessageBox.Show("You have just entered more than the limit. Please review your input", "Input is limited to 2 characters.");
                txtBox.Clear();
            }
        }

        protected int digitValInputEmpty(TextBox txtBox, int data, string title)
        {
            string strDigit = txtBox.Text;

            if (string.IsNullOrWhiteSpace(strDigit))
            {
                enableDisableButton(btnAddPatient, "disable");
                errorProvider.SetError(txtBox, "Required field");
                txtBox.BackColor = Color.Maroon;
                MessageBox.Show("Input required field.");
                txtBox.BackColor = Color.DarkCyan;
                txtBox.Focus();
            }
            else
            {
                enableDisableButton(btnAddPatient, "enable");
                errorProvider.Clear();
                data = Int32.Parse(strDigit);
            }

            if (title.Equals("Weight"))
            {
                txtBox.Text = strDigit + "KG";
            }
            else
            {
                MessageBoxButtons btns = MessageBoxButtons.YesNo;
                DialogResult dialogResult = MessageBox.Show("Does the patient's age is in weeks?", "Age Unit Validation", btns);

                if (dialogResult == DialogResult.Yes)
                {
                    ageUnit = " WEEKS OLD";
                    txtBox.Text = strDigit + ageUnit;
                }
                else
                {
                    MessageBoxButtons btns2 = MessageBoxButtons.YesNo;
                    DialogResult dialogResult2 = MessageBox.Show("Does the patient's age is in months?", "Age Unit Validation", btns2);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        ageUnit = " MONTHS OLD";
                        txtBox.Text = strDigit + ageUnit;
                    }
                    else
                    {
                        ageUnit = " YEARS OLD";
                        txtBox.Text = strDigit + ageUnit;
                    }
                }
            }
            return data;
        }

        //COMBOBOX
        protected string cmbValSelected(ComboBox cmbBox, string data)
        {
            string slctdItem = cmbBox.Text;
            if (slctdItem.Equals(""))
            {
                errorProvider.SetError(cmbBox, "Select from the dropdown control.");
                enableDisableButton(btnAddPatient, "disable");
                cmbBox.BackColor = Color.Maroon;
                MessageBox.Show("Dropdown control is empty. Click the box or the arrow to select an item.", "Required Dropdown field.");
                cmbBox.BackColor = Color.DarkCyan;
                cmbBox.Focus();
            }
            else
            {
                enableDisableButton(btnAddPatient, "enable");
                errorProvider.Clear();
                data = slctdItem;
            }
            return data;
        }

        //DATE TIME PICKER
        protected string dateValidation(DateTimePicker datePicker)
        {
            var defaultDate = DateTime.Today.ToString("MM/dd/yyyy");
            var inputDate = datePicker.Text.ToString();

            if (!defaultDate.Equals(inputDate))
            {
                MessageBox.Show("Your selelected date is " + inputDate, "Date Entered Validation");
                enableDisableButton(btnAddPatient, "enable");
                errorProvider.Clear();
            }
            else
            {
                MessageBoxButtons btns = MessageBoxButtons.YesNo;
                DialogResult dialogResult = MessageBox.Show("Are you sure you inputted this correctly?", "Default value for date is used", btns);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Your selelected date is " + inputDate, "Date Entered Validation");
                    enableDisableButton(btnAddPatient, "enable");
                    return inputDate;
                }
                else
                {
                    errorProvider.SetError(datePicker, "Date still in default value.");
                    enableDisableButton(btnAddPatient, "disable");
                    datePicker.Focus();
                    datePicker.BackColor = Color.Maroon;
                }
            }
            return inputDate;
        }

    }
}
