namespace WindowsFormsApp1
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
            this.chk16S = new System.Windows.Forms.CheckBox();
            this.chk70S = new System.Windows.Forms.CheckBox();
            this.txtRando = new System.Windows.Forms.TextBox();
            this.chkRunOnly = new System.Windows.Forms.CheckBox();
            this.chkFirst = new System.Windows.Forms.CheckBox();
            this.chkDownstairs = new System.Windows.Forms.CheckBox();
            this.chkUpstairs = new System.Windows.Forms.CheckBox();
            this.chkBowserStars = new System.Windows.Forms.CheckBox();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.chkSecretStars = new System.Windows.Forms.CheckBox();
            this.chkToads = new System.Windows.Forms.CheckBox();
            this.txtStarsNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeneratePatch = new System.Windows.Forms.Button();
            this.chkRandomClothes = new System.Windows.Forms.CheckBox();
            this.chkRandomSFX = new System.Windows.Forms.CheckBox();
            this.chkRandomMusic = new System.Windows.Forms.CheckBox();
            this.chkParallel = new System.Windows.Forms.CheckBox();
            this.chkRandomWarps = new System.Windows.Forms.CheckBox();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.Location = new System.Drawing.Point(13, 26);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(75, 23);
            this.btnNewSeed.TabIndex = 0;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = true;
            this.btnNewSeed.Click += new System.EventHandler(this.btnNewSeed_Click);
            // 
            // btnEnterSeed
            // 
            this.btnEnterSeed.Location = new System.Drawing.Point(252, 26);
            this.btnEnterSeed.Name = "btnEnterSeed";
            this.btnEnterSeed.Size = new System.Drawing.Size(92, 23);
            this.btnEnterSeed.TabIndex = 1;
            this.btnEnterSeed.Text = "Enter Seed";
            this.btnEnterSeed.UseVisualStyleBackColor = true;
            this.btnEnterSeed.Click += new System.EventHandler(this.btnEnterSeed_Click);
            // 
            // chk16S
            // 
            this.chk16S.AutoSize = true;
            this.chk16S.Checked = true;
            this.chk16S.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk16S.Enabled = false;
            this.chk16S.Location = new System.Drawing.Point(13, 54);
            this.chk16S.Name = "chk16S";
            this.chk16S.Size = new System.Drawing.Size(65, 17);
            this.chk16S.TabIndex = 3;
            this.chk16S.Text = "16 Stars";
            this.chk16S.UseVisualStyleBackColor = true;
            // 
            // chk70S
            // 
            this.chk70S.AutoSize = true;
            this.chk70S.Enabled = false;
            this.chk70S.Location = new System.Drawing.Point(13, 77);
            this.chk70S.Name = "chk70S";
            this.chk70S.Size = new System.Drawing.Size(65, 17);
            this.chk70S.TabIndex = 4;
            this.chk70S.Text = "70 Stars";
            this.chk70S.UseVisualStyleBackColor = true;
            // 
            // txtRando
            // 
            this.txtRando.Location = new System.Drawing.Point(13, 100);
            this.txtRando.Name = "txtRando";
            this.txtRando.ReadOnly = true;
            this.txtRando.Size = new System.Drawing.Size(515, 20);
            this.txtRando.TabIndex = 5;
            // 
            // chkRunOnly
            // 
            this.chkRunOnly.AutoSize = true;
            this.chkRunOnly.Enabled = false;
            this.chkRunOnly.Location = new System.Drawing.Point(382, 54);
            this.chkRunOnly.Name = "chkRunOnly";
            this.chkRunOnly.Size = new System.Drawing.Size(97, 17);
            this.chkRunOnly.TabIndex = 7;
            this.chkRunOnly.Text = "Run Only Stars";
            this.chkRunOnly.UseVisualStyleBackColor = true;
            // 
            // chkFirst
            // 
            this.chkFirst.AutoSize = true;
            this.chkFirst.Checked = true;
            this.chkFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFirst.Location = new System.Drawing.Point(94, 55);
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
            this.chkDownstairs.Location = new System.Drawing.Point(94, 78);
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
            this.chkUpstairs.Location = new System.Drawing.Point(182, 54);
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
            this.chkBowserStars.Location = new System.Drawing.Point(274, 55);
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
            this.chkTop.Location = new System.Drawing.Point(182, 77);
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
            this.chkSecretStars.Location = new System.Drawing.Point(274, 77);
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
            this.chkToads.Location = new System.Drawing.Point(382, 77);
            this.chkToads.Name = "chkToads";
            this.chkToads.Size = new System.Drawing.Size(102, 17);
            this.chkToads.TabIndex = 14;
            this.chkToads.Text = "Toads and Mips";
            this.chkToads.UseVisualStyleBackColor = true;
            // 
            // txtStarsNumber
            // 
            this.txtStarsNumber.Location = new System.Drawing.Point(428, 28);
            this.txtStarsNumber.Name = "txtStarsNumber";
            this.txtStarsNumber.ReadOnly = true;
            this.txtStarsNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStarsNumber.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "# of Stars";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGeneratePatch
            // 
            this.btnGeneratePatch.Location = new System.Drawing.Point(13, 155);
            this.btnGeneratePatch.Name = "btnGeneratePatch";
            this.btnGeneratePatch.Size = new System.Drawing.Size(75, 45);
            this.btnGeneratePatch.TabIndex = 17;
            this.btnGeneratePatch.Text = "Generate Patch";
            this.btnGeneratePatch.UseVisualStyleBackColor = true;
            this.btnGeneratePatch.Click += new System.EventHandler(this.btnGeneratePatch_Click);
            // 
            // chkRandomClothes
            // 
            this.chkRandomClothes.AutoSize = true;
            this.chkRandomClothes.Checked = true;
            this.chkRandomClothes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomClothes.Enabled = false;
            this.chkRandomClothes.Location = new System.Drawing.Point(112, 155);
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
            this.chkRandomSFX.Location = new System.Drawing.Point(112, 179);
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
            this.chkRandomMusic.Location = new System.Drawing.Point(274, 155);
            this.chkRandomMusic.Name = "chkRandomMusic";
            this.chkRandomMusic.Size = new System.Drawing.Size(110, 17);
            this.chkRandomMusic.TabIndex = 20;
            this.chkRandomMusic.Text = "Randomize Music";
            this.chkRandomMusic.UseVisualStyleBackColor = true;
            // 
            // chkParallel
            // 
            this.chkParallel.AutoSize = true;
            this.chkParallel.Location = new System.Drawing.Point(274, 179);
            this.chkParallel.Name = "chkParallel";
            this.chkParallel.Size = new System.Drawing.Size(84, 17);
            this.chkParallel.TabIndex = 22;
            this.chkParallel.Text = "Parallel Cam";
            this.chkParallel.UseVisualStyleBackColor = true;
            // 
            // chkRandomWarps
            // 
            this.chkRandomWarps.AutoSize = true;
            this.chkRandomWarps.Location = new System.Drawing.Point(382, 155);
            this.chkRandomWarps.Name = "chkRandomWarps";
            this.chkRandomWarps.Size = new System.Drawing.Size(113, 17);
            this.chkRandomWarps.TabIndex = 23;
            this.chkRandomWarps.Text = "Randomize Warps";
            this.chkRandomWarps.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(94, 28);
            this.nudSeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(152, 20);
            this.nudSeed.TabIndex = 24;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 135);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.chkRandomWarps);
            this.Controls.Add(this.chkParallel);
            this.Controls.Add(this.chkRandomMusic);
            this.Controls.Add(this.chkRandomSFX);
            this.Controls.Add(this.chkRandomClothes);
            this.Controls.Add(this.btnGeneratePatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStarsNumber);
            this.Controls.Add(this.chkToads);
            this.Controls.Add(this.chkSecretStars);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.chkBowserStars);
            this.Controls.Add(this.chkUpstairs);
            this.Controls.Add(this.chkDownstairs);
            this.Controls.Add(this.chkFirst);
            this.Controls.Add(this.chkRunOnly);
            this.Controls.Add(this.txtRando);
            this.Controls.Add(this.chk70S);
            this.Controls.Add(this.chk16S);
            this.Controls.Add(this.btnEnterSeed);
            this.Controls.Add(this.btnNewSeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 174);
            this.MinimumSize = new System.Drawing.Size(560, 174);
            this.Name = "Main";
            this.Text = "Super Mario 64 Randomizer v0.15 (by aGlitch)";
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewSeed;
        private System.Windows.Forms.Button btnEnterSeed;
        private System.Windows.Forms.CheckBox chk16S;
        private System.Windows.Forms.CheckBox chk70S;
        private System.Windows.Forms.TextBox txtRando;
        private System.Windows.Forms.CheckBox chkRunOnly;
        private System.Windows.Forms.CheckBox chkFirst;
        private System.Windows.Forms.CheckBox chkDownstairs;
        private System.Windows.Forms.CheckBox chkUpstairs;
        private System.Windows.Forms.CheckBox chkBowserStars;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.CheckBox chkSecretStars;
        private System.Windows.Forms.CheckBox chkToads;
        private System.Windows.Forms.TextBox txtStarsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeneratePatch;
        private System.Windows.Forms.CheckBox chkRandomClothes;
        private System.Windows.Forms.CheckBox chkRandomSFX;
        private System.Windows.Forms.CheckBox chkRandomMusic;
        private System.Windows.Forms.CheckBox chkParallel;
        private System.Windows.Forms.CheckBox chkRandomWarps;
        private System.Windows.Forms.NumericUpDown nudSeed;
    }
}

