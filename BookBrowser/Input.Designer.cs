namespace BookBrowser
{
    partial class Input
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            textBox5 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(216, 40);
            label1.Name = "label1";
            label1.Size = new Size(361, 53);
            label1.TabIndex = 0;
            label1.Text = "INPUT YOUR BOOKS";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(325, 392);
            button1.Name = "button1";
            button1.Size = new Size(140, 32);
            button1.TabIndex = 1;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20.25F);
            label2.Location = new Point(111, 96);
            label2.Name = "label2";
            label2.Size = new Size(114, 36);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 20.25F);
            label4.Location = new Point(111, 264);
            label4.Name = "label4";
            label4.Size = new Size(114, 36);
            label4.TabIndex = 4;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 20.25F);
            label5.Location = new Point(111, 222);
            label5.Name = "label5";
            label5.Size = new Size(129, 36);
            label5.TabIndex = 5;
            label5.Text = "Publisher";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 20.25F);
            label6.Location = new Point(111, 138);
            label6.Name = "label6";
            label6.Size = new Size(114, 36);
            label6.TabIndex = 6;
            label6.Text = "Genre";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(258, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 36);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(258, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 36);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(258, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 36);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F);
            textBox4.Location = new Point(258, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 36);
            textBox4.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(258, 306);
            button2.Name = "button2";
            button2.Size = new Size(270, 54);
            button2.TabIndex = 12;
            button2.Text = "INPUT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 16F);
            textBox5.Location = new Point(258, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(270, 36);
            textBox5.TabIndex = 13;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 20.25F);
            label3.Location = new Point(111, 180);
            label3.Name = "label3";
            label3.Size = new Size(114, 36);
            label3.TabIndex = 14;
            label3.Text = "ISBN";
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Input";
            Text = "Book Browser - Input";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private TextBox textBox5;
        private Label label3;
    }
}