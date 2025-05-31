namespace EF_Project
{
    partial class AddSellingOrder
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 77);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 131);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Client ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 183);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Supplier ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 230);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 3;
            label4.Text = "Warehouse ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 279);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "Order Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 227);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(252, 27);
            textBox4.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(38, 357);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 357);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.Cancel;
            button3.Location = new Point(329, 357);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // AddSellingOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddSellingOrder";
            Text = "AddSellingOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}