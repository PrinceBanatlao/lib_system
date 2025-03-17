namespace lib_system
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
            this.Library = new System.Windows.Forms.Label();
            this.Records = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Library
            // 
            this.Library.AutoSize = true;
            this.Library.BackColor = System.Drawing.Color.Transparent;
            this.Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library.ForeColor = System.Drawing.Color.Black;
            this.Library.Location = new System.Drawing.Point(99, 207);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(159, 37);
            this.Library.TabIndex = 0;
            this.Library.Text = "LIBRARY";
            this.Library.Click += new System.EventHandler(this.Library_Click);
            // 
            // Records
            // 
            this.Records.AutoSize = true;
            this.Records.BackColor = System.Drawing.Color.Transparent;
            this.Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records.Location = new System.Drawing.Point(74, 271);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(212, 42);
            this.Records.TabIndex = 1;
            this.Records.Text = "RECORDS";
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.Location = new System.Drawing.Point(111, 355);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(128, 53);
            this.enter_button.TabIndex = 7;
            this.enter_button.Text = "ENTER";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(110, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 122);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Library);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Library;
        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

