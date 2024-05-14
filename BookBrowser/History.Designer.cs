namespace BookBrowser
{
    partial class History
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
            HistoryGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)HistoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(267, 33);
            label1.Name = "label1";
            label1.Size = new Size(256, 34);
            label1.TabIndex = 0;
            label1.Text = "The Previous Search was";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(338, 349);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 1;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HistoryGridView
            // 
            HistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryGridView.Location = new Point(140, 112);
            HistoryGridView.Name = "HistoryGridView";
            HistoryGridView.Size = new Size(532, 139);
            HistoryGridView.TabIndex = 2;
            HistoryGridView.CellContentClick += HistoryGridView_CellContentClick;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HistoryGridView);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "History";
            Text = "Book Browser - History";
            ((System.ComponentModel.ISupportInitialize)HistoryGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView HistoryGridView;
    }
}