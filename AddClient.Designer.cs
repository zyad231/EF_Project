namespace EF_Project
{
    partial class AddClient
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
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(208, 393);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 36;
            button4.Text = "Change";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(361, 393);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 35;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(55, 393);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 34;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(245, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 27);
            textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 27);
            textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 205);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 29;
            label4.Text = "Client Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 149);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 28;
            label3.Text = "Client Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 32);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 27;
            label2.Text = "Client ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 93);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 26;
            label1.Text = "Client Name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(245, 260);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(259, 27);
            textBox5.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 263);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 37;
            label5.Text = "Client Website";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(245, 309);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(259, 27);
            textBox6.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 316);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 39;
            label6.Text = "Client Mobile Number";
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddClient";
            Text = "AddClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
    }
}