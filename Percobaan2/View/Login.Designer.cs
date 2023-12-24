namespace Percobaan2.View
{
    partial class Login
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
            button2 = new Button();
            richTextBox3 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(370, 93);
            button2.Name = "button2";
            button2.Size = new Size(93, 36);
            button2.TabIndex = 0;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(123, 45);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(205, 28);
            richTextBox3.TabIndex = 1;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(370, 40);
            button1.Name = "button1";
            button1.Size = new Size(93, 36);
            button1.TabIndex = 0;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 46);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Username : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 93);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            label2.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(123, 90);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(205, 28);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox3_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 159);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button button2;
        private RichTextBox richTextBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}