namespace BookBrowser
{
    partial class Form3
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(244, 44);
            label1.Name = "label1";
            label1.Size = new Size(296, 26);
            label1.TabIndex = 0;
            label1.Text = "Welcome to";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.Location = new Point(230, 70);
            label2.Name = "label2";
            label2.Size = new Size(337, 54);
            label2.TabIndex = 1;
            label2.Text = "BOOK BROWSER";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(364, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(364, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(230, 154);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(221, 209);
            label4.Name = "label4";
            label4.Size = new Size(137, 30);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(418, 278);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 6;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}