
namespace CustomController
{
    partial class CTextBoxWatermak
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
            this.inputField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputField.Location = new System.Drawing.Point(10, 7);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(230, 17);
            this.inputField.TabIndex = 0;
            this.inputField.Click += new System.EventHandler(this.inputField_Click);
            this.inputField.TextChanged += new System.EventHandler(this.inputField_TextChanged);
            this.inputField.Enter += new System.EventHandler(this.inputField_Enter);
            this.inputField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputField_KeyDown);
            this.inputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputField_KeyPress);
            this.inputField.Leave += new System.EventHandler(this.inputField_Leave);
            this.inputField.MouseEnter += new System.EventHandler(this.inputField_MouseEnter);
            this.inputField.MouseLeave += new System.EventHandler(this.inputField_MouseLeave);
            // 
            // CTextBoxWatermak
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.inputField);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "CTextBoxWatermak";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputField;
    }
}
