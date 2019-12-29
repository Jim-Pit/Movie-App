namespace WindowsFormsApp3
{
    partial class watchli
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
            this.screen = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.FormattingEnabled = true;
            this.screen.ItemHeight = 16;
            this.screen.Location = new System.Drawing.Point(46, 23);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(300, 308);
            this.screen.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 112);
            this.button1.TabIndex = 20;
            this.button1.Text = "DELETE?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // watchli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.screen);
            this.Name = "watchli";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.watchli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox screen;
        private System.Windows.Forms.Button button1;
    }
}