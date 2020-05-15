namespace fruity
{
    partial class Fruipedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruipedia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Fruipedia_Back = new System.Windows.Forms.Button();
            this.Fruipedia_Cari = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(360, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(46, 255);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Fruipedia_Back
            // 
            this.Fruipedia_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Fruipedia_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fruipedia_Back.Font = new System.Drawing.Font("TypoGraphica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fruipedia_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fruipedia_Back.Location = new System.Drawing.Point(211, 456);
            this.Fruipedia_Back.Name = "Fruipedia_Back";
            this.Fruipedia_Back.Size = new System.Drawing.Size(114, 31);
            this.Fruipedia_Back.TabIndex = 5;
            this.Fruipedia_Back.Text = "Kembali";
            this.Fruipedia_Back.UseVisualStyleBackColor = false;
            this.Fruipedia_Back.Click += new System.EventHandler(this.Greeting_Close_Click);
            // 
            // Fruipedia_Cari
            // 
            this.Fruipedia_Cari.AutoEllipsis = true;
            this.Fruipedia_Cari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(198)))), ((int)(((byte)(164)))));
            this.Fruipedia_Cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fruipedia_Cari.Font = new System.Drawing.Font("TypoGraphica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fruipedia_Cari.ForeColor = System.Drawing.Color.White;
            this.Fruipedia_Cari.Location = new System.Drawing.Point(210, 255);
            this.Fruipedia_Cari.Name = "Fruipedia_Cari";
            this.Fruipedia_Cari.Size = new System.Drawing.Size(115, 27);
            this.Fruipedia_Cari.TabIndex = 4;
            this.Fruipedia_Cari.Text = "Cari";
            this.Fruipedia_Cari.UseVisualStyleBackColor = false;
            this.Fruipedia_Cari.Click += new System.EventHandler(this.Greeting_Next_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(46, 294);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(279, 156);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.button4.TabIndex = 10;
            this.button4.Text = "PROFIL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Fruipedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 522);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Fruipedia_Back);
            this.Controls.Add(this.Fruipedia_Cari);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fruipedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button Fruipedia_Back;
        public System.Windows.Forms.Button Fruipedia_Cari;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}