namespace fruity
{
    partial class Menu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu2));
            this.Greeting_Close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Greeting_Close
            // 
            this.Greeting_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Greeting_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Greeting_Close.Font = new System.Drawing.Font("TypoGraphica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Greeting_Close.Location = new System.Drawing.Point(476, 450);
            this.Greeting_Close.Name = "Greeting_Close";
            this.Greeting_Close.Size = new System.Drawing.Size(114, 36);
            this.Greeting_Close.TabIndex = 17;
            this.Greeting_Close.Text = "Back";
            this.Greeting_Close.UseVisualStyleBackColor = false;
            this.Greeting_Close.Click += new System.EventHandler(this.Greeting_Close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(80, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(510, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("American Captain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(561, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 41);
            this.button4.TabIndex = 15;
            this.button4.Text = "PROFIL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 522);
            this.Controls.Add(this.Greeting_Close);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruitips";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Greeting_Close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}