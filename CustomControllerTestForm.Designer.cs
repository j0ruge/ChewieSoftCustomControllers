
namespace CustomController
{
    partial class CustomControllerTestForm
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
            this.cTextBox1 = new CustomController.CTextBox();
            this.cTextBox2 = new CustomController.CTextBox();
            this.SuspendLayout();
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cTextBox1.BorderSize = 2;
            this.cTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox1.Location = new System.Drawing.Point(535, 12);
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox1.Size = new System.Drawing.Size(253, 32);
            this.cTextBox1.TabIndex = 0;
            this.cTextBox1.UnderlinedStyle = false;
            // 
            // cTextBox2
            // 
            this.cTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.cTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextBox2.BorderSize = 2;
            this.cTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.cTextBox2.Location = new System.Drawing.Point(535, 64);
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox2.Size = new System.Drawing.Size(253, 32);
            this.cTextBox2.TabIndex = 0;
            this.cTextBox2.UnderlinedStyle = true;
            // 
            // CustomControllerTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cTextBox2);
            this.Controls.Add(this.cTextBox1);
            this.Name = "CustomControllerTestForm";
            this.Text = "CustomControllerTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CTextBox cTextBox1;
        private CTextBox cTextBox2;
    }
}