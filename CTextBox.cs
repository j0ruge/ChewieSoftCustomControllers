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
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        //Events
        public event EventHandler _TextChanged;

        #endregion => Fields

        //Constructor
        public CTextBox()
        {
            InitializeComponent();
        }

        #region => Properties

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
            get => isPasswordChar;
            set
            {
                isPasswordChar = value;
                inputField.UseSystemPasswordChar = value;
            }
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
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return inputField.Text;

            }
            set
            {
                inputField.Text = value;
                SetPlaceHolder();
            }
        }

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

        [Category("ChewieSoft")]
        public Color PlaceholderColor
        {
            get => placeholderColor; set
            {

                placeholderColor = value;
                if (isPlaceholder)
                    inputField.ForeColor = value;

            }
        }

        [Category("ChewieSoft")]
        public string PlaceholderText
        {
            get => placeholderText; set
            {
                placeholderText = value;
                inputField.Text = String.Empty; // More elegante than "";
                SetPlaceHolder();
            }
        }

        #endregion => Properties

        #region => Methods (Overriden) 
        //Overriden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;


            if (borderRadius > 1) // Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;


                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;

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

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(inputField.ClientRectangle, borderRadius - borderSize);
                inputField.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(inputField.ClientRectangle, borderSize * 2);
                inputField.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
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

        #endregion   => Methods (Overriden) 

        #region => Methods (Private)
        //Private methods

        private void SetPlaceHolder()
        {
            if (string.IsNullOrWhiteSpace(inputField.Text) && placeholderText != String.Empty) // More elegant than "";
            {
                isPlaceholder = true;
                inputField.Text = placeholderText;
                inputField.ForeColor = placeholderColor;
                if (isPasswordChar)
                    inputField.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceHolder()
        {
            if (isPlaceholder && placeholderText != String.Empty) // More elegant than "";
            {
                isPlaceholder = false;
                inputField.Text = String.Empty;
                inputField.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    inputField.UseSystemPasswordChar = true;
            }
        }

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
            RemovePlaceHolder();
        }

        private void inputField_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate(); // Redraw the control
            SetPlaceHolder();
        }

        ///TODO: Add the other events

        #endregion => Methods (Private)

    }
}