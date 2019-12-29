namespace WindowsFormsApp3
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.movie = new System.Windows.Forms.ToolStripMenuItem();
            this.actor = new System.Windows.Forms.ToolStripMenuItem();
            this.writer = new System.Windows.Forms.ToolStripMenuItem();
            this.director = new System.Windows.Forms.ToolStripMenuItem();
            this.country = new System.Windows.Forms.ToolStripMenuItem();
            this.language = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownmenu = new System.Windows.Forms.Button();
            this.whatsearch = new System.Windows.Forms.Label();
            this.searchBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeBtn = new WindowsFormsApp3.RoundedButton();
            this.searchBtn = new WindowsFormsApp3.RoundedButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movie,
            this.actor,
            this.writer,
            this.director,
            this.country,
            this.language});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 148);
            // 
            // movie
            // 
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(143, 24);
            this.movie.Text = "Movie";
            // 
            // actor
            // 
            this.actor.Name = "actor";
            this.actor.Size = new System.Drawing.Size(143, 24);
            this.actor.Text = "Actor";
            // 
            // writer
            // 
            this.writer.Name = "writer";
            this.writer.Size = new System.Drawing.Size(143, 24);
            this.writer.Text = "Writer";
            // 
            // director
            // 
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(143, 24);
            this.director.Text = "Director";
            // 
            // country
            // 
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(143, 24);
            this.country.Text = "Country";
            // 
            // language
            // 
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(143, 24);
            this.language.Text = "Language";
            // 
            // dropdownmenu
            // 
            this.dropdownmenu.BackColor = System.Drawing.SystemColors.Menu;
            this.dropdownmenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dropdownmenu.Image = ((System.Drawing.Image)(resources.GetObject("dropdownmenu.Image")));
            this.dropdownmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dropdownmenu.Location = new System.Drawing.Point(448, 153);
            this.dropdownmenu.Margin = new System.Windows.Forms.Padding(4);
            this.dropdownmenu.Name = "dropdownmenu";
            this.dropdownmenu.Size = new System.Drawing.Size(459, 58);
            this.dropdownmenu.TabIndex = 1;
            this.dropdownmenu.UseVisualStyleBackColor = false;
            this.dropdownmenu.Click += new System.EventHandler(this.dropdownmenu_Click);
            // 
            // whatsearch
            // 
            this.whatsearch.AutoSize = true;
            this.whatsearch.BackColor = System.Drawing.Color.Transparent;
            this.whatsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whatsearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.whatsearch.ForeColor = System.Drawing.Color.White;
            this.whatsearch.Location = new System.Drawing.Point(84, 169);
            this.whatsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.whatsearch.Name = "whatsearch";
            this.whatsearch.Size = new System.Drawing.Size(339, 28);
            this.whatsearch.TabIndex = 2;
            this.whatsearch.Text = "What are you searching for?";
            this.whatsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox1
            // 
            this.searchBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchBox1.Location = new System.Drawing.Point(448, 233);
            this.searchBox1.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(457, 37);
            this.searchBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.Location = new System.Drawing.Point(16, 15);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(105, 94);
            this.HomeBtn.TabIndex = 7;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(941, 169);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(95, 86);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox1);
            this.Controls.Add(this.whatsearch);
            this.Controls.Add(this.dropdownmenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movie;
        private System.Windows.Forms.ToolStripMenuItem actor;
        private System.Windows.Forms.ToolStripMenuItem writer;
        private System.Windows.Forms.ToolStripMenuItem director;
        private System.Windows.Forms.ToolStripMenuItem country;
        private System.Windows.Forms.ToolStripMenuItem language;
        private System.Windows.Forms.Button dropdownmenu;
        private System.Windows.Forms.Label whatsearch;
        private System.Windows.Forms.TextBox searchBox1;
        private System.Windows.Forms.Label label1;
        private RoundedButton searchBtn;
        private RoundedButton HomeBtn;
    }
}