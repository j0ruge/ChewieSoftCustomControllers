using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomController
{
    [DefaultEvent("_TextChanged")]
    public partial class CTextBoxWatermak : UserControl
    {

        #region => Fields 


        #region Protected Fields

        protected string _placeholderText = "Default Placeholder..."; //The placeholder text
        protected Color _placeholderColor; //Color of the placeholder when the control does not have focus
        protected Color _placeholderActiveColor; //Color of the placeholder when the control has focus

        //public Color placeholderBackColor;

        #endregion


        #region Private Fields


        private Panel placeholderContainer; //Container to hold the placeholder
        private Font placeholderFont; //Font of the placeholder
        private SolidBrush placeholderBrush; //Brush for the placeholder

        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;        
        private Color borderFocusColor = Color.DarkMagenta;
        private int borderRadius = 0;

        private bool underlinedStyle = false;
        private bool isFocused = false;
        
        private bool isPasswordChar = false;

        #endregion

        #endregion => Fields

        //Events
        public event EventHandler _TextChanged;

        //Constructor
        public CTextBoxWatermak()
        {
            InitializeComponent();
            Initialize();
            placeholderContainer.Size = new Size(200, 55);
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
            get => base.BackColor;
            set
            {
                try
                {
                    base.BackColor = value;
                    inputField.BackColor = value;
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
            get => inputField.Text;
            //{
            //if (isPlaceholder) return "";
            //else return inputField.Text;

            //}
            set
            {
                inputField.Text = value;
                //SetPlaceHolder();
            }
        }

        [Category("ChewieSoft")]
        public override string Text
        {
            get => inputField.Text;
            //{
            //    if (isPlaceholder) return "";
            //    else return inputField.Text;

            //}
            set
            {
                inputField.Text = value;
                //SetPlaceHolder();
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
        [Description("Sets the text of the placeholder")]
        public string Placeholder
        {
            get { return this._placeholderText; }
            set
            {
                this._placeholderText = value;
                this.Invalidate();
            }
        }

        [Category("ChewieSoft")]
        [Description("When the control gaines focus, this color will be used as the placeholder's forecolor")]
        public Color PlaceholderActiveForeColor
        {
            get { return this._placeholderActiveColor; }

            set
            {
                this._placeholderActiveColor = value;
                this.Invalidate();
            }
        }

        [Category("ChewieSoft")]
        [Description("When the control looses focus, this color will be used as the placeholder's forecolor")]
        public Color PlaceholderForeColor
        {
            get { return this._placeholderColor; }

            set
            {
                this._placeholderColor = value;
                this.Invalidate();
            }
        }

        [Category("ChewieSoft")]
        [Description("The font used on the placeholder. Default is the same as the control")]
        public Font PlaceholderFont
        {
            get
            {
                return this.placeholderFont;
            }

            set
            {
                this.placeholderFont = value;
                this.Invalidate();
            }
        }

        [Category("ChewieSoft")]
        public Color placeholderBackColor
        {
            get => base.BackColor;
            set
            {
                //base.BackColor = value;
                placeholderContainer.BackColor = value;
            }
        }


        #endregion => Properties

        #region => Methods (Overriden) 
        //Overriden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPlaceholder();
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

        #endregion => Methods (Overriden) 

        #region => Methods (Private)
        //Private methods

        /// <summary>
        /// Initializes placeholder properties and adds CtextBox events
        /// </summary>
        private void Initialize()
        {
            //Sets some default values to the placeholder properties
            _placeholderColor = Color.LightGray;
            _placeholderActiveColor = Color.Gray;
            placeholderFont = inputField.Font;
            placeholderBrush = new SolidBrush(_placeholderActiveColor);
            placeholderContainer = null;            

            //Draw the placeholder, so we can see it in design time
            DrawPlaceholder();

            //Eventhandlers which contains function calls. 
            //Either to draw or to remove the placeholder
            inputField.Enter += new EventHandler(ThisHasFocus);
            inputField.Leave += new EventHandler(ThisWasLeaved);
            inputField.TextChanged += new EventHandler(ThisTextChanged);
        }

        /// <summary>
        /// Removes the placeholder if it should
        /// </summary>
        private void RemovePlaceholder()
        {
            if (placeholderContainer != null)
            {
                this.Controls.Remove(placeholderContainer);
                placeholderContainer = null;
            }
        }

        /// <summary>
        /// Draws the placeholder if the text length is 0
        /// </summary>
        private void DrawPlaceholder()
        {
            if (this.placeholderContainer == null && inputField.TextLength <= 0)
            {
                placeholderContainer = new Panel(); // Creates the new panel instance
                placeholderContainer.Paint += new PaintEventHandler(placeholderContainer_Paint);
                placeholderContainer.Invalidate();
                placeholderContainer.Click += new EventHandler(placeholderContainer_Click);
                //placeholderContainer.Dock = DockStyle.Fill;
                this.Controls.Add(placeholderContainer); // adds the control
            }
        }

        #region Placeholder Events

        private void placeholderContainer_Click(object sender, EventArgs e)
        {
            inputField.Focus(); //Makes sure you can click wherever you want on the control to gain focus
        }

        private void placeholderContainer_Paint(object sender, PaintEventArgs e)
        {
            //Setting the placeholder container up
            placeholderContainer.Location = new Point(2, 0); // sets the location
            placeholderContainer.Height = inputField.Height; // Height should be the same as its parent
            placeholderContainer.Width = inputField.Width; // same goes for width and the parent
            placeholderContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right; // makes sure that it resizes with the parent control



            if (this.ContainsFocus)
            {
                //if focused use normal color
                placeholderBrush = new SolidBrush(this._placeholderActiveColor);
            }

            else
            {
                //if not focused use not active color
                placeholderBrush = new SolidBrush(this._placeholderColor);
            }

            //Drawing the string into the panel 
            Graphics g = e.Graphics;
            g.DrawString(this._placeholderText, placeholderFont, placeholderBrush, new PointF(-2f, 1f));//Take a look at that point
            //The reason I'm using the panel at all, is because of this feature, that it has no limits
            //I started out with a label but that looked very very bad because of its paddings 

        }

        #region => CTextBox Events

        private void ThisHasFocus(object sender, EventArgs e)
        {
            //if focused use focus color
            placeholderBrush = new SolidBrush(this._placeholderActiveColor);

            //The placeholder should not be drawn if the user has already written some text
            if (inputField.TextLength <= 0)
            {
                RemovePlaceholder();
                DrawPlaceholder();
            }
        }

        private void ThisWasLeaved(object sender, EventArgs e)
        {
            //if the user has written something and left the control
            if (inputField.TextLength > 0)
            {
                //Remove the placeholder
                RemovePlaceholder();
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
            if (inputField.TextLength > 0)
            {
                //Remove the placeholder
                RemovePlaceholder();
                inputField.Text.ToUpper(); //Testing here
            }
            else
            {
                //But if the text is empty, draw the placeholder again.
                DrawPlaceholder();
            }
        }


        #endregion => CTextBox Events              


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

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    //Draw the placeholder even in design time
        //    DrawPlaceholder();
        //}

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            //Check if there is a placeholder
            if (placeholderContainer != null)
                //if there is a placeholder it should also be invalidated();
                placeholderContainer.Invalidate();
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
        }

        private void inputField_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate(); // Redraw the control
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