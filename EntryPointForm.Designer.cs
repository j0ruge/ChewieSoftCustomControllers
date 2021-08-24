
namespace CustomController
{
    partial class EntryPointForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCallMaterialForm = new CustomController.Controls.CButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cTextBoxAlternative1 = new CustomController.Controls.CTextBoxAlternative();
            this.inputUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnApply = new CustomController.Controls.CButton();
            this.ifUserName = new CustomController.Controls.CTextBox();
            this.ifCompanyName = new CustomController.Controls.CTextBox();
            this.SuspendLayout();
            // 
            // btnCallMaterialForm
            // 
            this.btnCallMaterialForm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCallMaterialForm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCallMaterialForm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCallMaterialForm.BorderRadius = 10;
            this.btnCallMaterialForm.BorderSize = 0;
            this.btnCallMaterialForm.FlatAppearance.BorderSize = 0;
            this.btnCallMaterialForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallMaterialForm.ForeColor = System.Drawing.Color.White;
            this.btnCallMaterialForm.Location = new System.Drawing.Point(515, 191);
            this.btnCallMaterialForm.Name = "btnCallMaterialForm";
            this.btnCallMaterialForm.Size = new System.Drawing.Size(250, 40);
            this.btnCallMaterialForm.TabIndex = 0;
            this.btnCallMaterialForm.Text = "Material Form";
            this.btnCallMaterialForm.TextColor = System.Drawing.Color.White;
            this.btnCallMaterialForm.UseVisualStyleBackColor = false;
            this.btnCallMaterialForm.Click += new System.EventHandler(this.btnCallMaterialForm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Material";
            // 
            // cTextBoxAlternative1
            // 
            this.cTextBoxAlternative1.Location = new System.Drawing.Point(263, 262);
            this.cTextBoxAlternative1.MinimumSize = new System.Drawing.Size(227, 55);
            this.cTextBoxAlternative1.Name = "cTextBoxAlternative1";
            this.cTextBoxAlternative1.PlaceholderText = "GabirU";
            this.cTextBoxAlternative1.Size = new System.Drawing.Size(227, 23);
            this.cTextBoxAlternative1.TabIndex = 2;
            this.cTextBoxAlternative1.WaterMark = "Placeholder";
            this.cTextBoxAlternative1.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBoxAlternative1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cTextBoxAlternative1.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // inputUserName
            // 
            this.inputUserName.Depth = 0;
            this.inputUserName.Hint = "";
            this.inputUserName.Location = new System.Drawing.Point(515, 60);
            this.inputUserName.MaxLength = 32767;
            this.inputUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.PasswordChar = '\0';
            this.inputUserName.SelectedText = "";
            this.inputUserName.SelectionLength = 0;
            this.inputUserName.SelectionStart = 0;
            this.inputUserName.Size = new System.Drawing.Size(245, 23);
            this.inputUserName.TabIndex = 3;
            this.inputUserName.TabStop = false;
            this.inputUserName.UseSystemPasswordChar = false;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(144, 372);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(415, 5);
            this.materialProgressBar1.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnApply.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnApply.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnApply.BorderRadius = 10;
            this.btnApply.BorderSize = 0;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(46, 191);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(227, 40);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.TextColor = System.Drawing.Color.White;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ifUserName
            // 
            this.ifUserName.BackColor = System.Drawing.SystemColors.Window;
            this.ifUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ifUserName.BorderFocusColor = System.Drawing.Color.DarkMagenta;
            this.ifUserName.BorderRadius = 10;
            this.ifUserName.BorderSize = 2;
            this.ifUserName.Location = new System.Drawing.Point(46, 41);
            this.ifUserName.MinimumSize = new System.Drawing.Size(239, 55);
            this.ifUserName.Multiline = false;
            this.ifUserName.Name = "ifUserName";
            this.ifUserName.Padding = new System.Windows.Forms.Padding(40, 18, 10, 7);
            this.ifUserName.PasswordChar = false;
            this.ifUserName.Placeholder = "Default Watermark...";
            this.ifUserName.PlaceholderActiveForeColor = System.Drawing.Color.Gray;
            this.ifUserName.PlaceholderFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ifUserName.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.ifUserName.Size = new System.Drawing.Size(239, 55);
            this.ifUserName.TabIndex = 7;
            this.ifUserName.UnderlinedStyle = false;
            // 
            // ifCompanyName
            // 
            this.ifCompanyName.BackColor = System.Drawing.SystemColors.Window;
            this.ifCompanyName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ifCompanyName.BorderFocusColor = System.Drawing.Color.DarkMagenta;
            this.ifCompanyName.BorderRadius = 10;
            this.ifCompanyName.BorderSize = 2;
            this.ifCompanyName.Location = new System.Drawing.Point(46, 121);
            this.ifCompanyName.MinimumSize = new System.Drawing.Size(239, 55);
            this.ifCompanyName.Multiline = false;
            this.ifCompanyName.Name = "ifCompanyName";
            this.ifCompanyName.Padding = new System.Windows.Forms.Padding(40, 18, 10, 7);
            this.ifCompanyName.PasswordChar = false;
            this.ifCompanyName.Placeholder = "Default Watermark...";
            this.ifCompanyName.PlaceholderActiveForeColor = System.Drawing.Color.Gray;
            this.ifCompanyName.PlaceholderFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ifCompanyName.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.ifCompanyName.Size = new System.Drawing.Size(239, 55);
            this.ifCompanyName.TabIndex = 7;
            this.ifCompanyName.UnderlinedStyle = false;
            // 
            // EntryPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ifCompanyName);
            this.Controls.Add(this.ifUserName);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.materialProgressBar1);
            this.Controls.Add(this.inputUserName);
            this.Controls.Add(this.cTextBoxAlternative1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCallMaterialForm);
            this.Name = "EntryPointForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CButton btnCallMaterialForm;
        private System.Windows.Forms.TextBox textBox1;
        private Controls.CTextBoxAlternative cTextBoxAlternative1;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputUserName;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private CTextBoxWatermak userName;
        private Controls.CButton btnApply;
        private CTextBoxWatermak companyName;
        private Controls.CTextBox ifUserName;
        private Controls.CTextBox cTextBox1;
        private Controls.CTextBox ifCompanyName;
    }
}