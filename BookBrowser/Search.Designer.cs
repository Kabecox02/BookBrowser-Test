﻿namespace BookBrowser

{
    partial class Search
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(37, 84);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 0;
            label1.Text = "Author:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(37, 138);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 1;
            label2.Text = "ISBN:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(165, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 36);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(165, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 36);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(519, 81);
            button1.Name = "button1";
            button1.Size = new Size(185, 145);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(37, 193);
            label3.Name = "label3";
            label3.Size = new Size(120, 42);
            label3.TabIndex = 5;
            label3.Text = "Publisher:";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(165, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 36);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(37, 248);
            label4.Name = "label4";
            label4.Size = new Size(120, 42);
            label4.TabIndex = 7;
            label4.Text = "Title:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F);
            textBox4.Location = new Point(165, 245);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 36);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.Location = new Point(315, 9);
            label5.Name = "label5";
            label5.Size = new Size(249, 47);
            label5.TabIndex = 9;
            label5.Text = "BOOK BROWSER";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(519, 245);
            button2.Name = "button2";
            button2.Size = new Size(185, 36);
            button2.TabIndex = 10;
            button2.Text = "Main Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(165, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(539, 110);
            dataGridView1.TabIndex = 11;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Search";
            Text = "Book Browser - Search";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
