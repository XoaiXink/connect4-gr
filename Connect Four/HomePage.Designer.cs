namespace Connect_Four
{
    partial class HomePage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlayWithBots = new System.Windows.Forms.Button();
            this.btn2Players = new System.Windows.Forms.Button();
            this.lblConnectF = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = global::Connect_Four.Properties.Resources.Green_White_Blue_Illustrative_Playful_Group_Project_Presentation;
            this.pictureBox1.Location = new System.Drawing.Point(-46, -78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // btnPlayWithBots
            // 
            this.btnPlayWithBots.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPlayWithBots.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayWithBots.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPlayWithBots.Location = new System.Drawing.Point(273, 337);
            this.btnPlayWithBots.Name = "btnPlayWithBots";
            this.btnPlayWithBots.Size = new System.Drawing.Size(122, 49);
            this.btnPlayWithBots.TabIndex = 1;
            this.btnPlayWithBots.Text = "PLAY WITH BOTS";
            this.btnPlayWithBots.UseVisualStyleBackColor = false;
            this.btnPlayWithBots.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2Players
            // 
            this.btn2Players.BackColor = System.Drawing.Color.PowderBlue;
            this.btn2Players.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Players.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn2Players.Location = new System.Drawing.Point(432, 337);
            this.btn2Players.Name = "btn2Players";
            this.btn2Players.Size = new System.Drawing.Size(123, 49);
            this.btn2Players.TabIndex = 2;
            this.btn2Players.Text = "2 PLAYERS";
            this.btn2Players.UseVisualStyleBackColor = false;
            this.btn2Players.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblConnectF
            // 
            this.lblConnectF.BackColor = System.Drawing.Color.LightBlue;
            this.lblConnectF.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectF.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblConnectF.Location = new System.Drawing.Point(237, 128);
            this.lblConnectF.Name = "lblConnectF";
            this.lblConnectF.Size = new System.Drawing.Size(344, 62);
            this.lblConnectF.TabIndex = 3;
            this.lblConnectF.Text = "GREEN GRID";
            this.lblConnectF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConnectF.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SeaGreen;
            this.button3.Location = new System.Drawing.Point(343, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "ABOUT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SeaGreen;
            this.button4.Location = new System.Drawing.Point(343, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "HOW TO PLAY";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 520);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblConnectF);
            this.Controls.Add(this.btn2Players);
            this.Controls.Add(this.btnPlayWithBots);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomePage";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlayWithBots;
        private System.Windows.Forms.Button btn2Players;
        private System.Windows.Forms.Label lblConnectF;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}