namespace Percobaan2.View
{
    partial class CrudOperator
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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tesralse = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            txtNamaPelanggan = new TextBox();
            txtIDPelanggan = new TextBox();
            label3 = new Label();
            btnKirim = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Location = new Point(364, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 100);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 59);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 0;
            label6.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 26);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 0;
            label5.Text = "Username : ";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(80, 51);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(145, 23);
            textBox9.TabIndex = 3;
            textBox9.TextChanged += textBox1_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(80, 18);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(145, 23);
            textBox8.TabIndex = 3;
            textBox8.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "Detail";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tesralse);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(txtNamaPelanggan);
            panel2.Controls.Add(txtIDPelanggan);
            panel2.Location = new Point(12, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 244);
            panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pagi\t( 07:00-13:00)", "Siang \t( 13:00-21:00)", "Malam\t( 21:00-07:00)" });
            comboBox1.Location = new Point(108, 209);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 208);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Shift :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(108, 113);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 23);
            textBox6.TabIndex = 3;
            textBox6.TextChanged += textBox1_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 180);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 0;
            label12.Text = "Tgl Lahir :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 150);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 0;
            label11.Text = "No. Telepon : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 121);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 0;
            label10.Text = "Umur : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 92);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 0;
            label9.Text = "Alamat : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 63);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 0;
            label8.Text = "Username : ";
            // 
            // tesralse
            // 
            tesralse.AutoSize = true;
            tesralse.Location = new Point(17, 34);
            tesralse.Name = "tesralse";
            tesralse.Size = new Size(48, 15);
            tesralse.TabIndex = 0;
            tesralse.Text = "Nama : ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(108, 142);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 3;
            textBox5.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // txtNamaPelanggan
            // 
            txtNamaPelanggan.Location = new Point(108, 55);
            txtNamaPelanggan.Name = "txtNamaPelanggan";
            txtNamaPelanggan.Size = new Size(139, 23);
            txtNamaPelanggan.TabIndex = 3;
            txtNamaPelanggan.TextChanged += textBox1_TextChanged;
            // 
            // txtIDPelanggan
            // 
            txtIDPelanggan.Location = new Point(108, 26);
            txtIDPelanggan.Name = "txtIDPelanggan";
            txtIDPelanggan.Size = new Size(139, 23);
            txtIDPelanggan.TabIndex = 3;
            txtIDPelanggan.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 16);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Akun";
            // 
            // btnKirim
            // 
            btnKirim.Location = new Point(368, 205);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(98, 44);
            btnKirim.TabIndex = 2;
            btnKirim.Text = "Oke!";
            btnKirim.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(506, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 44);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Batal ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CrudOperator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 302);
            Controls.Add(btnCancel);
            Controls.Add(btnKirim);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CrudOperator";
            Text = "Tambah atau Edit Akun Operator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private TextBox txtIDPelanggan;
        private Label label5;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtNamaPelanggan;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label tesralse;
        private DateTimePicker dateTimePicker1;
        private Button btnKirim;
        private Button btnCancel;
        private Label label1;
        private ComboBox comboBox1;
    }
}