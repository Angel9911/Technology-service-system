
namespace Example2
{
    partial class Shops
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
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.webView1 = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.lblTableView = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCity
            // 
            this.listBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCity.BackColor = System.Drawing.Color.Red;
            this.listBoxCity.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listBoxCity.ForeColor = System.Drawing.Color.White;
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 23;
            this.listBoxCity.Location = new System.Drawing.Point(714, 52);
            this.listBoxCity.Margin = new System.Windows.Forms.Padding(9, 10, 3, 3);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(175, 579);
            this.listBoxCity.TabIndex = 0;
            this.listBoxCity.SelectedIndexChanged += new System.EventHandler(this.listBoxCity_SelectedIndexChanged);
            // 
            // webView1
            // 
            this.webView1.Location = new System.Drawing.Point(12, 52);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(696, 579);
            this.webView1.TabIndex = 1;
            this.webView1.DOMContentLoaded += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs>(this.webView1_DOMContentLoaded);
            // 
            // lblTableView
            // 
            this.lblTableView.AutoSize = true;
            this.lblTableView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTableView.ForeColor = System.Drawing.Color.Red;
            this.lblTableView.Location = new System.Drawing.Point(12, 18);
            this.lblTableView.Name = "lblTableView";
            this.lblTableView.Size = new System.Drawing.Size(365, 15);
            this.lblTableView.TabIndex = 2;
            this.lblTableView.Text = "Вижте информация за всичките магазини и работното им време";
            this.lblTableView.Click += new System.EventHandler(this.lblTableView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(714, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Градове";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Red;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(382, 637);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 36);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Shops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 681);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTableView);
            this.Controls.Add(this.webView1);
            this.Controls.Add(this.listBoxCity);
            this.Name = "Shops";
            this.Text = "Shops";
            this.Load += new System.EventHandler(this.Shops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCity;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView webView1;
        private System.Windows.Forms.Label lblTableView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
    }
}