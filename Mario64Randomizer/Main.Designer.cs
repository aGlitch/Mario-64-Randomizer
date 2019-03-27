namespace Mario64Randomizer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnNewSeed = new System.Windows.Forms.Button();
            this.btnEnterSeed = new System.Windows.Forms.Button();
            this.chkFirst = new System.Windows.Forms.CheckBox();
            this.chkDownstairs = new System.Windows.Forms.CheckBox();
            this.chkUpstairs = new System.Windows.Forms.CheckBox();
            this.chkBowserStars = new System.Windows.Forms.CheckBox();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.chkSecretStars = new System.Windows.Forms.CheckBox();
            this.chkToads = new System.Windows.Forms.CheckBox();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.nudStarAmount = new System.Windows.Forms.NumericUpDown();
            this.lvStars = new System.Windows.Forms.ListView();
            this.chk100CS = new System.Windows.Forms.CheckBox();
            this.chkMips = new System.Windows.Forms.CheckBox();
            this.lblNumberOfStars = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewSeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewSeed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewSeed.Location = new System.Drawing.Point(55, 19);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(75, 20);
            this.btnNewSeed.TabIndex = 0;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = true;
            this.btnNewSeed.Click += new System.EventHandler(this.btnNewSeed_Click);
            // 
            // btnEnterSeed
            // 
            this.btnEnterSeed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEnterSeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnterSeed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnterSeed.Location = new System.Drawing.Point(213, 19);
            this.btnEnterSeed.Name = "btnEnterSeed";
            this.btnEnterSeed.Size = new System.Drawing.Size(92, 20);
            this.btnEnterSeed.TabIndex = 1;
            this.btnEnterSeed.Text = "Enter Seed";
            this.btnEnterSeed.UseVisualStyleBackColor = false;
            this.btnEnterSeed.Click += new System.EventHandler(this.btnEnterSeed_Click);
            // 
            // chkFirst
            // 
            this.chkFirst.AutoSize = true;
            this.chkFirst.Checked = true;
            this.chkFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFirst.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFirst.Location = new System.Drawing.Point(55, 70);
            this.chkFirst.Name = "chkFirst";
            this.chkFirst.Size = new System.Drawing.Size(63, 17);
            this.chkFirst.TabIndex = 8;
            this.chkFirst.Text = "Hallway";
            this.chkFirst.UseVisualStyleBackColor = true;
            // 
            // chkDownstairs
            // 
            this.chkDownstairs.AutoSize = true;
            this.chkDownstairs.Checked = true;
            this.chkDownstairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDownstairs.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDownstairs.Location = new System.Drawing.Point(55, 92);
            this.chkDownstairs.Name = "chkDownstairs";
            this.chkDownstairs.Size = new System.Drawing.Size(78, 17);
            this.chkDownstairs.TabIndex = 9;
            this.chkDownstairs.Text = "Downstairs";
            this.chkDownstairs.UseVisualStyleBackColor = true;
            // 
            // chkUpstairs
            // 
            this.chkUpstairs.AutoSize = true;
            this.chkUpstairs.Checked = true;
            this.chkUpstairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpstairs.ForeColor = System.Drawing.SystemColors.Control;
            this.chkUpstairs.Location = new System.Drawing.Point(135, 70);
            this.chkUpstairs.Name = "chkUpstairs";
            this.chkUpstairs.Size = new System.Drawing.Size(64, 17);
            this.chkUpstairs.TabIndex = 10;
            this.chkUpstairs.Text = "Upstairs";
            this.chkUpstairs.UseVisualStyleBackColor = true;
            // 
            // chkBowserStars
            // 
            this.chkBowserStars.AutoSize = true;
            this.chkBowserStars.Checked = true;
            this.chkBowserStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBowserStars.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBowserStars.Location = new System.Drawing.Point(213, 70);
            this.chkBowserStars.Name = "chkBowserStars";
            this.chkBowserStars.Size = new System.Drawing.Size(88, 17);
            this.chkBowserStars.TabIndex = 11;
            this.chkBowserStars.Text = "Bowser Stars";
            this.chkBowserStars.UseVisualStyleBackColor = true;
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Checked = true;
            this.chkTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTop.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTop.Location = new System.Drawing.Point(135, 92);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(45, 17);
            this.chkTop.TabIndex = 12;
            this.chkTop.Text = "Top";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // chkSecretStars
            // 
            this.chkSecretStars.AutoSize = true;
            this.chkSecretStars.Checked = true;
            this.chkSecretStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSecretStars.ForeColor = System.Drawing.SystemColors.Control;
            this.chkSecretStars.Location = new System.Drawing.Point(213, 92);
            this.chkSecretStars.Name = "chkSecretStars";
            this.chkSecretStars.Size = new System.Drawing.Size(84, 17);
            this.chkSecretStars.TabIndex = 13;
            this.chkSecretStars.Text = "Secret Stars";
            this.chkSecretStars.UseVisualStyleBackColor = true;
            // 
            // chkToads
            // 
            this.chkToads.AutoSize = true;
            this.chkToads.ForeColor = System.Drawing.SystemColors.Control;
            this.chkToads.Location = new System.Drawing.Point(213, 115);
            this.chkToads.Name = "chkToads";
            this.chkToads.Size = new System.Drawing.Size(56, 17);
            this.chkToads.TabIndex = 14;
            this.chkToads.Text = "Toads";
            this.chkToads.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            this.nudSeed.BackColor = System.Drawing.SystemColors.ControlText;
            this.nudSeed.ForeColor = System.Drawing.SystemColors.Info;
            this.nudSeed.Location = new System.Drawing.Point(135, 19);
            this.nudSeed.Maximum = new decimal(new int[] {
            160000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(71, 20);
            this.nudSeed.TabIndex = 24;
            // 
            // nudStarAmount
            // 
            this.nudStarAmount.BackColor = System.Drawing.SystemColors.InfoText;
            this.nudStarAmount.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.nudStarAmount.Location = new System.Drawing.Point(135, 45);
            this.nudStarAmount.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudStarAmount.Name = "nudStarAmount";
            this.nudStarAmount.Size = new System.Drawing.Size(72, 20);
            this.nudStarAmount.TabIndex = 25;
            this.nudStarAmount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lvStars
            // 
            this.lvStars.BackColor = System.Drawing.SystemColors.InfoText;
            this.lvStars.ForeColor = System.Drawing.SystemColors.Info;
            this.lvStars.LabelWrap = false;
            this.lvStars.Location = new System.Drawing.Point(55, 138);
            this.lvStars.MultiSelect = false;
            this.lvStars.Name = "lvStars";
            this.lvStars.Size = new System.Drawing.Size(250, 352);
            this.lvStars.TabIndex = 28;
            this.lvStars.TileSize = new System.Drawing.Size(220, 30);
            this.lvStars.UseCompatibleStateImageBehavior = false;
            this.lvStars.View = System.Windows.Forms.View.Tile;
            this.lvStars.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvStars_ItemSelectionChanged);
            // 
            // chk100CS
            // 
            this.chk100CS.AutoSize = true;
            this.chk100CS.Checked = true;
            this.chk100CS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk100CS.ForeColor = System.Drawing.SystemColors.Control;
            this.chk100CS.Location = new System.Drawing.Point(135, 115);
            this.chk100CS.Name = "chk100CS";
            this.chk100CS.Size = new System.Drawing.Size(73, 17);
            this.chk100CS.TabIndex = 29;
            this.chk100CS.Text = "100 Coins";
            this.chk100CS.UseVisualStyleBackColor = true;
            // 
            // chkMips
            // 
            this.chkMips.AutoSize = true;
            this.chkMips.ForeColor = System.Drawing.SystemColors.Control;
            this.chkMips.Location = new System.Drawing.Point(55, 115);
            this.chkMips.Name = "chkMips";
            this.chkMips.Size = new System.Drawing.Size(48, 17);
            this.chkMips.TabIndex = 30;
            this.chkMips.Text = "Mips";
            this.chkMips.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfStars
            // 
            this.lblNumberOfStars.AutoSize = true;
            this.lblNumberOfStars.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumberOfStars.Location = new System.Drawing.Point(52, 47);
            this.lblNumberOfStars.Name = "lblNumberOfStars";
            this.lblNumberOfStars.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfStars.TabIndex = 31;
            this.lblNumberOfStars.Text = "Number of Stars";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(364, 501);
            this.Controls.Add(this.lblNumberOfStars);
            this.Controls.Add(this.chkMips);
            this.Controls.Add(this.chk100CS);
            this.Controls.Add(this.lvStars);
            this.Controls.Add(this.nudStarAmount);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.chkToads);
            this.Controls.Add(this.chkSecretStars);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.chkBowserStars);
            this.Controls.Add(this.chkUpstairs);
            this.Controls.Add(this.chkDownstairs);
            this.Controls.Add(this.chkFirst);
            this.Controls.Add(this.btnEnterSeed);
            this.Controls.Add(this.btnNewSeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 540);
            this.MinimumSize = new System.Drawing.Size(380, 540);
            this.Name = "Main";
            this.Text = "Super Mario 64 Randomizer v0.35";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewSeed;
        private System.Windows.Forms.Button btnEnterSeed;
        private System.Windows.Forms.CheckBox chkFirst;
        private System.Windows.Forms.CheckBox chkDownstairs;
        private System.Windows.Forms.CheckBox chkUpstairs;
        private System.Windows.Forms.CheckBox chkBowserStars;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.CheckBox chkSecretStars;
        private System.Windows.Forms.CheckBox chkToads;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.NumericUpDown nudStarAmount;
        private System.Windows.Forms.ListView lvStars;
        private System.Windows.Forms.CheckBox chk100CS;
        private System.Windows.Forms.CheckBox chkMips;
        private System.Windows.Forms.Label lblNumberOfStars;
    }
}

