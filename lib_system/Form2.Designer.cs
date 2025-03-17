namespace lib_system
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.book_button = new System.Windows.Forms.Button();
            this.author_button = new System.Windows.Forms.Button();
            this.member_button1 = new System.Windows.Forms.Button();
            this.borrow_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RECORDS2 = new System.Windows.Forms.Label();
            this.back6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // book_button
            // 
            this.book_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("book_button.BackgroundImage")));
            this.book_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.book_button.Location = new System.Drawing.Point(44, 141);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(112, 108);
            this.book_button.TabIndex = 0;
            this.book_button.UseVisualStyleBackColor = true;
            this.book_button.Click += new System.EventHandler(this.book_button_Click);
            // 
            // author_button
            // 
            this.author_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("author_button.BackgroundImage")));
            this.author_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.author_button.Location = new System.Drawing.Point(203, 141);
            this.author_button.Name = "author_button";
            this.author_button.Size = new System.Drawing.Size(112, 108);
            this.author_button.TabIndex = 1;
            this.author_button.UseVisualStyleBackColor = true;
            this.author_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // member_button1
            // 
            this.member_button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("member_button1.BackgroundImage")));
            this.member_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.member_button1.Location = new System.Drawing.Point(44, 323);
            this.member_button1.Name = "member_button1";
            this.member_button1.Size = new System.Drawing.Size(112, 108);
            this.member_button1.TabIndex = 2;
            this.member_button1.UseVisualStyleBackColor = true;
            this.member_button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // borrow_button
            // 
            this.borrow_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borrow_button.BackgroundImage")));
            this.borrow_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrow_button.Location = new System.Drawing.Point(204, 323);
            this.borrow_button.Name = "borrow_button";
            this.borrow_button.Size = new System.Drawing.Size(112, 108);
            this.borrow_button.TabIndex = 3;
            this.borrow_button.UseVisualStyleBackColor = true;
            this.borrow_button.Click += new System.EventHandler(this.borrow_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "BOOK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(225, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "AUTHOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "MEMBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = " BORROW \r\nRECORDS";
            // 
            // RECORDS2
            // 
            this.RECORDS2.AutoSize = true;
            this.RECORDS2.BackColor = System.Drawing.Color.Transparent;
            this.RECORDS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECORDS2.Location = new System.Drawing.Point(99, 39);
            this.RECORDS2.Name = "RECORDS2";
            this.RECORDS2.Size = new System.Drawing.Size(158, 31);
            this.RECORDS2.TabIndex = 8;
            this.RECORDS2.Text = "RECORDS";
            this.RECORDS2.Click += new System.EventHandler(this.label5_Click);
            // 
            // back6
            // 
            this.back6.BackColor = System.Drawing.Color.Transparent;
            this.back6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back6.BackgroundImage")));
            this.back6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back6.FlatAppearance.BorderSize = 0;
            this.back6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back6.ForeColor = System.Drawing.Color.Transparent;
            this.back6.Location = new System.Drawing.Point(4, 5);
            this.back6.Name = "back6";
            this.back6.Size = new System.Drawing.Size(27, 25);
            this.back6.TabIndex = 9;
            this.back6.UseVisualStyleBackColor = false;
            this.back6.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 628);
            this.Controls.Add(this.back6);
            this.Controls.Add(this.RECORDS2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrow_button);
            this.Controls.Add(this.member_button1);
            this.Controls.Add(this.author_button);
            this.Controls.Add(this.book_button);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button book_button;
        private System.Windows.Forms.Button author_button;
        private System.Windows.Forms.Button member_button1;
        private System.Windows.Forms.Button borrow_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RECORDS2;
        private System.Windows.Forms.Button back6;
    }
}