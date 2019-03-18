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
            this.chkRunOnly = new System.Windows.Forms.CheckBox();
            this.chkFirst = new System.Windows.Forms.CheckBox();
            this.chkDownstairs = new System.Windows.Forms.CheckBox();
            this.chkUpstairs = new System.Windows.Forms.CheckBox();
            this.chkBowserStars = new System.Windows.Forms.CheckBox();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.chkSecretStars = new System.Windows.Forms.CheckBox();
            this.chkToads = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeneratePatch = new System.Windows.Forms.Button();
            this.chkRandomClothes = new System.Windows.Forms.CheckBox();
            this.chkRandomSFX = new System.Windows.Forms.CheckBox();
            this.chkRandomMusic = new System.Windows.Forms.CheckBox();
            this.chkParallel = new System.Windows.Forms.CheckBox();
            this.chkRandomWarps = new System.Windows.Forms.CheckBox();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.nudStarAmount = new System.Windows.Forms.NumericUpDown();
            this.chkLsStars = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.Location = new System.Drawing.Point(51, 27);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(75, 23);
            this.btnNewSeed.TabIndex = 0;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = true;
            this.btnNewSeed.Click += new System.EventHandler(this.btnNewSeed_Click);
            // 
            // btnEnterSeed
            // 
            this.btnEnterSeed.Location = new System.Drawing.Point(209, 27);
            this.btnEnterSeed.Name = "btnEnterSeed";
            this.btnEnterSeed.Size = new System.Drawing.Size(92, 23);
            this.btnEnterSeed.TabIndex = 1;
            this.btnEnterSeed.Text = "Enter Seed";
            this.btnEnterSeed.UseVisualStyleBackColor = true;
            this.btnEnterSeed.Click += new System.EventHandler(this.btnEnterSeed_Click);
            // 
            // chkRunOnly
            // 
            this.chkRunOnly.AutoSize = true;
            this.chkRunOnly.Enabled = false;
            this.chkRunOnly.Location = new System.Drawing.Point(51, 123);
            this.chkRunOnly.Name = "chkRunOnly";
            this.chkRunOnly.Size = new System.Drawing.Size(97, 17);
            this.chkRunOnly.TabIndex = 7;
            this.chkRunOnly.Text = "Run Only Stars";
            this.chkRunOnly.UseVisualStyleBackColor = true;
            this.chkRunOnly.Visible = false;
            // 
            // chkFirst
            // 
            this.chkFirst.AutoSize = true;
            this.chkFirst.Checked = true;
            this.chkFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFirst.Location = new System.Drawing.Point(51, 78);
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
            this.chkDownstairs.Location = new System.Drawing.Point(51, 101);
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
            this.chkUpstairs.Location = new System.Drawing.Point(139, 77);
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
            this.chkBowserStars.Location = new System.Drawing.Point(209, 78);
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
            this.chkTop.Location = new System.Drawing.Point(139, 100);
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
            this.chkSecretStars.Location = new System.Drawing.Point(209, 100);
            this.chkSecretStars.Name = "chkSecretStars";
            this.chkSecretStars.Size = new System.Drawing.Size(84, 17);
            this.chkSecretStars.TabIndex = 13;
            this.chkSecretStars.Text = "Secret Stars";
            this.chkSecretStars.UseVisualStyleBackColor = true;
            // 
            // chkToads
            // 
            this.chkToads.AutoSize = true;
            this.chkToads.Enabled = false;
            this.chkToads.Location = new System.Drawing.Point(209, 123);
            this.chkToads.Name = "chkToads";
            this.chkToads.Size = new System.Drawing.Size(102, 17);
            this.chkToads.TabIndex = 14;
            this.chkToads.Text = "Toads and Mips";
            this.chkToads.UseVisualStyleBackColor = true;
            this.chkToads.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Number of Stars";
            // 
            // btnGeneratePatch
            // 
            this.btnGeneratePatch.Location = new System.Drawing.Point(18, 394);
            this.btnGeneratePatch.Name = "btnGeneratePatch";
            this.btnGeneratePatch.Size = new System.Drawing.Size(64, 45);
            this.btnGeneratePatch.TabIndex = 17;
            this.btnGeneratePatch.Text = "Generate Patch";
            this.btnGeneratePatch.UseVisualStyleBackColor = true;
            // 
            // chkRandomClothes
            // 
            this.chkRandomClothes.AutoSize = true;
            this.chkRandomClothes.Checked = true;
            this.chkRandomClothes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomClothes.Enabled = false;
            this.chkRandomClothes.Location = new System.Drawing.Point(93, 394);
            this.chkRandomClothes.Name = "chkRandomClothes";
            this.chkRandomClothes.Size = new System.Drawing.Size(153, 17);
            this.chkRandomClothes.TabIndex = 18;
            this.chkRandomClothes.Text = "Randomize Mario\'s Clothes";
            this.chkRandomClothes.UseVisualStyleBackColor = true;
            // 
            // chkRandomSFX
            // 
            this.chkRandomSFX.AutoSize = true;
            this.chkRandomSFX.Checked = true;
            this.chkRandomSFX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomSFX.Enabled = false;
            this.chkRandomSFX.Location = new System.Drawing.Point(93, 418);
            this.chkRandomSFX.Name = "chkRandomSFX";
            this.chkRandomSFX.Size = new System.Drawing.Size(102, 17);
            this.chkRandomSFX.TabIndex = 19;
            this.chkRandomSFX.Text = "Randomize SFX";
            this.chkRandomSFX.UseVisualStyleBackColor = true;
            // 
            // chkRandomMusic
            // 
            this.chkRandomMusic.AutoSize = true;
            this.chkRandomMusic.Checked = true;
            this.chkRandomMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomMusic.Enabled = false;
            this.chkRandomMusic.Location = new System.Drawing.Point(93, 464);
            this.chkRandomMusic.Name = "chkRandomMusic";
            this.chkRandomMusic.Size = new System.Drawing.Size(110, 17);
            this.chkRandomMusic.TabIndex = 20;
            this.chkRandomMusic.Text = "Randomize Music";
            this.chkRandomMusic.UseVisualStyleBackColor = true;
            // 
            // chkParallel
            // 
            this.chkParallel.AutoSize = true;
            this.chkParallel.Location = new System.Drawing.Point(93, 488);
            this.chkParallel.Name = "chkParallel";
            this.chkParallel.Size = new System.Drawing.Size(84, 17);
            this.chkParallel.TabIndex = 22;
            this.chkParallel.Text = "Parallel Cam";
            this.chkParallel.UseVisualStyleBackColor = true;
            // 
            // chkRandomWarps
            // 
            this.chkRandomWarps.AutoSize = true;
            this.chkRandomWarps.Location = new System.Drawing.Point(93, 441);
            this.chkRandomWarps.Name = "chkRandomWarps";
            this.chkRandomWarps.Size = new System.Drawing.Size(113, 17);
            this.chkRandomWarps.TabIndex = 23;
            this.chkRandomWarps.Text = "Randomize Warps";
            this.chkRandomWarps.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(132, 29);
            this.nudSeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(71, 20);
            this.nudSeed.TabIndex = 24;
            // 
            // nudStarAmount
            // 
            this.nudStarAmount.Location = new System.Drawing.Point(131, 55);
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
            // chkLsStars
            // 
            this.chkLsStars.BackColor = System.Drawing.SystemColors.Control;
            this.chkLsStars.FormattingEnabled = true;
            this.chkLsStars.Location = new System.Drawing.Point(51, 146);
            this.chkLsStars.Name = "chkLsStars";
            this.chkLsStars.ScrollAlwaysVisible = true;
            this.chkLsStars.Size = new System.Drawing.Size(261, 214);
            this.chkLsStars.TabIndex = 26;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 381);
            this.Controls.Add(this.chkLsStars);
            this.Controls.Add(this.nudStarAmount);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.chkRandomWarps);
            this.Controls.Add(this.chkParallel);
            this.Controls.Add(this.chkRandomMusic);
            this.Controls.Add(this.chkRandomSFX);
            this.Controls.Add(this.chkRandomClothes);
            this.Controls.Add(this.btnGeneratePatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkToads);
            this.Controls.Add(this.chkSecretStars);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.chkBowserStars);
            this.Controls.Add(this.chkUpstairs);
            this.Controls.Add(this.chkDownstairs);
            this.Controls.Add(this.chkFirst);
            this.Controls.Add(this.chkRunOnly);
            this.Controls.Add(this.btnEnterSeed);
            this.Controls.Add(this.btnNewSeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 420);
            this.MinimumSize = new System.Drawing.Size(300, 420);
            this.Name = "Main";
            this.Text = "Super Mario 64 Randomizer v0.2";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewSeed;
        private System.Windows.Forms.Button btnEnterSeed;
        private System.Windows.Forms.CheckBox chkRunOnly;
        private System.Windows.Forms.CheckBox chkFirst;
        private System.Windows.Forms.CheckBox chkDownstairs;
        private System.Windows.Forms.CheckBox chkUpstairs;
        private System.Windows.Forms.CheckBox chkBowserStars;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.CheckBox chkSecretStars;
        private System.Windows.Forms.CheckBox chkToads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeneratePatch;
        private System.Windows.Forms.CheckBox chkRandomClothes;
        private System.Windows.Forms.CheckBox chkRandomSFX;
        private System.Windows.Forms.CheckBox chkRandomMusic;
        private System.Windows.Forms.CheckBox chkParallel;
        private System.Windows.Forms.CheckBox chkRandomWarps;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.NumericUpDown nudStarAmount;
        private System.Windows.Forms.CheckedListBox chkLsStars;
    }
}

