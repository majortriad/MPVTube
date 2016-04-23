namespace mpvtube
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
		{
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.qualityBox = new System.Windows.Forms.GroupBox();
			this.audioQuality = new System.Windows.Forms.RadioButton();
			this.lowQuality = new System.Windows.Forms.RadioButton();
			this.highQuality = new System.Windows.Forms.RadioButton();
			this.playBtn = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signInToYouTubeNAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enterURLToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeAfterStartingVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resultsList = new System.Windows.Forms.ListView();
			this.titleCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.uploaderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dateTimeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.descriptCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mpvLow = new System.Windows.Forms.RadioButton();
			this.mpvMedium = new System.Windows.Forms.RadioButton();
			this.mpvHigh = new System.Windows.Forms.RadioButton();
			this.mpvHighest = new System.Windows.Forms.RadioButton();
			this.mpvInsane = new System.Windows.Forms.RadioButton();
			this.qualityBox.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchTxt
			// 
			this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchTxt.Location = new System.Drawing.Point(12, 27);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(629, 20);
			this.searchTxt.TabIndex = 0;
			// 
			// searchBtn
			// 
			this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchBtn.Location = new System.Drawing.Point(647, 27);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 1;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// qualityBox
			// 
			this.qualityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.qualityBox.Controls.Add(this.audioQuality);
			this.qualityBox.Controls.Add(this.lowQuality);
			this.qualityBox.Controls.Add(this.highQuality);
			this.qualityBox.Location = new System.Drawing.Point(12, 53);
			this.qualityBox.Name = "qualityBox";
			this.qualityBox.Size = new System.Drawing.Size(236, 46);
			this.qualityBox.TabIndex = 3;
			this.qualityBox.TabStop = false;
			this.qualityBox.Text = "YouTube Quality";
			// 
			// audioQuality
			// 
			this.audioQuality.AutoSize = true;
			this.audioQuality.Enabled = false;
			this.audioQuality.Location = new System.Drawing.Point(117, 19);
			this.audioQuality.Name = "audioQuality";
			this.audioQuality.Size = new System.Drawing.Size(103, 17);
			this.audioQuality.TabIndex = 2;
			this.audioQuality.TabStop = true;
			this.audioQuality.Text = "Audio only (N/A)";
			this.audioQuality.UseVisualStyleBackColor = true;
			// 
			// lowQuality
			// 
			this.lowQuality.AutoSize = true;
			this.lowQuality.Location = new System.Drawing.Point(61, 19);
			this.lowQuality.Name = "lowQuality";
			this.lowQuality.Size = new System.Drawing.Size(49, 17);
			this.lowQuality.TabIndex = 1;
			this.lowQuality.TabStop = true;
			this.lowQuality.Text = "360p";
			this.lowQuality.UseVisualStyleBackColor = true;
			// 
			// highQuality
			// 
			this.highQuality.AutoSize = true;
			this.highQuality.Location = new System.Drawing.Point(6, 19);
			this.highQuality.Name = "highQuality";
			this.highQuality.Size = new System.Drawing.Size(49, 17);
			this.highQuality.TabIndex = 0;
			this.highQuality.TabStop = true;
			this.highQuality.Text = "720p";
			this.highQuality.UseVisualStyleBackColor = true;
			// 
			// playBtn
			// 
			this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playBtn.Enabled = false;
			this.playBtn.Location = new System.Drawing.Point(647, 56);
			this.playBtn.Name = "playBtn";
			this.playBtn.Size = new System.Drawing.Size(75, 43);
			this.playBtn.TabIndex = 4;
			this.playBtn.Text = "Play";
			this.playBtn.UseVisualStyleBackColor = true;
			this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(734, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToYouTubeNAToolStripMenuItem,
            this.enterURLToPlayToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// signInToYouTubeNAToolStripMenuItem
			// 
			this.signInToYouTubeNAToolStripMenuItem.Enabled = false;
			this.signInToYouTubeNAToolStripMenuItem.Name = "signInToYouTubeNAToolStripMenuItem";
			this.signInToYouTubeNAToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.signInToYouTubeNAToolStripMenuItem.Text = "Sign in to YouTube (N/A)";
			// 
			// enterURLToPlayToolStripMenuItem
			// 
			this.enterURLToPlayToolStripMenuItem.Name = "enterURLToPlayToolStripMenuItem";
			this.enterURLToPlayToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.enterURLToPlayToolStripMenuItem.Text = "Enter URL to play";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.closeAfterStartingVideoToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
			// 
			// closeAfterStartingVideoToolStripMenuItem
			// 
			this.closeAfterStartingVideoToolStripMenuItem.CheckOnClick = true;
			this.closeAfterStartingVideoToolStripMenuItem.Name = "closeAfterStartingVideoToolStripMenuItem";
			this.closeAfterStartingVideoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.closeAfterStartingVideoToolStripMenuItem.Text = "Close after starting video";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Enabled = false;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Enabled = false;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			// 
			// resultsList
			// 
			this.resultsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleCol,
            this.uploaderCol,
            this.dateTimeCol,
            this.descriptCol});
			this.resultsList.Location = new System.Drawing.Point(12, 105);
			this.resultsList.MultiSelect = false;
			this.resultsList.Name = "resultsList";
			this.resultsList.Size = new System.Drawing.Size(710, 344);
			this.resultsList.TabIndex = 6;
			this.resultsList.UseCompatibleStateImageBehavior = false;
			this.resultsList.View = System.Windows.Forms.View.Details;
			this.resultsList.SelectedIndexChanged += new System.EventHandler(this.resultsList_SelectedIndexChanged);
			this.resultsList.DoubleClick += new System.EventHandler(this.resultsList_DoubleClick);
			// 
			// titleCol
			// 
			this.titleCol.Text = "Title";
			this.titleCol.Width = 300;
			// 
			// uploaderCol
			// 
			this.uploaderCol.Text = "Uploader";
			this.uploaderCol.Width = 100;
			// 
			// dateTimeCol
			// 
			this.dateTimeCol.Text = "Time uploaded";
			this.dateTimeCol.Width = 150;
			// 
			// descriptCol
			// 
			this.descriptCol.Text = "Desciption";
			this.descriptCol.Width = 1000;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mpvInsane);
			this.groupBox1.Controls.Add(this.mpvHighest);
			this.groupBox1.Controls.Add(this.mpvHigh);
			this.groupBox1.Controls.Add(this.mpvMedium);
			this.groupBox1.Controls.Add(this.mpvLow);
			this.groupBox1.Location = new System.Drawing.Point(254, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(387, 46);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MPV Quality";
			// 
			// mpvLow
			// 
			this.mpvLow.AutoSize = true;
			this.mpvLow.Location = new System.Drawing.Point(6, 19);
			this.mpvLow.Name = "mpvLow";
			this.mpvLow.Size = new System.Drawing.Size(45, 17);
			this.mpvLow.TabIndex = 0;
			this.mpvLow.TabStop = true;
			this.mpvLow.Text = "Low";
			this.mpvLow.UseVisualStyleBackColor = true;
			// 
			// mpvMedium
			// 
			this.mpvMedium.AutoSize = true;
			this.mpvMedium.Location = new System.Drawing.Point(58, 19);
			this.mpvMedium.Name = "mpvMedium";
			this.mpvMedium.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.mpvMedium.Size = new System.Drawing.Size(62, 17);
			this.mpvMedium.TabIndex = 1;
			this.mpvMedium.TabStop = true;
			this.mpvMedium.Text = "Medium";
			this.mpvMedium.UseVisualStyleBackColor = true;
			// 
			// mpvHigh
			// 
			this.mpvHigh.AutoSize = true;
			this.mpvHigh.Location = new System.Drawing.Point(127, 19);
			this.mpvHigh.Name = "mpvHigh";
			this.mpvHigh.Size = new System.Drawing.Size(47, 17);
			this.mpvHigh.TabIndex = 2;
			this.mpvHigh.TabStop = true;
			this.mpvHigh.Text = "High";
			this.mpvHigh.UseVisualStyleBackColor = true;
			// 
			// mpvHighest
			// 
			this.mpvHighest.AutoSize = true;
			this.mpvHighest.Location = new System.Drawing.Point(181, 19);
			this.mpvHighest.Name = "mpvHighest";
			this.mpvHighest.Size = new System.Drawing.Size(61, 17);
			this.mpvHighest.TabIndex = 3;
			this.mpvHighest.TabStop = true;
			this.mpvHighest.Text = "Highest";
			this.mpvHighest.UseVisualStyleBackColor = true;
			// 
			// mpvInsane
			// 
			this.mpvInsane.AutoSize = true;
			this.mpvInsane.Location = new System.Drawing.Point(249, 19);
			this.mpvInsane.Name = "mpvInsane";
			this.mpvInsane.Size = new System.Drawing.Size(57, 17);
			this.mpvInsane.TabIndex = 4;
			this.mpvInsane.TabStop = true;
			this.mpvInsane.Text = "Insane";
			this.mpvInsane.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AcceptButton = this.searchBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 461);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.resultsList);
			this.Controls.Add(this.playBtn);
			this.Controls.Add(this.qualityBox);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(750, 500);
			this.Name = "Form1";
			this.Text = "MPVTube";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.qualityBox.ResumeLayout(false);
			this.qualityBox.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.GroupBox qualityBox;
		private System.Windows.Forms.RadioButton lowQuality;
		private System.Windows.Forms.RadioButton highQuality;
		private System.Windows.Forms.RadioButton audioQuality;
		private System.Windows.Forms.Button playBtn;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeAfterStartingVideoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signInToYouTubeNAToolStripMenuItem;
		private System.Windows.Forms.ListView resultsList;
		private System.Windows.Forms.ColumnHeader titleCol;
		private System.Windows.Forms.ColumnHeader uploaderCol;
		private System.Windows.Forms.ColumnHeader dateTimeCol;
		private System.Windows.Forms.ColumnHeader descriptCol;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enterURLToPlayToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton mpvInsane;
		private System.Windows.Forms.RadioButton mpvHighest;
		private System.Windows.Forms.RadioButton mpvHigh;
		private System.Windows.Forms.RadioButton mpvMedium;
		private System.Windows.Forms.RadioButton mpvLow;
	}
}

