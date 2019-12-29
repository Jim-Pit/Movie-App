namespace WindowsFormsApp3
{
    partial class Rats
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
            this.ratpan = new System.Windows.Forms.Panel();
            this.hitrate = new System.Windows.Forms.Button();
            this.rates = new System.Windows.Forms.GroupBox();
            this.r5 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.ratpan.SuspendLayout();
            this.rates.SuspendLayout();
            this.SuspendLayout();
            // 
            // ratpan
            // 
            this.ratpan.Controls.Add(this.hitrate);
            this.ratpan.Controls.Add(this.rates);
            this.ratpan.Location = new System.Drawing.Point(12, 12);
            this.ratpan.Name = "ratpan";
            this.ratpan.Size = new System.Drawing.Size(190, 227);
            this.ratpan.TabIndex = 9;
            // 
            // hitrate
            // 
            this.hitrate.Location = new System.Drawing.Point(50, 192);
            this.hitrate.Name = "hitrate";
            this.hitrate.Size = new System.Drawing.Size(93, 32);
            this.hitrate.TabIndex = 5;
            this.hitrate.Text = "HIT IT";
            this.hitrate.UseVisualStyleBackColor = true;
            this.hitrate.Click += new System.EventHandler(this.hitrate_Click);
            // 
            // rates
            // 
            this.rates.Controls.Add(this.r5);
            this.rates.Controls.Add(this.r4);
            this.rates.Controls.Add(this.r3);
            this.rates.Controls.Add(this.r2);
            this.rates.Controls.Add(this.r1);
            this.rates.Location = new System.Drawing.Point(51, 3);
            this.rates.Name = "rates";
            this.rates.Size = new System.Drawing.Size(93, 158);
            this.rates.TabIndex = 7;
            this.rates.TabStop = false;
            this.rates.Text = "Rates";
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Location = new System.Drawing.Point(7, 134);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(68, 21);
            this.r5.TabIndex = 4;
            this.r5.TabStop = true;
            this.r5.Text = "kikass";
            this.r5.UseVisualStyleBackColor = true;
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(7, 106);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(55, 21);
            this.r4.TabIndex = 3;
            this.r4.TabStop = true;
            this.r4.Text = "cool";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(7, 78);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(85, 21);
            this.r3.TabIndex = 2;
            this.r3.TabStop = true;
            this.r3.Text = "n\'joyable";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(7, 50);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(65, 21);
            this.r2.TabIndex = 1;
            this.r2.TabStop = true;
            this.r2.Text = "m\'kay";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(7, 22);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(59, 21);
            this.r1.TabIndex = 0;
            this.r1.TabStop = true;
            this.r1.Text = "lame";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // Rats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 253);
            this.Controls.Add(this.ratpan);
            this.Name = "Rats";
            this.Text = "Rator";
            this.ratpan.ResumeLayout(false);
            this.rates.ResumeLayout(false);
            this.rates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ratpan;
        private System.Windows.Forms.Button hitrate;
        private System.Windows.Forms.GroupBox rates;
        private System.Windows.Forms.RadioButton r5;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
    }
}