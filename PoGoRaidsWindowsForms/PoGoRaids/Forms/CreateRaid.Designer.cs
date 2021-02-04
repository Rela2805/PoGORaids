namespace PoGoRaids
{
    partial class CreateRaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRaid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPoGoRaids = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblPokename = new System.Windows.Forms.Label();
            this.lblMinimalLevel = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.btnSaveCreate = new System.Windows.Forms.Button();
            this.txtPokename = new System.Windows.Forms.TextBox();
            this.txtMinLevel = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lblPoGoRaids);
            this.panel1.Controls.Add(this.pictureBox1);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panel2.TabIndex = 2;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
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
            this.btnCreate.FlatAppearance.BorderSize = 0;
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
            this.btnHome.FlatAppearance.BorderSize = 0;
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
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCreate);
            this.panel3.Location = new System.Drawing.Point(326, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 80);
            this.panel3.TabIndex = 3;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCreate.Location = new System.Drawing.Point(33, 23);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(233, 34);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "Create new raid";
            // 
            // lblPokename
            // 
            this.lblPokename.AutoSize = true;
            this.lblPokename.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPokename.Location = new System.Drawing.Point(266, 284);
            this.lblPokename.Name = "lblPokename";
            this.lblPokename.Size = new System.Drawing.Size(189, 25);
            this.lblPokename.TabIndex = 15;
            this.lblPokename.Text = "Pokemon name:";
            // 
            // lblMinimalLevel
            // 
            this.lblMinimalLevel.AutoSize = true;
            this.lblMinimalLevel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinimalLevel.Location = new System.Drawing.Point(266, 340);
            this.lblMinimalLevel.Name = "lblMinimalLevel";
            this.lblMinimalLevel.Size = new System.Drawing.Size(164, 25);
            this.lblMinimalLevel.TabIndex = 16;
            this.lblMinimalLevel.Text = "Minimal level:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStartTime.Location = new System.Drawing.Point(266, 400);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(121, 25);
            this.lblStartTime.TabIndex = 17;
            this.lblStartTime.Text = "Start time:";
            // 
            // btnSaveCreate
            // 
            this.btnSaveCreate.BackColor = System.Drawing.Color.Silver;
            this.btnSaveCreate.FlatAppearance.BorderSize = 0;
            this.btnSaveCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCreate.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveCreate.Location = new System.Drawing.Point(409, 526);
            this.btnSaveCreate.Name = "btnSaveCreate";
            this.btnSaveCreate.Size = new System.Drawing.Size(184, 81);
            this.btnSaveCreate.TabIndex = 18;
            this.btnSaveCreate.Text = "Create";
            this.btnSaveCreate.UseVisualStyleBackColor = false;
            this.btnSaveCreate.Click += new System.EventHandler(this.btnCreateRaidClick);
            // 
            // txtPokename
            // 
            this.txtPokename.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPokename.Location = new System.Drawing.Point(495, 275);
            this.txtPokename.Name = "txtPokename";
            this.txtPokename.Size = new System.Drawing.Size(223, 34);
            this.txtPokename.TabIndex = 19;
            // 
            // txtMinLevel
            // 
            this.txtMinLevel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMinLevel.Location = new System.Drawing.Point(495, 337);
            this.txtMinLevel.Name = "txtMinLevel";
            this.txtMinLevel.Size = new System.Drawing.Size(223, 34);
            this.txtMinLevel.TabIndex = 20;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStartTime.Location = new System.Drawing.Point(495, 397);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(223, 34);
            this.txtStartTime.TabIndex = 21;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblId.Location = new System.Drawing.Point(266, 464);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(91, 25);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "Your id:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtId.Location = new System.Drawing.Point(495, 464);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(223, 34);
            this.txtId.TabIndex = 23;
            // 
            // CreateRaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 631);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtMinLevel);
            this.Controls.Add(this.txtPokename);
            this.Controls.Add(this.btnSaveCreate);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblMinimalLevel);
            this.Controls.Add(this.lblPokename);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateRaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRaid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPoGoRaids;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblPokename;
        private System.Windows.Forms.Label lblMinimalLevel;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Button btnSaveCreate;
        private System.Windows.Forms.TextBox txtPokename;
        private System.Windows.Forms.TextBox txtMinLevel;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
    }
}