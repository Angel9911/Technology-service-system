
namespace Example2
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_pass = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnLog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 73);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(150, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "SIGN IN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имейл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Парола";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_email.Location = new System.Drawing.Point(133, 148);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(165, 23);
            this.txtbox_email.TabIndex = 3;
            this.txtbox_email.Text = "Въведете имейл";
            this.txtbox_email.TextChanged += new System.EventHandler(this.txtbox_email_TextChanged);
            this.txtbox_email.Enter += new System.EventHandler(this.emailText_enter);
            this.txtbox_email.Leave += new System.EventHandler(this.emailText_leave);
            // 
            // txtbox_pass
            // 
            this.txtbox_pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbox_pass.Location = new System.Drawing.Point(133, 204);
            this.txtbox_pass.Name = "txtbox_pass";
            this.txtbox_pass.Size = new System.Drawing.Size(165, 23);
            this.txtbox_pass.TabIndex = 4;
            this.txtbox_pass.Text = "Въведете парола";
            this.txtbox_pass.Enter += new System.EventHandler(this.passwordTxt_enter);
            this.txtbox_pass.Leave += new System.EventHandler(this.passwordTxt_leave);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(28, 285);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 36);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.Color.Red;
            this.BtnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLog.ForeColor = System.Drawing.Color.White;
            this.BtnLog.Location = new System.Drawing.Point(284, 285);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(95, 36);
            this.BtnLog.TabIndex = 6;
            this.BtnLog.Text = "Login";
            this.BtnLog.UseVisualStyleBackColor = false;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(84, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "click here to create new account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.txtbox_pass);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_pass;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.Label label4;
    }
}