namespace Percobaan2.View
{
    partial class BeliPaket
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
            lvwPaket = new ListView();
            SuspendLayout();
            // 
            // lvwPaket
            // 
            lvwPaket.Location = new Point(12, 12);
            lvwPaket.Name = "lvwPaket";
            lvwPaket.Size = new Size(469, 257);
            lvwPaket.TabIndex = 0;
            lvwPaket.UseCompatibleStateImageBehavior = false;
            // 
            // BeliPaket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 321);
            Controls.Add(lvwPaket);
            Name = "BeliPaket";
            Text = "BeliPaket";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvwPaket;
    }
}