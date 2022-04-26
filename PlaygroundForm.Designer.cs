
namespace CustomController
{
    partial class PlaygroundForm
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
            this.cTextBox1 = new CustomController.Controls.CTextBox();
            this.cTextBoxAlternative1 = new CustomController.Controls.CTextBoxAlternative();
            this.cComboBox1 = new CustomController.Controls.CComboBox();
            this.SuspendLayout();
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox1.BorderFocusColor = System.Drawing.Color.DarkMagenta;
            this.cTextBox1.BorderRadius = 10;
            this.cTextBox1.BorderSize = 2;
            this.cTextBox1.Location = new System.Drawing.Point(427, 143);
            this.cTextBox1.Multiline = false;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextBox1.PasswordChar = false;
            this.cTextBox1.Placeholder = "Default Watermark...";
            this.cTextBox1.PlaceholderActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBox1.PlaceholderFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cTextBox1.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.cTextBox1.Size = new System.Drawing.Size(230, 30);
            this.cTextBox1.TabIndex = 1;
            this.cTextBox1.UnderlinedStyle = false;
            // 
            // cTextBoxAlternative1
            // 
            this.cTextBoxAlternative1.Location = new System.Drawing.Point(520, 274);
            this.cTextBoxAlternative1.Name = "cTextBoxAlternative1";
            this.cTextBoxAlternative1.Size = new System.Drawing.Size(100, 23);
            this.cTextBoxAlternative1.TabIndex = 2;
            this.cTextBoxAlternative1.WaterMark = "Default Watermark...";
            this.cTextBoxAlternative1.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBoxAlternative1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cTextBoxAlternative1.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // cComboBox1
            // 
            this.cComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cComboBox1.BorderFocusColor = System.Drawing.Color.DarkMagenta;
            this.cComboBox1.BorderRadius = 10;
            this.cComboBox1.BorderSize = 0;
            this.cComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.cComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cComboBox1.Items.AddRange(new object[] {
            "Channel",
            "Data"});
            this.cComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.cComboBox1.Location = new System.Drawing.Point(192, 246);
            this.cComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.cComboBox1.Name = "cComboBox1";
            this.cComboBox1.Size = new System.Drawing.Size(200, 30);
            this.cComboBox1.TabIndex = 3;
            this.cComboBox1.Texts = "";
            // 
            // PlaygroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cComboBox1);
            this.Controls.Add(this.cTextBoxAlternative1);
            this.Controls.Add(this.cTextBox1);
            this.Name = "PlaygroundForm";
            this.Text = "PlaygroundForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.CTextBox cTextBox1;
        private Controls.CTextBoxAlternative cTextBoxAlternative1;
        private Controls.CComboBox cComboBox1;
    }
}