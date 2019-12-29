namespace WindowsFormsApp3
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.AddWatch = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.DataGridView();
            this.RateBtn = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.ListBox();
            this.info = new System.Windows.Forms.RichTextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWatch
            // 
            this.AddWatch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWatch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddWatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddWatch.Location = new System.Drawing.Point(881, 42);
            this.AddWatch.Margin = new System.Windows.Forms.Padding(4);
            this.AddWatch.Name = "AddWatch";
            this.AddWatch.Size = new System.Drawing.Size(169, 50);
            this.AddWatch.TabIndex = 0;
            this.AddWatch.Text = "Add to Watchlist";
            this.AddWatch.UseVisualStyleBackColor = false;
            this.AddWatch.Click += new System.EventHandler(this.AddWatch_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultBox.Location = new System.Drawing.Point(531, 228);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(515, 220);
            this.ResultBox.TabIndex = 1;
            // 
            // RateBtn
            // 
            this.RateBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RateBtn.Location = new System.Drawing.Point(877, 129);
            this.RateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RateBtn.Name = "RateBtn";
            this.RateBtn.Size = new System.Drawing.Size(169, 50);
            this.RateBtn.TabIndex = 2;
            this.RateBtn.Text = "Rate This!";
            this.RateBtn.UseVisualStyleBackColor = false;
            this.RateBtn.Click += new System.EventHandler(this.RateBtn_Click);
            // 
            // screen
            // 
            this.screen.FormattingEnabled = true;
            this.screen.ItemHeight = 16;
            this.screen.Location = new System.Drawing.Point(12, 12);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(395, 436);
            this.screen.TabIndex = 18;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(413, 13);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(305, 208);
            this.info.TabIndex = 19;
            this.info.Text = "";
            // 
            // backbutton
            // 
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.Location = new System.Drawing.Point(33, 469);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(145, 55);
            this.backbutton.TabIndex = 16;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(956, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1059, 559);
            this.Controls.Add(this.info);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.RateBtn);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.AddWatch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWatch;
        private System.Windows.Forms.DataGridView ResultBox;
        private System.Windows.Forms.Button RateBtn;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.ListBox screen;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label label1;
    }
}