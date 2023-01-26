
namespace Example2
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 68);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(455, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(428, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Име";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Имейл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Парола";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Телефон";
            // 
            // nameTxt
            // 
            this.nameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameTxt.Location = new System.Drawing.Point(91, 150);
            this.nameTxt.MaximumSize = new System.Drawing.Size(138, 28);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(138, 23);
            this.nameTxt.TabIndex = 5;
            this.nameTxt.Text = "Въведете име";
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            this.nameTxt.Enter += new System.EventHandler(this.nameTxt_enter);
            this.nameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTxt_KeyDown);
            this.nameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxt_KeyPress);
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_leave);
            // 
            // emailTxt
            // 
            this.emailTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTxt.Location = new System.Drawing.Point(91, 195);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(138, 23);
            this.emailTxt.TabIndex = 6;
            this.emailTxt.Text = "Въведете имейл";
            this.emailTxt.Enter += new System.EventHandler(this.emailTxt_enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_leave);
            // 
            // passTxt
            // 
            this.passTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passTxt.Location = new System.Drawing.Point(91, 240);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(138, 23);
            this.passTxt.TabIndex = 7;
            this.passTxt.Text = "Въведете парола";
            this.passTxt.Enter += new System.EventHandler(this.passTxt_enter);
            this.passTxt.Leave += new System.EventHandler(this.passTxt_leave);
            // 
            // phoneTxt
            // 
            this.phoneTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneTxt.Location = new System.Drawing.Point(91, 333);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(138, 23);
            this.phoneTxt.TabIndex = 8;
            this.phoneTxt.Text = "Въведете телефон";
            this.phoneTxt.Enter += new System.EventHandler(this.phoneTxt_enter);
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(197, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "От Град";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cityTxt
            // 
            this.cityTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cityTxt.Location = new System.Drawing.Point(91, 287);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(138, 23);
            this.cityTxt.TabIndex = 11;
            this.cityTxt.Text = "Въведете град";
            this.cityTxt.TextChanged += new System.EventHandler(this.cityTxt_TextChanged);
            this.cityTxt.Enter += new System.EventHandler(this.city_enter);
            this.cityTxt.Leave += new System.EventHandler(this.city_leave);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 424);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cityTxt;
    }
}