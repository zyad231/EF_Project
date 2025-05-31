namespace EF_Project
{
    partial class AddTransferOrder
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 47);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 106);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 1;
            label2.Text = "Source Warehouse ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 166);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 2;
            label3.Text = "Destination Warehouse ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 229);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Supplier ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 288);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 4;
            label5.Text = "Production Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 350);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 5;
            label6.Text = "Expiry Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(244, 343);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(244, 281);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 44);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(44, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(221, 398);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.Cancel;
            button3.Location = new Point(400, 398);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // AddTransferOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddTransferOrder";
            Text = "AddTransferOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}