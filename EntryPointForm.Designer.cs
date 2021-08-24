
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPointForm));
            this.btnCallMaterialForm = new CustomController.Controls.CButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cTextBoxAlternative1 = new CustomController.Controls.CTextBoxAlternative();
            this.inputUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.userName = new CustomController.CTextBox();
            this.btnApply = new CustomController.Controls.CButton();
            this.companyName = new CustomController.CTextBox();
            this.ifUserName = new CustomController.Controls.CTextBoxWatermak();
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
            this.inputUserName.Location = new System.Drawing.Point(515, 237);
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
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userName.BackgroundImage")));
            this.userName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.userName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userName.BorderRadius = 10;
            this.userName.BorderSize = 2;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.ForeColor = System.Drawing.Color.Black;
            this.userName.Location = new System.Drawing.Point(53, 51);
            this.userName.MinimumSize = new System.Drawing.Size(227, 55);
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.Padding = new System.Windows.Forms.Padding(40, 18, 10, 7);
            this.userName.PasswordChar = false;
            this.userName.Placeholder = "User";
            this.userName.PlaceholderActiveForeColor = System.Drawing.Color.Gray;
            this.userName.placeholderBackColor = System.Drawing.Color.White;
            this.userName.PlaceholderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.userName.Size = new System.Drawing.Size(227, 55);
            this.userName.TabIndex = 5;
            this.userName.Texts = "";
            this.userName.UnderlinedStyle = false;
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
            this.btnApply.Location = new System.Drawing.Point(53, 161);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(227, 40);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.TextColor = System.Drawing.Color.White;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // companyName
            // 
            this.companyName.BackColor = System.Drawing.SystemColors.Window;
            this.companyName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.companyName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.companyName.BorderRadius = 10;
            this.companyName.BorderSize = 2;
            this.companyName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyName.ForeColor = System.Drawing.Color.DimGray;
            this.companyName.Location = new System.Drawing.Point(53, 112);
            this.companyName.Multiline = false;
            this.companyName.Name = "companyName";
            this.companyName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.companyName.PasswordChar = false;
            this.companyName.Placeholder = "Default Placeholder...";
            this.companyName.PlaceholderActiveForeColor = System.Drawing.Color.Gray;
            this.companyName.placeholderBackColor = System.Drawing.SystemColors.Window;
            this.companyName.PlaceholderFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyName.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.companyName.Size = new System.Drawing.Size(227, 32);
            this.companyName.TabIndex = 5;
            this.companyName.Texts = "";
            this.companyName.UnderlinedStyle = false;
            // 
            // ifUserName
            // 
            this.ifUserName.BackColor = System.Drawing.SystemColors.Window;
            this.ifUserName.BackgroundImage = global::CustomController.Properties.Resources.userInputField;
            this.ifUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ifUserName.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.ifUserName.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.ifUserName.BorderRadius = 10;
            this.ifUserName.BorderSize = 2;
            this.ifUserName.Location = new System.Drawing.Point(515, 73);
            this.ifUserName.MinimumSize = new System.Drawing.Size(227, 55);
            this.ifUserName.Multiline = false;
            this.ifUserName.Name = "ifUserName";
            this.ifUserName.Padding = new System.Windows.Forms.Padding(40, 18, 7, 7);
            this.ifUserName.PasswordChar = false;
            this.ifUserName.Placeholder = "User";
            this.ifUserName.PlaceholderActiveForeColor = System.Drawing.Color.Gray;
            this.ifUserName.PlaceholderFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ifUserName.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.ifUserName.Size = new System.Drawing.Size(230, 55);
            this.ifUserName.TabIndex = 7;
            this.ifUserName.UnderlinedStyle = false;
            // 
            // EntryPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ifUserName);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.userName);
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
        private CTextBox userName;
        private Controls.CButton btnApply;
        private CTextBox companyName;
        private Controls.CTextBoxWatermak ifUserName;
    }
}