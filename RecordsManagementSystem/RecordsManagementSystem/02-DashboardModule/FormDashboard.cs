using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace RecordsManagementSystem
{
    public partial class FormDashboard : Form
    {
        static FormDashboard _obj;

        public static FormDashboard Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new FormDashboard();
                }
                return _obj;
            }
        }

        public Panel PnlDashboard
        {
            get { return PanelDashboard; }
            set { PanelDashboard = value; }
        }

        public Button BtnDashboard 
        {
            get { return iconButtonDashboard; }
            set { iconButtonDashboard = (IconButton)value; }
        }
        
        public Button BtnPatient 
        {
            get { return iconButtonPatient; }
            set { iconButtonPatient = (IconButton)value; }
        }
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn; 

        //constructor
        public FormDashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(37, 202, 217);
        }
            
        //methods
        private void ActivateButton(object senderBtn, Color color) //pagcinlick yung button sa sidebar
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(27, 98, 105);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton() 
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(13, 65, 71);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
       
        private void iconButtonDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            PanelDashboard.Controls["Dashboard"].BringToFront();
            new Dashboard();
        }

        private void iconButtonVaccine_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            iconButtonDashboard.Visible = true;
            _obj = this;
            Dashboard db = new Dashboard();
            db.Dock = DockStyle.Fill;
            PanelDashboard.Controls.Add(db);
        }

        private void iconButtonPatient_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            if (FormDashboard.Instance.PnlDashboard.Controls.ContainsKey("PatientInformation"))
            {
                //remove current pi
                var control = FormDashboard.Instance.PnlDashboard.Controls.Find("PatientInformation", true)[0];
                FormDashboard.Instance.PnlDashboard.Controls.Remove(control);
            }

            //re-add pi with no parameter
            PatientInformation pi = new PatientInformation()
            {
                Dock = DockStyle.Fill
            };
            FormDashboard.Instance.PnlDashboard.Controls.Add(pi);
            FormDashboard.Instance.PnlDashboard.Controls["PatientInformation"].BringToFront();
            FormDashboard.Instance.BtnDashboard.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn login = new FormLogIn();
            login.Show();
        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?",
            "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
