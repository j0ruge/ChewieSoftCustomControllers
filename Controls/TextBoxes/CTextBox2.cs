using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace CustomController
{
    [DefaultEvent("_TextChanged")]
    public partial class CTextBox2 : TextBox 
    {


        #region => Fields 


        #region => Protected Fields

        protected string _waterMarkText = "Default Watermark..."; //The watermark text
        protected Color _waterMarkColor; //Color of the watermark when the control does not have focus
        protected Color _waterMarkActiveColor; //Color of the watermark when the control has focus

        #endregion => Protected Fields

        #region => Private Fields

        private Panel waterMarkContainer; //Container to hold the watermark
        private Font waterMarkFont; //Font of the watermark
        private SolidBrush waterMarkBrush; //Brush for the watermark

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.DarkMagenta;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;


        #endregion => Private Fields

        #endregion => Fields
        /// <summary>
        /// Initializes watermark properties and adds CtextBox events
        /// </summary>
        private void Initialize()
        {
            //Sets some default values to the watermark properties
            _waterMarkColor = Color.LightGray;
            _waterMarkActiveColor = Color.Gray;
            waterMarkFont = this.Font;
            waterMarkBrush = new SolidBrush(_waterMarkActiveColor);
            waterMarkContainer = null;

            //Draw the watermark, so we can see it in design time
            DrawWaterMark();

            //Eventhandlers which contains function calls. 
            //Either to draw or to remove the watermark
            this.Enter += new EventHandler(ThisHasFocus);
            this.Leave += new EventHandler(ThisWasLeaved);
            this.TextChanged += new EventHandler(ThisTextChanged);
        }

        /// <summary>
        /// Removes the watermark if it should
        /// </summary>
        private void RemoveWaterMark()
        {
            if (waterMarkContainer != null)
            {
                this.Controls.Remove(waterMarkContainer);
                waterMarkContainer = null;
            }
        }


        /// <summary>
        /// Draws the watermark if the text length is 0
        /// </summary>
        private void DrawWaterMark()
        {
            if (this.waterMarkContainer == null && this.TextLength <= 0)
            {
                waterMarkContainer = new Panel(); // Creates the new panel instance
                waterMarkContainer.Paint += new PaintEventHandler(waterMarkContainer_Paint);
                waterMarkContainer.Invalidate();
                waterMarkContainer.Click += new EventHandler(waterMarkContainer_Click);
                this.Controls.Add(waterMarkContainer); // adds the control
            }
        }

        #region Eventhandlers

        #region WaterMark Events

        private void waterMarkContainer_Click(object sender, EventArgs e)
        {
            this.Focus(); //Makes sure you can click wherever you want on the control to gain focus
        }

        private void waterMarkContainer_Paint(object sender, PaintEventArgs e)
        {
            //Setting the watermark container up
            waterMarkContainer.Location = new Point(2, 0); // sets the location
            waterMarkContainer.Height = this.Height; // Height should be the same as its parent
            waterMarkContainer.Width = this.Width; // same goes for width and the parent
            waterMarkContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right; // makes sure that it resizes with the parent control

            if (this.ContainsFocus)
            {
                //if focused use normal color
                waterMarkBrush = new SolidBrush(this._waterMarkActiveColor);
            }

            else
            {
                //if not focused use not active color
                waterMarkBrush = new SolidBrush(this._waterMarkColor);
            }

            //Drawing the string into the panel 
            Graphics g = e.Graphics;
            g.DrawString(this._waterMarkText, waterMarkFont, waterMarkBrush, new PointF(-2f, 1f));//Take a look at that point
            //The reason I'm using the panel at all, is because of this feature, that it has no limits
            //I started out with a label but that looked very very bad because of its paddings 

        }

        public event EventHandler _TextChanged;

        #endregion

        //Constructor
        public CTextBox2()
        {
            //InitializeComponent();
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
                this.UseSystemPasswordChar = value;
            }
        }

        [Category("ChewieSoft")]
        public bool Multiline
        {
            get => this.Multiline;
            set => this.Multiline = value;
        }

        [Category("ChewieSoft")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                try
                {
                    base.BackColor = value;
                    this.BackColor = value;
                }
                catch (Exception)
                {

                    return;
                }
            }
        }

        [Category("ChewieSoft")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                this.ForeColor = value;
            }
        }

        [Category("ChewieSoft")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                this.Font = value;
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
                else return this.Text;

            }
            set
            {
                this.Text = value;
                SetPlaceholder();
            }
        }

        [Category("ChewieSoft")]
        public override string Text
        {
            get
            {
                if (isPlaceholder) return "";
                else return this.Text;

            }
            set
            {
                this.Text = value;
                SetPlaceholder();
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
            get => placeholderColor;
            set
            {

                placeholderColor = value;
                if (isPlaceholder)
                    this.ForeColor = value;

            }
        }

        [Category("ChewieSoft")]
        public string PlaceholderText
        {
            get => placeholderText; set
            {
                placeholderText = value;
                this.Text = ""; // String.Empty is More elegante than "";
                SetPlaceholder();
            }
        }

        [Category("Watermark attribtues")]
        [Description("Sets the text of the watermark")]
        public string WaterMark
        {
            get { return this._waterMarkText; }
            set
            {
                this._waterMarkText = value;
                this.Invalidate();
            }
        }

        [Category("Watermark attribtues")]
        [Description("When the control gaines focus, this color will be used as the watermark's forecolor")]
        public Color WaterMarkActiveForeColor
        {
            get { return this._waterMarkActiveColor; }

            set
            {
                this._waterMarkActiveColor = value;
                this.Invalidate();
            }
        }

        [Category("Watermark attribtues")]
        [Description("When the control looses focus, this color will be used as the watermark's forecolor")]
        public Color WaterMarkForeColor
        {
            get { return this._waterMarkColor; }

            set
            {
                this._waterMarkColor = value;
                this.Invalidate();
            }
        }

        [Category("Watermark attribtues")]
        [Description("The font used on the watermark. Default is the same as the control")]
        public Font WaterMarkFont
        {
            get
            {
                return this.waterMarkFont;
            }

            set
            {
                this.waterMarkFont = value;
                this.Invalidate();
            }
        }



        #endregion => Properties

        #region => CTextBox Events

        private void ThisHasFocus(object sender, EventArgs e)
        {
            //if focused use focus color
            waterMarkBrush = new SolidBrush(this._waterMarkActiveColor);

            //The watermark should not be drawn if the user has already written some text
            if (this.TextLength <= 0)
            {
                RemoveWaterMark();
                DrawWaterMark();
            }
        }

        private void ThisWasLeaved(object sender, EventArgs e)
        {
            //if the user has written something and left the control
            if (this.TextLength > 0)
            {
                //Remove the watermark
                RemoveWaterMark();
            }
            else
            {
                //But if the user didn't write anything, Then redraw the control.
                this.Invalidate();
            }
        }

        private void ThisTextChanged(object sender, EventArgs e)
        {
            //If the text of the textbox is not empty
            if (this.TextLength > 0)
            {
                //Remove the watermark
                RemoveWaterMark();
            }
            else
            {
                //But if the text is empty, draw the watermark again.
                DrawWaterMark();
            }
        }


        #endregion  => CTextBox Events

        #region  => Overrided Events

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Draw the watermark even in design time
        //    DrawWaterMark();
        //}

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            //Check if there is a watermark
            if (waterMarkContainer != null)
                //if there is a watermark it should also be invalidated();
                waterMarkContainer.Invalidate();
        }

        #endregion  => Overrided Events



        #region => Methods (Overriden) 
        //Overriden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawWaterMark();
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
                pathTxt = GetFigurePath(this.ClientRectangle, borderRadius - borderSize);
                this.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(this.ClientRectangle, borderSize * 2);
                this.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected void OnLoad(EventArgs e)
        {
            this.OnLoad(e);
            UpdateControlHeight();
        }

        #endregion   => Methods (Overriden) 

        #region => Methods (Private)
        //Private methods


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
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(this.Text) && placeholderText != "") // String.Empty is More elegant than "";
            {
                isPlaceholder = true;
                this.Text = placeholderText;
                this.ForeColor = placeholderColor;
                if (isPasswordChar)
                    this.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceHolder()
        {
            if (isPlaceholder && placeholderText != "") // String.Empty is More elegant than "";
            {
                isPlaceholder = false;
                this.Text = "";
                this.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    this.UseSystemPasswordChar = true;
            }
        }

        private void UpdateControlHeight()
        {
            if (this.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("GabirU", this.Font).Height + 1;
                this.Multiline = true;
                this.MinimumSize = new Size(0, txtHeight);
                this.Multiline = false;

                this.Height = this.Height + this.Padding.Top + this.Padding.Bottom;
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
            SetPlaceholder();
        }

        private void inputField_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        ///TODO: Add the other events

        #endregion => Methods (Private)

        #endregion
    }
}