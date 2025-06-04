using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RecordsManagementSystem
{
    class ComboBox2 : ComboBox
    {

        //Fields
        //-> Appearance
        private Color skinColor = Color.DarkCyan;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;

        //-> Other Values
        private bool droppedDown = true;
        private const int arrowIconWidth = 34;

        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                this.Invalidate();
            }
        }
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        //Constructor
        public ComboBox2()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 21);
            this.Font = new Font(this.Font.Name, 12.5F);
        }
        //Overridden methods
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - arrowIconWidth, 0, arrowIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;
                //Draw surface
                graphics.FillRectangle(skinBrush, clientArea);
                //Draw text
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                //Draw open arrow icon highlight
                if (droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                //Draw border 
                if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                //Draw icon
            }
        }
    }
}
