using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomController
{
    [DefaultEvent("_TextChanged")]
    public partial class CTextBox : UserControl
    {

        #region => Fields 
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;

        //Events
        public event EventHandler _TextChanged;

        #endregion => Fields

        //Constructor
        public CTextBox()
        {
            InitializeComponent();
        }



        //Properties

        [Category("ChewieSoft")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("ChewieSoft")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("ChewieSoft")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("ChewieSoft")]
        public bool PasswordChar
        {
            get => inputField.UseSystemPasswordChar;
            set => inputField.UseSystemPasswordChar = value;
        }

        [Category("ChewieSoft")]
        public bool Multiline
        {
            get => inputField.Multiline;
            set => inputField.Multiline = value;
        }

        [Category("ChewieSoft")]
        public override Color BackColor
        {
            get => base.BackColor; set
            {
                base.BackColor = value;
                inputField.BackColor = value;
            }
        }

        [Category("ChewieSoft")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                inputField.ForeColor = value;
            }
        }

        [Category("ChewieSoft")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                inputField.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("ChewieSoft")]
        public string Texts { get => inputField.Text; set => inputField.Text = value; }

        [Category("ChewieSoft")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("ChewieSoft")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate(); // Redraw the control
                }
            }
        }

        //Overriden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;


            if (borderRadius > 1) // Rounded TextBox
            {

            }
            else
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!isFocused)
                    {
                        if (underlinedStyle) //Line Style
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        else                 //Normal Style
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;

                        if (underlinedStyle) //Line Style
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        else                 //Normal Style
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }

                }

            }

            
        }


        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //Private methods
        private void UpdateControlHeight()
        {
            if (inputField.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("GabirU", this.Font).Height + 1;
                inputField.Multiline = true;
                inputField.MinimumSize = new Size(0, txtHeight);
                inputField.Multiline = false;

                this.Height = inputField.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void inputField_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void inputField_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void inputField_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void inputField_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void inputField_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void inputField_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate(); // Redraw the control
        }

        ///TODO: Add the other events
    }
}
