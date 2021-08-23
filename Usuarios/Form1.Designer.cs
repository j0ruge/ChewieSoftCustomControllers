
namespace VDRDataAnalyzer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonRecuperar = new System.Windows.Forms.Button();
            this.buttonRecuperarJSON = new System.Windows.Forms.Button();
            this.buttonSalvarJSON = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonRecuperarCripto = new System.Windows.Forms.Button();
            this.buttonSalvarCripto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(100, 45);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(229, 23);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa:";
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(100, 74);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(229, 23);
            this.textBoxEmpresa.TabIndex = 2;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(100, 167);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(112, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar XML";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonRecuperar
            // 
            this.buttonRecuperar.Location = new System.Drawing.Point(222, 167);
            this.buttonRecuperar.Name = "buttonRecuperar";
            this.buttonRecuperar.Size = new System.Drawing.Size(107, 23);
            this.buttonRecuperar.TabIndex = 5;
            this.buttonRecuperar.Text = "Recuperar XML";
            this.buttonRecuperar.UseVisualStyleBackColor = true;
            this.buttonRecuperar.Click += new System.EventHandler(this.buttonRecuperar_Click);
            // 
            // buttonRecuperarJSON
            // 
            this.buttonRecuperarJSON.Location = new System.Drawing.Point(222, 196);
            this.buttonRecuperarJSON.Name = "buttonRecuperarJSON";
            this.buttonRecuperarJSON.Size = new System.Drawing.Size(107, 23);
            this.buttonRecuperarJSON.TabIndex = 7;
            this.buttonRecuperarJSON.Text = "Recuperar JSON";
            this.buttonRecuperarJSON.UseVisualStyleBackColor = true;
            this.buttonRecuperarJSON.Click += new System.EventHandler(this.buttonRecuperarJSON_Click);
            // 
            // buttonSalvarJSON
            // 
            this.buttonSalvarJSON.Location = new System.Drawing.Point(100, 196);
            this.buttonSalvarJSON.Name = "buttonSalvarJSON";
            this.buttonSalvarJSON.Size = new System.Drawing.Size(112, 23);
            this.buttonSalvarJSON.TabIndex = 6;
            this.buttonSalvarJSON.Text = "Salvar JSON";
            this.buttonSalvarJSON.UseVisualStyleBackColor = true;
            this.buttonSalvarJSON.Click += new System.EventHandler(this.buttonSalvarJSON_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(100, 138);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(112, 23);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonRecuperarCripto
            // 
            this.buttonRecuperarCripto.Location = new System.Drawing.Point(222, 225);
            this.buttonRecuperarCripto.Name = "buttonRecuperarCripto";
            this.buttonRecuperarCripto.Size = new System.Drawing.Size(107, 23);
            this.buttonRecuperarCripto.TabIndex = 10;
            this.buttonRecuperarCripto.Text = "Recuperar Cripto";
            this.buttonRecuperarCripto.UseVisualStyleBackColor = true;
            this.buttonRecuperarCripto.Click += new System.EventHandler(this.buttonRecuperarCripto_Click);
            // 
            // buttonSalvarCripto
            // 
            this.buttonSalvarCripto.Location = new System.Drawing.Point(100, 225);
            this.buttonSalvarCripto.Name = "buttonSalvarCripto";
            this.buttonSalvarCripto.Size = new System.Drawing.Size(112, 23);
            this.buttonSalvarCripto.TabIndex = 9;
            this.buttonSalvarCripto.Text = "Salvar Cripto";
            this.buttonSalvarCripto.UseVisualStyleBackColor = true;
            this.buttonSalvarCripto.Click += new System.EventHandler(this.buttonSalvarCripto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRecuperarCripto);
            this.Controls.Add(this.buttonSalvarCripto);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonRecuperarJSON);
            this.Controls.Add(this.buttonSalvarJSON);
            this.Controls.Add(this.buttonRecuperar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsuario);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonRecuperar;
        private System.Windows.Forms.Button buttonRecuperarJSON;
        private System.Windows.Forms.Button buttonSalvarJSON;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonRecuperarCripto;
        private System.Windows.Forms.Button buttonSalvarCripto;
    }
}

