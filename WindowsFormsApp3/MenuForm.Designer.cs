namespace WindowsFormsApp3
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.searchBtn1 = new WindowsFormsApp3.RoundedButton();
            this.WatchListBtn = new WindowsFormsApp3.RoundedButton();
            this.ExitBtn = new WindowsFormsApp3.RoundedButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.WatchLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBtn1
            // 
            this.searchBtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn1.BackgroundImage")));
            this.searchBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn1.Location = new System.Drawing.Point(228, 90);
            this.searchBtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBtn1.Name = "searchBtn1";
            this.searchBtn1.Size = new System.Drawing.Size(164, 146);
            this.searchBtn1.TabIndex = 0;
            this.searchBtn1.UseVisualStyleBackColor = true;
            this.searchBtn1.Click += new System.EventHandler(this.searchBtn1_Click);
            // 
            // WatchListBtn
            // 
            this.WatchListBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WatchListBtn.BackgroundImage")));
            this.WatchListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WatchListBtn.Location = new System.Drawing.Point(568, 90);
            this.WatchListBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WatchListBtn.Name = "WatchListBtn";
            this.WatchListBtn.Size = new System.Drawing.Size(164, 146);
            this.WatchListBtn.TabIndex = 1;
            this.WatchListBtn.UseVisualStyleBackColor = true;
            this.WatchListBtn.Click += new System.EventHandler(this.WatchListBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(413, 292);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(164, 146);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(268, 240);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(77, 23);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search";
            // 
            // WatchLabel
            // 
            this.WatchLabel.AutoSize = true;
            this.WatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.WatchLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.WatchLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.WatchLabel.Location = new System.Drawing.Point(581, 240);
            this.WatchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WatchLabel.Name = "WatchLabel";
            this.WatchLabel.Size = new System.Drawing.Size(133, 23);
            this.WatchLabel.TabIndex = 4;
            this.WatchLabel.Text = "My Watchlist";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(472, 442);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(42, 23);
            this.ExitLabel.TabIndex = 5;
            this.ExitLabel.Text = "Exit";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.WatchLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.WatchListBtn);
            this.Controls.Add(this.searchBtn1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton searchBtn1;
        private RoundedButton WatchListBtn;
        private RoundedButton ExitBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label WatchLabel;
        private System.Windows.Forms.Label ExitLabel;
    }
}