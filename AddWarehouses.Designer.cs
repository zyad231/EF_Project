namespace EF_Project
{
    partial class AddWarehouses
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
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(224, 356);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 25;
            button4.Text = "Change";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(377, 356);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 23;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(71, 356);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 27);
            textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 27);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 27);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 238);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 17;
            label4.Text = "ManagerName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 189);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 16;
            label3.Text = "Warehouse Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 72);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 15;
            label2.Text = "Warehouse ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 133);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 14;
            label1.Text = "Warehouse Name";
            // 
            // AddWarehouses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "AddWarehouses";
            Text = "AddWarehouses";
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
    }
}