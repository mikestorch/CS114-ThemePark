namespace ThemeParkProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnRecommend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picStormLand = new System.Windows.Forms.PictureBox();
            this.picStormLandClosed = new System.Windows.Forms.PictureBox();
            this.picAmusement = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblPark = new System.Windows.Forms.Label();
            this.lblAttraction = new System.Windows.Forms.Label();
            this.picSki = new System.Windows.Forms.PictureBox();
            this.picWater = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStormLand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStormLandClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmusement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(30, 117);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(128, 20);
            this.txtAge.TabIndex = 2;
            // 
            // txtSeason
            // 
            this.txtSeason.Location = new System.Drawing.Point(30, 182);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(128, 20);
            this.txtSeason.TabIndex = 3;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(30, 247);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(128, 20);
            this.txtTemp.TabIndex = 4;
            // 
            // btnRecommend
            // 
            this.btnRecommend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRecommend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRecommend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommend.Location = new System.Drawing.Point(30, 329);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(101, 23);
            this.btnRecommend.TabIndex = 5;
            this.btnRecommend.Text = "Recommend";
            this.btnRecommend.UseVisualStyleBackColor = false;
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(252, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(474, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // picStormLand
            // 
            this.picStormLand.Image = ((System.Drawing.Image)(resources.GetObject("picStormLand.Image")));
            this.picStormLand.Location = new System.Drawing.Point(291, 50);
            this.picStormLand.Name = "picStormLand";
            this.picStormLand.Size = new System.Drawing.Size(284, 164);
            this.picStormLand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStormLand.TabIndex = 7;
            this.picStormLand.TabStop = false;
            // 
            // picStormLandClosed
            // 
            this.picStormLandClosed.Image = ((System.Drawing.Image)(resources.GetObject("picStormLandClosed.Image")));
            this.picStormLandClosed.Location = new System.Drawing.Point(291, 50);
            this.picStormLandClosed.Name = "picStormLandClosed";
            this.picStormLandClosed.Size = new System.Drawing.Size(284, 164);
            this.picStormLandClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picStormLandClosed.TabIndex = 8;
            this.picStormLandClosed.TabStop = false;
            this.picStormLandClosed.Visible = false;
            // 
            // picAmusement
            // 
            this.picAmusement.Image = ((System.Drawing.Image)(resources.GetObject("picAmusement.Image")));
            this.picAmusement.Location = new System.Drawing.Point(338, 37);
            this.picAmusement.Name = "picAmusement";
            this.picAmusement.Size = new System.Drawing.Size(200, 200);
            this.picAmusement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmusement.TabIndex = 9;
            this.picAmusement.TabStop = false;
            this.picAmusement.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(30, 101);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeason.Location = new System.Drawing.Point(29, 166);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(237, 13);
            this.lblSeason.TabIndex = 12;
            this.lblSeason.Text = "Season (Spring, Summer, Fall, or Winter)";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(30, 231);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(78, 13);
            this.lblTemp.TabIndex = 13;
            this.lblTemp.Text = "Temperature";
            // 
            // lblPark
            // 
            this.lblPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPark.ForeColor = System.Drawing.Color.Blue;
            this.lblPark.Location = new System.Drawing.Point(310, 257);
            this.lblPark.Name = "lblPark";
            this.lblPark.Size = new System.Drawing.Size(239, 26);
            this.lblPark.TabIndex = 14;
            this.lblPark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAttraction
            // 
            this.lblAttraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttraction.ForeColor = System.Drawing.Color.Red;
            this.lblAttraction.Location = new System.Drawing.Point(305, 283);
            this.lblAttraction.Name = "lblAttraction";
            this.lblAttraction.Size = new System.Drawing.Size(249, 32);
            this.lblAttraction.TabIndex = 15;
            this.lblAttraction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picSki
            // 
            this.picSki.Image = ((System.Drawing.Image)(resources.GetObject("picSki.Image")));
            this.picSki.Location = new System.Drawing.Point(361, 17);
            this.picSki.Name = "picSki";
            this.picSki.Size = new System.Drawing.Size(127, 229);
            this.picSki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSki.TabIndex = 16;
            this.picSki.TabStop = false;
            this.picSki.Visible = false;
            // 
            // picWater
            // 
            this.picWater.Image = ((System.Drawing.Image)(resources.GetObject("picWater.Image")));
            this.picWater.Location = new System.Drawing.Point(291, 37);
            this.picWater.Name = "picWater";
            this.picWater.Size = new System.Drawing.Size(284, 200);
            this.picWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWater.TabIndex = 17;
            this.picWater.TabStop = false;
            this.picWater.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(601, 381);
            this.Controls.Add(this.picWater);
            this.Controls.Add(this.picSki);
            this.Controls.Add(this.lblAttraction);
            this.Controls.Add(this.lblPark);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picAmusement);
            this.Controls.Add(this.picStormLandClosed);
            this.Controls.Add(this.picStormLand);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRecommend);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "frmMain";
            this.Text = "Storm Land";
            ((System.ComponentModel.ISupportInitialize)(this.picStormLand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStormLandClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmusement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnRecommend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picStormLand;
        private System.Windows.Forms.PictureBox picStormLandClosed;
        private System.Windows.Forms.PictureBox picAmusement;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblPark;
        private System.Windows.Forms.Label lblAttraction;
        private System.Windows.Forms.PictureBox picSki;
        private System.Windows.Forms.PictureBox picWater;
    }
}

