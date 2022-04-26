using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomController.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class CTextBox : UserControl
    {
        #region => Private Fields

        //Border
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private Color borderFocusColor = Color.DarkMagenta;
        private int borderRadius = 0;


        private bool underlinedStyle = false;
        private bool isFocused = false;

        private bool isPasswordChar = false;

        #endregion => Private Fields

        public CTextBox()
        {
            InitializeComponent();
        }

        #region => Properties


        [Category("ChewieSoft - Appearance")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("ChewieSoft - Appearance")]
        public bool PasswordChar
        {
            get => isPasswordChar;
            set
            {
                isPasswordChar = value;
                inputPlaceholder.UseSystemPasswordChar = value;
            }
        }

        [Category("ChewieSoft - Appearance")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("ChewieSoft - Appearance")]
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


        [Category("ChewieSoft - Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("ChewieSoft - Appearance")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }


        [Category("ChewieSoft - Appearance")]
        [Description("Sets the text of the input field")]
        public override string Text { get => inputPlaceholder.Text; set => inputPlaceholder.Text = value; }

        [Category("Placeholder")]
        [Description("Sets the placeholder text for the input field")]
        public string Placeholder { get => inputPlaceholder.WaterMark; set { inputPlaceholder.WaterMark = value; this.Invalidate(); } }


        [Category("Placeholder")]
        [Description("Sets the placeholder active fore color for the input field")]
        public Color PlaceholderActiveForeColor { get => inputPlaceholder.WaterMarkActiveForeColor; set { inputPlaceholder.WaterMarkActiveForeColor = value; this.Invalidate(); } }

        [Category("Placeholder")]
        [Description("Sets the placeholder fore color for the input field")]
        public Color PlaceholderForeColor { get => inputPlaceholder.WaterMarkForeColor; set { inputPlaceholder.WaterMarkForeColor = value; this.Invalidate(); } }

        [Category("Placeholder")]
        [Description("Sets the placeholder font for the input field. Default is the same as the control")]
        public Font PlaceholderFont { get => inputPlaceholder.WaterMarkFont; set { inputPlaceholder.WaterMarkFont = value; this.Invalidate(); } }


        [Category("ChewieSoft - Appearance")]
        public bool Multiline
        {
            get => inputPlaceholder.Multiline;
            set => inputPlaceholder.Multiline = value;
        }

        [Category("ChewieSoft - Appearance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                inputPlaceholder.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("ChewieSoft - Appearance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                try
                {
                    base.BackColor = value;
                    inputPlaceholder.BackColor = value;
                }
                catch (Exception)
                {

                    return;
                }
            }
        }

        [Category("ChewieSoft - Appearance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                inputPlaceholder.ForeColor = value;
            }
        }



        #endregion => Properties

        #region => Events

        public event EventHandler _TextChanged;

        private void inputPlaceholder_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {                
                _TextChanged.Invoke(sender, e);
            }
        }

        private void inputPlaceholder_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void inputPlaceholder_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void inputPlaceholder_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void inputPlaceholder_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void inputPlaceholder_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate(); // Redraw the control
        }

        private void inputPlaceholder_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
        ///TODO: Add the other events


        #endregion => Events

        #region => Methods (Private)

        private void UpdateControlHeight()
        {
            if (inputPlaceholder.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("GabirU", this.Font).Height + 1;
                inputPlaceholder.Multiline = true;
                inputPlaceholder.MinimumSize = new Size(0, txtHeight);
                inputPlaceholder.Multiline = false;

                this.Height = inputPlaceholder.Height + this.Padding.Top + this.Padding.Bottom;
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
                pathTxt = GetFigurePath(inputPlaceholder.ClientRectangle, borderRadius - borderSize);
                inputPlaceholder.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(inputPlaceholder.ClientRectangle, borderSize * 2);
                inputPlaceholder.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }


        #endregion => Methods (Private)

       
    }
}
