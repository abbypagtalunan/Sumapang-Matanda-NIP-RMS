using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordsManagementSystem
{
    public partial class Dashboard : UserControl
    {
        readonly PatientRecordsManagementSystemEntities db;

        public Dashboard()
        {
            InitializeComponent();
            db = new PatientRecordsManagementSystemEntities();
            populateGrid();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            populateGrid();
            var PatientCount = db.PtntInfoRecordsTables.ToList().Count();
            lblNumTotalPatient.Text = PatientCount.ToString();

            var TotalDoses = db.PtntVaccineRecordsTables.ToList().Where(date => DateTime.Parse(date.Date1stDose) <= DateTime.Now).Count();
            lblNumTotalDoses.Text = TotalDoses.ToString();

            var IncomingDoses = db.PtntVaccineRecordsTables.ToList().Where(date => Convert.ToDateTime(date.Date2ndDose) <= DateTime.Now).Count();
            lblNumIncoming2ndDose.Text = IncomingDoses.ToString();
        }

        private void populateGrid()
        {
            //LOADS SELECTED DATA INTO DATA GRID VIEW
            var ptntRecord = db.PtntInfoRecordsTables.Select(ptntRec => new
            {
                ID = ptntRec.PtntID,
                NAME = ptntRec.PtntGivenName + " ",
                MIDDLE = ptntRec.PtntMidName + " ",
                SURNAME = ptntRec.PtntSurname + " ",
                AGE = ptntRec.PtntAge + ptntRec.AgeUnit,

                GENDER = ptntRec.PtntGender,
                WEIGHT = ptntRec.PtntWeight + " KG",
                BIRTHDATE = ptntRec.PtntBirthdate,
            }).ToList();
            dataGrid_dashboard.DataSource = ptntRecord;

            //INDEX COLUMN COUNT OF ICONS IS 0,1,2, SET TO 10 (RIGHT END)
            dataGrid_dashboard.Columns[0].DisplayIndex = 10;
            dataGrid_dashboard.Columns[1].DisplayIndex = 10;
            dataGrid_dashboard.Columns[2].DisplayIndex = 10;

            dataGrid_dashboard.Columns[0].Width = 35;
            dataGrid_dashboard.Columns[1].Width = 35;
            dataGrid_dashboard.Columns[2].Width = 35;
            dataGrid_dashboard.Columns[3].Width = 30;
            dataGrid_dashboard.Columns[4].Width = 120;
            dataGrid_dashboard.Columns[5].Width = 120;
            dataGrid_dashboard.Columns[6].Width = 100;
            dataGrid_dashboard.Columns[7].Width = 125;
            dataGrid_dashboard.Columns[8].Width = 80;
            dataGrid_dashboard.Columns[9].Width = 80;
            dataGrid_dashboard.Columns[10].Width = 100;

            //INDEX COLUMN COUNT OF DATA DISPLAYED IS FROM 3-10
            dataGrid_dashboard.Columns[3].HeaderText = "ID";
            dataGrid_dashboard.Columns[3].Visible = false;
            dataGrid_dashboard.Columns[4].HeaderText = "NAME";
            dataGrid_dashboard.Columns[5].HeaderText = "";
            dataGrid_dashboard.Columns[6].HeaderText = "";
            dataGrid_dashboard.Columns[7].HeaderText = "AGE";
            dataGrid_dashboard.Columns[8].HeaderText = "GENDER";
            dataGrid_dashboard.Columns[9].HeaderText = "WEIGHT";
            dataGrid_dashboard.Columns[10].HeaderText = "BIRTHDATE";
        }

        //ICON CLICK METHODS
        private void dataGrid_dashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                //COLUMN INDEX OF PATIENT VACCINATION RECORD ICON (VIEW EXISTING VACCINATION RECORD)
                case 0:
                    var slctdID = (int)dataGrid_dashboard.Rows[e.RowIndex].Cells[3].Value;
                    var ptntRec = db.PtntInfoRecordsTables.FirstOrDefault(ptnt => ptnt.PtntID == slctdID);

                    if (FormDashboard.Instance.PnlDashboard.Controls.ContainsKey("VaccinationRecord"))
                    {
                        var control = FormDashboard.Instance.PnlDashboard.Controls.Find("VaccinationRecord", true)[0];
                        FormDashboard.Instance.PnlDashboard.Controls.Remove(control);
                    }

                    VaccinationRecord vrx = new VaccinationRecord(ptntRec)
                    {
                        Dock = DockStyle.Fill
                    };
                    FormDashboard.Instance.PnlDashboard.Controls.Add(vrx);

                    FormDashboard.Instance.PnlDashboard.Controls["VaccinationRecord"].BringToFront();
                    FormDashboard.Instance.BtnDashboard.Visible = true;
                    break;

                //CASE 1 IS THE COLUMN INDEX OF PATIENT INFORMATION RECORD ICON (VIEW EXISTING RECORD) MEANING,
                case 1:
                    //GETS SELECTED ROW ID AND COMPARES IF SELECTED ROW ID IS == TO PTNTID IN THE DATABASE
                    var slctdID1 = (int)dataGrid_dashboard.Rows[e.RowIndex].Cells[3].Value;
                    var ptntRec1 = db.PtntInfoRecordsTables.FirstOrDefault(ptnt => ptnt.PtntID == slctdID1);

                    var PatientInformation = FormDashboard.Instance.PnlDashboard.Controls.ContainsKey("PatientInformation");
                    if (PatientInformation == true)
                    {
                        var control = FormDashboard.Instance.PnlDashboard.Controls.Find("PatientInformation", true)[0];
                        FormDashboard.Instance.PnlDashboard.Controls.Remove(control);
                    }

                    PatientInformation pi = new PatientInformation(ptntRec1)
                    {
                        Dock = DockStyle.Fill
                    };
                    FormDashboard.Instance.PnlDashboard.Controls.Add(pi);
                    FormDashboard.Instance.PnlDashboard.Controls["PatientInformation"].BringToFront();
                    FormDashboard.Instance.BtnDashboard.Visible = true;
                    break;

                //COLUMN INDEX OF DELETE PATIENT RECORD
                case 2:
                    //GETS SELECTED ROW ID AND COMPARES IF SELECTED ROW ID IS == TO PTNTID IN THE DATABASE
                    var slctdID2 = (int)dataGrid_dashboard.Rows[e.RowIndex].Cells[3].Value;
                    var ptntRec2 = db.PtntInfoRecordsTables.FirstOrDefault(ptnt => ptnt.PtntID == slctdID2);

                    MessageBoxButtons btns = MessageBoxButtons.OKCancel;
                    DialogResult dialogResult = MessageBox.Show("Are you sure to permanently delete this record?", "Patient Record Deletion", btns);
                    if (dialogResult == DialogResult.OK)
                    {
                        try
                        {
                            db.PtntInfoRecordsTables.Remove(ptntRec2);
                            db.SaveChanges();
                            MessageBox.Show("Patient record was deleted permanently.", "Patient Record Deletion Success");
                            dataGrid_dashboard.Refresh();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("The system failed to delete the record.", "Patient Record Deletion Failed");
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        //TOOL TIP OF ICONS
        private void dataGrid_dashboard_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == this.dataGrid_dashboard.Columns[0].Index)
        && e.Value != null)
            {
                DataGridViewCell cell =
           this.dataGrid_dashboard.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "View vaccine record";
            }
            else if((e.ColumnIndex == this.dataGrid_dashboard.Columns[1].Index)
        && e.Value != null)
            {
                DataGridViewCell cell =
          this.dataGrid_dashboard.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "View patient information record";
            }
            else if ((e.ColumnIndex == this.dataGrid_dashboard.Columns[2].Index)
        && e.Value != null)
            {
                DataGridViewCell cell =
          this.dataGrid_dashboard.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Delete patient record";
            }
        }
    }
}
