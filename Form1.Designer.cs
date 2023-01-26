
namespace Example2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientName = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ServicesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShopsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.srchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Laundry = new System.Windows.Forms.Button();
            this.btn_Tv = new System.Windows.Forms.Button();
            this.btn_AirC = new System.Windows.Forms.Button();
            this.btn_Phone = new System.Windows.Forms.Button();
            this.Btn_hladilnici = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clientName);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 41);
            this.panel1.TabIndex = 0;
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Location = new System.Drawing.Point(108, 17);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(38, 15);
            this.clientName.TabIndex = 2;
            this.clientName.Text = "label2";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(11, 17);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(91, 15);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Добре Дошли: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServicesMenu,
            this.ShopsMenu,
            this.ContactMenu});
            this.menuStrip1.Location = new System.Drawing.Point(673, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // ServicesMenu
            // 
            this.ServicesMenu.Name = "ServicesMenu";
            this.ServicesMenu.Size = new System.Drawing.Size(57, 20);
            this.ServicesMenu.Text = "Услуги";
            // 
            // ShopsMenu
            // 
            this.ShopsMenu.Name = "ShopsMenu";
            this.ShopsMenu.Size = new System.Drawing.Size(73, 20);
            this.ShopsMenu.Text = "Магазини";
            // 
            // ContactMenu
            // 
            this.ContactMenu.Name = "ContactMenu";
            this.ContactMenu.Size = new System.Drawing.Size(69, 20);
            this.ContactMenu.Text = "Контакти";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.srchBtn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(207, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 89);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImage = global::Example2.Properties.Resources.logo1;
            this.pictureBox1.Image = global::Example2.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(584, 38);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(90, 29);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "ВХОД";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            this.btnLog.MouseLeave += new System.EventHandler(this.OnMouseLeaveBtn);
            this.btnLog.MouseHover += new System.EventHandler(this.OnMouseHoverBtn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // srchBtn
            // 
            this.srchBtn.BackColor = System.Drawing.Color.White;
            this.srchBtn.Location = new System.Drawing.Point(456, 44);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(75, 23);
            this.srchBtn.TabIndex = 2;
            this.srchBtn.Text = "Търси";
            this.srchBtn.UseVisualStyleBackColor = false;
            this.srchBtn.MouseLeave += new System.EventHandler(this.OnSearchLeaveBtn);
            this.srchBtn.MouseHover += new System.EventHandler(this.OnSearchHoverBtn);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Търсене";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.btn_Laundry);
            this.panel3.Controls.Add(this.btn_Tv);
            this.panel3.Controls.Add(this.btn_AirC);
            this.panel3.Controls.Add(this.btn_Phone);
            this.panel3.Controls.Add(this.Btn_hladilnici);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(1, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 65);
            this.panel3.TabIndex = 2;
            // 
            // btn_Laundry
            // 
            this.btn_Laundry.BackColor = System.Drawing.Color.Red;
            this.btn_Laundry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Laundry.FlatAppearance.BorderSize = 0;
            this.btn_Laundry.Location = new System.Drawing.Point(0, 213);
            this.btn_Laundry.Name = "btn_Laundry";
            this.btn_Laundry.Size = new System.Drawing.Size(208, 37);
            this.btn_Laundry.TabIndex = 5;
            this.btn_Laundry.Text = "Перални";
            this.btn_Laundry.UseVisualStyleBackColor = false;
            this.btn_Laundry.Click += new System.EventHandler(this.btn_Laundry_Click);
            // 
            // btn_Tv
            // 
            this.btn_Tv.BackColor = System.Drawing.Color.Red;
            this.btn_Tv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tv.FlatAppearance.BorderSize = 0;
            this.btn_Tv.Location = new System.Drawing.Point(0, 176);
            this.btn_Tv.Name = "btn_Tv";
            this.btn_Tv.Size = new System.Drawing.Size(208, 37);
            this.btn_Tv.TabIndex = 4;
            this.btn_Tv.Text = "Телевизори";
            this.btn_Tv.UseVisualStyleBackColor = false;
            this.btn_Tv.Click += new System.EventHandler(this.btn_Tv_Click_1);
            // 
            // btn_AirC
            // 
            this.btn_AirC.BackColor = System.Drawing.Color.Red;
            this.btn_AirC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AirC.FlatAppearance.BorderSize = 0;
            this.btn_AirC.Location = new System.Drawing.Point(0, 139);
            this.btn_AirC.Name = "btn_AirC";
            this.btn_AirC.Size = new System.Drawing.Size(208, 37);
            this.btn_AirC.TabIndex = 3;
            this.btn_AirC.Text = "Климатици";
            this.btn_AirC.UseVisualStyleBackColor = false;
            this.btn_AirC.Click += new System.EventHandler(this.btn_AirC_Click);
            // 
            // btn_Phone
            // 
            this.btn_Phone.BackColor = System.Drawing.Color.Red;
            this.btn_Phone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Phone.FlatAppearance.BorderSize = 0;
            this.btn_Phone.Location = new System.Drawing.Point(0, 102);
            this.btn_Phone.Name = "btn_Phone";
            this.btn_Phone.Size = new System.Drawing.Size(208, 37);
            this.btn_Phone.TabIndex = 2;
            this.btn_Phone.Text = "Телефони";
            this.btn_Phone.UseVisualStyleBackColor = false;
            this.btn_Phone.Click += new System.EventHandler(this.btn_Phone_Click);
            // 
            // Btn_hladilnici
            // 
            this.Btn_hladilnici.BackColor = System.Drawing.Color.Red;
            this.Btn_hladilnici.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_hladilnici.FlatAppearance.BorderSize = 0;
            this.Btn_hladilnici.Location = new System.Drawing.Point(0, 65);
            this.Btn_hladilnici.Name = "Btn_hladilnici";
            this.Btn_hladilnici.Size = new System.Drawing.Size(208, 37);
            this.Btn_hladilnici.TabIndex = 1;
            this.Btn_hladilnici.Text = "Хладилници";
            this.Btn_hladilnici.UseVisualStyleBackColor = false;
            this.Btn_hladilnici.Click += new System.EventHandler(this.Btn_hladilnici_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 65);
            this.button4.TabIndex = 0;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(1, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 27);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 603);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ServicesMenu;
        private System.Windows.Forms.ToolStripMenuItem ShopsMenu;
        private System.Windows.Forms.ToolStripMenuItem ContactMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_AirC;
        private System.Windows.Forms.Button btn_Phone;
        private System.Windows.Forms.Button Btn_hladilnici;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Laundry;
        private System.Windows.Forms.Button btn_Tv;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

