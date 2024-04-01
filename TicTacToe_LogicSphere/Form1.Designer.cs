namespace TicTacToe_LogicSphere
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnPlayerAI = new System.Windows.Forms.Button();
            this.btnPlayerPlayer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboInstagram = new System.Windows.Forms.PictureBox();
            this.pboFacebook = new System.Windows.Forms.PictureBox();
            this.pboYoutube = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboYoutube)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(209, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TicTacToe";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblAuthor.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(368, 104);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(359, 35);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "by LogicSphere Studio";
            // 
            // btnPlayerAI
            // 
            this.btnPlayerAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.btnPlayerAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerAI.FlatAppearance.BorderSize = 0;
            this.btnPlayerAI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(162)))), ((int)(((byte)(1)))));
            this.btnPlayerAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerAI.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerAI.Location = new System.Drawing.Point(264, 289);
            this.btnPlayerAI.Name = "btnPlayerAI";
            this.btnPlayerAI.Size = new System.Drawing.Size(247, 60);
            this.btnPlayerAI.TabIndex = 2;
            this.btnPlayerAI.Text = "Player vs AI";
            this.btnPlayerAI.UseVisualStyleBackColor = false;
            this.btnPlayerAI.Click += new System.EventHandler(this.btnPlayerAI_Click);
            // 
            // btnPlayerPlayer
            // 
            this.btnPlayerPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.btnPlayerPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayerPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(162)))), ((int)(((byte)(1)))));
            this.btnPlayerPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerPlayer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerPlayer.Location = new System.Drawing.Point(264, 211);
            this.btnPlayerPlayer.Name = "btnPlayerPlayer";
            this.btnPlayerPlayer.Size = new System.Drawing.Size(247, 60);
            this.btnPlayerPlayer.TabIndex = 3;
            this.btnPlayerPlayer.Text = "Player vs Player";
            this.btnPlayerPlayer.UseVisualStyleBackColor = false;
            this.btnPlayerPlayer.Click += new System.EventHandler(this.btnPlayerPlayer_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(162)))), ((int)(((byte)(1)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(264, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(247, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TicTacToe_LogicSphere.Properties.Resources.LogicSphere_Studio_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pboLogo_Click);
            // 
            // pboInstagram
            // 
            this.pboInstagram.BackColor = System.Drawing.Color.Transparent;
            this.pboInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboInstagram.Image = global::TicTacToe_LogicSphere.Properties.Resources.Instagram;
            this.pboInstagram.Location = new System.Drawing.Point(128, 491);
            this.pboInstagram.Name = "pboInstagram";
            this.pboInstagram.Size = new System.Drawing.Size(52, 50);
            this.pboInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboInstagram.TabIndex = 7;
            this.pboInstagram.TabStop = false;
            this.pboInstagram.Click += new System.EventHandler(this.pboInstagram_Click);
            // 
            // pboFacebook
            // 
            this.pboFacebook.BackColor = System.Drawing.Color.Transparent;
            this.pboFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboFacebook.Image = global::TicTacToe_LogicSphere.Properties.Resources.Facebook;
            this.pboFacebook.Location = new System.Drawing.Point(70, 491);
            this.pboFacebook.Name = "pboFacebook";
            this.pboFacebook.Size = new System.Drawing.Size(52, 50);
            this.pboFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFacebook.TabIndex = 8;
            this.pboFacebook.TabStop = false;
            this.pboFacebook.Click += new System.EventHandler(this.pboFacebook_Click);
            // 
            // pboYoutube
            // 
            this.pboYoutube.BackColor = System.Drawing.Color.Transparent;
            this.pboYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboYoutube.Image = ((System.Drawing.Image)(resources.GetObject("pboYoutube.Image")));
            this.pboYoutube.Location = new System.Drawing.Point(12, 491);
            this.pboYoutube.Name = "pboYoutube";
            this.pboYoutube.Size = new System.Drawing.Size(52, 50);
            this.pboYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboYoutube.TabIndex = 9;
            this.pboYoutube.TabStop = false;
            this.pboYoutube.Click += new System.EventHandler(this.pboYoutube_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::TicTacToe_LogicSphere.Properties.Resources.MainMenuImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pboYoutube);
            this.Controls.Add(this.pboFacebook);
            this.Controls.Add(this.pboInstagram);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayerPlayer);
            this.Controls.Add(this.btnPlayerAI);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboYoutube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnPlayerAI;
        private System.Windows.Forms.Button btnPlayerPlayer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pboInstagram;
        private System.Windows.Forms.PictureBox pboFacebook;
        private System.Windows.Forms.PictureBox pboYoutube;
    }
}

