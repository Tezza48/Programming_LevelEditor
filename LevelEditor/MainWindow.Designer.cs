﻿namespace LevelEditor
{
    partial class MainWindow
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
<<<<<<< HEAD
            this.locDisplayBox = new System.Windows.Forms.ListBox();
=======
            this.btnEditLocations = new System.Windows.Forms.Button();
            this.btnEditExits = new System.Windows.Forms.Button();
            this.txtbxStartText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
>>>>>>> SeparatingFuncions
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.locNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxLocName = new System.Windows.Forms.TextBox();
            this.txtbxLocDescription = new System.Windows.Forms.TextBox();
            this.btnSaveLoc = new System.Windows.Forms.Button();
            this.btnNewLoc = new System.Windows.Forms.Button();
            this.btnRemoveLoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combobxExits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combobxExitLeadsTo = new System.Windows.Forms.ComboBox();
            this.btnSetExit = new System.Windows.Forms.Button();
            this.btnClearExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // locDisplayBox
            // 
            this.locDisplayBox.FormattingEnabled = true;
            this.locDisplayBox.Location = new System.Drawing.Point(12, 27);
            this.locDisplayBox.Name = "locDisplayBox";
            this.locDisplayBox.Size = new System.Drawing.Size(156, 277);
            this.locDisplayBox.TabIndex = 5;
            this.locDisplayBox.SelectedIndexChanged += new System.EventHandler(this.locationDisplayBox_SelectedIndexChanged);
=======
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditLocations
            // 
            this.btnEditLocations.Location = new System.Drawing.Point(12, 168);
            this.btnEditLocations.Name = "btnEditLocations";
            this.btnEditLocations.Size = new System.Drawing.Size(260, 23);
            this.btnEditLocations.TabIndex = 0;
            this.btnEditLocations.Text = "Edit Locations";
            this.btnEditLocations.UseVisualStyleBackColor = true;
            this.btnEditLocations.Click += new System.EventHandler(this.btnEditLocations_Click);
            // 
            // btnEditExits
            // 
            this.btnEditExits.Location = new System.Drawing.Point(12, 197);
            this.btnEditExits.Name = "btnEditExits";
            this.btnEditExits.Size = new System.Drawing.Size(260, 23);
            this.btnEditExits.TabIndex = 2;
            this.btnEditExits.Text = "Edit Exits";
            this.btnEditExits.UseVisualStyleBackColor = true;
            // 
            // txtbxStartText
            // 
            this.txtbxStartText.Location = new System.Drawing.Point(12, 27);
            this.txtbxStartText.Multiline = true;
            this.txtbxStartText.Name = "txtbxStartText";
            this.txtbxStartText.Size = new System.Drawing.Size(260, 135);
            this.txtbxStartText.TabIndex = 3;
            this.txtbxStartText.TextChanged += new System.EventHandler(this.txtbxStartText_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
>>>>>>> SeparatingFuncions
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
<<<<<<< HEAD
            this.loadToolStripMenuItem.Text = "Load";
=======
            this.loadToolStripMenuItem.Text = "&Load";
>>>>>>> SeparatingFuncions
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // btnEditPlayer
            // 
<<<<<<< HEAD
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breakLocationsToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // breakLocationsToolStripMenuItem
            // 
            this.breakLocationsToolStripMenuItem.Name = "breakLocationsToolStripMenuItem";
            this.breakLocationsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.breakLocationsToolStripMenuItem.Text = "Break Locations";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // locNameLabel
            // 
            this.locNameLabel.AutoSize = true;
            this.locNameLabel.Location = new System.Drawing.Point(174, 27);
            this.locNameLabel.Name = "locNameLabel";
            this.locNameLabel.Size = new System.Drawing.Size(35, 13);
            this.locNameLabel.TabIndex = 9;
            this.locNameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description";
            // 
            // txtbxLocName
            // 
            this.txtbxLocName.Location = new System.Drawing.Point(177, 44);
            this.txtbxLocName.Name = "txtbxLocName";
            this.txtbxLocName.Size = new System.Drawing.Size(287, 20);
            this.txtbxLocName.TabIndex = 11;
            // 
            // txtbxLocDescription
            // 
            this.txtbxLocDescription.Location = new System.Drawing.Point(177, 84);
            this.txtbxLocDescription.Multiline = true;
            this.txtbxLocDescription.Name = "txtbxLocDescription";
            this.txtbxLocDescription.Size = new System.Drawing.Size(287, 84);
            this.txtbxLocDescription.TabIndex = 12;
            // 
            // btnSaveLoc
            // 
            this.btnSaveLoc.Location = new System.Drawing.Point(177, 310);
            this.btnSaveLoc.Name = "btnSaveLoc";
            this.btnSaveLoc.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLoc.TabIndex = 13;
            this.btnSaveLoc.Text = "Set Location";
            this.btnSaveLoc.UseVisualStyleBackColor = true;
            this.btnSaveLoc.Click += new System.EventHandler(this.btnSaveLoc_Click);
            // 
            // btnNewLoc
            // 
            this.btnNewLoc.Location = new System.Drawing.Point(12, 310);
            this.btnNewLoc.Name = "btnNewLoc";
            this.btnNewLoc.Size = new System.Drawing.Size(75, 23);
            this.btnNewLoc.TabIndex = 14;
            this.btnNewLoc.Text = "Add";
            this.btnNewLoc.UseVisualStyleBackColor = true;
            this.btnNewLoc.Click += new System.EventHandler(this.btnNewLoc_Click);
            // 
            // btnRemoveLoc
            // 
            this.btnRemoveLoc.Location = new System.Drawing.Point(93, 310);
            this.btnRemoveLoc.Name = "btnRemoveLoc";
            this.btnRemoveLoc.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveLoc.TabIndex = 15;
            this.btnRemoveLoc.Text = "Remove";
            this.btnRemoveLoc.UseVisualStyleBackColor = true;
            this.btnRemoveLoc.Click += new System.EventHandler(this.btnRemoveLoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Exits";
=======
            this.btnEditPlayer.Location = new System.Drawing.Point(13, 226);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(259, 23);
            this.btnEditPlayer.TabIndex = 5;
            this.btnEditPlayer.Text = "Edit Player";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
>>>>>>> SeparatingFuncions
            // 
            // combobxExits
            // 
            this.combobxExits.FormattingEnabled = true;
            this.combobxExits.Location = new System.Drawing.Point(180, 192);
            this.combobxExits.Name = "combobxExits";
            this.combobxExits.Size = new System.Drawing.Size(89, 21);
            this.combobxExits.TabIndex = 17;
            this.combobxExits.SelectedIndexChanged += new System.EventHandler(this.combobxExits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Leads To";
            // 
            // combobxExitLeadsTo
            // 
            this.combobxExitLeadsTo.FormattingEnabled = true;
            this.combobxExitLeadsTo.Location = new System.Drawing.Point(333, 192);
            this.combobxExitLeadsTo.Name = "combobxExitLeadsTo";
            this.combobxExitLeadsTo.Size = new System.Drawing.Size(131, 21);
            this.combobxExitLeadsTo.TabIndex = 19;
            // 
            // btnSetExit
            // 
            this.btnSetExit.Location = new System.Drawing.Point(389, 219);
            this.btnSetExit.Name = "btnSetExit";
            this.btnSetExit.Size = new System.Drawing.Size(75, 23);
            this.btnSetExit.TabIndex = 20;
            this.btnSetExit.Text = "Set";
            this.btnSetExit.UseVisualStyleBackColor = true;
            this.btnSetExit.Click += new System.EventHandler(this.btnSetExit_Click);
            // 
            // btnClearExit
            // 
            this.btnClearExit.Location = new System.Drawing.Point(180, 219);
            this.btnClearExit.Name = "btnClearExit";
            this.btnClearExit.Size = new System.Drawing.Size(75, 23);
            this.btnClearExit.TabIndex = 21;
            this.btnClearExit.Text = "Clear";
            this.btnClearExit.UseVisualStyleBackColor = true;
            this.btnClearExit.Click += new System.EventHandler(this.btnClearExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(474, 370);
            this.Controls.Add(this.btnClearExit);
            this.Controls.Add(this.btnSetExit);
            this.Controls.Add(this.combobxExitLeadsTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combobxExits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveLoc);
            this.Controls.Add(this.btnNewLoc);
            this.Controls.Add(this.btnSaveLoc);
            this.Controls.Add(this.txtbxLocDescription);
            this.Controls.Add(this.txtbxLocName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locNameLabel);
            this.Controls.Add(this.locDisplayBox);
=======
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.txtbxStartText);
            this.Controls.Add(this.btnEditExits);
            this.Controls.Add(this.btnEditLocations);
>>>>>>> SeparatingFuncions
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Level Editor";
<<<<<<< HEAD
=======
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
>>>>>>> SeparatingFuncions
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
<<<<<<< HEAD
        private System.Windows.Forms.ListBox locDisplayBox;
=======

        private System.Windows.Forms.Button btnEditLocations;
        private System.Windows.Forms.Button btnEditExits;
        private System.Windows.Forms.TextBox txtbxStartText;
        private System.Windows.Forms.MenuStrip menuStrip1;
>>>>>>> SeparatingFuncions
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakLocationsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label locNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxLocName;
        private System.Windows.Forms.TextBox txtbxLocDescription;
        private System.Windows.Forms.Button btnSaveLoc;
        private System.Windows.Forms.Button btnNewLoc;
        private System.Windows.Forms.Button btnRemoveLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobxExits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobxExitLeadsTo;
        private System.Windows.Forms.Button btnSetExit;
        private System.Windows.Forms.Button btnClearExit;
=======
        private System.Windows.Forms.Button btnEditPlayer;
>>>>>>> SeparatingFuncions
    }
}