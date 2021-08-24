
namespace CustomController.Controls
{
    partial class CTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputPlaceholder = new CustomController.Controls.CTextBoxAlternative();
            this.SuspendLayout();
            // 
            // inputPlaceholder
            // 
            this.inputPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPlaceholder.Location = new System.Drawing.Point(10, 7);
            this.inputPlaceholder.Name = "inputPlaceholder";
            this.inputPlaceholder.Size = new System.Drawing.Size(210, 16);
            this.inputPlaceholder.TabIndex = 0;
            this.inputPlaceholder.WaterMark = "Default Watermark...";
            this.inputPlaceholder.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.inputPlaceholder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPlaceholder.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.inputPlaceholder.Click += new System.EventHandler(this.inputPlaceholder_Click);
            this.inputPlaceholder.TextChanged += new System.EventHandler(this.inputPlaceholder_TextChanged);
            this.inputPlaceholder.Enter += new System.EventHandler(this.inputPlaceholder_Enter);
            this.inputPlaceholder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputPlaceholder_KeyDown);
            this.inputPlaceholder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPlaceholder_KeyPress);
            this.inputPlaceholder.Leave += new System.EventHandler(this.inputPlaceholder_Leave);
            this.inputPlaceholder.MouseEnter += new System.EventHandler(this.inputPlaceholder_MouseEnter);
            // 
            // CTextBoxWatermak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.inputPlaceholder);
            this.Name = "CTextBoxWatermak";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(230, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTextBoxAlternative inputPlaceholder;
    }
}
