
namespace Example2
{
    partial class Form5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MessageTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "пп";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 108);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contact Form";
            // 
            // emailTxt
            // 
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTxt.Location = new System.Drawing.Point(101, 225);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(199, 23);
            this.emailTxt.TabIndex = 4;
            this.emailTxt.Text = "Въведете имейл";
            this.emailTxt.Enter += new System.EventHandler(this.emailText_enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailText_leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Имейл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(397, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Телефон";
            // 
            // nameTxt
            // 
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameTxt.Location = new System.Drawing.Point(101, 184);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(199, 23);
            this.nameTxt.TabIndex = 8;
            this.nameTxt.Text = "Въведете име";
            this.nameTxt.Enter += new System.EventHandler(this.nameTxt_enter);
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_leave);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneTxt.Location = new System.Drawing.Point(472, 184);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(199, 23);
            this.phoneTxt.TabIndex = 9;
            this.phoneTxt.Text = "Въведете телефон";
            this.phoneTxt.Enter += new System.EventHandler(this.phoneTxt_enter);
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(397, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Град";
            // 
            // cityTxt
            // 
            this.cityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cityTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cityTxt.Location = new System.Drawing.Point(472, 225);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(199, 23);
            this.cityTxt.TabIndex = 11;
            this.cityTxt.Text = "Въведете град";
            this.cityTxt.Enter += new System.EventHandler(this.city_enter);
            this.cityTxt.Leave += new System.EventHandler(this.city_leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(153, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Въведете съобщение";
            // 
            // MessageTxt
            // 
            this.MessageTxt.Location = new System.Drawing.Point(153, 304);
            this.MessageTxt.Multiline = true;
            this.MessageTxt.Name = "MessageTxt";
            this.MessageTxt.Size = new System.Drawing.Size(400, 150);
            this.MessageTxt.TabIndex = 13;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Red;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(569, 418);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(125, 36);
            this.sendBtn.TabIndex = 14;
            this.sendBtn.Text = "Изпрати";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Red;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 418);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 36);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 458);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.MessageTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MessageTxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button backBtn;
    }
}