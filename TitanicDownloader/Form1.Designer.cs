namespace TitanicDownloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.build_name = new System.Windows.Forms.Label();
            this.desc1 = new System.Windows.Forms.Label();
            this.desc2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(499, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 511);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.List_Test);
            // 
            // build_name
            // 
            this.build_name.AutoSize = true;
            this.build_name.Location = new System.Drawing.Point(223, 13);
            this.build_name.Name = "build_name";
            this.build_name.Size = new System.Drawing.Size(70, 13);
            this.build_name.TabIndex = 1;
            this.build_name.Text = "{Build_name}";
            this.build_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // desc1
            // 
            this.desc1.AutoSize = true;
            this.desc1.Location = new System.Drawing.Point(12, 285);
            this.desc1.Name = "desc1";
            this.desc1.Size = new System.Drawing.Size(44, 13);
            this.desc1.TabIndex = 1;
            this.desc1.Text = "{desc1}";
            this.desc1.Click += new System.EventHandler(this.label1_Click);
            // 
            // desc2
            // 
            this.desc2.AutoSize = true;
            this.desc2.Location = new System.Drawing.Point(12, 332);
            this.desc2.Name = "desc2";
            this.desc2.Size = new System.Drawing.Size(44, 13);
            this.desc2.TabIndex = 1;
            this.desc2.Text = "{desc2}";
            this.desc2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(481, 118);
            this.button1.TabIndex = 3;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desc2);
            this.Controls.Add(this.desc1);
            this.Controls.Add(this.build_name);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TitanicDownloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label build_name;
        private System.Windows.Forms.Label desc1;
        private System.Windows.Forms.Label desc2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

