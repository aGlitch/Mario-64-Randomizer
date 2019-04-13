namespace Mario64Randomizer
{
    partial class BehaviourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BehaviourForm));
            this.lBehaviours = new System.Windows.Forms.ListBox();
            this.txtNewBehaviour = new System.Windows.Forms.TextBox();
            this.btnRestoreBehaviours = new System.Windows.Forms.Button();
            this.btnAddBehaviour = new System.Windows.Forms.Button();
            this.btnRemoveBehaviour = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lBehaviours.Location = new System.Drawing.Point(12, 49);
            this.lBehaviours.Name = "lBehaviours";
            this.lBehaviours.Size = new System.Drawing.Size(367, 372);
            this.lBehaviours.TabIndex = 1;
            // 
            // txtNewBehaviour
            // 
            this.txtNewBehaviour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtNewBehaviour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewBehaviour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewBehaviour.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNewBehaviour.Location = new System.Drawing.Point(86, 18);
            this.txtNewBehaviour.Name = "txtNewBehaviour";
            this.txtNewBehaviour.Size = new System.Drawing.Size(262, 24);
            this.txtNewBehaviour.TabIndex = 14;
            // 
            // btnRestoreBehaviours
            // 
            this.btnRestoreBehaviours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnRestoreBehaviours.BackgroundImage = global::Mario64Randomizer.Properties.Resources.refresh;
            this.btnRestoreBehaviours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestoreBehaviours.FlatAppearance.BorderSize = 0;
            this.btnRestoreBehaviours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBehaviours.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestoreBehaviours.Location = new System.Drawing.Point(354, 18);
            this.btnRestoreBehaviours.Name = "btnRestoreBehaviours";
            this.btnRestoreBehaviours.Size = new System.Drawing.Size(25, 25);
            this.btnRestoreBehaviours.TabIndex = 11;
            this.btnRestoreBehaviours.UseVisualStyleBackColor = false;
            this.btnRestoreBehaviours.Click += new System.EventHandler(this.btnRestoreBehaviours_Click);
            // 
            // btnAddBehaviour
            // 
            this.btnAddBehaviour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnAddBehaviour.FlatAppearance.BorderSize = 0;
            this.btnAddBehaviour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBehaviour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddBehaviour.Location = new System.Drawing.Point(13, 18);
            this.btnAddBehaviour.Name = "btnAddBehaviour";
            this.btnAddBehaviour.Size = new System.Drawing.Size(30, 25);
            this.btnAddBehaviour.TabIndex = 10;
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
            this.btnRemoveBehaviour.Location = new System.Drawing.Point(49, 18);
            this.btnRemoveBehaviour.Name = "btnRemoveBehaviour";
            this.btnRemoveBehaviour.Size = new System.Drawing.Size(30, 25);
            this.btnRemoveBehaviour.TabIndex = 9;
            this.btnRemoveBehaviour.Text = "-";
            this.btnRemoveBehaviour.UseVisualStyleBackColor = false;
            this.btnRemoveBehaviour.Click += new System.EventHandler(this.btnRemoveBehaviour_Click);
            // 
            // BehaviourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(391, 448);
            this.Controls.Add(this.txtNewBehaviour);
            this.Controls.Add(this.btnRestoreBehaviours);
            this.Controls.Add(this.btnAddBehaviour);
            this.Controls.Add(this.btnRemoveBehaviour);
            this.Controls.Add(this.lBehaviours);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BehaviourForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BehaviourForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBehaviours;
        private System.Windows.Forms.TextBox txtNewBehaviour;
        private System.Windows.Forms.Button btnRestoreBehaviours;
        private System.Windows.Forms.Button btnAddBehaviour;
        private System.Windows.Forms.Button btnRemoveBehaviour;
    }
}