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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWarps = new System.Windows.Forms.TabPage();
            this.btnLoadWarpList = new System.Windows.Forms.Button();
            this.btnSaveWarpList = new System.Windows.Forms.Button();
            this.btnRestoreWarps = new System.Windows.Forms.Button();
            this.chklbWarpList = new System.Windows.Forms.CheckedListBox();
            this.chkWarpFile = new System.Windows.Forms.CheckBox();
            this.tabEnemies = new System.Windows.Forms.TabPage();
            this.txtNewBehaviour = new System.Windows.Forms.TextBox();
            this.btnLoadBehaviours = new System.Windows.Forms.Button();
            this.btnSaveBehaviours = new System.Windows.Forms.Button();
            this.btnRestoreBehaviours = new System.Windows.Forms.Button();
            this.btnAddBehaviour = new System.Windows.Forms.Button();
            this.btnRemoveBehaviour = new System.Windows.Forms.Button();
            this.lBehaviours = new System.Windows.Forms.ListBox();
            this.tabClothes = new System.Windows.Forms.TabPage();
            this.chkRandomizeHair = new System.Windows.Forms.CheckBox();
            this.chkRandomizeSkin = new System.Windows.Forms.CheckBox();
            this.pColorHair = new System.Windows.Forms.Panel();
            this.pColorFace = new System.Windows.Forms.Panel();
            this.pColorShoes = new System.Windows.Forms.Panel();
            this.pColorGloves = new System.Windows.Forms.Panel();
            this.pColorCap = new System.Windows.Forms.Panel();
            this.pColorOveralls = new System.Windows.Forms.Panel();
            this.btnColorHair = new System.Windows.Forms.Button();
            this.btnColorFace = new System.Windows.Forms.Button();
            this.btnColorShoes = new System.Windows.Forms.Button();
            this.btnColorGloves = new System.Windows.Forms.Button();
            this.btnColorCapArms = new System.Windows.Forms.Button();
            this.btnColorOveralls = new System.Windows.Forms.Button();
            this.btnColorRestore = new System.Windows.Forms.Button();
            this.tabSequence = new System.Windows.Forms.TabPage();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.chkRandomizeText = new System.Windows.Forms.CheckBox();
            this.btnSaveRom = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnOpenRom = new System.Windows.Forms.Button();
            this.chkRandomizeEnemies = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMarioClothes = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMusic = new System.Windows.Forms.CheckBox();
            this.chkRandomizeWarps = new System.Windows.Forms.CheckBox();
            this.cdClothes = new System.Windows.Forms.ColorDialog();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.chkWarpPatch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabWarps.SuspendLayout();
            this.tabEnemies.SuspendLayout();
            this.tabClothes.SuspendLayout();
            this.tabSequence.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnNewSeed.FlatAppearance.BorderSize = 0;
            this.btnNewSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSeed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewSeed.Location = new System.Drawing.Point(30, 16);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(100, 25);
            this.btnNewSeed.TabIndex = 1;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = false;
            this.btnNewSeed.Click += new System.EventHandler(this.btnNewSeed_Click);
            // 
            // btnEnterSeed
            // 
            this.btnEnterSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnEnterSeed.FlatAppearance.BorderSize = 0;
            this.btnEnterSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterSeed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnterSeed.Location = new System.Drawing.Point(274, 16);
            this.btnEnterSeed.Name = "btnEnterSeed";
            this.btnEnterSeed.Size = new System.Drawing.Size(100, 25);
            this.btnEnterSeed.TabIndex = 2;
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
            this.chkFirst.Location = new System.Drawing.Point(6, 36);
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
            this.chkDownstairs.Location = new System.Drawing.Point(6, 58);
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
            this.chkUpstairs.Location = new System.Drawing.Point(86, 36);
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
            this.chkBowserStars.Location = new System.Drawing.Point(164, 36);
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
            this.chkTop.Location = new System.Drawing.Point(86, 58);
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
            this.chkSecretStars.Location = new System.Drawing.Point(164, 58);
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
            this.chkToads.Location = new System.Drawing.Point(164, 81);
            this.chkToads.Name = "chkToads";
            this.chkToads.Size = new System.Drawing.Size(56, 17);
            this.chkToads.TabIndex = 14;
            this.chkToads.Text = "Toads";
            this.chkToads.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            this.nudSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.nudSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSeed.ForeColor = System.Drawing.SystemColors.Menu;
            this.nudSeed.Location = new System.Drawing.Point(152, 16);
            this.nudSeed.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(100, 22);
            this.nudSeed.TabIndex = 1;
            // 
            // nudStarAmount
            // 
            this.nudStarAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.nudStarAmount.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.nudStarAmount.Location = new System.Drawing.Point(165, 12);
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
            this.lvStars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.lvStars.ForeColor = System.Drawing.SystemColors.Info;
            this.lvStars.LabelWrap = false;
            this.lvStars.Location = new System.Drawing.Point(6, 104);
            this.lvStars.MinimumSize = new System.Drawing.Size(250, 150);
            this.lvStars.MultiSelect = false;
            this.lvStars.Name = "lvStars";
            this.lvStars.Size = new System.Drawing.Size(318, 215);
            this.lvStars.Sorting = System.Windows.Forms.SortOrder.Ascending;
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
            this.chk100CS.Location = new System.Drawing.Point(86, 81);
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
            this.chkMips.Location = new System.Drawing.Point(6, 81);
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
            this.lblNumberOfStars.Location = new System.Drawing.Point(69, 14);
            this.lblNumberOfStars.Name = "lblNumberOfStars";
            this.lblNumberOfStars.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfStars.TabIndex = 31;
            this.lblNumberOfStars.Text = "Number of Stars";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabWarps);
            this.tabControl1.Controls.Add(this.tabEnemies);
            this.tabControl1.Controls.Add(this.tabClothes);
            this.tabControl1.Controls.Add(this.tabSequence);
            this.tabControl1.Controls.Add(this.tabMisc);
            this.tabControl1.Location = new System.Drawing.Point(30, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 348);
            this.tabControl1.TabIndex = 33;
            // 
            // tabWarps
            // 
            this.tabWarps.BackColor = System.Drawing.Color.Black;
            this.tabWarps.Controls.Add(this.btnLoadWarpList);
            this.tabWarps.Controls.Add(this.btnSaveWarpList);
            this.tabWarps.Controls.Add(this.btnRestoreWarps);
            this.tabWarps.Controls.Add(this.chklbWarpList);
            this.tabWarps.Controls.Add(this.chkWarpFile);
            this.tabWarps.ForeColor = System.Drawing.SystemColors.Control;
            this.tabWarps.Location = new System.Drawing.Point(4, 22);
            this.tabWarps.Name = "tabWarps";
            this.tabWarps.Padding = new System.Windows.Forms.Padding(3);
            this.tabWarps.Size = new System.Drawing.Size(336, 322);
            this.tabWarps.TabIndex = 5;
            this.tabWarps.Text = "Warps";
            // 
            // btnLoadWarpList
            // 
            this.btnLoadWarpList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLoadWarpList.FlatAppearance.BorderSize = 0;
            this.btnLoadWarpList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadWarpList.Location = new System.Drawing.Point(94, 41);
            this.btnLoadWarpList.Name = "btnLoadWarpList";
            this.btnLoadWarpList.Size = new System.Drawing.Size(40, 25);
            this.btnLoadWarpList.TabIndex = 10;
            this.btnLoadWarpList.Text = "Load Behaviours";
            this.btnLoadWarpList.UseVisualStyleBackColor = false;
            this.btnLoadWarpList.Click += new System.EventHandler(this.btnLoadWarpList_Click);
            // 
            // btnSaveWarpList
            // 
            this.btnSaveWarpList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSaveWarpList.FlatAppearance.BorderSize = 0;
            this.btnSaveWarpList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWarpList.Location = new System.Drawing.Point(48, 41);
            this.btnSaveWarpList.Name = "btnSaveWarpList";
            this.btnSaveWarpList.Size = new System.Drawing.Size(40, 25);
            this.btnSaveWarpList.TabIndex = 9;
            this.btnSaveWarpList.Text = "Save Behaviours";
            this.btnSaveWarpList.UseVisualStyleBackColor = false;
            this.btnSaveWarpList.Click += new System.EventHandler(this.btnSaveWarpList_Click);
            // 
            // btnRestoreWarps
            // 
            this.btnRestoreWarps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnRestoreWarps.BackgroundImage = global::Mario64Randomizer.Properties.Resources.refresh;
            this.btnRestoreWarps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestoreWarps.FlatAppearance.BorderSize = 0;
            this.btnRestoreWarps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreWarps.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestoreWarps.Location = new System.Drawing.Point(262, 41);
            this.btnRestoreWarps.Name = "btnRestoreWarps";
            this.btnRestoreWarps.Size = new System.Drawing.Size(25, 25);
            this.btnRestoreWarps.TabIndex = 8;
            this.btnRestoreWarps.UseVisualStyleBackColor = false;
            this.btnRestoreWarps.Click += new System.EventHandler(this.btnRestoreWarps_Click);
            // 
            // chklbWarpList
            // 
            this.chklbWarpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklbWarpList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.chklbWarpList.CheckOnClick = true;
            this.chklbWarpList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbWarpList.ForeColor = System.Drawing.SystemColors.Window;
            this.chklbWarpList.FormattingEnabled = true;
            this.chklbWarpList.Items.AddRange(new object[] {
            "Course 1",
            "Course 2",
            "Course 3",
            "Course 4",
            "Course 5",
            "Course 6",
            "Course 7",
            "Course 8",
            "Course 9",
            "Course 10",
            "Course 11",
            "Course 12",
            "Course 13",
            "Course 14",
            "Course 15",
            "Bowser 1",
            "Bowser Battle 1",
            "Bowser Course 2",
            "Bowser Battle 2",
            "Bowser Course 3",
            "Bowser Battle 3",
            "Peach Slide",
            "Metal Cap",
            "Wing Cap",
            "Vanish Cap",
            "Rainbow",
            "Aquarium",
            "\"The End\"",
            "Castle Grounds",
            "Inside Castle",
            "Castle Courtyard"});
            this.chklbWarpList.Location = new System.Drawing.Point(48, 76);
            this.chklbWarpList.Name = "chklbWarpList";
            this.chklbWarpList.Size = new System.Drawing.Size(239, 225);
            this.chklbWarpList.TabIndex = 7;
            // 
            // chkWarpFile
            // 
            this.chkWarpFile.AutoSize = true;
            this.chkWarpFile.Location = new System.Drawing.Point(48, 19);
            this.chkWarpFile.Name = "chkWarpFile";
            this.chkWarpFile.Size = new System.Drawing.Size(106, 17);
            this.chkWarpFile.TabIndex = 3;
            this.chkWarpFile.Text = "Output Warp File";
            this.chkWarpFile.UseVisualStyleBackColor = true;
            // 
            // tabEnemies
            // 
            this.tabEnemies.BackColor = System.Drawing.Color.Black;
            this.tabEnemies.Controls.Add(this.txtNewBehaviour);
            this.tabEnemies.Controls.Add(this.btnLoadBehaviours);
            this.tabEnemies.Controls.Add(this.btnSaveBehaviours);
            this.tabEnemies.Controls.Add(this.btnRestoreBehaviours);
            this.tabEnemies.Controls.Add(this.btnAddBehaviour);
            this.tabEnemies.Controls.Add(this.btnRemoveBehaviour);
            this.tabEnemies.Controls.Add(this.lBehaviours);
            this.tabEnemies.ForeColor = System.Drawing.SystemColors.Control;
            this.tabEnemies.Location = new System.Drawing.Point(4, 22);
            this.tabEnemies.Name = "tabEnemies";
            this.tabEnemies.Size = new System.Drawing.Size(336, 322);
            this.tabEnemies.TabIndex = 6;
            this.tabEnemies.Text = "Enemies";
            // 
            // txtNewBehaviour
            // 
            this.txtNewBehaviour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtNewBehaviour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewBehaviour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewBehaviour.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNewBehaviour.Location = new System.Drawing.Point(98, 16);
            this.txtNewBehaviour.Name = "txtNewBehaviour";
            this.txtNewBehaviour.Size = new System.Drawing.Size(94, 24);
            this.txtNewBehaviour.TabIndex = 8;
            // 
            // btnLoadBehaviours
            // 
            this.btnLoadBehaviours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLoadBehaviours.FlatAppearance.BorderSize = 0;
            this.btnLoadBehaviours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadBehaviours.Location = new System.Drawing.Point(276, 16);
            this.btnLoadBehaviours.Name = "btnLoadBehaviours";
            this.btnLoadBehaviours.Size = new System.Drawing.Size(40, 25);
            this.btnLoadBehaviours.TabIndex = 7;
            this.btnLoadBehaviours.Text = "Load Behaviours";
            this.btnLoadBehaviours.UseVisualStyleBackColor = false;
            this.btnLoadBehaviours.Click += new System.EventHandler(this.btnLoadBehaviours_Click);
            // 
            // btnSaveBehaviours
            // 
            this.btnSaveBehaviours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSaveBehaviours.FlatAppearance.BorderSize = 0;
            this.btnSaveBehaviours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBehaviours.Location = new System.Drawing.Point(230, 16);
            this.btnSaveBehaviours.Name = "btnSaveBehaviours";
            this.btnSaveBehaviours.Size = new System.Drawing.Size(40, 25);
            this.btnSaveBehaviours.TabIndex = 6;
            this.btnSaveBehaviours.Text = "Save Behaviours";
            this.btnSaveBehaviours.UseVisualStyleBackColor = false;
            this.btnSaveBehaviours.Click += new System.EventHandler(this.btnSaveBehaviours_Click);
            // 
            // btnRestoreBehaviours
            // 
            this.btnRestoreBehaviours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnRestoreBehaviours.BackgroundImage = global::Mario64Randomizer.Properties.Resources.refresh;
            this.btnRestoreBehaviours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestoreBehaviours.FlatAppearance.BorderSize = 0;
            this.btnRestoreBehaviours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBehaviours.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestoreBehaviours.Location = new System.Drawing.Point(198, 16);
            this.btnRestoreBehaviours.Name = "btnRestoreBehaviours";
            this.btnRestoreBehaviours.Size = new System.Drawing.Size(25, 25);
            this.btnRestoreBehaviours.TabIndex = 4;
            this.btnRestoreBehaviours.UseVisualStyleBackColor = false;
            this.btnRestoreBehaviours.Click += new System.EventHandler(this.btnRestoreBehaviours_Click);
            // 
            // btnAddBehaviour
            // 
            this.btnAddBehaviour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnAddBehaviour.FlatAppearance.BorderSize = 0;
            this.btnAddBehaviour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBehaviour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddBehaviour.Location = new System.Drawing.Point(25, 16);
            this.btnAddBehaviour.Name = "btnAddBehaviour";
            this.btnAddBehaviour.Size = new System.Drawing.Size(30, 25);
            this.btnAddBehaviour.TabIndex = 3;
            this.btnAddBehaviour.Text = "+";
            this.btnAddBehaviour.UseVisualStyleBackColor = false;
            this.btnAddBehaviour.Click += new System.EventHandler(this.btnAddBehaviour_Click);
            // 
            // btnRemoveBehaviour
            // 
            this.btnRemoveBehaviour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnRemoveBehaviour.FlatAppearance.BorderSize = 0;
            this.btnRemoveBehaviour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBehaviour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveBehaviour.Location = new System.Drawing.Point(61, 16);
            this.btnRemoveBehaviour.Name = "btnRemoveBehaviour";
            this.btnRemoveBehaviour.Size = new System.Drawing.Size(30, 25);
            this.btnRemoveBehaviour.TabIndex = 2;
            this.btnRemoveBehaviour.Text = "-";
            this.btnRemoveBehaviour.UseVisualStyleBackColor = false;
            this.btnRemoveBehaviour.Click += new System.EventHandler(this.btnRemoveBehaviour_Click);
            // 
            // lBehaviours
            // 
            this.lBehaviours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBehaviours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lBehaviours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBehaviours.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lBehaviours.FormattingEnabled = true;
            this.lBehaviours.ItemHeight = 16;
            this.lBehaviours.Location = new System.Drawing.Point(25, 48);
            this.lBehaviours.Name = "lBehaviours";
            this.lBehaviours.Size = new System.Drawing.Size(291, 260);
            this.lBehaviours.TabIndex = 0;
            // 
            // tabClothes
            // 
            this.tabClothes.BackColor = System.Drawing.Color.Black;
            this.tabClothes.Controls.Add(this.chkRandomizeHair);
            this.tabClothes.Controls.Add(this.chkRandomizeSkin);
            this.tabClothes.Controls.Add(this.pColorHair);
            this.tabClothes.Controls.Add(this.pColorFace);
            this.tabClothes.Controls.Add(this.pColorShoes);
            this.tabClothes.Controls.Add(this.pColorGloves);
            this.tabClothes.Controls.Add(this.pColorCap);
            this.tabClothes.Controls.Add(this.pColorOveralls);
            this.tabClothes.Controls.Add(this.btnColorHair);
            this.tabClothes.Controls.Add(this.btnColorFace);
            this.tabClothes.Controls.Add(this.btnColorShoes);
            this.tabClothes.Controls.Add(this.btnColorGloves);
            this.tabClothes.Controls.Add(this.btnColorCapArms);
            this.tabClothes.Controls.Add(this.btnColorOveralls);
            this.tabClothes.Controls.Add(this.btnColorRestore);
            this.tabClothes.ForeColor = System.Drawing.SystemColors.Control;
            this.tabClothes.Location = new System.Drawing.Point(4, 22);
            this.tabClothes.Name = "tabClothes";
            this.tabClothes.Size = new System.Drawing.Size(336, 322);
            this.tabClothes.TabIndex = 3;
            this.tabClothes.Text = "Mario\'s Clothes";
            // 
            // chkRandomizeHair
            // 
            this.chkRandomizeHair.AutoSize = true;
            this.chkRandomizeHair.Location = new System.Drawing.Point(62, 35);
            this.chkRandomizeHair.Name = "chkRandomizeHair";
            this.chkRandomizeHair.Size = new System.Drawing.Size(101, 17);
            this.chkRandomizeHair.TabIndex = 16;
            this.chkRandomizeHair.Text = "Randomize Hair";
            this.chkRandomizeHair.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeSkin
            // 
            this.chkRandomizeSkin.AutoSize = true;
            this.chkRandomizeSkin.Location = new System.Drawing.Point(62, 15);
            this.chkRandomizeSkin.Name = "chkRandomizeSkin";
            this.chkRandomizeSkin.Size = new System.Drawing.Size(103, 17);
            this.chkRandomizeSkin.TabIndex = 15;
            this.chkRandomizeSkin.Text = "Randomize Skin";
            this.chkRandomizeSkin.UseVisualStyleBackColor = true;
            // 
            // pColorHair
            // 
            this.pColorHair.BackColor = System.Drawing.Color.White;
            this.pColorHair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColorHair.Location = new System.Drawing.Point(167, 139);
            this.pColorHair.Name = "pColorHair";
            this.pColorHair.Size = new System.Drawing.Size(109, 23);
            this.pColorHair.TabIndex = 14;
            this.pColorHair.Click += new System.EventHandler(this.btnColorHair_Click);
            // 
            // pColorFace
            // 
            this.pColorFace.BackColor = System.Drawing.Color.White;
            this.pColorFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColorFace.Location = new System.Drawing.Point(167, 99);
            this.pColorFace.Name = "pColorFace";
            this.pColorFace.Size = new System.Drawing.Size(109, 23);
            this.pColorFace.TabIndex = 14;
            this.pColorFace.Click += new System.EventHandler(this.btnColorFace_Click);
            // 
            // pColorShoes
            // 
            this.pColorShoes.BackColor = System.Drawing.Color.White;
            this.pColorShoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColorShoes.Location = new System.Drawing.Point(167, 260);
            this.pColorShoes.Name = "pColorShoes";
            this.pColorShoes.Size = new System.Drawing.Size(109, 23);
            this.pColorShoes.TabIndex = 14;
            this.pColorShoes.Click += new System.EventHandler(this.btnColorShoes_Click);
            // 
            // pColorGloves
            // 
            this.pColorGloves.BackColor = System.Drawing.Color.White;
            this.pColorGloves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColorGloves.Location = new System.Drawing.Point(167, 217);
            this.pColorGloves.Name = "pColorGloves";
            this.pColorGloves.Size = new System.Drawing.Size(109, 23);
            this.pColorGloves.TabIndex = 14;
            this.pColorGloves.Click += new System.EventHandler(this.btnColorGloves_Click);
            // 
            // pColorCap
            // 
            this.pColorCap.BackColor = System.Drawing.Color.White;
            this.pColorCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColorCap.Location = new System.Drawing.Point(167, 58);
            this.pColorCap.Name = "pColorCap";
            this.pColorCap.Size = new System.Drawing.Size(109, 23);
            this.pColorCap.TabIndex = 14;
            this.pColorCap.Click += new System.EventHandler(this.btnColorCapArms_Click);
            // 
            // pColorOveralls
            // 
            this.pColorOveralls.BackColor = System.Drawing.Color.White;
            this.pColorOveralls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColorOveralls.Location = new System.Drawing.Point(167, 179);
            this.pColorOveralls.Name = "pColorOveralls";
            this.pColorOveralls.Size = new System.Drawing.Size(109, 23);
            this.pColorOveralls.TabIndex = 13;
            this.pColorOveralls.Click += new System.EventHandler(this.btnColorOveralls_Click);
            // 
            // btnColorHair
            // 
            this.btnColorHair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnColorHair.FlatAppearance.BorderSize = 0;
            this.btnColorHair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorHair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColorHair.Location = new System.Drawing.Point(62, 139);
            this.btnColorHair.Name = "btnColorHair";
            this.btnColorHair.Size = new System.Drawing.Size(75, 23);
            this.btnColorHair.TabIndex = 6;
            this.btnColorHair.Text = "Hair";
            this.btnColorHair.UseVisualStyleBackColor = false;
            this.btnColorHair.Click += new System.EventHandler(this.btnColorHair_Click);
            // 
            // btnColorFace
            // 
            this.btnColorFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnColorFace.FlatAppearance.BorderSize = 0;
            this.btnColorFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorFace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColorFace.Location = new System.Drawing.Point(62, 99);
            this.btnColorFace.Name = "btnColorFace";
            this.btnColorFace.Size = new System.Drawing.Size(75, 23);
            this.btnColorFace.TabIndex = 5;
            this.btnColorFace.Text = "Face";
            this.btnColorFace.UseVisualStyleBackColor = false;
            this.btnColorFace.Click += new System.EventHandler(this.btnColorFace_Click);
            // 
            // btnColorShoes
            // 
            this.btnColorShoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnColorShoes.FlatAppearance.BorderSize = 0;
            this.btnColorShoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorShoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColorShoes.Location = new System.Drawing.Point(62, 260);
            this.btnColorShoes.Name = "btnColorShoes";
            this.btnColorShoes.Size = new System.Drawing.Size(75, 23);
            this.btnColorShoes.TabIndex = 4;
            this.btnColorShoes.Text = "Shoes";
            this.btnColorShoes.UseVisualStyleBackColor = false;
            this.btnColorShoes.Click += new System.EventHandler(this.btnColorShoes_Click);
            // 
            // btnColorGloves
            // 
            this.btnColorGloves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnColorGloves.FlatAppearance.BorderSize = 0;
            this.btnColorGloves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorGloves.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColorGloves.Location = new System.Drawing.Point(62, 217);
            this.btnColorGloves.Name = "btnColorGloves";
            this.btnColorGloves.Size = new System.Drawing.Size(75, 23);
            this.btnColorGloves.TabIndex = 3;
            this.btnColorGloves.Text = "Gloves";
            this.btnColorGloves.UseVisualStyleBackColor = false;
            this.btnColorGloves.Click += new System.EventHandler(this.btnColorGloves_Click);
            // 
            // btnColorCapArms
            // 
            this.btnColorCapArms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnColorCapArms.FlatAppearance.BorderSize = 0;
            this.btnColorCapArms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorCapArms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColorCapArms.Location = new System.Drawing.Point(62, 58);
            this.btnColorCapArms.Name = "btnColorCapArms";
            this.btnColorCapArms.Size = new System.Drawing.Size(75, 23);
            this.btnColorCapArms.TabIndex = 2;
            this.btnColorCapArms.Text = "Cap";
            this.btnColorCapArms.UseVisualStyleBackColor = false;
            this.btnColorCapArms.Click += new System.EventHandler(this.btnColorCapArms_Click);
            // 
            // btnColorOveralls
            // 
            this.btnColorOveralls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnColorOveralls.FlatAppearance.BorderSize = 0;
            this.btnColorOveralls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorOveralls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColorOveralls.Location = new System.Drawing.Point(62, 179);
            this.btnColorOveralls.Name = "btnColorOveralls";
            this.btnColorOveralls.Size = new System.Drawing.Size(75, 23);
            this.btnColorOveralls.TabIndex = 1;
            this.btnColorOveralls.Text = "Overalls";
            this.btnColorOveralls.UseVisualStyleBackColor = false;
            this.btnColorOveralls.Click += new System.EventHandler(this.btnColorOveralls_Click);
            // 
            // btnColorRestore
            // 
            this.btnColorRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnColorRestore.BackgroundImage = global::Mario64Randomizer.Properties.Resources.refresh;
            this.btnColorRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColorRestore.Location = new System.Drawing.Point(252, 15);
            this.btnColorRestore.Name = "btnColorRestore";
            this.btnColorRestore.Size = new System.Drawing.Size(24, 24);
            this.btnColorRestore.TabIndex = 0;
            this.btnColorRestore.UseVisualStyleBackColor = false;
            this.btnColorRestore.Click += new System.EventHandler(this.btnColorRestore_Click);
            // 
            // tabSequence
            // 
            this.tabSequence.BackColor = System.Drawing.Color.Black;
            this.tabSequence.Controls.Add(this.btnRefreshList);
            this.tabSequence.Controls.Add(this.chkMips);
            this.tabSequence.Controls.Add(this.chkFirst);
            this.tabSequence.Controls.Add(this.lblNumberOfStars);
            this.tabSequence.Controls.Add(this.chkDownstairs);
            this.tabSequence.Controls.Add(this.chkUpstairs);
            this.tabSequence.Controls.Add(this.chk100CS);
            this.tabSequence.Controls.Add(this.chkBowserStars);
            this.tabSequence.Controls.Add(this.lvStars);
            this.tabSequence.Controls.Add(this.chkTop);
            this.tabSequence.Controls.Add(this.nudStarAmount);
            this.tabSequence.Controls.Add(this.chkSecretStars);
            this.tabSequence.Controls.Add(this.chkToads);
            this.tabSequence.ForeColor = System.Drawing.SystemColors.Control;
            this.tabSequence.Location = new System.Drawing.Point(4, 22);
            this.tabSequence.Name = "tabSequence";
            this.tabSequence.Padding = new System.Windows.Forms.Padding(3);
            this.tabSequence.Size = new System.Drawing.Size(336, 322);
            this.tabSequence.TabIndex = 0;
            this.tabSequence.Text = "Sequence (Vanilla)";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnRefreshList.BackgroundImage = global::Mario64Randomizer.Properties.Resources.refresh;
            this.btnRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshList.Location = new System.Drawing.Point(300, 12);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(24, 24);
            this.btnRefreshList.TabIndex = 42;
            this.btnRefreshList.UseVisualStyleBackColor = false;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // chkRandomizeText
            // 
            this.chkRandomizeText.AutoSize = true;
            this.chkRandomizeText.Enabled = false;
            this.chkRandomizeText.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeText.Location = new System.Drawing.Point(18, 49);
            this.chkRandomizeText.Name = "chkRandomizeText";
            this.chkRandomizeText.Size = new System.Drawing.Size(47, 17);
            this.chkRandomizeText.TabIndex = 0;
            this.chkRandomizeText.Text = "Text";
            this.chkRandomizeText.UseVisualStyleBackColor = true;
            this.chkRandomizeText.Visible = false;
            // 
            // btnSaveRom
            // 
            this.btnSaveRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnSaveRom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveRom.FlatAppearance.BorderSize = 0;
            this.btnSaveRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveRom.Location = new System.Drawing.Point(274, 42);
            this.btnSaveRom.Name = "btnSaveRom";
            this.btnSaveRom.Size = new System.Drawing.Size(100, 25);
            this.btnSaveRom.TabIndex = 5;
            this.btnSaveRom.Text = "Save Rom";
            this.btnSaveRom.UseVisualStyleBackColor = false;
            this.btnSaveRom.Click += new System.EventHandler(this.btnSaveRom_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnRandomize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomize.FlatAppearance.BorderSize = 0;
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRandomize.Location = new System.Drawing.Point(152, 42);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(100, 25);
            this.btnRandomize.TabIndex = 4;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnOpenRom
            // 
            this.btnOpenRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnOpenRom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOpenRom.FlatAppearance.BorderSize = 0;
            this.btnOpenRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenRom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenRom.Location = new System.Drawing.Point(30, 42);
            this.btnOpenRom.Name = "btnOpenRom";
            this.btnOpenRom.Size = new System.Drawing.Size(100, 25);
            this.btnOpenRom.TabIndex = 3;
            this.btnOpenRom.Text = "Open Rom";
            this.btnOpenRom.UseVisualStyleBackColor = false;
            this.btnOpenRom.Click += new System.EventHandler(this.btnOpenRom_Click);
            // 
            // chkRandomizeEnemies
            // 
            this.chkRandomizeEnemies.AutoSize = true;
            this.chkRandomizeEnemies.Checked = true;
            this.chkRandomizeEnemies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeEnemies.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeEnemies.Location = new System.Drawing.Point(152, 71);
            this.chkRandomizeEnemies.Name = "chkRandomizeEnemies";
            this.chkRandomizeEnemies.Size = new System.Drawing.Size(66, 17);
            this.chkRandomizeEnemies.TabIndex = 40;
            this.chkRandomizeEnemies.Text = "Enemies";
            this.chkRandomizeEnemies.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeMarioClothes
            // 
            this.chkRandomizeMarioClothes.AutoSize = true;
            this.chkRandomizeMarioClothes.Checked = true;
            this.chkRandomizeMarioClothes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeMarioClothes.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeMarioClothes.Location = new System.Drawing.Point(152, 95);
            this.chkRandomizeMarioClothes.Name = "chkRandomizeMarioClothes";
            this.chkRandomizeMarioClothes.Size = new System.Drawing.Size(97, 17);
            this.chkRandomizeMarioClothes.TabIndex = 39;
            this.chkRandomizeMarioClothes.Text = "Mario\'s Clothes";
            this.chkRandomizeMarioClothes.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeMusic
            // 
            this.chkRandomizeMusic.AutoSize = true;
            this.chkRandomizeMusic.Checked = true;
            this.chkRandomizeMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeMusic.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeMusic.Location = new System.Drawing.Point(30, 95);
            this.chkRandomizeMusic.Name = "chkRandomizeMusic";
            this.chkRandomizeMusic.Size = new System.Drawing.Size(54, 17);
            this.chkRandomizeMusic.TabIndex = 38;
            this.chkRandomizeMusic.Text = "Music";
            this.chkRandomizeMusic.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeWarps
            // 
            this.chkRandomizeWarps.AutoSize = true;
            this.chkRandomizeWarps.Checked = true;
            this.chkRandomizeWarps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeWarps.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeWarps.Location = new System.Drawing.Point(30, 71);
            this.chkRandomizeWarps.Name = "chkRandomizeWarps";
            this.chkRandomizeWarps.Size = new System.Drawing.Size(57, 17);
            this.chkRandomizeWarps.TabIndex = 37;
            this.chkRandomizeWarps.Text = "Warps";
            this.chkRandomizeWarps.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = global::Mario64Randomizer.Properties.Resources.help;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelp.Location = new System.Drawing.Point(339, 77);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(35, 35);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.btnHelp_Enter);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_Hover);
            // 
            // tabMisc
            // 
            this.tabMisc.BackColor = System.Drawing.Color.Black;
            this.tabMisc.Controls.Add(this.chkWarpPatch);
            this.tabMisc.Controls.Add(this.chkRandomizeText);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(336, 322);
            this.tabMisc.TabIndex = 7;
            this.tabMisc.Text = "Misc";
            // 
            // chkWarpPatch
            // 
            this.chkWarpPatch.AutoSize = true;
            this.chkWarpPatch.Checked = true;
            this.chkWarpPatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarpPatch.ForeColor = System.Drawing.Color.White;
            this.chkWarpPatch.Location = new System.Drawing.Point(18, 26);
            this.chkWarpPatch.Name = "chkWarpPatch";
            this.chkWarpPatch.Size = new System.Drawing.Size(123, 17);
            this.chkWarpPatch.TabIndex = 42;
            this.chkWarpPatch.Text = "Patch Fading Warps";
            this.chkWarpPatch.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(404, 481);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.chkRandomizeEnemies);
            this.Controls.Add(this.chkRandomizeMarioClothes);
            this.Controls.Add(this.chkRandomizeMusic);
            this.Controls.Add(this.chkRandomizeWarps);
            this.Controls.Add(this.btnSaveRom);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnOpenRom);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.btnEnterSeed);
            this.Controls.Add(this.btnNewSeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 1080);
            this.MinimumSize = new System.Drawing.Size(420, 350);
            this.Name = "Main";
            this.Text = "Super Mario 64 Randomizer v1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabWarps.ResumeLayout(false);
            this.tabWarps.PerformLayout();
            this.tabEnemies.ResumeLayout(false);
            this.tabEnemies.PerformLayout();
            this.tabClothes.ResumeLayout(false);
            this.tabClothes.PerformLayout();
            this.tabSequence.ResumeLayout(false);
            this.tabSequence.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.tabMisc.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSequence;
        private System.Windows.Forms.Button btnSaveRom;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnOpenRom;
        private System.Windows.Forms.CheckBox chkRandomizeEnemies;
        private System.Windows.Forms.CheckBox chkRandomizeMarioClothes;
        private System.Windows.Forms.CheckBox chkRandomizeMusic;
        private System.Windows.Forms.CheckBox chkRandomizeWarps;
        private System.Windows.Forms.TabPage tabClothes;
        private System.Windows.Forms.ColorDialog cdClothes;
        private System.Windows.Forms.Button btnColorRestore;
        private System.Windows.Forms.Button btnColorHair;
        private System.Windows.Forms.Button btnColorFace;
        private System.Windows.Forms.Button btnColorShoes;
        private System.Windows.Forms.Button btnColorGloves;
        private System.Windows.Forms.Button btnColorCapArms;
        private System.Windows.Forms.Button btnColorOveralls;
        private System.Windows.Forms.Panel pColorOveralls;
        private System.Windows.Forms.Panel pColorHair;
        private System.Windows.Forms.Panel pColorFace;
        private System.Windows.Forms.Panel pColorShoes;
        private System.Windows.Forms.Panel pColorGloves;
        private System.Windows.Forms.Panel pColorCap;
        private System.Windows.Forms.CheckBox chkRandomizeText;
        private System.Windows.Forms.TabPage tabWarps;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.CheckBox chkWarpFile;
        private System.Windows.Forms.TabPage tabEnemies;
        private System.Windows.Forms.Button btnRestoreBehaviours;
        private System.Windows.Forms.Button btnAddBehaviour;
        private System.Windows.Forms.Button btnRemoveBehaviour;
        private System.Windows.Forms.ListBox lBehaviours;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLoadBehaviours;
        private System.Windows.Forms.Button btnSaveBehaviours;
        private System.Windows.Forms.TextBox txtNewBehaviour;
        private System.Windows.Forms.CheckBox chkRandomizeHair;
        private System.Windows.Forms.CheckBox chkRandomizeSkin;
        private System.Windows.Forms.Button btnLoadWarpList;
        private System.Windows.Forms.Button btnSaveWarpList;
        private System.Windows.Forms.Button btnRestoreWarps;
        private System.Windows.Forms.CheckedListBox chklbWarpList;
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.CheckBox chkWarpPatch;
    }
}

