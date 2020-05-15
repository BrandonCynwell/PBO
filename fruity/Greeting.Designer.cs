namespace fruity
{
    partial class Greeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Greeting));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Greeting_Next = new System.Windows.Forms.Button();
            this.Greeting_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(304, 249);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 104);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Greeting_Next
            // 
            this.Greeting_Next.AutoEllipsis = true;
            this.Greeting_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(198)))), ((int)(((byte)(164)))));
            this.Greeting_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Greeting_Next.Font = new System.Drawing.Font("TypoGraphica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting_Next.ForeColor = System.Drawing.Color.White;
            this.Greeting_Next.Location = new System.Drawing.Point(343, 386);
            this.Greeting_Next.Name = "Greeting_Next";
            this.Greeting_Next.Size = new System.Drawing.Size(114, 36);
            this.Greeting_Next.TabIndex = 0;
            this.Greeting_Next.Text = "Selanjutnya";
            this.Greeting_Next.UseVisualStyleBackColor = false;
            this.Greeting_Next.Click += new System.EventHandler(this.Greeting_Next_Click);
            // 
            // Greeting_Close
            // 
            this.Greeting_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Greeting_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Greeting_Close.Font = new System.Drawing.Font("TypoGraphica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Greeting_Close.Location = new System.Drawing.Point(478, 386);
            this.Greeting_Close.Name = "Greeting_Close";
            this.Greeting_Close.Size = new System.Drawing.Size(114, 36);
            this.Greeting_Close.TabIndex = 4;
            this.Greeting_Close.Text = "Keluar";
            this.Greeting_Close.UseVisualStyleBackColor = false;
            this.Greeting_Close.Click += new System.EventHandler(this.Greeting_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_3);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(318, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(388, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(663, 522);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Greeting_Close);
            this.Controls.Add(this.Greeting_Next);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Greeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruity";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Button Greeting_Next;
        public System.Windows.Forms.Button Greeting_Close;
    }
}

