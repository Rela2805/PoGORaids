namespace PoGoRaids
{
    partial class RaidDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaidDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPoGoRaids = new System.Windows.Forms.Label();
            this.pictureBoxPokeball = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPokemonName = new System.Windows.Forms.Label();
            this.lblMinimalLevel = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.lblContenders = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokeball)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lblPoGoRaids);
            this.panel1.Controls.Add(this.pictureBoxPokeball);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 143);
            this.panel1.TabIndex = 1;
            // 
            // lblPoGoRaids
            // 
            this.lblPoGoRaids.AutoSize = true;
            this.lblPoGoRaids.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoGoRaids.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPoGoRaids.Location = new System.Drawing.Point(6, 99);
            this.lblPoGoRaids.Name = "lblPoGoRaids";
            this.lblPoGoRaids.Size = new System.Drawing.Size(150, 28);
            this.lblPoGoRaids.TabIndex = 1;
            this.lblPoGoRaids.Text = "PoGO Raids";
            // 
            // pictureBoxPokeball
            // 
            this.pictureBoxPokeball.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPokeball.Image")));
            this.pictureBoxPokeball.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPokeball.Name = "pictureBoxPokeball";
            this.pictureBoxPokeball.Size = new System.Drawing.Size(82, 84);
            this.pictureBoxPokeball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPokeball.TabIndex = 0;
            this.pictureBoxPokeball.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 488);
            this.panel2.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProfile.Location = new System.Drawing.Point(0, 197);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(186, 85);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfileClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreate.Location = new System.Drawing.Point(0, 106);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(186, 85);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreateClick);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.Location = new System.Drawing.Point(0, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 85);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHomeClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(232, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 196);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblPokemonName
            // 
            this.lblPokemonName.AutoSize = true;
            this.lblPokemonName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPokemonName.Location = new System.Drawing.Point(471, 204);
            this.lblPokemonName.Name = "lblPokemonName";
            this.lblPokemonName.Size = new System.Drawing.Size(189, 25);
            this.lblPokemonName.TabIndex = 37;
            this.lblPokemonName.Text = "Pokemon name:";
            // 
            // lblMinimalLevel
            // 
            this.lblMinimalLevel.AutoSize = true;
            this.lblMinimalLevel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinimalLevel.Location = new System.Drawing.Point(471, 281);
            this.lblMinimalLevel.Name = "lblMinimalLevel";
            this.lblMinimalLevel.Size = new System.Drawing.Size(164, 25);
            this.lblMinimalLevel.TabIndex = 38;
            this.lblMinimalLevel.Text = "Minimal level:";
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.Silver;
            this.btnJoin.FlatAppearance.BorderSize = 0;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnJoin.Location = new System.Drawing.Point(521, 390);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(153, 62);
            this.btnJoin.TabIndex = 39;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoinClick);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Silver;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLeave.Location = new System.Drawing.Point(728, 390);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(153, 62);
            this.btnLeave.TabIndex = 40;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeaveClick);
            // 
            // lblContenders
            // 
            this.lblContenders.AutoSize = true;
            this.lblContenders.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContenders.Location = new System.Drawing.Point(251, 427);
            this.lblContenders.Name = "lblContenders";
            this.lblContenders.Size = new System.Drawing.Size(143, 25);
            this.lblContenders.TabIndex = 43;
            this.lblContenders.Text = "Contenders:";
            // 
            // RaidDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 631);
            this.Controls.Add(this.lblContenders);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.lblMinimalLevel);
            this.Controls.Add(this.lblPokemonName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaidDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaidDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokeball)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPoGoRaids;
        private System.Windows.Forms.PictureBox pictureBoxPokeball;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPokemonName;
        private System.Windows.Forms.Label lblMinimalLevel;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label lblContenders;
    }
}