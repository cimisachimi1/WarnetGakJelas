namespace Percobaan2.View
{
    partial class IsiTransaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            lvwTransaksi = new ListView();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(86, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // lvwTransaksi
            // 
            lvwTransaksi.Location = new Point(28, 76);
            lvwTransaksi.Name = "lvwTransaksi";
            lvwTransaksi.Size = new Size(1026, 545);
            lvwTransaksi.TabIndex = 1;
            lvwTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(349, 47);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 53);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "sampai :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 53);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "dari :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(832, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(929, 49);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IsiTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvwTransaksi);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "IsiTransaksi";
            Size = new Size(1094, 655);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ListView lvwTransaksi;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}
