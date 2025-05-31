namespace EF_Project
{
    partial class Reports
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            checkedListBox1 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(505, 60);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 2;
            label1.Text = "Expires in (Days):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(353, 28);
            label2.TabIndex = 3;
            label2.Text = "Show Products that will expire soon";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(859, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(417, 450);
            dataGridView1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 105);
            label3.Name = "label3";
            label3.Size = new Size(389, 28);
            label3.TabIndex = 8;
            label3.Text = "Show Products that Stayed in inventory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 7;
            label4.Text = "Been in inventory for (Days):";
            // 
            // button2
            // 
            button2.Location = new Point(505, 156);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(13, 204);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(219, 268);
            checkedListBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(258, 262);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(304, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(258, 362);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(304, 27);
            dateTimePicker2.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(263, 443);
            button3.Name = "button3";
            button3.Size = new Size(139, 29);
            button3.TabIndex = 13;
            button3.Text = "Show Transfers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 214);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 14;
            label5.Text = "Earlier Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 313);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 15;
            label6.Text = "Later Date";
            // 
            // button4
            // 
            button4.Location = new Point(423, 443);
            button4.Name = "button4";
            button4.Size = new Size(139, 29);
            button4.TabIndex = 16;
            button4.Text = "Show Warehouse";
            button4.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 487);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Reports";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button2;
        private CheckedListBox checkedListBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button3;
        private Label label5;
        private Label label6;
        private Button button4;
    }
}