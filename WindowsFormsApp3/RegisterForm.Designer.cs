namespace WindowsFormsApp3
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.User = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usr = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.DateTimePicker();
            this.SubmitBtn = new WindowsFormsApp3.RoundedButton();
            this.termtsek = new System.Windows.Forms.CheckBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.rgstr = new System.Windows.Forms.Panel();
            this.rgstr.SuspendLayout();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.User.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.User.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.User.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.User.Location = new System.Drawing.Point(310, 28);
            this.User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(152, 28);
            this.User.TabIndex = 0;
            this.User.Text = "Username";
            this.User.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mail
            // 
            this.mail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mail.Location = new System.Drawing.Point(310, 133);
            this.mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(152, 28);
            this.mail.TabIndex = 3;
            this.mail.Text = "Mail";
            this.mail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.password.Location = new System.Drawing.Point(310, 76);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(152, 28);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            this.password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usr
            // 
            this.usr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usr.Location = new System.Drawing.Point(488, 28);
            this.usr.Margin = new System.Windows.Forms.Padding(4);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(179, 22);
            this.usr.TabIndex = 5;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email.Location = new System.Drawing.Point(488, 139);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(179, 22);
            this.email.TabIndex = 8;
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pass.Location = new System.Drawing.Point(488, 82);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(179, 22);
            this.pass.TabIndex = 9;
            // 
            // birth
            // 
            this.birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.birth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.birth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birth.Location = new System.Drawing.Point(310, 193);
            this.birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(152, 28);
            this.birth.TabIndex = 11;
            this.birth.Text = "Birthdate";
            this.birth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cal
            // 
            this.cal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cal.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cal.CustomFormat = "";
            this.cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cal.Location = new System.Drawing.Point(488, 193);
            this.cal.Margin = new System.Windows.Forms.Padding(4);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(179, 30);
            this.cal.TabIndex = 13;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SubmitBtn.Location = new System.Drawing.Point(399, 354);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(215, 85);
            this.SubmitBtn.TabIndex = 10;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // termtsek
            // 
            this.termtsek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.termtsek.AutoSize = true;
            this.termtsek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.termtsek.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.termtsek.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.termtsek.Location = new System.Drawing.Point(294, 264);
            this.termtsek.Margin = new System.Windows.Forms.Padding(4);
            this.termtsek.Name = "termtsek";
            this.termtsek.Size = new System.Drawing.Size(240, 23);
            this.termtsek.TabIndex = 14;
            this.termtsek.Text = "I accept Terms and Conditions";
            this.termtsek.UseVisualStyleBackColor = false;
            this.termtsek.CheckedChanged += new System.EventHandler(this.termtsek_CheckedChanged_1);
            // 
            // backbutton
            // 
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.Location = new System.Drawing.Point(13, 4);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(145, 55);
            this.backbutton.TabIndex = 15;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // rgstr
            // 
            this.rgstr.BackColor = System.Drawing.Color.White;
            this.rgstr.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._42587227_262024617783525_8359530981211766784_n;
            this.rgstr.Controls.Add(this.User);
            this.rgstr.Controls.Add(this.backbutton);
            this.rgstr.Controls.Add(this.password);
            this.rgstr.Controls.Add(this.SubmitBtn);
            this.rgstr.Controls.Add(this.termtsek);
            this.rgstr.Controls.Add(this.mail);
            this.rgstr.Controls.Add(this.cal);
            this.rgstr.Controls.Add(this.birth);
            this.rgstr.Controls.Add(this.usr);
            this.rgstr.Controls.Add(this.email);
            this.rgstr.Controls.Add(this.pass);
            this.rgstr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgstr.Location = new System.Drawing.Point(0, 0);
            this.rgstr.Name = "rgstr";
            this.rgstr.Size = new System.Drawing.Size(1067, 554);
            this.rgstr.TabIndex = 16;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rgstr);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "Form2";
            this.rgstr.ResumeLayout(false);
            this.rgstr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usr;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private RoundedButton SubmitBtn;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.DateTimePicker cal;
        private System.Windows.Forms.CheckBox termtsek;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Panel rgstr;
    }
}