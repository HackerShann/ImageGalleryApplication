namespace imageGallery
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
            this.uploadButton = new System.Windows.Forms.Button();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.addTagButton = new System.Windows.Forms.Button();
            this.imageDisplayPanel = new System.Windows.Forms.Panel();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.metadataLabel = new System.Windows.Forms.Label();
            this.searchTagTextBox = new System.Windows.Forms.TextBox();
            this.searchTagButton = new System.Windows.Forms.Button();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.TagLabel = new System.Windows.Forms.Label();
            this.SearchTag = new System.Windows.Forms.Label();
            this.groupTagBox = new System.Windows.Forms.GroupBox();
            this.groupSearchBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupSearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(68, 129);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(400, 61);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // tagTextBox
            // 
            this.tagTextBox.Location = new System.Drawing.Point(869, 130);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(235, 31);
            this.tagTextBox.TabIndex = 1;
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(592, 205);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(512, 65);
            this.addTagButton.TabIndex = 2;
            this.addTagButton.Text = "Add Tag";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // imageDisplayPanel
            // 
            this.imageDisplayPanel.AutoScroll = true;
            this.imageDisplayPanel.Location = new System.Drawing.Point(68, 247);
            this.imageDisplayPanel.Name = "imageDisplayPanel";
            this.imageDisplayPanel.Size = new System.Drawing.Size(400, 225);
            this.imageDisplayPanel.TabIndex = 4;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(68, 523);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(196, 50);
            this.prevButton.TabIndex = 5;
            this.prevButton.Text = "←";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(272, 523);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(196, 50);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "→";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // metadataLabel
            // 
            this.metadataLabel.AutoSize = true;
            this.metadataLabel.Location = new System.Drawing.Point(73, 619);
            this.metadataLabel.Name = "metadataLabel";
            this.metadataLabel.Size = new System.Drawing.Size(111, 25);
            this.metadataLabel.TabIndex = 7;
            this.metadataLabel.Text = "MetaData:";
            // 
            // searchTagTextBox
            // 
            this.searchTagTextBox.Location = new System.Drawing.Point(869, 424);
            this.searchTagTextBox.Name = "searchTagTextBox";
            this.searchTagTextBox.Size = new System.Drawing.Size(235, 31);
            this.searchTagTextBox.TabIndex = 8;
            // 
            // searchTagButton
            // 
            this.searchTagButton.Location = new System.Drawing.Point(605, 493);
            this.searchTagButton.Name = "searchTagButton";
            this.searchTagButton.Size = new System.Drawing.Size(499, 65);
            this.searchTagButton.TabIndex = 9;
            this.searchTagButton.Text = "Search by Tag";
            this.searchTagButton.UseVisualStyleBackColor = true;
            this.searchTagButton.Click += new System.EventHandler(this.searchTagButton_Click);
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 25;
            this.searchResultsListBox.Location = new System.Drawing.Point(49, 312);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(499, 154);
            this.searchResultsListBox.TabIndex = 10;
            this.searchResultsListBox.SelectedIndexChanged += new System.EventHandler(this.searchResultsListBox_SelectedIndexChanged_1);
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Location = new System.Drawing.Point(587, 136);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(235, 25);
            this.TagLabel.TabIndex = 11;
            this.TagLabel.Text = "Add a Tag to an Image:";
            // 
            // SearchTag
            // 
            this.SearchTag.AutoSize = true;
            this.SearchTag.Location = new System.Drawing.Point(600, 427);
            this.SearchTag.Name = "SearchTag";
            this.SearchTag.Size = new System.Drawing.Size(222, 25);
            this.SearchTag.TabIndex = 12;
            this.SearchTag.Text = "Search Image by Tag:";
            // 
            // groupTagBox
            // 
            this.groupTagBox.Location = new System.Drawing.Point(556, 69);
            this.groupTagBox.Name = "groupTagBox";
            this.groupTagBox.Size = new System.Drawing.Size(592, 250);
            this.groupTagBox.TabIndex = 13;
            this.groupTagBox.TabStop = false;
            this.groupTagBox.Text = "Add Tag";
            this.groupTagBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupSearchBox
            // 
            this.groupSearchBox.Controls.Add(this.label1);
            this.groupSearchBox.Controls.Add(this.searchResultsListBox);
            this.groupSearchBox.Location = new System.Drawing.Point(556, 358);
            this.groupSearchBox.Name = "groupSearchBox";
            this.groupSearchBox.Size = new System.Drawing.Size(592, 524);
            this.groupSearchBox.TabIndex = 14;
            this.groupSearchBox.TabStop = false;
            this.groupSearchBox.Text = "Search Images";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Images will be shown here. Click on image name to show in display.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Start by Uploading your Images.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 938);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTagButton);
            this.Controls.Add(this.SearchTag);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.searchTagTextBox);
            this.Controls.Add(this.metadataLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.imageDisplayPanel);
            this.Controls.Add(this.addTagButton);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.groupTagBox);
            this.Controls.Add(this.groupSearchBox);
            this.Name = "Form1";
            this.Text = "Image Gallery Application";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupSearchBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.Panel imageDisplayPanel;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label metadataLabel;
        private System.Windows.Forms.TextBox searchTagTextBox;
        private System.Windows.Forms.Button searchTagButton;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.Label SearchTag;
        private System.Windows.Forms.GroupBox groupTagBox;
        private System.Windows.Forms.GroupBox groupSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

