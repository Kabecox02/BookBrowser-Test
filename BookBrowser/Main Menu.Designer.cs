namespace BookBrowser
{
    partial class BookBrowser_MainMenu
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
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            label6 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(267, 68);
            label1.Name = "label1";
            label1.Size = new Size(267, 42);
            label1.TabIndex = 0;
            label1.Text = "MAIN MENU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(517, 114);
            button1.Name = "button1";
            button1.Size = new Size(122, 48);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(152, 114);
            label2.Name = "label2";
            label2.Size = new Size(359, 48);
            label2.TabIndex = 2;
            label2.Text = "Search for a specific book via Author, Title, ISBN, or Publisher";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(152, 181);
            label3.Name = "label3";
            label3.Size = new Size(359, 48);
            label3.TabIndex = 4;
            label3.Text = "Input a new book into the database";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(517, 181);
            button2.Name = "button2";
            button2.Size = new Size(122, 48);
            button2.TabIndex = 3;
            button2.Text = "Input";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(152, 248);
            label4.Name = "label4";
            label4.Size = new Size(359, 48);
            label4.TabIndex = 6;
            label4.Text = "Generate a random book to read from our system";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(517, 248);
            button3.Name = "button3";
            button3.Size = new Size(122, 48);
            button3.TabIndex = 5;
            button3.Text = "Randomize";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(152, 315);
            label5.Name = "label5";
            label5.Size = new Size(359, 48);
            label5.TabIndex = 8;
            label5.Text = "Access the history of books you have input or searched";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(517, 315);
            button4.Name = "button4";
            button4.Size = new Size(122, 48);
            button4.TabIndex = 7;
            button4.Text = "History";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label6.Location = new Point(229, 9);
            label6.Name = "label6";
            label6.Size = new Size(351, 59);
            label6.TabIndex = 9;
            label6.Text = "BOOK BROWSER";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(335, 384);
            button5.Name = "button5";
            button5.Size = new Size(113, 37);
            button5.TabIndex = 10;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // BookBrowser_MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "BookBrowser_MainMenu";
            Text = "Book Browser - Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button3;
        private Label label5;
        private Button button4;
        private Label label6;
        private Button button5;
    }
}